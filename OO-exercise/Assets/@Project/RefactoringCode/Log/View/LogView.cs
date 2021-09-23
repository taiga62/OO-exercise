using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogView : MonoBehaviour
{
    [SerializeField] private Text _logText;

    public void ChangeMoneyText(int money)
    {
        _logText.text = money +"円を投入しました。";
    }

    public void ChangeBuyDrinkText(string text)
    {
        _logText.text += "\n" + text+"を購入しました。";
    }

    public void ChangeHasChangeText(int money)
    {
        _logText.text += "\n" + money + "円のお釣りです。";
    }

    public void ChangeOnclickButtnText(string text)
    {
        _logText.text = text+"ボタンを押しました。";
    }
}
