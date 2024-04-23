<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Danny_Problem.aspx.cs" Inherits="Group11_FinaalProject.Danny_Problem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h2>Roman to Integer Converter</h2>
            <asp:TextBox ID="RomanTextBox" runat="server"></asp:TextBox><br />
            <asp:Button ID="ConvertButton" runat="server" Text="Convert" OnClick="ConvertButton_Click" /><br />
            <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
