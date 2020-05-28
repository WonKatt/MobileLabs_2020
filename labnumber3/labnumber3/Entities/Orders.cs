using SQLite;

namespace labnumber3.Entities
{
    [Table("Orders")]
    public class Order
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        [MaxLength(256)]
        [Unique]
        public string Name { get; set; }
        [MaxLength(256)]
        public string Addons { get; set; }
    }
}