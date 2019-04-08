using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextScape
{
    class StatEntity : MoveableEntity
    {
        private int healthMax, healthCurrent;
        private int manaMax, manaCurrent;
        private int level;

        public StatEntity(int itemID, string name) : base(itemID, name)
        {

        }

        public int getMaxHit()
        {
            return ((int)(level * 0.25) + 1);
        }

        #region getters
        public int getHealthMax() { return healthMax; }
        public int getHealthCurrent() { return healthCurrent; }
        public int getManaMax() { return manaMax; }
        public int getManaCurrent() { return manaCurrent; }
        public int getLevel() { return level; }
        #endregion
        #region setters
        public void setHealthMax(int healthMax) { this.healthMax = healthMax; }
        public void setHealthCurrent(int healthCurrent) { this.healthCurrent = healthCurrent; }
        public void setManaMax(int manaMax) { this.manaMax = manaMax; }
        public void setManaCurrent(int manaCurrent) { this.manaCurrent = manaCurrent; }
        public void setLevel(int level) { this.level = level; }
        #endregion
    }
}
