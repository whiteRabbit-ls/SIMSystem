<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminAdd.aspx.cs" Inherits="SIMSystem.WebPro.AdminAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
        .style1
        {
        }
        .style2
        {
            height: 20px;
        width: 272px;
    }
        .style3
        {
            width: 124px;
        }
        .style4
        {
            height: 20px;
            width: 124px;
        }
        .style5
        {
            width: 151px;
        }
        .style6
        {
            height: 20px;
            width: 151px;
        }
    .style7
    {
        width: 272px;
    }
    .style8
    {
        width: 293px;
        height: 27px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
        <table style="weight: 100%;">
            <tr>
                <td align="left" class="style8">
                    用户名：</td>
                <td align="left" class="style5">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td align="left" class="style7">
                    <asp:RequiredFieldValidator
            ID="RequiredFieldValidator3" runat="server" ErrorMessage="用户ID不能为空！" 
            ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="left" class="style8">
                    密 码 ：</td>
                <td align="left" class="style6">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td align="left" class="style2">
                    <asp:RequiredFieldValidator
            ID="RequiredFieldValidator4" runat="server" ErrorMessage="密码不能为空！" 
            ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="left" class="style8">
        请再次输入密码:</td>
                <td align="left" class="style5">
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td align="left" class="style7">
                    <asp:CompareValidator
            ID="CompareValidator2" runat="server" ErrorMessage="两次输入的密码不一致！" 
            ControlToCompare="TextBox2" ControlToValidate="TextBox3" ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td align="center" class="style1" colspan="3">
        <asp:Button ID="Button1" runat="server" Text="提交" onclick="Button1_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
