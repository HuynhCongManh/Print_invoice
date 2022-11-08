using System.Data;
using System.Data.SqlClient;

namespace Print_invoice
{
    public class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public DataTable ShowAllProduct()
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
        }
    }
}