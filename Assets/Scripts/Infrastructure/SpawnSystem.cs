using Assets.Scripts.Common;
using Assets.Scripts.Components;
using Leopotam.Ecs;

namespace Assets.Scripts.Infrastructure
{
    public class SpawnSystem : IEcsPreInitSystem, IEcsRunSystem
    {
        private EcsWorld _world;
        private SceneData _sceneData;

        // ссылки на все сущности с компонентом SpawnPrefab
        private EcsFilter<SpawnPrefab> _spawnFilter = null;

        private PrefabFactory _factory;

        public void PreInit()
        {
            _factory = _sceneData.Factory;
            _factory.SetWorld(_world);
        }

        public void Run()
        {
            // проверяем естьли сущность в этом фильтре
            if (_spawnFilter.IsEmpty())
                return;

            foreach(int index in _spawnFilter)
            {
                // ref что бы сущности изменились и там откуда они пришли
                ref EcsEntity spawnEntity = ref _spawnFilter.GetEntity(index);
                var spawnPrefabData = spawnEntity.Get<SpawnPrefab>();
                _factory.Spawn(spawnPrefabData);
                spawnEntity.Del<SpawnPrefab>();
            }
        }
    }
}
