using EGameSystems;
using UnityEngine;
using Zenject;

public class DataInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<GameData>().FromNew().AsSingle();
    }

}
