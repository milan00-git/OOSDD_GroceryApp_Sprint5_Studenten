using System;

namespace Grocery.Core.Data
{
	public class CategoryRepository : ICategoryRepository
	{
		private List<Category> categories;
		public CategoryRepository()
		{
			categories = [
				new Category(1, "zuivel"),
				new Category(2, "ontbijt"),
				new Category(3, "graanproducten")
				new Category(4, "vlees"),
				new Category(5, "snacks"),
				new Category(6, "drinken")
				];
		}

		public List<Category> GetAll()
		{
			return categories;	// Geef lijst met alle categories terug
		}

		public Category? Get(int id)
		{
			foreach (category in categories)
			{
				// Check of de id klopt met de id van de category
				if (category.Id == id)
				{
					return Category;
				}
			}

			return null;	// geef null als er geen category gevonden is
		}
	}
}

