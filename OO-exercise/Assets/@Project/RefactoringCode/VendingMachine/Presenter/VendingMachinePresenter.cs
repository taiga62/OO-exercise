using RefactoringCode;
using Zenject;
using UniRx;

namespace VendingMachinePresenters
{
    public class VendingMachinePresenter
    {
        [Inject] private IShowableMoney _view;
        [Inject] private RVendingMachineSceneModel _model;

        private VendingMachinePresenter()
        {
            Init();
        }

        private void Init()
        {
            SetModelEvent();
        }

        private void SetModelEvent()
        {
            _model.HasMoneys
                .SkipLatestValueOnSubscribe()
                .Subscribe(money => { _view.ChangeYenText(money); });
        }
    }
}