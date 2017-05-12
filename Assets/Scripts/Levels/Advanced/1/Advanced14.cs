// 20,11,01
namespace Assets.Scripts.Levels
{
    class Advanced14 : GameLevel
    {
        public Advanced14() : base("Advanced14")
        {
            Initialize(3, 3);
            MapButtons = new int[,]
            {
                {YLW, OFF, LIT},
                {GRN, OFF, OFF},
                {YLW, YLW, RED},
            };
        }

        public override GameLevel NextLevel
        {
            get { return new Advanced15(); }
        }
    }
}
