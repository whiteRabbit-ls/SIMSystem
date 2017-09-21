<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="GradeList_guest.aspx.cs" Inherits="SIMSystem.WebPro.GradeList_guest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
    .style6
    {
            width: 112px;
        }
    .style7
    {
            width: 181px;
        }
        .style8
        {
            width: 102px;
        }
        .style9
        {
            width: 81px;
        }
        .style10
        {
            width: 79px;
        }
        .style11
        {
            width: 149px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table border="1" style="width: 80%;">
    <tr>
        <td align="center" class="style9">
            SID</td>
        <td align="center" class="style9">
            课程号</td>
        <td align="center" class="style7">
            课程名</td>
        <td align="center" class="style10">
            成绩</td>
    </tr>
        <asp:Repeater ID="Repeater_StuScore" runat="server">
        <ItemTemplate>
        <tr>
        <td align="center" class="style9">
            <%#Eval("Sid") %></td>
        <td align="center" class="style6">
            <%#Eval("Cid") %></td>
        <td align="center" class="style7">
            <%#Eval("Cname") %></td>
        <td align="center" class="style8">
            <%#Eval("Scores") %></td>
    </tr>
        </ItemTemplate>
        </asp:Repeater>
    </table>
</asp:Content>
