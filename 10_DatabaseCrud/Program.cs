using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            #region kategori ekleme işlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=IDEPEXSRV;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory(CategoryName) values (@p1)",connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //Console.Write("Ekleme işlemi başarılı"); 
            #endregion

            #region Ürün ekleme işlemi
            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Ürün Adı : ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı :");
            //productPrice=decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=IDEPEXSRV;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values (@productName, @productPrice, @productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine();
            //Console.Write("******************Ürün ekleme başarılı.****************");
            #endregion

            #region **Ürün Listeleme**
            //SqlConnection connection = new SqlConnection("Data Source=IDEPEXSRV;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * from TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);

            //foreach (DataRow dr in dt.Rows) 
            //{
            //    foreach (var item in dr.ItemArray)
            //    {
            //        Console.Write(item.ToString()+ " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close(); 

            #endregion

            #region **Ürün Silme İşlemi**

            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=IDEPEXSRV; initial Catalog = EgitimKampiDb; integrated security = true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //Console.WriteLine("********Silme işlemi yapıldı*******");

            #endregion

            #region **Ürün güncelleme işlemi**

            Console.Write("Güncellenecek Ürün Id: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Adı:");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek Ürün Fiyatı:");
            decimal productPrice = decimal.Parse(Console.ReadLine());

             
         
            SqlConnection connection = new SqlConnection("Data Source=IDEPEXSRV; initial Catalog = EgitimKampiDb; integrated security = true");
            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice where ProductId = @productId", connection);
            
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Güncelleme başarılı!");
            #endregion

            Console.Read();
        }
    }
}
