using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void cmdCompute_Click(Object sender, EventArgs e)
    {
        try {
            decimal a, b, result;
            a = decimal.Parse(txtBoxA.Text);
            b = decimal.Parse(txtBoxB.Text);
            result = a / b;
            lblResult.Text = result.ToString();
            lblResult.ForeColor = System.Drawing.Color.Black; 
        }  
        catch(Exception err)
        {
            lblResult.Text = "<b>Message:</b> " + err.Message;
            lblResult.Text += "<br></br> ";
            lblResult.Text += "<b>Source:</b> " + err.Source;
            lblResult.Text += "<br></br> ";
            lblResult.Text += "<b>Stack Trace:</b> " + err.StackTrace;
            lblResult.ForeColor = System.Drawing.Color.Red;
        }
    }
    
}