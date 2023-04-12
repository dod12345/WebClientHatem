using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClientHatem
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            WebClientHatem.WCFHatem.Employee employee = new WebClientHatem.WCFHatem.Employee();
            employee.Id = Convert.ToInt32(txtID.Text);
            employee.Name = txtName.Text;
            employee.Gender = txtGender.Text;
            employee.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);

            WebClientHatem.WCFHatem.WCFHatemClient client = new
                WebClientHatem.WCFHatem.WCFHatemClient();
            client.SaveEmployee(employee);

            lblMessage.Text = "Employee saved";
        }

        protected void btnGetEmployee_Click(object sender, EventArgs e)
        {
            WebClientHatem.WCFHatem.WCFHatemClient client = new
                WebClientHatem.WCFHatem.WCFHatemClient();

            WebClientHatem.WCFHatem.Employee employee =
                client.GetEmployee(Convert.ToInt32(txtID.Text));

            txtName.Text = employee.Name;
            txtGender.Text = employee.Gender;
            txtDateOfBirth.Text = employee.DateOfBirth.ToShortDateString();

            lblMessage.Text = "Employee retrieved";
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            WebClientHatem.WCFHatem.WCFHatemClient client = new
                WebClientHatem.WCFHatem.WCFHatemClient();
            int idTry = Convert.ToInt32(txtID.Text);
            //WebApplication1.EmployeeService.Employee employee = client.DeleteEmployee(idTry);
            client.DeleteEmployee(idTry);
            /*txtName.Text = employee.Name;
            txtGender.Text = employee.Gender;
            txtDateOfBirth.Text = employee.DateOfBirth.ToShortDateString();*/

            lblMessage.Text = "Employee Deleted";
        }

        protected void Inner_Click(object sender, EventArgs e)
        {
            WebClientHatem.WCFHatem.WCFHatemClient client = new
                WebClientHatem.WCFHatem.WCFHatemClient();

            client.Stam();
            lblMessage.Text = "YUP YOU INNER JOINED";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WebClientHatem.WCFHatem.WCFHatemClient client = new
                WebClientHatem.WCFHatem.WCFHatemClient();


            client.JsonWow();
            lblMessage.Text = "YUP YOU JSONEDITUP";

        }
    }
}