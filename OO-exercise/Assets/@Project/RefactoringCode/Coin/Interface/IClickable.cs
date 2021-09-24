using System;
using UniRx;

namespace VendingMachinePresenters
{
    public interface IClickable
    {
        public IObservable<Unit> OnClickAsObservable { get; }
    }
}