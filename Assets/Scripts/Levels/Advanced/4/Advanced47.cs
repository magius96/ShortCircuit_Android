

// 41,31,21,11,12,13,14,25,35,44
namespace Assets.Scripts.Levels
{
    class Advanced47 : GameLevel
    {
        public Advanced47()
            : base("Advanced47", "4-7")
        {
            Initialize(6, 10);
            MapButtons = new int[,]
            {
                {OFF, LIT, LIT, LIT, LIT, OFF},
                {LIT, RED, RED, RED, GRN, LIT},
                {LIT, LIT, OFF, LIT, YLW, OFF},
                {LIT, LIT, LIT, OFF, YLW, OFF},
                {LIT, GRN, OFF, OFF, YLW, LIT},
                {OFF, OFF, GRN, GRN, OFF, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get { return new Advanced51(); }
        }
    }
}
