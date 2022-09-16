using Assets.Scripts.Components;
using Leopotam.Ecs;
using UnityEngine;

namespace Assets.Scripts.System
{
    public class KeyInputSystem : IEcsRunSystem
    {
        private EcsWorld _world;
        public void Run()
        {
            if (Input.anyKeyDown)
                _world.NewEntity().Get<AnyKeyDownTag>();
        }
    }
}