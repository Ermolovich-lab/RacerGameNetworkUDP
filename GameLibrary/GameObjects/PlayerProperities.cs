using EngineLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.GameObjects
{
    public abstract class PlayerProperities
    {
        protected Player player;

        protected float timeDeactivate = 2;
        protected float timer = 0;

        /// <summary>
        /// Запас здоровья игрока
        /// </summary>
        public abstract float Fuel { get; protected set; }

        /// <summary>
        /// Запас здоровья игрока
        /// </summary>
        public abstract bool Tires { get; set; }
        /// <summary>
        /// Боезапас
        /// </summary>
        public abstract int Ammo { get; protected set; }
        /// <summary>
        /// Скорость
        /// </summary>
        public abstract float Speed { get; protected set; }
        /// <summary>
        /// Время перезарядки оружия
        /// </summary>
        public abstract float ReloadTime { get; protected set; }
        /// <summary>
        /// 
        /// </summary>
        public abstract float Consumption { get; protected set; }

        //public virtual void SetPlayer(Player player)
        //{
        //    this.player = player;
        //}

        public virtual void SetProperty(TypeProperty type, float value)
        {
            switch (type)
            {
                case TypeProperty.Fuel:
                    Fuel = value;
                    break;
                case TypeProperty.Ammo:
                    Ammo = (int)value;
                    break;
                case TypeProperty.Consumption:
                    Consumption = value;
                    break;
            }
        }

        public virtual void UpdateTime(GameObject player)
        {
            timer += Time.DeltaTime;

            if (timer >= timeDeactivate)
            {
                timer = 0;
                DeactivateProperities(player);
            }
        }

        protected abstract void DeactivateProperities(GameObject player);
    }
}
