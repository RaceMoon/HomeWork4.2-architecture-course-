using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class MediatorInstaller : MonoInstaller
{
    [SerializeField] private GameplayMediator _gameplayMediator;
    [SerializeField] private DefeatPanel _defeatPanel;
    [SerializeField] private MediatorBootstrap _bootstrap;
    public override void InstallBindings()
    {
        Container.Bind<Level>().AsSingle().NonLazy();
        Container.Bind<GameplayMediator>().FromInstance(_gameplayMediator).AsSingle();
        Container.BindInterfacesAndSelfTo<InputManager>().AsSingle().NonLazy();
        Container.InstantiatePrefabForComponent<MediatorBootstrap>(_bootstrap, Vector3.zero, Quaternion.identity, null);
    }
}
