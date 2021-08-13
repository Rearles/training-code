namespace Data
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime Dob { get; set; }
        public Gender Gender { get; set; }
    }
    public enum Gender{
        Male,
        Female
    }
}