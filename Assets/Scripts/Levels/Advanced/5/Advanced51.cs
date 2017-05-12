

// 33,22,42,44,24,15,55,51,11,00,60,66,06,35,31,53,13
namespace Assets.Scripts.Levels
{
    class Advanced51 : GameLevel
    {
        public Advanced51()
            : base("Advanced51")
        {
            Initialize(7, 17);
            MapButtons = new int[,]
            {
                {LIT, GRN, OFF, LIT, OFF, GRN, LIT},
                {GRN, YLW, RED, LIT, RED, YLW, GRN},
                {OFF, RED, YLW, YLW, YLW, RED, OFF},
                {LIT, LIT, YLW, YLW, YLW, LIT, LIT},
                {OFF, RED, YLW, YLW, YLW, RED, OFF},
                {GRN, YLW, RED, LIT, RED, YLW, GRN},
                {LIT, GRN, OFF, LIT, OFF, GRN, LIT},
            };
        }
        public override GameLevel NextLevel
        {
            get { return new Advanced52(); }
        }
    }
}
