using System;
using RefactoringCode;
using UniRx;

namespace VendingMachinePresenters
{
    public class LogPresenter
    { 
        private IShowableLog _view;
        private RVendingMachineSceneModel _model;

        private LogPresenter(
            IShowableLog view,
            RVendingMachineSceneModel model)
        {
            _view = view ?? throw new  ArgumentException(nameof(view));
            _model = model ?? throw new ArgumentException(nameof(model));
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
                .Where(money => money > 0)
                .Subscribe(money => { _view.ChangeMoneyText(money); });

            _model.Charge
                .SkipLatestValueOnSubscribe()
                .Where(charge => charge > 0)
                .Subscribe(charge => { _view.ChangeHasChargeText(charge); });

            _model.BuiedDrink
                .SkipLatestValueOnSubscribe()
                .Where(drink => drink != null)
                .Subscribe(drink =>
                {
                    if (drink.getKind() == 0)
                    {
                        _view.ChangeBuyedDrinkText("コーラ");
                    }
                    else if (drink.getKind() == 1)
                    {
                        _view.ChangeBuyedDrinkText("コーラゼロ");
                    }
                    else if (drink.getKind() == 2)
                    {
                        _view.ChangeBuyedDrinkText("お茶");
                    }
                });
        }

    }
}