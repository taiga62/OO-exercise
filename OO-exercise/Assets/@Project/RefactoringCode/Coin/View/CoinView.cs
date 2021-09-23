using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class CoinView : MonoBehaviour
{
    [SerializeField] private Button _button;
    public IObservable<Unit> OnClickAsObservable => _button.OnClickAsObservable();
}
