<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Greyson_Problem.aspx.cs" Inherits="Group11_FinaalProject.Greyson_Problem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Count and Say</title>
</head>
<body>
    <div>
        The count-and-say sequence is a sequence of digit strings defined by the recursive formula:
    </div>
    <div>
        To determine how you "say" a digit string, split it into the minimal number of substrings such that each substring contains exactly one unique digit. Then for each substring, say the number of digits, then say the digit. Finally, concatenate every said digit.
    </div>
    <div inert-attribute-added-by-wlp="true" inert="">&nbsp;</div>
    <div></div>
    <div inert-attribute-added-by-wlp="true" inert="">&nbsp;</div>
    <div>
        Input: n = 4 
        Test Case:
    <br />
        Output: "1211"<br />
        Explanation:<br />
        countAndSay(1) = "1"<br />
        countAndSay(2) = say "1" = one 1 = "11"<br />
        countAndSay(3) = say "11" = two 1's = "21"<br />
        countAndSay(4) = say "21" = one 2 + one 1 = "12" + "11" = "1211"
 
    </div>
    <form id="form1" runat="server">
        <div>
           <h2>Count And Say</h2>
            <asp:Label ID="lblInput" runat="server" Text="Enter value of 'n':"></asp:Label>
            <asp:TextBox ID="txtN" runat="server"></asp:TextBox>
            <asp:Button ID="btnGenerate" runat="server" Text="Generate" OnClick="btnGenerate_Click" />
            <br />
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
