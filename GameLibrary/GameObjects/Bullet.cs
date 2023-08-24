using EngineLibrary;
using GameLibrary.Factory;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.GameObjects
{
    public class Bullet : ObjectScript
    {
        /// <summary>
        /// Скорость пули
        /// </summary>
        public float Speed { get; } = 800;

        /// <summary>
        /// Экземпляр сцены игры
        /// </summary>
        protected Game game;

        private Vector2 flyDirection;
        private string[] interactionTag = new string[2];
        protected string tag;
        protected float power;

        /// <summary>
        /// Установление направления полета пули
        /// </summary>
        /// <param name="direction">Вектор направления</param>
        /// <param name="tag">Тег игрового объекта, создающий пулю</param>
        public void SetSettings(Vector2 direction, string tag, float power)
        {
            this.tag = tag;
            flyDirection = direction;
            this.power = power;

            if(tag == "PlayerOne")
                interactionTag[0] = "PlayerTwo";
            else
                interactionTag[0] = "PlayerOne";

        }

        /// <summary>
        /// Поведение на момент создание игрового объекта
        /// </summary>
        public override void Start(GameObject gameObject = null)
        {
            game = Game.instance;
        }

        /// <summary>
        /// Обновление игрового объекта
        /// </summary>
        public override void Update(GameObject gameObject)
        {
            Vector2 movement = flyDirection * Speed * Time.DeltaTime;

            gameObject.Transform.SetMovement(movement);

            //if (flyDirection.X > 0)
            //    gameObject.Texture.Set("Right");
            //else if (flyDirection.X < 0)
            //    gameObject.Texture.Set("Left");
            //else if (flyDirection.Y > 0)
            //    gameObject.Texture.Set("Down");
            //else if (flyDirection.Y < 0)
            //    gameObject.Texture.Set("Up");
             
            //if (gameObject.Collider.CheckGameObjectIntersection("Wall"))
            //{
            //    game.AddObjectsToRemove(gameObject);
            //}

            if (gameObject.Collider.CheckGameObjectIntersection(out GameObject interGameObject, interactionTag))
            {
                PlayerInteraction(interGameObject);
                game.AddObjectsToRemove(gameObject);
            }
        }

        /// <summary>
        /// Взаимодействие с игроком
        /// </summary>
        public void PlayerInteraction(GameObject playerGameObject)
        {
            (playerGameObject.Script as BasePlayer).Property.Tires = false;
            (playerGameObject.Script as BasePlayer).Property = new SpeedDecorator((playerGameObject.Script as BasePlayer).Property);
            (playerGameObject.Script as BasePlayer).ChangeStatsValue(playerGameObject, false);
        }
    }
}
