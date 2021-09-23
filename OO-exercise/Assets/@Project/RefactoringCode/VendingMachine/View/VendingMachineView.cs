using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class VendingMachineView : MonoBehaviour
{
    [SerializeField] private Text _yenText;

    public void ChangeYenText(int money)
    {
        _yenText.text = money+"円";
    }
}
