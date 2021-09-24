using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using VendingMachinePresenters;

namespace VendingMachineViews
{
    public class MoneyView : MonoBehaviour,IClickable
    {
        [SerializeField] private Button _button;
        public IObservable<Unit> OnClickAsObservable => _button.OnClickAsObservable();
    }
}