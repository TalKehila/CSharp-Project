
namespace MyPetStore.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string CommentText { get; set; }
        public int AnimalId { get; set; }

       
    }
}
