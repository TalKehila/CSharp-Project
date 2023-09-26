namespace MyPetStore.Data
{
	public class MyData : DbContext
	{
		DbContextOptions<MyData> _options;
		public MyData(DbContextOptions<MyData> options) : base(options)
		{
			_options = options;
		}
		public DbSet<Animal> animals { get; set; } // to make interact with my tables 
		public DbSet<Comment> comments { get; set; }
		public DbSet<Category> categories { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//Categories

			modelBuilder.Entity<Category>().HasData(
	   new Category { CategoryId = 1, Name = "Mammals" },
	   new Category { CategoryId = 2, Name = "Fish" },
	   new Category { CategoryId = 3, Name = "Birds" },
	   new Category { CategoryId = 4, Name = "Reptiles" }

	   );
			// Animals
			modelBuilder.Entity<Animal>().HasData(
				new Animal { AnimalId = 1, Name = "Cat",
					Age = 10, Photo = "/img/cati.jpeg",
					Description = "A cute cat",
					CategoryId = 1 },


				new Animal { AnimalId = 2,
					Name = "Dog",
					Age = 30,
					Photo = "/img/dog.jpeg",
					Description = "A friendly dog",
					CategoryId = 1 },


				new Animal { AnimalId = 3,
					Name = "Bird",
					Age = 35,
					Photo = "/img/bird.jpeg",
					Description = "A colorful bird",
					CategoryId = 3 },


				new Animal { AnimalId = 4,
					Name = "Barracuda",
					Age = 5,
					Photo = "/img/bar.jpeg", Description = "a Fast Fish",
					CategoryId = 2 },


				new Animal { AnimalId = 5,
					Name = "Snake",
					Age = 67,
					Photo = "/img/snakea.jpeg", Description = " A green snake",
					CategoryId = 4 }
			);


			modelBuilder.Entity<Comment>().HasData(
			   new Comment { CommentId = 1, CommentText = "I love Fluffy!", AnimalId = 1 },
			   new Comment { CommentId = 2, CommentText = "Rex is so cute!", AnimalId = 2 },
			   new Comment { CommentId = 3, CommentText = "Tweety is beautiful!", AnimalId = 3 },
			   new Comment { CommentId = 4, CommentText = "He eat Nemo !", AnimalId = 4 },
			   new Comment { CommentId = 5, CommentText = "Snakes are cutes!", AnimalId = 5 },
			   new Comment { CommentId = 6, CommentText = "Look like a SwordFish!", AnimalId = 4 },
			   new Comment { CommentId = 7, CommentText = "HAHAHAHAHAA", AnimalId = 4 },
			   new Comment { CommentId = 8, CommentText = "This fish is fast", AnimalId = 4 },
			   new Comment { CommentId = 9, CommentText = "SOOOO cuteeee", AnimalId = 5 },
			   new Comment { CommentId = 10, CommentText = "Hello there", AnimalId = 5 },
			   new Comment { CommentId = 11, CommentText = "Look", AnimalId = 5 },
			   new Comment { CommentId = 12, CommentText = "WOW", AnimalId = 5 }
		   );

			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Animal>().ToTable("animals");
			modelBuilder.Entity<Comment>().ToTable("comments");
			modelBuilder.Entity<Category>().ToTable("categories");

		}
	}
}
