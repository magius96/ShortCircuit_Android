namespace Assets.Scripts.Levels
{
    class TestLevel : GameLevel
    {
        public TestLevel() : base("TestLevel", "TEST")
        {
            // This level should never be displayed.
            Initialize(3, 1);
            MapButtons = new int[,]
            {
                {RED, OFF, OFF},
                {OFF, RED, OFF},
                {OFF, OFF, RED},
            };
        }
        public override GameLevel NextLevel
        {
            get { return new Advanced11(); }
        }
    }
}
