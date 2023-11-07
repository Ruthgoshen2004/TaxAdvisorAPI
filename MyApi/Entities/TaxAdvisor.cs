namespace MyApi.Entities
{
    public class TaxAdvisor
    {
        int id;
        string name;
        int age;
        string status;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Status { get => status; set => status = value; }
    }
}
