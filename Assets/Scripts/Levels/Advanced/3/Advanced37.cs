

// 00,01,02,03,04,40,41,42,43,44,32,22,12
namespace Assets.Scripts.Levels
{
    class Advanced37 : GameLevel
    {
        public Advanced37()
            : base("Advanced37")
        {
            Initialize(5, 13);
            MapButtons = new int[,]
            {
                {GRN, YLW, RED, YLW, GRN},
                {RED, OFF, LIT, OFF, RED},
                {YLW, LIT, RED, LIT, YLW},
                {RED, OFF, LIT, OFF, RED},
                {GRN, YLW, RED, YLW, GRN},
            };
        }
        public override GameLevel NextLevel
        {
            get { return new Advanced41(); }
        }
    }
}
