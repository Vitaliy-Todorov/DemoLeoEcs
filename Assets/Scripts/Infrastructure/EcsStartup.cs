using Assets.Scripts.Common;
using Assets.Scripts.Components;
using Assets.Scripts.System;
using Leopotam.Ecs;
using UnityEngine;

namespace Assets.Scripts.Infrastructure
{
    public class EcsStartup : MonoBehaviour
    {
        [SerializeField]
        private StaticData _staticData;
        [SerializeField]
        private SceneData _sceneData;

        private EcsWorld _world;
        private EcsSystems _systems;

        void Start()
        {
            _world = new EcsWorld();
            _systems = new EcsSystems(_world);

#if UNITY_EDITOR
            Leopotam.Ecs.UnityIntegration.EcsWorldObserver.Create(_world);
            Leopotam.Ecs.UnityIntegration.EcsSystemsObserver.Create(_systems);
#endif

            _systems
                .OneFrame<AnyKeyDownTag>() // удаляем компонент
                .Add(new KeyInputSystem())
                .Add(new SpawnPlayer())
                .Add(new SpawnSystem())
                .Add(new DemoSystem())
                .Inject(_staticData)
                .Inject(_sceneData)
                .Init();
        }

        void Update()
        {
            _systems?.Run();
        }

        private void OnDestroy()
        {
            if (_systems != null)
            {
                _systems.Destroy();
                _systems = null;
                _world.Destroy();
                _world = null;
            }
        }
    }
}
