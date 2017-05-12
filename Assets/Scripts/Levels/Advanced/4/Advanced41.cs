

// 11,12,13,14,24,34,44,43,42,41,31,21
namespace Assets.Scripts.Levels
{
    class Advanced41 : GameLevel
    {
        public Advanced41()
            : base("Advanced41")
        {
            Initialize(6, 12);
            MapButtons = new int[,]
            {
                {RED, LIT, YLW, LIT, YLW, OFF},
                {LIT, RED, LIT, RED, LIT, YLW},
                {YLW, LIT, GRN, OFF, RED, LIT},
                {LIT, RED, OFF, GRN, LIT, YLW},
                {YLW, LIT, RED, LIT, RED, LIT},
                {OFF, YLW, LIT, YLW, LIT, RED},
            };
        }
        public override GameLevel NextLevel
        {
            get { return new Advanced42(); }
        }
    }
}
