<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NumericQuestions.aspx.cs" Inherits="OnlineExam.NumericQuestions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <asp:Repeater ID="Repeater1" runat="server">
                     <ItemTemplate>
                         <asp:Label ID="Label1" runat="server" Text='<%#Eval("Option1") %>'></asp:Label>
                     </ItemTemplate>
                </asp:Repeater>
            </center>
        </div>
    </form>
</body>
</html>
