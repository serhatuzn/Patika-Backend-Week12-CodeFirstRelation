namespace CodeFirstRelation.Data.Entities
{
    public class Post
    {
        public int Id { get; set; } // Primary Key
        public string Title { get; set; } = ""; // Default değeri boş string olan bir Title property'si
        public string Content { get; set; } = ""; // Default değeri boş string olan bir Content property'si
        public int UserId { get; set; } // Postun sahibinin Id'si

        public User User { get; set; } // Postun sahibi
    }
}
