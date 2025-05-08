    public class Data
    {
        public int ID;
        public int TeamID;
        public string PlaceName;
        public Vector3 HeadPosition;
        public int Count { get; set; } = 1;
        public List<Transition> Transitions { get; set; } = new List<Transition>();
    }

    public class Transition
    {
        public int TargetID;
        public int Count { get; set; } = 1;
    }
