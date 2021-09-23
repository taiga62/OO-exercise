using RefactoringCode;
using Zenject;
using UniRx;
using UnityEngine;

public class CoinPresenter:MonoBehaviour
{
    [Inject(Id = "Yen100")]private CoinView _100YenView;
    [Inject(Id = "Yen500")]private CoinView _500YenView;
    [Inject] private RVendingMachineSceneModel _model;

    
    private void Start()
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
            .Subscribe(_ =>
            {
                _model.ReceiveMoneys(100);
            });
        
        _500YenView.OnClickAsObservable
            .Subscribe(_ =>
            {
                _model.ReceiveMoneys(500);
            });
    }

    private void SetModelEvent()
    {
        
    }
}