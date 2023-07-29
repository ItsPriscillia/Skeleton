using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();
        string Firstname = txtFirstname.Text;
        string Lastname = txtLastname.Text;
        string Email = txtEmail.Text;
        string DOB = txtDOB.Text;
        string Postcode = txtPostcode.Text;
        string Error = "";
        Error = AnCustomer.Valid(Firstname, Lastname, Email, DOB, Postcode);
        if (Error == "")
        {
            AnCustomer.Firstname = Firstname;
            AnCustomer.Lastname = Lastname;
            AnCustomer.Email = Email;
            AnCustomer.DOB = Convert.ToDateTime(DOB);
            AnCustomer.Postcode = Postcode;
            AnCustomer.Active = chkActive.Checked;

            clsCustomerCollection CustomerList = new clsCustomerCollection();
            CustomerList.ThisCustomer = AnCustomer;
            CustomerList.Add();
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();
        Int32 CustomerID;
        Boolean Found = false;
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        Found = AnCustomer.Find(CustomerID);
        if(Found==true)
        {
            txtFirstname.Text = AnCustomer.Firstname;
            txtLastname.Text = AnCustomer.Lastname;
            txtEmail.Text = AnCustomer.Email;
            txtPostcode.Text = AnCustomer.Postcode;
            txtDOB.Text = AnCustomer.DOB.ToString();
            chkActive.Checked = AnCustomer.Active;
        }
    }
}
