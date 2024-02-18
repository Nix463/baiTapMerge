using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//thao tac voi cai bang nhu them xoa sua
namespace Form1
{
     class ProductDAO
    {
        
        public ProductDAO() { }

        // lay tat ca du lieu tu bang product
        public DataTable getProducts()
        {
            DBconnection db = new DBconnection();
            db.open();
            DataTable result = new DataTable();
           
            String sql = String.Format("select * from products");
            SqlDataAdapter adapter = new SqlDataAdapter(sql, db.GetConnection());
            adapter.Fill(result);
            
            db.close();
            return result;
        }
        public void addProduct(Product pro)
        {
            DBconnection db = new DBconnection();
            db.open();

            String sqlStr = String.Format("INSERT INTO products(id,name,condition,descibe,date_add,email, phone_number) VALUES ('{0}', '{1}', '{2}','{3}', '{4}', '{5}','{6}')", 
                pro.Id, pro.Name,pro.Condition,pro.Descibe,pro.DateAdd,pro.Email,pro.PhoneNumber);
           SqlCommand sqlCommand = new SqlCommand(sqlStr, db.GetConnection());
            sqlCommand.ExecuteNonQuery();
            db.close();

        }
        public int nextId()
        {
            DBconnection db = new DBconnection();
            db.open();
            String sql = String.Format("select max(id) as 'id' from products");
            DataTable result = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, db.GetConnection());
            adapter.Fill(result);

            DataRow dataRow = result.Rows[0];
            int id = (int)dataRow["id"];

            db.close();
            return id + 1;

            
          
        }
        
    }
}
