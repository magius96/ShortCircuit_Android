

// 40,41,42,43,44,45,46,47,48,04,14,24,34,44,54,64,74,84,80,71,62,53,08,17,26,35,00,11,22,33,88,77,66,55
namespace Assets.Scripts.Levels
{
    class Advanced55 : GameLevel
    {
        public Advanced55()
            : base("Advanced55")
        {
            Initialize(9, 34);
            MapButtons = new int[,]
            {
                {LIT, OFF, RED, YLW, GRN, YLW, RED, OFF, LIT},
                {OFF, YLW, OFF, LIT, LIT, LIT, OFF, YLW, OFF},
                {RED, OFF, LIT, RED, RED, RED, LIT, OFF, RED},
                {YLW, LIT, RED, LIT, OFF, LIT, RED, LIT, YLW},
                {GRN, LIT, RED, OFF, RED, OFF, RED, LIT, GRN},
                {YLW, LIT, RED, LIT, OFF, LIT, RED, LIT, YLW},
                {RED, OFF, LIT, RED, RED, RED, LIT, OFF, RED},
                {OFF, YLW, OFF, LIT, LIT, LIT, OFF, YLW, OFF},
                {LIT, OFF, RED, YLW, GRN, YLW, RED, OFF, LIT},
            };
        }
        public override GameLevel NextLevel
        {
            get { return new Advanced56(); }
        }
    }
}
