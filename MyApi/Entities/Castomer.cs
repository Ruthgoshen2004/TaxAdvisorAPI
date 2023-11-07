namespace MyApi.Entities
{
    public class Castomer
    {
        int id;
        string name;
        int age;
        int status;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Status { get => status; set => status = value; }
    }
}
