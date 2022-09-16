using Assets.Scripts.Common;
using Assets.Scripts.Components;
using Leopotam.Ecs;
using UnityEngine;

namespace Assets.Scripts.Infrastructure
{
    public class SpawnPlayer : IEcsInitSystem
    {
        private EcsWorld _world = null;
        private StaticData _staticData;

        public void Init()
        {
            _world.NewEntity().Get<SpawnPrefab>() = new SpawnPrefab
            {
                Prefab = _staticData.PlayerPrefab,
                Position = Vector3.zero,
                Rotation = Quaternion.identity,
                Parent = null
            };
        }
    }
}
