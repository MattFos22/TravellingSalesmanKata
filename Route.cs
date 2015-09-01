namespace TravellingSalesman
{
    public class Route
    {
        public Route(string start, string end)
        {
            Start = start;
            End = end;
        }

        public string Start { get; set; }
        public string End { get; set; }

        public override bool Equals(object obj)
        {
            var other = (Route) obj;
            return other.Start == Start && other.End == End || other.End == Start && other.Start == End;
        }
    }
}