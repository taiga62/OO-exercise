using UnityEngine;
using UnityEngine.UI;
using VendingMachinePresenters;

namespace VendingMachineViews
{
    public class VendingMachineView : MonoBehaviour,IShowableMoney
    {
        [SerializeField] private Text _yenText;

        public void ChangeYenText(int money)
        {
            _yenText.text = money + "円";
        }
    }
}
