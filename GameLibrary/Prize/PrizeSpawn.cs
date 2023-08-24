using EngineLibrary;
using GameLibrary.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Prize
{
    /// <summary>
    /// Класс подбираемого оружия в лабиринте
    /// </summary>
    public class PrizeSpawn : ObjectScript
    {
        private Game maze;
        private PlayerProperities dropOutPrize;
        private TypeProperty typeProperty;
        private float cuurentTimeToDisappear;
        private int value;
        private bool valueBool;

        /// <summary>
        /// Инициализация места подбираемого оружия
        /// </summary>
        /// <param name="disappearTime">Время исчезнование места</param>
        public void InitializePrizeSpawn(PlayerProperities playerProperities, float disappearTime)
        {
            dropOutPrize = playerProperities;
            //nameOfgun = name;
            cuurentTimeToDisappear = Time.CurrentTime + disappearTime;
        }

        // <summary>
        /// Инициализация места подбираемого оружия
        /// </summary>
        /// <param name="name">Название оружия</param>
        /// <param name="gun">Подбираемое оружие</param>
        /// <param name="disappearTime">Время исчезнование места</param>
        public void InitializePrizeSpawn(TypeProperty typeProperty, int value, float disappearTime)
        {
            this.typeProperty = typeProperty;
            this.value = value;
            cuurentTimeToDisappear = Time.CurrentTime + disappearTime;
        }

        // <summary>
        /// Инициализация места подбираемого оружия
        /// </summary>
        /// <param name="name">Название оружия</param>
        /// <param name="gun">Подбираемое оружие</param>
        /// <param name="disappearTime">Время исчезнование места</param>
        public void InitializePrizeSpawn(TypeProperty typeProperty, bool value, float disappearTime)
        {
            this.typeProperty = typeProperty;
            valueBool = value;
            cuurentTimeToDisappear = Time.CurrentTime + disappearTime;
        }

        /// <summary>
        /// Поведение на момент создание игрового объекта
        /// </summary>
        public override void Start(GameObject gameObject = null)
        {
            maze = Game.instance;
        }

        /// <summary>
        /// Обновление игрового объекта
        /// </summary>
        public override void Update(GameObject gameObject)
        {
            if (cuurentTimeToDisappear < Time.CurrentTime)
            {
                maze.AddObjectsToRemove(gameObject);
            }

            if (gameObject.Collider.CheckGameObjectIntersection(out GameObject player, "PlayerOne", "PlayerTwo"))
            {
                if (dropOutPrize == null)
                {
                    if (typeProperty == TypeProperty.Tires)
                        (player.Script as BasePlayer).Property.Tires = valueBool;
                    else
                        (player.Script as BasePlayer).Property.SetProperty(typeProperty, value);
                }
                else
                    (player.Script as BasePlayer).Property = dropOutPrize;

                maze.AddObjectsToRemove(gameObject);
            }
        }
    }
}
