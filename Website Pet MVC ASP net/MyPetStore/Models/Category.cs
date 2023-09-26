
namespace MyPetStore.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }	
	    [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Invalid characters in the Name field.")]
        [IsTextValid]
		public string Name { get; set; }
        public bool IsCategoryExist(MyData context)
        {
            return context.categories.Any(c => c.Name == this.Name);
        }

    }
}
