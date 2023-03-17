
namespace FarmHub.Shared.Entities
{
    public class Orders : EntityBase
    {
        public int UserId { get; set; }
        public int SellerId { get; set; }

        public decimal TotalPrice { get; set; }
        public int Count { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
