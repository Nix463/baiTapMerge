using System.Data;
using System.Data.SqlClient;
namespace Form1
{

    public partial class FAddProduct : Form
    {
       
        public FAddProduct()
        {
            InitializeComponent();
        }

        private void FAddProduct_Load(object sender, EventArgs e)
        {
            try
            {
                ProductDAO productsDAO = new ProductDAO();
                dgvDang.DataSource = productsDAO.getProducts();
                Console.WriteLine("m chay ho t cai");

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }
        

        // add product
        private void btnPost_Click_1(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("m chay ho t cai");
                ProductDAO dao = new ProductDAO();
               
                Product pro = new Product(dao.nextId(), txtName.Text, cbbCondition.Text, txtDescibe.Text, Convert.ToDateTime(dtpDay.Text), txtEmail.Text, txtPhone.Text);
                dao.addProduct(pro);

                dao.getProducts();

            }
            catch (Exception exc)
            {
                Console.WriteLine("m chay ho t cai");
                MessageBox.Show(exc.Message);
            }

        }
    }
}
