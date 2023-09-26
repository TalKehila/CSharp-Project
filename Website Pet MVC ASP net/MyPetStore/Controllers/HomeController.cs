
namespace MyPetStore.Controllers
{
	public class HomeController : Controller
	{
		private readonly MyData _context;

		public HomeController(MyData context)
		{
			_context = context;

		}
		public IActionResult Index()
		{

			var animals = _context.animals
			 .Include(a => a.Comments)
			   .ToList();

			return View(animals);
		}
		public IActionResult Admin()
		{
			return View(_context);
		}
		public IActionResult Catalog(int? categoryId)
		{
			var categories = _context.categories.ToList();
			var animals = _context.animals.ToList();
			if (categoryId.HasValue)
			{

				animals = animals.Where(a => a.CategoryId == categoryId).ToList();
			}
			ViewBag.Categories = categories;
			return View(animals);
		}
		public IActionResult Animal(int animalId, string commentText)
		{

			var animal = _context.animals.ToList().Find(x => animalId == x.AnimalId);

			if (animal != null && !string.IsNullOrEmpty(commentText))
			{
				var newComment = new Comment
				{
					CommentText = commentText,
					AnimalId = animalId
				};

				_context.comments.Add(newComment);
				_context.SaveChanges();
			}
			return View(animal);
		}
		public IActionResult DeleteAnimal(int AnimalId)
		{
			var animalToDelete = _context.animals.FirstOrDefault(a => a.AnimalId == AnimalId);
			if (animalToDelete != null)
			{
				_context.animals.Remove(animalToDelete);
				_context.SaveChanges();
			}
			return RedirectToAction("Delete");
		}
		public IActionResult Delete()
		{
			return View("Delete", _context.animals.ToList());
		}

		[HttpGet]
		public IActionResult Edit(int animalId)
		{
			var existingAnimal = _context.animals
		.Include(a => a.Category)
		.FirstOrDefault(a => a.AnimalId == animalId);
			if (existingAnimal == null)
			{
				return NotFound();
			}
			var categories = _context.categories.ToList();
			ViewBag.Categories = categories;
			return View("Edit", existingAnimal);
		}
		[HttpPost]
		public IActionResult SaveBackToCatalog(Animal animalUpdate, IFormFile Photo)
		{
			var categories = _context.categories.ToList();			
			var existingAnimal = _context.animals
				.Include(a => a.Category)
				.FirstOrDefault(a => a.AnimalId == animalUpdate.AnimalId);

			if (existingAnimal == null)
			{
				return NotFound();
			}
			existingAnimal.Name = animalUpdate.Name;
			existingAnimal.Age = animalUpdate.Age;
			existingAnimal.Description = animalUpdate.Description;
			existingAnimal.CategoryId = animalUpdate.CategoryId;		
			existingAnimal.Category = categories.FirstOrDefault(x => x.CategoryId == animalUpdate.CategoryId);
			if (!ModelState.IsValid)
			{
				ViewBag.Categories = categories;
				return View("Edit", animalUpdate);
			}
			if (Photo != null && Photo.Length > 0)
			{
				var uniqueFileName = Photo.FileName;
				var uploadDir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img");
				var filePath = Path.Combine(uploadDir, uniqueFileName);

				using (var stream = new FileStream(filePath, FileMode.Create))
				{
					Photo.CopyTo(stream);
				}
				existingAnimal.Photo = "/img/" + uniqueFileName;
			}
			_context.SaveChanges();
			return RedirectToAction("Catalog");
		}

		
        [HttpGet]
        public IActionResult AddNew()
        {
            var categories = _context.categories.ToList();
            ViewBag.Categories = categories;
            Animal animal = new Animal();
            return View(animal);
        }

        [HttpPost]
        public IActionResult AddNew(Animal newAnimal, IFormFile Photo)
		{
			var categories = _context.categories.ToList();
			ViewBag.Categories = categories;
			
			var categoryName = newAnimal.Category?.Name;
			if (!string.IsNullOrEmpty(categoryName) && _context.categories.Any(c => c.Name == categoryName))
			{
				ModelState.AddModelError("Category.Name", "A category with this name already exists.");
			}
			else
			{
				if (Photo != null && Photo.Length > 0)
				{
					var uniqueFileName = Photo.FileName;
					var uploadDir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img");
					var filePath = Path.Combine(uploadDir, uniqueFileName);

					using (var stream = new FileStream(filePath, FileMode.Create))
					{
						Photo.CopyTo(stream);
					}

					newAnimal.Photo = "/img/" + uniqueFileName;
				}

				if (ModelState.IsValid)
				{
					_context.animals.Add(newAnimal);
					_context.SaveChanges();
					return RedirectToAction("Catalog");
				}

			}			
			return View(newAnimal);
		}

	}

}