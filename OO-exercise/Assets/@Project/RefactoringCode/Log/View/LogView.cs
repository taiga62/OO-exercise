using UnityEngine;
using UnityEngine.UI;
using VendingMachinePresenters;

namespace VendingMachineViews
{
    public class LogView : MonoBehaviour,IShowableLog
    {
        [SerializeField] private Text _logText;

        public void ChangeMoneyText(int money)
        {
            _logText.text += "\n"+ money + "円を投入しました。";
        }

        public void ChangeBuyedDrinkText(string text)
        {
            _logText.text += "\n" + text + "を購入しました。";
        }

        public void ChangeHasChargeText(int charge)
        {
            _logText.text += "\n" + charge + "円のお釣りです。";
        }

        public void ChangeOnclickButtnText(string text)
        {
            _logText.text = text + "ボタンを押しました。";
        }
    }
}