using Microsoft.EntityFrameworkCore;
using Print_invoice;
using System.Data;
using System.Data.SqlClient;

namespace Print_invoice
{
    public partial class Form1 : Form
    {
        string ConnectionString = @"Data Source = WS-1067\SQLEXPRESS ;Initial Catalog= cosmetic ;User ID=sa;Password=123456";
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;
        string sql;
        public Form1()
        {
            InitializeComponent();
            ketnoi = new SqlConnection(ConnectionString);
            ketnoi.Open();
            sql = @"SELECT TENSP from SANPHAM";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                cbTenSP.Items.Add(docdulieu[0].ToString());
                i++;

            }
            ketnoi.Close();
        }
    
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                /*Provider p = new Provider();
                DataTable dt = null;
                try
                {
                    string strSQL = "sp_ShowAllProduct";
                    p.Connect();
                    dt = p.ExcecuteQuery(CommandType.StoredProcedure, strSQL);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    p.DisConnect();
                }*/
        }


        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*MessageBox.Show("aaaaa");
            ketnoi.Open();
            sql = @"SELECT TENSP from SANPHAM";
            thuchien = new SqlCommand(sql,ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                cbTenSP.Items.Add(docdulieu[1].ToString());
                i++;

            }
            ketnoi.Close();*/
        }

        //
        /*        public DataTable ShowAllProduct()
                {
                    Provider p = new Provider();
                    DataTable dt = null;
                    try
                    {
                        string strSQL = "sp_ShowAllProduct";
                        p.Connect();
                        dt = p.ExcecuteQuery(CommandType.StoredProcedure, strSQL);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        p.DisConnect();
                    }
                    return dt;
                }*/
    }
}