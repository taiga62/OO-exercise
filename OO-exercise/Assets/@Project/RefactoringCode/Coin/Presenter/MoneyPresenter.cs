using RefactoringCode;
using Zenject;
using UniRx;

namespace VendingMachinePresenters
{
    public class MoneyPresenter
    {
        [Inject(Id = "Yen100")] private IClickable _100YenView;
        [Inject(Id = "Yen500")] private IClickable _500YenView;
        [Inject] private RVendingMachineSceneModel _model;


        private  MoneyPresenter()
        {
            Init();
        }

        private void Init()
        {
            viewEvent();
        }

        private void viewEvent()
        {
            _100YenView.OnClickAsObservable
                .Subscribe(_ => { _model.ReceiveMoneys(100); });

            _500YenView.OnClickAsObservable
                .Subscribe(_ => { _model.ReceiveMoneys(500); });
        }
    }
}