
namespace Repositories.Models
{
    public class Shake
    {
        public string Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double PriceSizeL { get; set; }
        public double PriceSizeM { get; set; }
        public double PriceSizeS { get; set; }

        public Shake()
        {
            Id = Guid.NewGuid().ToString();
        }


    }
}
