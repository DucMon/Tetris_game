using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris_NKĐ
{
    public partial class Tetris : Form
    {
        private bool playing { get; set; } // biến cờ trạng thái
        private bool paused;    // biến cờ trạng thái
        private static int cellSize = 30;   // kích cỡ ô
        private static int numRows = 20;    // số dòng
        private static int numCols = 10;    // số cột
        private int baseTickInterval = 500;     // khoảng giữa 2 hành động (độ khó)
        private int currentTickInterval;    //  
        private int highScore;      
        private int currentLevel;   // độ khó hiện tại
        private Board board;
        private KeyboardInput input = new KeyboardInput();
        private Dictionary<string, oVuong> boardCells = new Dictionary<string, oVuong>();
        String[] paths, files; // ten bai hat & dia chi
       
        public Tetris()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.highScore = 0;
            this.textBoxHighScore.Text = this.highScore.ToString();
            this.currentTickInterval = this.baseTickInterval;
            this.paused = false;
            this.board = new Board();
            this.drawBackgroundBoard();
           // wplayer.URL = "tetris.mp3";
           // wplayer.settings.setMode("loop", true);
           // wplayer.settings.volume = 20;

        }
        private void drawBackgroundBoard()
        {
            foreach (KeyValuePair<string, oVuong> c in boardCells)
            {
                c.Value.Dispose();
            }
            boardCells.Clear();

            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    oVuong cell = new oVuong(row, col);
                    cell.Parent = boardPanel; // nền tảng vẽ (panel)
                    cell.Top = row * cellSize;
                    cell.Left = col * cellSize;
                    boardCells.Add(oVuongKey(row, col), cell);
                }
            }
        }
        private string oVuongKey(int row, int col)
        {
            return row.ToString() + ", " + col.ToString();
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.reset();
        }
        private void reset()
        {
            this.resetTextFields();
            this.board = new Board();
            this.currentLevel = board.currentLevel;
            this.playing = true;
            this.tickTimer.Interval = this.baseTickInterval;
            this.tickTimer.Enabled = true;
        }
        private void resetTextFields()
        {
              this.textBoxScore.Text = "0";
              this.labelGameOver.Text = "";
        }
        private void tickTimer_Tick(object sender, EventArgs e)
        {
            if (playing)
            {
                if (!board.tick())
                    this.gameOver();
                this.updateGameBoard();
                this.updateTextFields();
                this.checkLevelUp();
            }
        }
        private void updateTextFields()
        {
               this.textBoxScore.Text = this.board.score.ToString();
                this.textBoxRowsCompleted.Text = this.board.rowsCompleted.ToString();
               this.textBoxLevel.Text = this.board.currentLevel.ToString();
        }
        private void checkLevelUp()
        {
            if (this.board.currentLevel > this.currentLevel)
            {
                this.currentLevel = this.board.currentLevel;

                double newinterval = this.tickTimer.Interval;
                newinterval *= 0.75;
                this.tickTimer.Interval = (int)newinterval;
                this.currentTickInterval = this.tickTimer.Interval;
            }
        }
        private void increaseGameLevel()
        {
            this.board.currentLevel++;
        }
        private void updateGameBoard()
        {
            oVuong cell;
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    boardCells.TryGetValue(oVuongKey(row, col), out cell);
                    cell.oVuongColor = board.grid[row, col];
                }
            }
            Tetromino block = board.currentBlock;
            for (int row = 0; row < block.currBlock.GetLength(0); row++)
            {
                for (int col = 0; col < block.currBlock.GetLength(1); col++)
                {
                    ToaDo c = new ToaDo(col, row);
                    c = block.toBoardCoord(c);
                    if (block.currBlock[row, col] && c.x >= 0 && c.x < numCols && c.y < numRows)
                    {
                        boardCells.TryGetValue(oVuongKey(c.y, c.x), out cell);

                        cell.oVuongColor = block.blockColor;
                    }
                }
            }
        }
        private void gameOver()
        {
            this.tickTimer.Enabled = false;
            this.playing = false;
            DialogResult a = MessageBox.Show("YOU LOSE! PLAY AGAIN?", "Warning!", MessageBoxButtons.OK);
            if (this.board.score > this.highScore)
            {
                this.highScore = this.board.score;
                this.textBoxHighScore.Text = this.board.score.ToString();
            }
            if (a == DialogResult.OK)
            {
                this.reset();
            }
        }
        private void pauseGame()
        {
            if (this.paused == false)
            {
                this.tickTimer.Enabled = false;
                this.playing = false;
                this.paused = true;
            }
        }
        private void resumeGame()
        {
            if (this.paused == true)
            {
                this.tickTimer.Enabled = true;
                this.playing = true;
                this.paused = false;
            }
        }
        private void Tetris_KeyUp(object sender, KeyEventArgs e)
        {
             if (playing)
            {
                if (input.spaceKeyPressed)
                    board.rotateCurrentBlockClockwise();
                if (input.leftKeyPressed)
                    board.moveCurrentBlockLeft();
                if (input.rightKeyPressed)
                    board.moveCurrentBlockRight();
                if (input.downKeyPressed)
                    board.lowerCurrentBlock();
                this.updateGameBoard();
            }     
            input.evaluateKey(e.KeyCode, false);
        }
        private void Tetris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && playing)
                input.evaluateKey(e.KeyCode, true); e.Handled = true;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Home:
                    this.increaseGameLevel();
                    return true;
                case (Keys.Control | Keys.P):
                    this.pauseGame();
                    return true;
                case (Keys.Control | Keys.G):
                    this.resumeGame();
                    return true;
            }
            while (keyData == Keys.Right)
            {
                board.moveCurrentBlockRight();
                this.updateGameBoard();
                return true;
            }
            while (keyData == Keys.Left)
            {
                board.moveCurrentBlockLeft();
                this.updateGameBoard();
                return true;
            }
            while (keyData == Keys.Down)
            {
                board.lowerCurrentBlock();
                this.updateGameBoard();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void buttonResume_Click(object sender, EventArgs e)
        {
            this.resumeGame();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            this.pauseGame();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSelectSong_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for(int i = 0; i < files.Length;i++)
                {
                    listMusic.Items.Add(files[i]);
                }
            }
        }

        private void listMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[listMusic.SelectedIndex];
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
