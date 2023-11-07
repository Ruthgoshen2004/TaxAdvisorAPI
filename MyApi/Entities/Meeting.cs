namespace MyApi.Entities
{
    public class Meeting
    {
        string date;
        string hour;
        int Durationofmeeting;

        public string Hour { get => hour; set => hour = value; }
        public int Durationofmeeting1 { get => Durationofmeeting; set => Durationofmeeting = value; }
        public string Date { get => date; set => date = value; }
    }
}
