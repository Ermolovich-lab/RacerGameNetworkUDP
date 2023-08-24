using EngineLibrary;
using GameLibrary.GameObjects;
using GameLibrary.Network;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Factory
{
    public class BulletFactory
    {
        /// <summary>
        /// Создание игрового объекта пули, которая убивает
        /// </summary>
        /// <param name="position">Позиция появления пули</param>
        /// <param name="direction">Направление пули</param>
        /// <param name="tag">Тег игрового объекта, создающий пулю</param>
        /// <returns>Игровой объект</returns>
        public static GameObject CreateBullet(Vector2 position, Vector2 direction, string tag, float power = 1)
        {
            LevelScene.instance?.UpdateBullet(new BulletNetworkData()
            { Power = power, Direction = new[] { direction.X, direction.Y }, SpawnPosition = new[] { position.X, position.Y }, Tag = tag });

            GameObject gameObject = new GameObject();
            gameObject.SetComponent(new TransformComponent(position, new Vector2(0.01f, 0.01f), new Vector2(0, 0), 0));

            TexturesBox texture;
            texture = new TexturesBox(ContentPipe.LoadTexture("Bullets/bullet.png"));

            gameObject.SetComponent(texture);
            gameObject.SetComponent(new ColliderComponent(gameObject, 1, new Vector2(10, 10)));
            gameObject.GameObjectTag = "Bullet";

            Bullet bullet = new Bullet();
            bullet.SetSettings(direction, tag, power);
            bullet.Start(gameObject);

            gameObject.SetComponent(bullet);

            return gameObject;
        }
    }
}
