using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;

namespace DataAccessLayer
{
    public class CategoryProductDataAccessLogic
    {
        SqlConnection conn = new SqlConnection("Data Source=BLR1-LHP-N80812;Initial Catalog=training;Integrated Security=true;");
        List<Product> product = new List<Product>();
        List<Category> category = new List<Category>();
        public void InsertIntoCategoryTable(Category ctg)
        {
            conn.Open();
            try
            {
                category.Add(ctg);
                string query = $"Insert into Category values({ctg.CategoryId},'{ctg.CategoryName}')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

            }
            catch(SqlException sql)
            {
                Console.WriteLine(sql.Message);
            }
            catch (Exception e)
            {

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void InsertIntoProductTable(Product ptd,string CategoryName)
        {
            conn.Open();
            try
            {
                string ctgquery = $"Select CategoryId from Category where CategoryName='{CategoryName}'";
                SqlCommand ctgcmd = new SqlCommand(ctgquery, conn);
                int? CategoryId=null;
                CategoryId = (int)ctgcmd.ExecuteScalar();
                if (CategoryId != null)
                {
                    ptd.CategoryId = (int)CategoryId;
                    product.Add(ptd);
                    string query = $"Insert into Product values({ptd.ProductID},'{ptd.ProductName}','{ptd.Price}',{CategoryId})";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    throw new CategoryDepartmentException();
                }

            }
            catch(CategoryDepartmentException e)
            {
                e.InvalidCategory(CategoryName);
            }
            catch (SqlException sql)
            {
                Console.WriteLine(sql.Message);
            }
            catch (Exception e)
            {

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void GetCategoryData()
        {
            conn.Open();
            SqlDataReader reader = null;
            try
            {
                string query = $"Select * from Category";
                SqlCommand cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for(int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.WriteLine($"{reader.GetName(i)}: {reader[i]}");
                        }
                    }
                    Console.WriteLine("".PadLeft(30, '-'));

                }
                else
                {
                    throw new CategoryDepartmentException();
                }

            }
            catch(CategoryDepartmentException e)
            {
                e.EmptyDatabase("Category");
            }
            catch(SqlException sql)
            {
                Console.WriteLine(sql.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if(conn!= null)
                {
                    conn.Close();
                }
            }
        }

        public void GetProductData()
        {
            conn.Open();
            SqlDataReader reader = null;
            try
            {
                string query = $"Select ProductId,ProductName,Price,c.CategoryId,c.CategoryName from Product p inner join Category c on p.CategoryId = c.CategoryId ";
                SqlCommand cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.WriteLine($"{reader.GetName(i)}: {reader[i]}");
                        }
                        Console.WriteLine("".PadLeft(30, '-'));
                    }
                }
                else
                {
                    throw new CategoryDepartmentException();
                }

            }
            catch (CategoryDepartmentException e)
            {
                e.EmptyDatabase("Product");
            }
            catch (SqlException sql)
            {
                Console.WriteLine(sql.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void RetrieveSpecificProductData(int ProductId)
        {
            conn.Open();
            SqlDataReader reader = null;
            try
            {
                string query = $"Select * from Product p Inner Join Category c On p.CategoryId = c.CategoryId where p.ProductId ={ProductId} ";
                SqlCommand cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.WriteLine($"{reader.GetName(i)}: {reader[i]}");
                        }
                    }
                    Console.WriteLine("".PadLeft(30, '-'));

                }
                else
                {
                    throw new CategoryDepartmentException();
                }

            }
            catch (CategoryDepartmentException e)
            {
                e.InvalidId("Product");
            }
            catch (SqlException sql)
            {
                Console.WriteLine(sql.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public bool? UpdateProductPriceValue(int ProductId,float Price)
        {
            conn.Open();
            try
            {
                string query = $"Update Product Set Price = {Price} where ProductId={ProductId}";
                SqlCommand cmd = new SqlCommand(query, conn);
                int count = cmd.ExecuteNonQuery();
                if (count>0)
                {
                    return true;
                }
                else
                {
                    throw new CategoryDepartmentException();
                }

            }
            catch (CategoryDepartmentException e)
            {
                e.InvalidId("Product");
                return false;
            }
            catch (SqlException sql)
            {
                Console.WriteLine(sql.Message);
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public bool? DeleteProductfromTable(int ProductId)
        {
            conn.Open();

            try
            {
                string query = $"Delete from Product where ProductId={ProductId}";
                SqlCommand cmd = new SqlCommand(query, conn);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    throw new CategoryDepartmentException();
                }

            }
            catch(CategoryDepartmentException e)
            {
                e.InvalidId("Product");
                return false;
            }
            catch (SqlException sql)
            {
                Console.WriteLine(sql.Message);
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
          
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
