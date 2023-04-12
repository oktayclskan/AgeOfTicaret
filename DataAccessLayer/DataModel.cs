using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;

        public DataModel()
        {
            con = new SqlConnection(ConnectionStrings.conStr);
            cmd = con.CreateCommand();
        }
        #region Categort metots
        public List<Category> CategoriesList()
        {
            List<Category> categories = new List<Category>();
            try
            {
                cmd.CommandText = "SELECT CategoryID, CategoryName, Description  FROM Categories";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Category cg = new Category();
                    cg.ID = reader.GetInt32(0);
                    cg.CategoryName = reader.GetString(1);
                    cg.Descripton = reader.GetString(2);
                    categories.Add(cg);
                }
                return categories;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public Category KategoriEkle(Category c)
        {
            try
            {
                cmd.CommandText = "Insert Into Categories(CategoryName,Description) Values (@categoryName,@description) Select @@IDENTITY";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@categoryName", c.CategoryName);
                cmd.Parameters.AddWithValue("@description", c.Descripton);
                con.Open();
                c.ID = Convert.ToInt32(cmd.ExecuteScalar());
                return c;
            }

            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        public Category getCategory(int id)
        {
            try
            {
                cmd.CommandText = "SELECT CategoryID, CategoryName, Description  FROM Categories Where CategoryID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Category cg = new Category();
                while (reader.Read())
                {

                    cg.ID = reader.GetInt32(0);
                    cg.CategoryName = reader.GetString(1);
                    cg.Descripton = reader.GetString(2);

                }
                return cg;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        public bool KategoriGuncelle(Category c)
        {
            try
            {
                cmd.CommandText = "Update Categories Set CategoryName=@categoryName,Description=@description Where CategoryID=@id ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", c.ID);
                cmd.Parameters.AddWithValue("@categoryName", c.CategoryName);
                cmd.Parameters.AddWithValue("@description", c.Descripton);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally { con.Close(); }
        }
        public bool kategoriSil(int id)
        {
            try
            {
                cmd.CommandText = "Delete From Categories Where CategoryID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally { con.Close(); }
        }
        #endregion
        #region Employee Login
        
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
        public Employes GetEmployee(int id)
        {
            try
            {
                Employes model = new Employes();
                cmd.CommandText = "Select [EmployeeID],[UserName],[Password],[LastName],[FirstName],[Title],[TitleOfCourtesy],[BirthDate],[HireDate],[Address],[City],[Region],[PostalCode],[Country],[HomePhone],[Extension],[Notes],[ReportsTo],[PhotoPath],[TitleOfCourtesy] +' '+[FirstName]+' '+[LastName] AS Fullname From Employees WHERE EmployeeID=@id ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id",id);
                if (con.State !=System.Data.ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    model.EmployeeID = reader.GetInt32(0);
                    model.UserName = reader.GetString(1);
                    model.Password = reader.GetString(2);
                    model.LastName = reader.GetString(3);
                    model.FirstName = reader.GetString(4);
                    model.Title = reader.GetString(5);
                    model.TitleOfCourtesy = reader.GetString(6);
                    model.BirthDate = reader.GetDateTime(7);
                    model.HireDate = reader.GetDateTime(7);
                    model.Address = reader.GetString(9);
                    model.City = reader.GetString(10);
                    model.Region = !reader.IsDBNull(11) ? reader.GetString(11) : "";
                    model.PostalCode = reader.GetString(12);
                    model.Country = reader.GetString(13);
                    model.HomePhone = reader.GetString(14);
                    model.Extension = reader.GetString(15);
                    model.Notes = reader.GetString(16);
                    model.ReportsTo = !reader.IsDBNull(17) ? reader.GetInt32(17) : 0;
                    model.PhotoPath = reader.GetString(18);
                    model.FullName = reader.GetString(19);
                }
                return model;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public Employes EmployeeLogin(string username, string password)
        {
            Employes model = new Employes();
            try
            {
                cmd.CommandText = "Select EmployeeID From Employees Where UserName=@userName AND Password = @password";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@userName",username);
                cmd.Parameters.AddWithValue("@password", password);
                con.Open();
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                if (id>0)
                {
                    model = GetEmployee(id);
                }
                return model;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        #endregion
    }
}
