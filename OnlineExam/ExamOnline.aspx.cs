using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace OnlineExam
{
    public partial class ExamOnline : System.Web.UI.Page
    {
        int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
            SqlConnection sqlcon = new SqlConnection(con);
            string sqlquery = "Select * from BooleanQuestions";
            string sqlquery2 = "Select * from NumericalQuestions";
            string sqlquery3 = "Select * from TextQuestions";

            if (!Page.IsPostBack)
            {
                sqlcon.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlquery, sqlcon);
                SqlDataAdapter sdr = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
               

              
                SqlCommand sqlCommand2 = new SqlCommand(sqlquery2, sqlcon);
                SqlDataAdapter sdr2 = new SqlDataAdapter(sqlCommand2);
                DataTable dt2 = new DataTable();
                sdr2.Fill(dt2);
                Repeater2.DataSource = dt2;
                Repeater2.DataBind();


                SqlCommand sqlCommand3 = new SqlCommand(sqlquery3, sqlcon);
                SqlDataAdapter sdr3 = new SqlDataAdapter(sqlCommand3);
                DataTable dt3 = new DataTable();
                sdr3.Fill(dt3);
                Repeater3.DataSource = dt3;
                Repeater3.DataBind();

                sqlcon.Close();

              


            }
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
           
            foreach (RepeaterItem ri in Repeater1.Items)
            {
                RadioButton rb1 = (RadioButton)ri.FindControl("RadOption1");
                Label labcorrectans = (Label)ri.FindControl("LaBCorrentAns");
                labcorrectans.Visible = true;

                if (rb1.Checked == true)
                {
                    if (rb1.Text.Equals(labcorrectans.Text))
                    {
                        Label UserSlectedans = (Label)ri.FindControl("LabUserSelectedOption");

                        UserSlectedans.Text = "The Selected Answer is <b>" + rb1.Text.ToString() + " Correct </b>";
                        UserSlectedans.ForeColor = System.Drawing.Color.Green;
                        count++;
                    }
                    else
                    {
                        Label WrongAnswe = (Label)ri.FindControl("LabUserSelectedOption");

                        WrongAnswe.Text = "The Selected Answer is <b>" + rb1.Text.ToString() + "</b> Is Wrong";
                        WrongAnswe.ForeColor = System.Drawing.Color.Red;
                        
                    }
                }
            }
            foreach (RepeaterItem ri in Repeater1.Items)
            {
                RadioButton rb1 = (RadioButton)ri.FindControl("RadOption2");
                Label labcorrectans = (Label)ri.FindControl("LaBCorrentAns");
                labcorrectans.Visible = true;

                if (rb1.Checked == true)
                {
                    if (rb1.Text.Equals(labcorrectans.Text))
                    {
                        Label UserSlectedans = (Label)ri.FindControl("LabUserSelectedOption");

                        UserSlectedans.Text = "The Selected Answer is <b>" + rb1.Text.ToString() + " Correct </b>";
                        UserSlectedans.ForeColor = System.Drawing.Color.Green;
                        count++;
                    }
                    else
                    {
                        Label WrongAnswe = (Label)ri.FindControl("LabUserSelectedOption");

                        WrongAnswe.Text = "The Selected Answer is <b>" + rb1.Text.ToString() + "</b> Is Wrong";
                        WrongAnswe.ForeColor = System.Drawing.Color.Red;

                    }
                }
            }

            foreach (RepeaterItem ri in Repeater2.Items)
            {
                TextBox rb2 = (TextBox)ri.FindControl("Txtb1");
                Label labcorrectans = (Label)ri.FindControl("LaBCorrentAns2");
                labcorrectans.Visible = true;

                if (rb2.Text !=null)
                {
                    if (rb2.Text.Equals(labcorrectans.Text))
                    {
                        Label UserSlectedans = (Label)ri.FindControl("LabUserSelectedOption2");

                        UserSlectedans.Text = "The Selected Answer is <b>" + rb2.Text.ToString() + " Correct </b>";
                        UserSlectedans.ForeColor = System.Drawing.Color.Green;
                        count++;
                    }
                    else
                    {
                        Label WrongAnswe = (Label)ri.FindControl("LabUserSelectedOption2");

                        WrongAnswe.Text = "The Selected Answer is <b>" + rb2.Text.ToString() + "</b> Is Wrong";
                        WrongAnswe.ForeColor = System.Drawing.Color.Red;
                       
                    }
                }
            }

            foreach (RepeaterItem ri in Repeater3.Items)
            {
                TextBox rb3 = (TextBox)ri.FindControl("Txtb2");
                
                Label labcorrectans = (Label)ri.FindControl("LaBCorrentAns3");
                labcorrectans.Visible = true;

                if (rb3.Text != null)
                {
                    string UCstring = rb3.Text.ToUpper().Trim();
              
                    if (UCstring.Equals(labcorrectans.Text))
                    {
                        Label UserSlectedans = (Label)ri.FindControl("LabUserSelectedOption3");

                        UserSlectedans.Text = "The Selected Answer  is <b>" + rb3.Text.ToString() + " Correct </b>";
                        UserSlectedans.ForeColor = System.Drawing.Color.Green;
                        count++;

                    }
                    else
                    {
                        Label WrongAnswe = (Label)ri.FindControl("LabUserSelectedOption3");

                        WrongAnswe.Text = "The Selected Answer is <b>" + rb3.Text.ToString() + "</b> Is Wrong";
                        WrongAnswe.ForeColor = System.Drawing.Color.Red;
                    }
                }
                
            }
            //string Ans1 = count.ToString();
            //Label Ans = (Label)FindControl("ScoreID");
            ScoreID.Text = "You Scored <b>" + count + "</b>";
        }
       
    }
}