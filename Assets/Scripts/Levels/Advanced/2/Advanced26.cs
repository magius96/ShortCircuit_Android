

namespace Assets.Scripts.Levels
{
    class Advanced26 : GameLevel
    {
        public Advanced26()
            : base("Advanced26")
        {
            Initialize(4, 8);
            MapButtons = new int[,]
            {
                {GRN, LIT, RED, LIT},
                {OFF, RED, OFF, GRN},
                {OFF, RED, OFF, GRN},
                {GRN, LIT, RED, LIT},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Advanced27();
            }
        }
    }
}
