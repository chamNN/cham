using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace baiHoc_15_07
{
    public partial class baihoc15_07 : Form
    {
        public baihoc15_07()
        {
            InitializeComponent();



        }
        string ketNoi = "Data Source=LAPTOP-JAKJA372\\TAIMAIKHONGDUOC;Initial Catalog=onTapLab_LT3;Integrated Security=True";
        SqlConnection conn = null;


        private void btn_them_Click(object sender, EventArgs e)
        {
            using(conn = new SqlConnection(ketNoi))
            {
                conn.Open();

                string strcmd = @"INSERT INTO lop(maLop, tenLop) VALUES (@maLop, @tenLop)";

                SqlCommand cmd = new SqlCommand(strcmd, conn);
                cmd.Parameters.AddWithValue("@maLop", txt_maLop.Text);
                cmd.Parameters.AddWithValue("@tenLop", txt_tenLop.Text);
                cmd.ExecuteNonQuery(); // chạy câu lệnh insert into





            }
        }

        private void baihoc15_07_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(ketNoi))
            {
                conn.Open();
                string strcmd = @"SELECT * FROM lop";

                SqlCommand cmd = new SqlCommand(strcmd, conn);
                SqlDataAdapter dat = new SqlDataAdapter(cmd);

                DataTable tbt_lop = new DataTable();
                dat.Fill(tbt_lop);
                cmb_lop.DisplayMember = "tenLop";
                cmb_lop.ValueMember = "maLop";
                cmb_lop.DataSource = tbt_lop;

            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            using( conn = new SqlConnection(ketNoi))
            {
                conn.Open();

                string xoa = @"DELETE FROM lop WHERE maLop = @maLop";


                SqlCommand cmd = new SqlCommand(xoa, conn);

                cmd.Parameters.AddWithValue("@maLop", cmb_lop.SelectedValue.ToString());
                cmd.ExecuteNonQuery();
            }
        }
    }
}
