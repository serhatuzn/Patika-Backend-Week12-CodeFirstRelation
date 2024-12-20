using Microsoft.Extensions.Hosting;

namespace CodeFirstRelation.Data.Entities
{
    public class User
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; } = ""; // Default değeri boş string olan bir Name property'si
        public string Email { get; set; } = ""; // Default değeri boş string olan bir Email property'si

        public List<Post> Posts { get; set; } // User'ın postları
    }
}
