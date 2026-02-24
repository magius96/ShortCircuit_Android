

// 09,19,29,39,49,59,69,79,89,99,97,87,77,67,57,47,37,27,17,07,05,15,25,35,45,55,65,75,85,95,93,83,73,63,53,91,81,71,61,51,10,30,41,21,01,12,32,43,23,03
namespace Assets.Scripts.Levels
{
    class Advanced57 : GameLevel
    {
        public Advanced57()
            : base("Advanced57", "5-7")
        {
            Initialize(10, 50);
            MapButtons = new int[,]
            {
                {GRN, LIT, RED, LIT, GRN, YLW, YLW, YLW, YLW, YLW},
                {LIT, YLW, LIT, YLW, OFF, LIT, LIT, LIT, LIT, OFF},
                {RED, LIT, YLW, LIT, RED, GRN, GRN, GRN, GRN, GRN},
                {LIT, RED, LIT, RED, OFF, LIT, LIT, LIT, LIT, OFF},
                {GRN, LIT, GRN, LIT, GRN, GRN, GRN, GRN, GRN, GRN},
                {OFF, LIT, LIT, LIT, LIT, LIT, LIT, LIT, LIT, OFF},
                {GRN, GRN, GRN, GRN, GRN, GRN, GRN, GRN, GRN, GRN},
                {OFF, LIT, LIT, LIT, LIT, LIT, LIT, LIT, LIT, OFF},
                {GRN, GRN, GRN, GRN, GRN, GRN, GRN, GRN, GRN, GRN},
                {OFF, LIT, LIT, LIT, LIT, LIT, LIT, LIT, LIT, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new TestLevel();
            }
        }
    }
}
