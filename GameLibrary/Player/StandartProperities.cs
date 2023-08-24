using EngineLibrary;
using GameLibrary.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    /// <summary>
    /// Класс с характеристиками игрока
    /// </summary>
    public class StandartProperities : PlayerProperities
    {
        /// <summary>
        /// Боезапас
        /// </summary>
        public override int Ammo { get; protected set; }
        /// <summary>
        /// Скорость
        /// </summary>
        public override float Speed { get; protected set; } = 400;

        /// <summary>
        /// Время перезарядки оружия
        /// </summary>
        public override float ReloadTime { get; protected set; } = 0.5f;

        public override float Fuel { get; protected set; }

        public override bool Tires { get; set; } = true;

        public override float Consumption { get; protected set; }

        protected override void DeactivateProperities(GameObject player)
        {

        }
    }
}
