using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_NKĐ
{
    class Tetromino
    {
        public int x { get; set; }
        public int y { get; set; }
        public Int32 blockColor { get; set; }
        private static readonly int numShape = 7;
        private Int32[] colorSet;
        public bool[][,] blockConfig = new bool[numShape][,];
        public bool[,] currBlock;
        Random rand = new Random();

        public  Tetromino()
        {
            this.defineShapes();
            this.colorSet = this.getColorSet();
            this.getNextBlock();
        }
        public void getNextBlock()
        {
            int randomBlock = rand.Next(7);
            int startPos = rand.Next(6);
            this.x = startPos;
            this.y = 0;
            this.currBlock = this.blockConfig[randomBlock];
            this.blockColor = this.colorSet[randomBlock];
        }
        public ToaDo toBoardCoord(ToaDo coord)
        {
            coord.x += this.x;
            coord.y += this.y;
            return coord;
        }
        public Tetromino Clone()
        {
            return (Tetromino)this.MemberwiseClone();
        }

        public void rotateClockwise()
        {
            bool[,] newArray = new bool[4, 4];

            for (int i = 3; i > -1; i--)
            {
                for (int j = 0; j < 4; j++)
                {
                    newArray[j, 3 - i] = this.currBlock[i, j];
                }
            }
            this.currBlock = newArray;
        }
        private void defineShapes()
        {
            //định dạng cứng cho mỗi block
            bool[,] straightLine = new bool[4, 4] { { false, true, false, false }, { false, true, false, false }, { false, true, false, false }, { false, true, false, false } };
            bool[,] leftThunder = new bool[4, 4] { { false, false, false, false }, { true, true, false, false }, { false, true, true, false }, { false, false, false, false } };
            bool[,] rightThunder = new bool[4, 4] { { false, false, false, false }, { false, false, true, true }, { false, true, true, false }, { false, false, false, false } };
            bool[,] triangle = new bool[4, 4] { { false, false, true, false }, { false, true, true, false }, { false, false, true, false }, { false, false, false, false } };
            bool[,] rightL = new bool[4, 4] { { false, false, false, false }, { false, true, true, false }, { false, false, true, false }, { false, false, true, false } };
            bool[,] leftL = new bool[4, 4] { { false, false, false, false }, { false, true, true, false }, { false, true, false, false }, { false, true, false, false } };
            bool[,] square = new bool[4, 4] { { false, false, false, false }, { false, true, true, false }, { false, true, true, false }, { false, false, false, false } };

            //tạo vùng nhớ cho mảng cấu hình block
            for (int i = 0; i < numShape; i++)
                blockConfig[i] = new bool[4, 4];

            //đưa hình dạng vào set
            blockConfig[0] = straightLine;
            blockConfig[1] = leftThunder;
            blockConfig[2] = rightThunder;
            blockConfig[3] = triangle;
            blockConfig[4] = rightL;
            blockConfig[5] = leftL;
            blockConfig[6] = square;
        }

        internal void rotateCounterClockwise()
        {
            throw new NotImplementedException();
        }

        private Int32[] getColorSet()
        {
            Int32 blue = Convert.ToInt32("0xFF0000FF", 16);
            Int32 yellow = Convert.ToInt32("0xFFFFFF00", 16);
            Int32 green = Convert.ToInt32("0xFF008000", 16);
            Int32 beige = Convert.ToInt32("0xFFF5F5DC", 16);
            Int32 crimson = Convert.ToInt32("0xFFDC143C", 16);
            Int32 darkOrange = Convert.ToInt32("0xFFFF8C00", 16);
            Int32 darkViolet = Convert.ToInt32("0xFF9400D3", 16);

            Int32[] set = { blue, yellow, green, beige, crimson, darkOrange, darkViolet};

            return set;
        }
    }
}
