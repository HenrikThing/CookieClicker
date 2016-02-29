using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CookieClicker
{
    
    class Unit : GameObject
    {
        private int dps;
        private int cost;

        public Unit(string imagePath, Vector2D startPosition, int dps, int cost) : base (imagePath, startPosition)
        {
            this.dps = dps;
            this.cost = cost;
        }
        public static void Cost(int cost)
        {
            GameWorld.Gold -= cost;
        }
    }
}
