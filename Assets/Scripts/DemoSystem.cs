using Leopotam.Ecs;
using UnityEngine;

namespace Assets.Scripts
{
    public class DemoSystem : IEcsPreInitSystem, IEcsInitSystem, IEcsRunSystem, IEcsDestroySystem, IEcsPostDestroySystem
    {
        public void PreInit()
        {
            // Debug.Log("PreInitSystem");
        }

        public void Init()
        {
            // Debug.Log("InitSystem");
        }

        public void Run()
        {
            // Debug.Log("RunSystem");
        }

        public void Destroy()
        {
            // Debug.Log("DestroySystem");
        }

        public void PostDestroy()
        {
            // Debug.Log("PostDestroySystem");
        }
    }
}