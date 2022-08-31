using Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class Brand : Entity //Sınıfların her zaman imzası olsun dedi. Bu yuzden entityden kaltım aldı.
    {
        public string Name { get; set; }
        public Brand()
        {
        }

        public Brand(int id, string name): this() //Ortak şeylerin çalıştırılması adına basenin constunu çağırdı.
        {
            Id = id;
            Name = name;
        }
    }
}
