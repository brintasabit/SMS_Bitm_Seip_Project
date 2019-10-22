using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Model;
using StockManagementSystem.Repository;

namespace StockManagementSystem.Bill
{
    class CategoryManager
    {
        CategoryRepository _categoryRepository=new CategoryRepository();
        public List<Category> ShowCategories(Category _category)
        {
            return _categoryRepository.ShowCategories(_category);
        }
        public List<Category> SearchCategoriesCode(Category _category)
        {
            return _categoryRepository.SearchCategoriesCode(_category);
        }
        public List<Category> SearchCategoriesName(Category _category)
        {
            return _categoryRepository.SearchCategoriesName(_category);
        }
        public bool SaveInfo(Category _category)
        {
            return _categoryRepository.SaveInfo(_category);
        }

        public List<Category> SearchCategoriesCode2(Category _category)
        {
            return _categoryRepository.SearchCategoriesCode2(_category);
        }
        public List<Category> SearchCategoriesName2(Category _category)
        {
            return _categoryRepository.SearchCategoriesName2(_category);
        }
    }
}
