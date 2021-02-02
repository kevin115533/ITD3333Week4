<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            A:
            <asp:TextBox ID="txtBoxA" runat="server"></asp:TextBox><br />
            B:
            <asp:TextBox ID="txtBoxB" runat="server"></asp:TextBox><br />
            <br />
            <asp:Button ID="btnDivide" runat="server" OnClick="cmdCompute_Click" Text="Divide A / B" />
            <br />
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
