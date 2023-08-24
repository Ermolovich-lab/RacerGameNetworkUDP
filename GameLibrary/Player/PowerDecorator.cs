using GameLibrary.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class PowerDecorator : DecoratorProperty
    {
        public PowerDecorator(PlayerProperities playerProperities) : base(playerProperities)
        {

        }

        /// <summary>
        /// Скорость
        /// </summary>
        //public override float Power { get => playerProperities.Power * 2; }
    }
}
