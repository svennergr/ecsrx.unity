﻿using EcsRx.Entities;
using EcsRx.Events;
using EcsRx.Pools;
using EcsRx.Unity.Systems;
using EcsRx.Views.Components;
using UnityEngine;
using Zenject;

namespace EcsRx.Unity.Examples.AutoRegisterSystems.Systems
{
    public class DefaultViewResolver : UnityViewResolverSystem
    {
        public DefaultViewResolver(IPoolManager poolManager, IEventSystem eventSystem, IInstantiator instantiator) 
            : base(poolManager, eventSystem, instantiator)
        {}

        protected override GameObject PrefabTemplate => GameObject.CreatePrimitive(PrimitiveType.Cube);

        protected override void OnViewCreated(IEntity entity, GameObject view)
        {
            view.name = $"entity-{entity.Id}";
        }
    }
}