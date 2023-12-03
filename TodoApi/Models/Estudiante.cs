namespace TodoApi.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdTarea  { get; set; }
        public string Password { get; set; } = "1234567";
    }
}