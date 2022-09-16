﻿using Leopotam.Ecs;
using UnityEngine;

namespace Assets.Scripts.Infrastructure
{
    [RequireComponent(typeof(MonoEntity))]
    public abstract class MonoLinkBase : MonoBehaviour
    {
        public abstract void Make(ref EcsEntity entity);
    }
}