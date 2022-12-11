namespace ApiEmployee.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public bool status { get; set; }
        public string? createdAt { get; set; }
    }
}
