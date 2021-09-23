namespace RefactoringCode
{
    public class RVendingMachine
    {
        private int quantityOfCoke = 5; // コーラの在庫数
        private int quantityOfDietCoke = 5; // ダイエットコーラの在庫数
        private int quantityOfTea = 5; // お茶の在庫数
        private int numberOf100Yen = 10; // 100円玉の在庫
        private int charge; // お釣り
        
        public RDrink Buy(int i, int kindOfDrink) {
            // 100円と500円だけ受け付ける
            if ((i != 100) && (i != 500)) {
                charge += i;
                return null;
            }

            if ((kindOfDrink == RDrink.COKE) && (quantityOfCoke == 0)) {
                charge += i;
                return null;
            } else if ((kindOfDrink == RDrink.DIET_COKE) && (quantityOfDietCoke == 0)) {
                charge += i;
                return null;
            } else if ((kindOfDrink == RDrink.TEA) && (quantityOfTea == 0)) {
                charge += i;
                return null;
            }

            // 釣り銭不足
            if (i == 500 && numberOf100Yen < 4) {
                charge += i;
                return null;
            }

            if (i == 100) {
                // 100円玉を釣り銭に使える
                numberOf100Yen++;
            } else if (i == 500) {
                // 400円のお釣り
                charge += (i - 100);
                // 100円玉を釣り銭に使える
                numberOf100Yen -= (i - 100) / 100;
            }

            if (kindOfDrink == RDrink.COKE) {
                quantityOfCoke--;
            } else if (kindOfDrink == RDrink.DIET_COKE) {
                quantityOfDietCoke--;
            } else {
                quantityOfTea--;
            }

            return new RDrink(kindOfDrink);
        }

        /**
     * お釣りを取り出す.
     *
     * @return お釣りの金額
     */
        public int Refund() {
            var result = charge;
            charge = 0;
            return result;
        }
    }
}