

// 01,11,21,31,41,51,61,71,76,66,56,46,36,26,06,16,04,03,13,14,24,23,33,34,44,43,53,54,64,63,73,74
namespace Assets.Scripts.Levels
{
    class Advanced54 : GameLevel
    {
        public Advanced54()
            : base("Advanced54", "5-4")
        {
            Initialize(8, 32);
            MapButtons = new int[,]
            {
                {LIT, YLW, LIT, YLW, YLW, LIT, YLW, LIT},
                {OFF, RED, LIT, RED, RED, LIT, RED, OFF},
                {OFF, GRN, OFF, GRN, GRN, OFF, GRN, OFF},
                {LIT, YLW, OFF, YLW, YLW, OFF, YLW, LIT},
                {LIT, YLW, OFF, YLW, YLW, OFF, YLW, LIT},
                {OFF, GRN, OFF, GRN, GRN, OFF, GRN, OFF},
                {OFF, RED, LIT, RED, RED, LIT, RED, OFF},
                {LIT, YLW, LIT, YLW, YLW, LIT, YLW, LIT},
            };
        }
        public override GameLevel NextLevel
        {
            get { return new Advanced55(); }
        }
    }
}
