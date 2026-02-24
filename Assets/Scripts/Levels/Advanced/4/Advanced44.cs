

// 05,04,03,02,11,20,30,41,52,53,54,55,43,33,23,13
namespace Assets.Scripts.Levels
{
    class Advanced44 : GameLevel
    {
        public Advanced44()
            : base("Advanced44", "4-4")
        {
            Initialize(6, 16);
            MapButtons = new int[,]
            {
                {RED, OFF, OFF, OFF, OFF, RED},
                {OFF, YLW, OFF, OFF, YLW, OFF},
                {OFF, LIT, YLW, YLW, LIT, OFF},
                {OFF, LIT, RED, RED, LIT, OFF},
                {LIT, OFF, YLW, YLW, OFF, LIT},
                {OFF, LIT, RED, RED, LIT, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get { return new Advanced45(); }
        }
    }
}
