using Assets.Scripts.Components;
using Leopotam.Ecs;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Assets.Scripts.Infrastructure
{
    public class PrefabFactory 
    {
        private EcsWorld _world;

        internal void SetWorld(EcsWorld world)
        {
            _world = world;
        }

        public void Spawn(SpawnPrefab spawnData)
        {
            GameObject gameObject = Object.Instantiate(spawnData.Prefab, spawnData.Position, Quaternion.identity);
            var monoEntity = gameObject.GetComponent<MonoEntity>();
            if (monoEntity == null)
                return;

            EcsEntity ecsEntity = _world.NewEntity();
            monoEntity.Make(ref ecsEntity);
        }
    }
}