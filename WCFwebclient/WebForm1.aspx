<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WCFwebclient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        <br />
    </p>
    <form id="form1" runat="server">
        <p>
            enter ecode :&nbsp;
            <asp:TextBox ID="txtecode" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnfid" runat="server" OnClick="btnfid_Click" Text="FIND BY ID" />
        </p>
        <p>
            enter ename:&nbsp; <asp:TextBox ID="txtename" runat="server"></asp:TextBox>
        </p>
        <p>
            enter salary:&nbsp;&nbsp;
            <asp:TextBox ID="txtsalary" runat="server"></asp:TextBox>
        </p>
        <p>
            enter deptid:&nbsp;
            <asp:TextBox ID="txtdeptid" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnadd" runat="server" OnClick="btnadd_Click" Text="ADD" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btndel" runat="server" OnClick="btndel_Click" Text="DELETE" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnupdate" runat="server" OnClick="btnupdate_Click" style="height: 35px" Text="UPDATE" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="lblmsg"></asp:Label>
        </p>
        <div>
        </div>
    </form>
</body>
</html>
