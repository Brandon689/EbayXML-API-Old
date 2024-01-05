using SQLite;

namespace ECommerce.Database.DTO
{
    public class DomainObject
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
    }
}
