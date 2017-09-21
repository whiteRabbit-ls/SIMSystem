<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminList.aspx.cs" Inherits="SIMSystem.WebPro.AdminList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
        .style1
        {
            width: 196px;
        }
        .style2
        {
            width: 106px;
        }
        .style3
        {
            width: 214px;
        }
    .style8
    {
        width: 106px;
        height: 27px;
    }
    .style9
    {
        width: 95px;
    }
    .style10
    {
        width: 94px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
        <table style="width: 100%; margin-right: 41px;">
            <tr>
                <td class="style9">
                    用户ID
                </td>
                <td class="style10">
                    密码
                </td>
                <td class="style8">
                    权限
                </td>
                <td>
                    操作
                </td>
            </tr>
            <asp:Repeater ID = "Repeater_AdmInfo" runat = "server">
            <ItemTemplate>
            <tr>
                <td class="style1">
                    <%#Eval("ID") %>
                </td>
                <td>
                    <%#Eval("Password") %>
                </td>
                <td class="style2">
                    <%#Eval("Privilege") %>
                </td>
                <td>
                    <a style = "margin-right:20px;" href="AdminEdit.aspx?id=<%#Eval("ID") %>">编辑</a>
                    <a href="AdminDel.aspx?id=<%#Eval("ID") %>">删除</a>
                </td>
            </tr>
            </ItemTemplate>
            </asp:Repeater>
            
        </table>
        <asp:Button ID="Button3" runat="server" Text="添加" onclick="Button3_Click" />
    </div>
</asp:Content>
