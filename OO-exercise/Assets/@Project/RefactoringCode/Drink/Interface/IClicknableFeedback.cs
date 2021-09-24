using System;
using UniRx;

namespace VendingMachinePresenters
{
    public interface IClicknableFeedback
    {
        public IObservable<Unit> OnClickAsObservable { get; }
        public void ImageFeedBack();
    }
}