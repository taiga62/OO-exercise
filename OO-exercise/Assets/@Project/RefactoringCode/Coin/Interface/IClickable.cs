using System;
using UniRx;

namespace VendingMachinePresenters
{
    /// <summary>
    /// ボタンがクリックされたことを観測
    /// </summary>
    public interface IClickable
    {
        public IObservable<Unit> OnClickAsObservable { get; }
    }
}