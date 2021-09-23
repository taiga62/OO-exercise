using UniRx;

namespace RefactoringCode
{
    public class RVendingMachineSceneModel
    {
        private readonly ReactiveProperty<int> _hasMoneys;
        private readonly ReactiveProperty<int> _charge;
        private readonly ReactiveProperty<RDrink> _dring;

        public IReactiveProperty<int> HasMoneys => _hasMoneys;
        public IReactiveProperty<int> Charge => _charge;
        public IReactiveProperty<RDrink> BuiedDrink => _dring;
        
        private readonly RVendingMachine _rVendingMachine;

        public RVendingMachineSceneModel()
        {
            _hasMoneys = new ReactiveProperty<int>();
            _charge = new ReactiveProperty<int>();
            _dring = new ReactiveProperty<RDrink>();
            _rVendingMachine = new RVendingMachine();
        }

        public void ReceiveMoneys(int moneys)
        {
            if (_hasMoneys.Value > 0) return;
            
            _hasMoneys.Value += moneys;
        }
        
        public void BuyDrink(int kind)
        {
            
            var drink = _rVendingMachine.Buy(_hasMoneys.Value, kind);
            var charge = _rVendingMachine.Refund();
            _hasMoneys.Value = 0;
            
            if (drink == null) return;

            _dring.Value = drink;
            _charge.Value = charge;
            
            _charge.Value = -1;
            _dring.Value = null;
        }

    }
}