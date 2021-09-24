using Zenject;
using VendingMachinePresenters;

public class RefactoringPresenterInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        // Container.Bind<DrinkPresenter>().AsSingle().NonLazy();
        // Container.Bind<LogPresenter>().AsSingle().NonLazy();
        // Container.Bind<MoneyPresenter>().AsSingle().NonLazy();
        // Container.Bind<VendingMachinePresenter>().AsSingle().NonLazy();
    }
}