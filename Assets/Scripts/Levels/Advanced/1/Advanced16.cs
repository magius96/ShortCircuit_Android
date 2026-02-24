

namespace Assets.Scripts.Levels
{
    class Advanced16 : GameLevel
    {
        public Advanced16()
            : base("Advanced16", "1-6")
        {
            Initialize(3, 5);
            MapButtons = new int[,]
            {
                {RED, YLW, GRN},
                {YLW, OFF, RED},
                {GRN, RED, RED},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Advanced17();
            }
        }
    }
}
