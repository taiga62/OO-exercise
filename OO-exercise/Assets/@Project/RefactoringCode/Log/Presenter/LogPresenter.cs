using RefactoringCode;
using Zenject;
using UniRx;
using UnityEngine;

public class LogPresenter:MonoBehaviour
{
    [Inject]private LogView _view;
    [Inject]private RVendingMachineSceneModel _model;

    private void Start()
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
            .Where(money => money > 0)
            .Subscribe(money =>
            {
                _view.ChangeMoneyText(money);
            });

        _model.Charge
            .SkipLatestValueOnSubscribe()
            .Where(charge => charge > 0)
            .Subscribe(charge  =>
            {
                _view.ChangeHasChangeText(charge);
            });

        _model.BuiedDrink
            .SkipLatestValueOnSubscribe()
            .Where(drink => drink!=null)
            .Subscribe(drink =>
            {
                if (drink.getKind() == 0)
                {
                    _view.ChangeBuyDrinkText("コーラ");
                }
                else if (drink.getKind() == 1)
                {
                    _view.ChangeBuyDrinkText("コーラゼロ");
                }
                else if (drink.getKind() == 2)
                {
                    _view.ChangeBuyDrinkText("お茶");
                }
            });
    }
    
}