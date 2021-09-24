using RefactoringCode;
using Zenject;
using UniRx;
using UnityEngine;

namespace VendingMachinePresenters
{
    public class DrinkPresenter
    {
        [Inject(Id = "Cola")] private IClicknableFeedback _colaView;
        [Inject(Id = "ColaZero")] private IClicknableFeedback _colaZeroView;
        [Inject(Id = "Tea")] private IClicknableFeedback _teaView;
        [Inject] private IShowableLog _logView;
        [Inject] private RVendingMachineSceneModel _model;

        private DrinkPresenter()
        {
            Init();
            Debug.Log("inject");
        }

        private void Init()
        {
            SetViewEvent();
        }

        private void SetViewEvent()
        {
            _colaView.OnClickAsObservable
                .Subscribe(_ =>
                {
                    _logView.ChangeOnclickButtnText("コーラ");
                    _model.BuyDrink(0);
                });

            _colaZeroView.OnClickAsObservable
                .Subscribe(_ =>
                {
                    _logView.ChangeOnclickButtnText("コーラゼロ");
                    _model.BuyDrink(1);
                });

            _teaView.OnClickAsObservable
                .Subscribe(_ =>
                {
                    _logView.ChangeOnclickButtnText("お茶");
                    _model.BuyDrink(2);
                });
        }

    }
}