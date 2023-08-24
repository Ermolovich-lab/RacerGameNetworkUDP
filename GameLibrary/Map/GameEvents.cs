using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Maze
{
    /// <summary>
    /// Статический класс событий игры
    /// </summary>
    public static class GameEvents
    {
        /// <summary>
        /// Делегат события изменения количества здоровья
        /// </summary>
        /// <param name="tagPlayer">Тег игрового объекта игрока</param>
        /// <param name="value">Значение собранных монет</param>
        public delegate void FuelDelegate(string tagPlayer, float value);
        /// <summary>
        /// Событие изменения количества здоровья
        /// </summary>
        public static FuelDelegate ChangeFuel { get; set; }
        /// <summary>
        /// Делегат события изменения количества здоровья
        /// </summary>
        /// <param name="tagPlayer">Тег игрового объекта игрока</param>
        /// <param name="value">Значение собранных монет</param>
        public delegate void TiresDelegate(string tagPlayer, bool value);
        /// <summary>
        /// Событие изменения количества здоровья
        /// </summary>
        public static TiresDelegate ChangeTires{ get; set; }
        /// <summary>
        /// Делегат события изменения количества монет
        /// </summary>
        /// <param name="tagPlayer">Тег игрового объекта игрока</param>
        /// <param name="value">Значение собранных монет</param>
        public delegate void LapsDelegate(string tagPlayer, int value);
        /// <summary>
        /// Событие изменения количества монет
        /// </summary>
        /// 
        public static LapsDelegate ChangeLaps { get; set; }
        /// <summary>
        /// Делегат события окончания игры
        /// </summary>
        public delegate void EndGameDelegate(string winPlayer);
        /// <summary>
        /// Событие окончания игры
        /// </summary>
        public static EndGameDelegate EndGame { get; set; }

        /// <summary>
        /// Делегат события получения оружия игроком
        /// </summary>
        /// <param name="tagPlayer">Тег игрового объекта игрока</param>
        public delegate void CountBullets(string tagPlayer, int count);
        /// <summary>
        /// Событие получения оружия игроком
        /// </summary>
        public static CountBullets ChangeCount { get; set; }
    }
}
