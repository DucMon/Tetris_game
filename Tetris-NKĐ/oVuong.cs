﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris_NKĐ
{
    public partial class oVuong : UserControl
    {
        public int row { get; set; }
        public int col { get; set; }
        public oVuong()
        {
            InitializeComponent();
        }
        public oVuong(int row, int col)
        {
            InitializeComponent();
            this.Name = row.ToString() + ", " + col.ToString();
            this.row = row;
            this.col = col;
        }

        public int oVuongColor
        {
            set
            {
                this.BackColor = Color.FromArgb(value);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, 1, ButtonBorderStyle.Inset
                , Color.Black, 1, ButtonBorderStyle.Inset
                , Color.Black, 1, ButtonBorderStyle.Inset
                , Color.Black, 1, ButtonBorderStyle.Inset);
        }

    }
}
