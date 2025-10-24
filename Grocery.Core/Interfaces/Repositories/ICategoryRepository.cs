using System;
using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Repositories
{
	public interface ICategoryRepository
	{
		public ICategoryRepository()
		{
			public List<Category> GetAll();	// GetAll() geeft lijst met Category objecten
			public Category? Get(int id);	// Kan een Category meegeven of Null
		}
	}
}

