using RefactoringCode;
using UnityEngine;
using Zenject;

public class RefactoringCodeInstaller : MonoInstaller
{
    [SerializeField] private GameObject _100Yen;
    [SerializeField] private GameObject _500Yen;
    [SerializeField] private GameObject _cola;
    [SerializeField] private GameObject _colaZero;
    [SerializeField] private GameObject _tea;
    public override void InstallBindings()
    {
        Container
            .Bind<RVendingMachineSceneModel>()
            .AsSingle()
            .NonLazy();

        Container
            .Bind<CoinView>()
            .WithId("Yen100")
            .FromComponentOn(_100Yen)
            .AsTransient()
            .NonLazy();

        Container
            .Bind<CoinView>()
            .WithId("Yen500")
            .FromComponentOn(_500Yen)
            .AsTransient()
            .NonLazy();

        Container
            .Bind<DrinkView>()
            .WithId("Cola")
            .FromComponentOn(_cola)
            .AsTransient()
            .NonLazy();

        Container
            .Bind<DrinkView>()
            .WithId("ColaZero")
            .FromComponentOn(_colaZero)
            .AsTransient()
            .NonLazy();
        
        Container
            .Bind<DrinkView>()
            .WithId("Tea")
            .FromComponentOn(_tea)
            .AsTransient()
            .NonLazy();


    }
}