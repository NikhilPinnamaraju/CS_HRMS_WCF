using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFwebclient.ServiceReference1;

namespace WCFwebclient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                EmpserviceClient proxy = new EmpserviceClient();
                var emplst = proxy.GetEmployees();
                GridView1.DataSource = emplst;
                GridView1.DataBind();
            }
        }

        

        protected void btnadd_Click(object sender, EventArgs e)
        {
            employee emp = new employee
            {
                ecode = int.Parse(txtecode.Text),
                ename = txtename.Text,
                salary = int.Parse(txtsalary.Text),
                deptid = int.Parse(txtdeptid.Text)

            };

            EmpserviceClient proxy = new EmpserviceClient();
            proxy.addfield(emp);

            var emplst = proxy.GetEmployees();
            GridView1.DataSource = emplst;
            GridView1.DataBind();
            Label1.Text = "record added";
        }

        protected void btndel_Click(object sender, EventArgs e)
        {
            
                int ecode = int.Parse(txtecode.Text);
                EmpserviceClient proxy = new EmpserviceClient();
                proxy.DeleteEmpById(ecode);
                Label1.Text = "record deleted";
                var emplst = proxy.GetEmployees();
                GridView1.DataSource = emplst;
                GridView1.DataBind();
          
           
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            employee emp = new employee
            {
                ecode = int.Parse(txtecode.Text),
                ename = txtename.Text,
                salary = int.Parse(txtsalary.Text),
                deptid = int.Parse(txtdeptid.Text)

            };

            EmpserviceClient proxy = new EmpserviceClient();
            proxy.UpdateEmpById(emp);
            Label1.Text = "record updated";
            var emplst = proxy.GetEmployees();
            GridView1.DataSource = emplst;
            GridView1.DataBind();
        }

        protected void btnfid_Click(object sender, EventArgs e)
        {
            int ecode = int.Parse(txtecode.Text);

            EmpserviceClient proxy = new EmpserviceClient();
           employee record= proxy.GetEmpById(ecode);
            txtename.Text = record.ename;
            txtsalary.Text = (record.salary).ToString();
            txtdeptid.Text = (record.deptid).ToString();
            
        }
    }
}