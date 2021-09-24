using RefactoringCode;
using UnityEngine;
using VendingMachinePresenters;
using VendingMachineViews;
using Zenject;

namespace VendingMachineInstallers
{
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
                .AsSingle();

            Container
                .Bind<IClickable>()
                .WithId("Yen100")
                .To<MoneyView>()
                .FromComponentOn(_100Yen)
                .AsTransient();

            Container
                .Bind<IClickable>()
                .WithId("Yen500")
                .To<MoneyView>()
                .FromComponentOn(_500Yen)
                .AsTransient();

            Container
                .Bind<IClicknableFeedback>()
                .WithId("Cola")
                .To<DrinkView>()
                .FromComponentOn(_cola)
                .AsTransient();

            Container
                .Bind<IClicknableFeedback>()
                .WithId("ColaZero")
                .To<DrinkView>()
                .FromComponentOn(_colaZero)
                .AsTransient();

            Container
                .Bind<IClicknableFeedback>()
                .WithId("Tea")
                .To<DrinkView>()
                .FromComponentOn(_tea)
                .AsTransient();
            
            //Container.Bind<DrinkPresenter>().AsSingle().NonLazy();
            Container.Bind<LogPresenter>().AsSingle().NonLazy();
            //Container.Bind<MoneyPresenter>().AsSingle().NonLazy();
            //Container.Bind<VendingMachinePresenter>().AsSingle().NonLazy();
        }
    }
}