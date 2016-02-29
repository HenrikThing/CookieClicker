using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker
{
    class Unit : GameObject
    {
        private int dps;
        public Unit(string imagePath, Vector2D startPosition, int dps) : base (imagePath, startPosition)
        {
            this.dps = dps;
        }
    }
}
