using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL;
using Entity;

namespace BLL
{
    public class CategoriesBLL
    {
        private CategoriesDAL categoriesDAL;
        public CategoriesBLL()
        {
            categoriesDAL = new CategoriesDAL();
        }
        public List<CategoriesEntity> GetCategories()
        {
            return categoriesDAL.GetCategories();
        }
        public void AddCategory(CategoriesEntity category)
        {
           categoriesDAL.AddCategory(category);
        }
    }
}
