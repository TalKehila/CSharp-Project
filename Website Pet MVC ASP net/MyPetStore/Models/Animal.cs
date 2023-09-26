

namespace MyPetStore.Models
{
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }
	
		[Required(ErrorMessage = "The Name field is required.")]
		[RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Invalid characters in the Name field.")]
        public string Name { get; set; }

		[Required(ErrorMessage = "The Age field is required.")]
		[Range(1, 150, ErrorMessage = "Please enter a valid age between 1 and 150.")]	
        public int? Age { get; set; }

        //[IsTextValid]
        // [Required(ErrorMessage = "The Photo field is required.")]
		//[RegularExpression(@"^.+\.(jpg|jpeg|png)$", ErrorMessage = "Invalid photo file.")]
        public string Photo { get; set; }


      [Required(ErrorMessage = "The  Description field is required.")]
		[RegularExpression(@"^[A-Za-z\s\d]{3,200}$", ErrorMessage = "Description should be between 10 and 200 characters.")]
		public string Description { get; set; }  


        public int CategoryId { get; set; }
        public virtual List<Comment> Comments { get; set; }

		public virtual Category Category { get; set; }
        internal bool IsExist(MyData context)
        {
            return context.animals.Any(a => a.Name == this.Name && a.AnimalId != this.AnimalId);
        }
    }
}
