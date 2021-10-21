using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace ASPCRUD
{
    public partial class Index : System.Web.UI.Page
    {
        string connectionString = @"Server=localhost; Database=asp_crud_db; Uid=root; Pwd=cyb88";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection selCon = new MySqlConnection(connectionString))
            {
                sqlCon.Open();
                MySqlCommand sqlCmd = new MySqlCommand("ProductAddOrEdit",sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
            }
        }
    }
}