namespace WebAppApi.Models
{
    public class Mahasiswa
    {
        [Key]
        public int id { get; set; }
        public int? npm { get; set; } = null!;
        [Requierd]
        public string nama { get; set; } = null!;
        [Requierd]
        public string alamat { get; set; } = null!;
        [Requierd]
        public string kontak { get; set; } = null!;
        [Requierd]
        public Priority Priority { get; set; }
        public MahasiwaType MahasiwaType { get; set; }  
        public DateTime Created { get; set; }
        public DateTime? Completed { get; set; }

    }

    internal class KeyAttribute : Attribute
    {
    }

    internal class RequierdAttribute : Attribute
    {
    }

    public enum Priority
    {
        Low, Medium, High
    }

    public enum MahasiwaType {
        Feature, Bug, Documentation
    }
}
