using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace THEME.UserControles
{
    public partial class UC_UserReporting : UserControl
    {
        public UC_UserReporting()
        {
            InitializeComponent();
        }

        private void UC_UserReporting_Load(object sender, EventArgs e)
        {
            SqlConnection obj = new SqlConnection("server=.;database=Telephone;uid=sa;password=123");
            SqlDataAdapter obj1 = new SqlDataAdapter("select * from infoation where type_of_conntion like '%" + comboBox1.Text + "%'", obj);
            obj.Open();
            DataTable dt = new DataTable();
            obj1.Fill(dt);
           
        }
    }
}
