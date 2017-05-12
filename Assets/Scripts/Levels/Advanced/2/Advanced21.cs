

namespace Assets.Scripts.Levels
{
    class Advanced21 : GameLevel
    {
        public Advanced21()
            : base("Advanced21")
        {
            Initialize(4, 4);
            MapButtons = new int[,]
            {
                {OFF, YLW, YLW, OFF},
                {YLW, LIT, LIT, YLW},
                {YLW, LIT, LIT, YLW},
                {OFF, YLW, YLW, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Advanced22();
            }
        }
    }
}
