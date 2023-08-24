using GameLibrary.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class ReloadTimeDecorator : DecoratorProperty
    {
        public ReloadTimeDecorator(PlayerProperities playerProperities) : base(playerProperities)
        {

        }

        /// <summary>
        /// Скорость
        /// </summary>
        public override float ReloadTime { get => playerProperities.ReloadTime / 2; }
    }
}
