

// 50,41,50,00,00,11,05,05,14,55,55,44,33,33,22,22,32,32,23,23
namespace Assets.Scripts.Levels
{
    class Advanced43 : GameLevel
    {
        public Advanced43()
            : base("Advanced43", "4-3")
        {
            Initialize(6, 20);
            MapButtons = new int[,]
            {
                {GRN, RED, OFF, OFF, RED, GRN},
                {RED, YLW, LIT, LIT, YLW, RED},
                {OFF, LIT, RED, RED, LIT, OFF},
                {OFF, LIT, RED, RED, LIT, OFF},
                {RED, YLW, LIT, LIT, YLW, RED},
                {GRN, RED, OFF, OFF, RED, GRN},
            };
        }
        public override GameLevel NextLevel
        {
            get { return new Advanced44(); }
        }
    }
}
