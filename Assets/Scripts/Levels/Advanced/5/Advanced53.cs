// 21,32,42,51,62,53,54,65,56,45,35,26,15,24,23,12
namespace Assets.Scripts.Levels
{
    class Advanced53 : GameLevel
    {
        public Advanced53()
            : base("Advanced53", "5-3")
        {
            Initialize(8, 16);
            MapButtons = new int[,]
            {
                {OFF, OFF, YLW, OFF, OFF, YLW, OFF, OFF},
                {OFF, OFF, LIT, GRN, GRN, LIT, OFF, OFF},
                {YLW, LIT, YLW, OFF, OFF, YLW, LIT, YLW},
                {OFF, GRN, OFF, OFF, OFF, OFF, GRN, OFF},
                {OFF, GRN, OFF, OFF, OFF, OFF, GRN, OFF},
                {YLW, LIT, YLW, OFF, OFF, YLW, LIT, YLW},
                {OFF, OFF, LIT, GRN, GRN, LIT, OFF, OFF},
                {OFF, OFF, YLW, OFF, OFF, YLW, OFF, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get { return new Advanced54(); }
        }
    }
}
