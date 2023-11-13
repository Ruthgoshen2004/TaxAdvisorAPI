namespace MyApi.Entities
{
    public class Meeting
    {
        public  int IDmeet { get; set; }
        public string Hour { get ; set; }
        public int Durationofmeeting1 { get ; set; }
        public string Date { get; set; }
        public int CastomerId { get; set; }
        public int TaxAdvisorId { get ; set ; }
    }
}
