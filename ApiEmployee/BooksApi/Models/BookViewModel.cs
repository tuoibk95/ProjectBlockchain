using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BooksApi.Models
{
    public class BookViewModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Name")]
        public string BookName { get; set; } = null!;

        public decimal Price { get; set; }

        public string Category { get; set; } = null!;
    }
}
