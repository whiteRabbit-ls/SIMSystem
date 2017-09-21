<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SIMSystem.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 65px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%;">
            <tr>
                <td class="style1">
                    用户名：
                </td>
                <td>
                    <asp:TextBox ID="TID" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style1">
                    密码：
                </td>
                <td>
                    <asp:TextBox ID="TPwd" runat="server" TextMode="Password"> </asp:TextBox>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style1">
                   身份：
                </td>
                <td>
                    <asp:RadioButtonList ID="Type" runat="server" 
                        RepeatDirection="Horizontal">
                       <asp:ListItem Value="1">管理员</asp:ListItem>
                       <asp:ListItem Value="2">学生</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style1">
                </td>
                <td>
                   <asp:Button ID="Submit" runat="server" Text="登录" onclick="Submit_Click" 
                        style="margin-bottom: 0px" />
                </td>
                <td>                                                                   
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
