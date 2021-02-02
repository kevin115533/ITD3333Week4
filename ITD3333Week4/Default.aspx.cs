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
    private void DivideNumbers()
    {
        decimal numerator = decimal.Parse(txtBoxA.Text);
        decimal divisor = decimal.Parse(txtBoxB.Text);
        decimal result;
        try
        {
            result = numerator / divisor;
            lblResult.Text = result.ToString();
            lblResult.ForeColor = System.Drawing.Color.Black;
        }
        catch (DivideByZeroException)
        {
            DivideByZeroException KevinTranException = new DivideByZeroException("ITD1333-1940: Divide by Zero");
            lblResult.Text = "Student Name: Kevin Tran<br></br>";
            lblResult.Text += KevinTranException.Message;
            lblResult.ForeColor = System.Drawing.Color.Red;
        }
    }
    protected void cmdCompute_Click(Object sender, EventArgs e)
    {
        DivideNumbers();
    }

}