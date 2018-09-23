using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_NKĐ
{
    //object the hien toa do
    class ToaDo
    {
        public int x { get; set; }
        public int y { get; set; }
        //init ToaDo
        public ToaDo(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
