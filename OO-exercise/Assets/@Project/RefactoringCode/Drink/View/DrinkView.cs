using System;
using System.Collections;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using VendingMachinePresenters;

namespace VendingMachineViews
{
    public class DrinkView : MonoBehaviour, IClicknableFeedback
    {
        [SerializeField] private Image _drinkimage;
        [SerializeField] private Button _button;
        [SerializeField] private Color _feedBackColor;

        public IObservable<Unit> OnClickAsObservable => _button.OnClickAsObservable();

        public void ImageFeedBack()
        {
            StartCoroutine(FeedBack());
        }

        private IEnumerator FeedBack()
        {
            var defaultColor = _drinkimage.color;
            _drinkimage.color = _feedBackColor;
            yield return new WaitForSeconds(0.5f);
            _drinkimage.color = defaultColor;
        }
    }
}