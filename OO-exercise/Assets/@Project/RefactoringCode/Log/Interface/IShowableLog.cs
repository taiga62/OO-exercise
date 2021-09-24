namespace VendingMachinePresenters
{
    public interface IShowableLog
    {
        public void ChangeMoneyText(int money);
        public void ChangeBuyedDrinkText(string text);
        public void ChangeHasChargeText(int money);
        public void ChangeOnclickButtnText(string text);
    }
}