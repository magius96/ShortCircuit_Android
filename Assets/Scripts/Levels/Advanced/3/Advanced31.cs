

namespace Assets.Scripts.Levels
{
    class Advanced31 : GameLevel
    {
        public Advanced31()
            : base("Advanced31", "3-1")
        {
            Initialize(5, 12);
            MapButtons = new int[,]
            {
                {OFF, LIT, RED, LIT, OFF},
                {LIT, YLW, LIT, YLW, LIT},
                {RED, LIT, YLW, LIT, RED},
                {LIT, YLW, LIT, YLW, LIT},
                {OFF, LIT, RED, LIT, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Advanced32();
            }
        }
    }
}
