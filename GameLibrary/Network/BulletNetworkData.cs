using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Network
{
    public class BulletNetworkData
    {
        /// <summary>
        /// Индефикатор пули
        /// </summary>
        public float Power { get; set; }
        /// <summary>
        /// Позиция появления
        /// </summary>
        public float[] SpawnPosition { get; set; }
        /// <summary>
        /// Направление пули
        /// </summary>
        public float[] Direction { get; set; }
        /// <summary>
        /// Тег игрока, создавшего пулю
        /// </summary>
        public string Tag { get; set; }

        public override string ToString()
        {
            return "\n\tPower: " + Power + " Position: " + SpawnPosition + " Direction: " + Direction.ToString();
        }
    }
}
