// 01,41,23,12,32,20,04,44
namespace Assets.Scripts.Levels
{
    class Advanced35 : GameLevel
    {
        public Advanced35()
            : base("Advanced35")
        {
            Initialize(5, 8);
            MapButtons = new int[,]
            {
                {LIT, LIT, LIT, LIT, LIT},
                {LIT, GRN, YLW, GRN, LIT},
                {GRN, LIT, LIT, LIT, GRN},
                {LIT, GRN, LIT, GRN, LIT},
                {LIT, LIT, YLW, LIT, LIT},
            };
        }
        public override GameLevel NextLevel
        {
            get { return new Advanced36(); }
        }
    }
}
