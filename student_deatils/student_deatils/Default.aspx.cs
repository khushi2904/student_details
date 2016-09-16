using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace student_deatils
{
    public partial class _Default : Page
    {
        SqlConnection conn;
        int n = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            string myconnectionstring = @"Data Source=(localdb)\Projects;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
            conn = new SqlConnection(myconnectionstring);

            if (!this.IsPostBack)
            {
                lblname.Visible = false;
                lblmarks.Visible = false;
                txtname.Visible = false;
                txtmarks.Visible = false;
                btnsubmit.Visible = false;
                lblerror.Visible = false;
                lblerror.Text = "";
            }
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            lblerror.Text = "";
            lblname.Visible = true;
            lblmarks.Visible = true;
            txtname.Visible = true;
            txtmarks.Visible = true;
            btnsubmit.Visible = true;
            lblerror.Visible = true;
            n = 1;
           
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                lblerror.Text = "";
                conn.Open();
                string sqls;
                SqlCommand cmd;
                if (n == 1)
                {
                    sqls = "update student_results set marks=@marks where name='@name'";
                    cmd = new SqlCommand(sqls, conn);
                    cmd.Parameters.AddWithValue("@marks", txtmarks.Text);
                    cmd.Parameters.AddWithValue("@name", txtname.Text);
                }
                else if (n == 2)
                {
                    sqls = "delete from student_results where name='@name'";
                    cmd = new SqlCommand(sqls, conn);
                    cmd.Parameters.AddWithValue("@name", txtname.Text);
                }
                else
                {
                    return;
                }
                cmd.ExecuteNonQuery();
                lblerror.Text = "Update Successful.";

            }
            catch (Exception ex)
            {
                lblerror.Text = "Update Unsuccessful.";
            }
            finally
            {
                conn.Close();
            }
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            lblerror.Text = "";
            lblmarks.Visible = false;
            txtmarks.Visible = false;
            lblname.Visible = true;
            txtname.Visible = true;
            btnsubmit.Visible = true;
            lblerror.Visible = true;
            n = 2;
        }
    }
}