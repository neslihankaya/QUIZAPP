using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entity;

namespace DAL
{
    public class CategoriesDAL
    {
        private DBConnection dBConnection;
        public CategoriesDAL()
        {
            dBConnection = new DBConnection();
        }

        public List<CategoriesEntity> GetCategories()
        {


            SqlCommand cmd = dBConnection.GetSqlCommand();
            cmd.CommandText = "SELECT categoryName FROM categories";
            cmd.ExecuteNonQuery();

            List<CategoriesEntity> categories = new List<CategoriesEntity>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CategoriesEntity category = new CategoriesEntity();
                category.categoryName = dr["categoryname"].ToString();

                categories.Add(category);
            }
            return categories;
        }
        public void AddCategory(CategoriesEntity category)
        {

            SqlCommand cmd = dBConnection.GetSqlCommand();
            cmd.CommandText = "INSERT INTO categories(categoryname) VALUES(@p1)";
            cmd.Parameters.AddWithValue("@p1", category.categoryName);

            cmd.ExecuteNonQuery();
        }
    }
}
