// 21,13,17,56,87,63,44,60,42,26,48,56,72,32,24,35,48,56
namespace Assets.Scripts.Levels
{
    class Advanced56 : GameLevel
    {
        public Advanced56()
            : base("Advanced56", "5-6")
        {
            Initialize(9, 18);
            MapButtons = new int[,]
            {
                {RED, OFF, LIT, OFF, OFF, YLW, YLW, YLW, RED},
                {OFF, YLW, LIT, OFF, LIT, RED, YLW, YLW, RED},
                {OFF, LIT, GRN, OFF, OFF, YLW, GRN, YLW, YLW},
                {LIT, LIT, OFF, YLW, OFF, YLW, YLW, GRN, RED},
                {OFF, OFF, LIT, LIT, YLW, LIT, LIT, OFF, OFF},
                {RED, RED, RED, YLW, OFF, RED, OFF, OFF, OFF},
                {RED, GRN, YLW, GRN, LIT, LIT, RED, OFF, LIT},
                {YLW, YLW, GRN, RED, OFF, LIT, OFF, YLW, LIT},
                {RED, YLW, RED, GRN, OFF, OFF, OFF, OFF, YLW},
            };
        }
        public override GameLevel NextLevel
        {
            get { return new Advanced57(); }
        }
    }
}
