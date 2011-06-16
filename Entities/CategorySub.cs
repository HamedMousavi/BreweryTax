
namespace Entities
{
    public class CategorySub
    {
        public Culture Language { get; set; }
        public GeneralTypeCollection Types { get; set; }

        public CategorySub()
        {
            this.Types = new GeneralTypeCollection();
        }
    }
}
