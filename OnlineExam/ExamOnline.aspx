<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExamOnline.aspx.cs" Inherits="OnlineExam.ExamOnline" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Please select the correct answer below "></asp:Label>
            <center>
                <asp:Label ID="ScoreID" runat="server" Text=""></asp:Label>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <table>
                            <tr>
                                <td><%#Eval("Qid") %> : <%#Eval("Question") %> </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:RadioButton ID="RadOption1" Text='<%#Eval("Option1") %>' runat="server" GroupName="rdexam"></asp:RadioButton>
                                    <asp:RadioButton ID="RadOption2" Text='<%#Eval("Option2") %>' runat="server" GroupName="rdexam"></asp:RadioButton>
                                <br />
                                    <asp:Label ID="LaBCorrentAns" runat="server" Text='<%#Eval("CorrectAnswer") %>' Visible="false"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="LabUserSelectedOption" runat="server" Text=""></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:Repeater>
                <br />
               <p> Please provide the correct Answer </p>
                <asp:Repeater ID="Repeater2" runat="server">
                    <ItemTemplate>
                        <table>
                            <tr>
                                <td><%#Eval("Qid") %> : <%#Eval("Question") %> </td>
                            </tr>
                            <tr>
                                <td>
                                   <asp:TextBox ID="Txtb1" runat="server" ></asp:TextBox>
                                    <asp:Label ID="LaBCorrentAns2" runat="server" Text='<%#Eval("Answer") %>' Visible="false"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="LabUserSelectedOption2" runat="server" Text=""></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:Repeater>
                 <br />
                <br />
                <asp:Repeater ID="Repeater3" runat="server">
                    <ItemTemplate>
                        <table>
                            <tr>
                                <td><%#Eval("Qid") %> : <%#Eval("Question") %> </td>
                            </tr>
                            <tr>
                                <td>
                                   <asp:TextBox ID="Txtb2" runat="server" ></asp:TextBox>
                                    <asp:Label ID="LaBCorrentAns3" runat="server" Text='<%#Eval("Answer") %>' Visible="false"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="LabUserSelectedOption3" runat="server" Text=""></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <td>
                                    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                                </td>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:Repeater>
                <asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click"></asp:Button>
            </center>
        </div>
    </form>
</body>
</html>
