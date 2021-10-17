using System;
using UniRx;

namespace VendingMachinePresenters
{
    /// <summary>
    /// ボタンを押されたときにフィードバックをする
    /// </summary>
    public interface IClicknableFeedback
    {
        public IObservable<Unit> OnClickAsObservable { get; }
        public void ImageFeedBack();
    }
}