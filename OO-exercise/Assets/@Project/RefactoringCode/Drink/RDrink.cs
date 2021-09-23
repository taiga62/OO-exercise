
namespace RefactoringCode
{
    public class RDrink
    {
        public static int COKE = 0;
        public static int DIET_COKE = 1;
        public static int TEA = 2;

        private readonly int _kind;

        public RDrink(int kind)
        {
            this._kind = kind;
        }

        public int getKind()
        {
            return _kind;
        }
    }
}