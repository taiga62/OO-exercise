using RefactoringCode;
using Zenject;
using UniRx;
using UnityEngine;

public class DrinkPresenter:MonoBehaviour
{
    [Inject(Id = "Cola")] private DrinkView _colaView;
    [Inject(Id = "ColaZero")] private DrinkView _colaZeroView;
    [Inject(Id = "Tea")] private DrinkView _teaView;
    [Inject] private LogView _logView;
    [Inject] private RVendingMachineSceneModel _model;

    private void Start()
    {
        Init();
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
