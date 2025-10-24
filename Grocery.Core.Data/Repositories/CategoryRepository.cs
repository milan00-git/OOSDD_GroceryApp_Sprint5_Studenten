using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
	public class CategoryRepository : ICategoryRepository
	{
		private readonly List<Category> categories;
		public CategoryRepository()
		{
			categories = new List<Category>
			{
				new Category(1, "zuivel"),
				new Category(2, "ontbijt"),
				new Category(3, "graanproducten"),
				new Category(4, "vlees"),
				new Category(5, "snacks"),
				new Category(6, "drinken")
			};		
		}

		public List<Category> GetAll()
		{
			return categories;	// Geef lijst met alle categories terug
		}

		public Category? Get(int id)
		{
			foreach (Category category in categories)
			{
				// Check of de id klopt met de id van de category
				if (category.Id == id)
				{
					return category;
				}
			}

			return null;	// geef null als er geen category gevonden is
		}
	}
}

