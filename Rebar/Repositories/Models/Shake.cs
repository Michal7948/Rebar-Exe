
namespace Repositories.Models
{
    public class Shake
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }//must be of menu.
        public string Description { get; set; }
        public double PriceSizeL { get; set; }
        public double PriceSizeM { get; set; }
        public double PriceSizeS { get; set; }

        //public Shake()
        //{
        //    Id = Guid.NewGuid();
        //}


    }
}
