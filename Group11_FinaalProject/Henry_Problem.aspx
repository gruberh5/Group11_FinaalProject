<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Henry_Problem.aspx.cs" Inherits="Group11_FinaalProject.Henry_Problem" %>
<!--Name: Henry Gruber
 email: gruberhw@mail.uc.edu
 Assignment Title: Final Project
 Due Date: 4/22/2024
 Course: IS 3050
 Semester/Year: Spring 
Brief Description: This project displays our use of github, ASPX and C#
 Citations: ChatGPT
 Anything else that's relevant: StackOverFlow -->
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <strong>LeetCode Hard:</strong> Number of Visible People in a Queue/Line<br />
            <br />
            <strong>Problem Description</strong>: There are n people standing in a queue, and they are numbered from 0 to n-1 in left
            <br />
            to right order. You are given an array of heights of distinct integeres where heights[i] represents the height of the i person.<br />
            <br />
            A person can see another person to their right in the queue if everybody in between is shorter than both of them.<br />
            <br />
            <strong>Test Case Exampl</strong>:<br />
            <br />
            Person 0 height: <strong>10</strong><br />
            Person 1 height: <strong>6</strong><br />
            Person 2 height: <strong>8</strong><br />
            Person 3 height: <strong>5</strong><br />
            Person 4 height: <strong>11</strong><br />
            Person 5 height: <strong>9</strong><br />
            

            <br />  

         <asp:Label ID="lblOutput" runat="server" Text="Enter heights of persons in line:"></asp:Label>
            <asp:TextBox ID="txtHeights" runat="server"></asp:TextBox>
            &nbsp;<br />
            <br />
            <br />
         <asp:Button ID="cmdGenerate" runat="server" Text="Generate" OnClick="cmdGenerate_Click" />

            <br />

            <br />
            <br />
            <strong>Explanation</strong>:
            <br />
            Person 0 can see persons 1, 2, and 4.<br />
            Person 1 can see person 2.<br />
            Person 2 can see person 3 and 4.<br />
            Person 3 can see person 4.<br />
            Person 4 can see person 5.<br />
            Person 5 can see no one since no one is to their right.</div>
    </form>
</body>
</html>
