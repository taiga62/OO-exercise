using RefactoringCode;
using Zenject;
using UniRx;
using UnityEngine;

public class VendingMachinePresenter:MonoBehaviour
{
    [Inject]private readonly VendingMachineView _view;
    [Inject]private readonly RVendingMachineSceneModel _model;

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
            .Subscribe(money =>
        {
            _view.ChangeYenText(money);
        });
    }
}