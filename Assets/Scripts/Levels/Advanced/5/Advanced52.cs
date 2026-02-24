

// 36,25,35,45,44,34,24,23,33,43,42,32,22,21,31,41,30
namespace Assets.Scripts.Levels
{
    class Advanced52 : GameLevel
    {
        public Advanced52()
            : base("Advanced52", "5-2")
        {
            Initialize(7, 17);
            MapButtons = new int[,]
            {
                {OFF, OFF, OFF, GRN, OFF, OFF, OFF},
                {OFF, LIT, LIT, LIT, RED, LIT, OFF},
                {OFF, YLW, YLW, GRN, YLW, LIT, OFF},
                {RED, LIT, YLW, LIT, YLW, LIT, RED},
                {OFF, LIT, YLW, GRN, YLW, YLW, OFF},
                {OFF, LIT, RED, LIT, LIT, LIT, OFF},
                {OFF, OFF, OFF, GRN, OFF, OFF, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get { return new Advanced53(); }
        }
    }
}
