using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class BigUFOEnemyShip:UFOEnemyShip
    {
        public BigUFOEnemyShip()
        {
            setName("Big UFO Enemy Ship");
            setDamage(60.0);
        }
    }
}
