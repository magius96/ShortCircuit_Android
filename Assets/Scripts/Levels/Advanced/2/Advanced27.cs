

// 20,21,11,01,12,13,22,32
namespace Assets.Scripts.Levels
{
    class Advanced27 : GameLevel
    {
        public Advanced27()
            : base("Advanced27")
        {
            Initialize(4, 8);
            MapButtons = new int[,]
            {
                {LIT, GRN, OFF, LIT},
                {OFF, YLW, YLW, GRN},
                {GRN, YLW, YLW, OFF},
                {LIT, OFF, GRN, LIT},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Advanced31();
            }
        }
    }
}
