// 11,22,33,31,13,22
namespace Assets.Scripts.Levels
{
    class Advanced36 : GameLevel
    {
        public Advanced36()
            : base("Advanced36")
        {
            Initialize(5, 6);
            MapButtons = new int[,]
            {
                {OFF, YLW, RED, YLW, OFF},
                {YLW, LIT, YLW, LIT, YLW},
                {RED, YLW, OFF, YLW, RED},
                {YLW, LIT, YLW, LIT, YLW},
                {OFF, YLW, RED, YLW, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get { return new Advanced37(); }
        }
    }
}
