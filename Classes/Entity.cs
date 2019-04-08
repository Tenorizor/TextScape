using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextScape
{
    public abstract class Entity
    {
        private int itemID;
        private String name;

        public Entity(int itemID, String name)
        {
            this.itemID = itemID;
            this.name = name;
        }

        public int getItemID()
        {
            return itemID;
        }

        public String getName()
        {
            return name;
        }
    }
}
