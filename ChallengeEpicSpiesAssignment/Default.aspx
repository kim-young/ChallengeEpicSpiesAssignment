<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Spy New Assignment Form</h1>
            <br />
            Spy Code Name: <asp:TextBox ID="SpyNameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            New Assignment Name: <asp:TextBox ID="NewAssignmentTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            End Date of Previous Assignment<br />
            <asp:Calendar ID="PreviousEndDateCalendar" runat="server"></asp:Calendar>
            <br />
            Start Date of New Assignment<br />
            <asp:Calendar ID="StartDateCalendar" runat="server"></asp:Calendar>
            <br />
            Projected End Date of New Assignment<br />
            <asp:Calendar ID="EndDateCalendar" runat="server"></asp:Calendar>
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Generate" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
