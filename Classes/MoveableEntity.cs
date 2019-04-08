using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextScape
{
    class MoveableEntity : Entity
    {
        private int x;
        private int y;

        public MoveableEntity(int itemID, string name) : base(itemID, name)
        {

        }

        public int getX() { return x; }
        public int getY() { return y; }
        public void setX(int x) { this.x = x; }
        public void setY(int y) { this.y = y; }
    }
}
