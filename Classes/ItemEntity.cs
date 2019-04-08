using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextScape
{
    class ItemEntity : Entity
    {
        private int value = -1;
        public ItemEntity(int itemID, string name, int value) : base(itemID, name)
        {
            this.value = value;
        }

        public bool isTradeable()
        {
            return (value > -1);
        }
    }
}
