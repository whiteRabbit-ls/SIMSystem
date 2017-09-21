<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="AdminList_guest.aspx.cs" Inherits="SIMSystem.WebPro.AdminList_guest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
        <tr>
            <td class="style6">
                用户ID:</td>
            <td class="style7">
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                密码：</td>
            <td class="style7">
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBox2" ErrorMessage="密码不能为空！" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style6">
                请再次输入密码:</td>
            <td class="style7">
                <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="TextBox2" ControlToValidate="TextBox3" 
                    ErrorMessage="两次输入的密码不一致！" ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td align="center" class="style6" colspan="3">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="提交" />
            </td>
        </tr>
    </table>
</asp:Content>
