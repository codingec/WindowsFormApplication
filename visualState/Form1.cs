using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace visualState
{
    
    public partial class Form1 : Form
    {                                          //location                           //Dbname
        SqlConnection con = new SqlConnection("Data Source=ANDERSON-PC;Initial Catalog=DEEPc;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //ID variable used in Updating and Deleting Record  
        int Id = 0;
        public Form1()
        {
            InitializeComponent();
            DisplayData();
        }
        
   
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Products", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
          
        private void ClearData()
        {
            product.Text = "";
            description.Text = "";
            price.Text = "";
            quantity.Text = "";
            Id = 0;
        }


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            product.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            description.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            price.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            quantity.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
           
            if (product.Text != "" && description.Text != "")
            {
                cmd = new SqlCommand("insert into Products(product,description,price,quantity) values(@product,@description,@price,@quantity)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@product", product.Text);
                cmd.Parameters.AddWithValue("@description", description.Text);
                cmd.Parameters.AddWithValue("@price", price.Text);
                cmd.Parameters.AddWithValue("@quantity", quantity.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Se ha grabado correctamente los datos ");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Por favor Proveer datos ");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("update id " + Id);
            if (product.Text != "" && description.Text != "")
            {
                cmd = new SqlCommand("update Products set product=@product,description=@description,price=@price,quantity=@quantity where Id=@Id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@product", product.Text);
                cmd.Parameters.AddWithValue("@description", description.Text);
                cmd.Parameters.AddWithValue("@price", price.Text);
                cmd.Parameters.AddWithValue("@quantity", quantity.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se han actualizado los datos ");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Selecciona para actualizar los datos " + Id);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("delete id " + Id);
            if (Id != 0)
            {
                cmd = new SqlCommand("delete Products where Id=@Id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Se han borrado estos datos");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Por favor seleccione para borrar los datos "+ Id);
            }
        }
 
    }
}
