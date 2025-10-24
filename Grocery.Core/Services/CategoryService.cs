using System;
using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.Core.Services
{
	public class CategoryService : ICategoryService
    {
		private readonly ICategoryRepository _CategoryRepository;

		// Dependency Injection van CategoryRepository 
		public CategoryService(ICategoryRepository categoryRepository)
		{
			_CategoryRepository = categoryRepository;
		}

		public List<Category> GetAll()
		{
			return _CategoryRepository.GetAll();
		}

		public Category? Get(int id)
		{
			return _CategoryRepository.Get(id);
		}
	}
}


