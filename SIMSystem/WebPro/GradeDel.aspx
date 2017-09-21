<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="GradeDel.aspx.cs" Inherits="SIMSystem.WebPro.GradeDel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style6
        {
            width: 82px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    删除成绩：<br />
    <table align="left" style="width: 51%;">
        <tr>
            <td align="center" class="style6">
        课程号：</td>
            <td align="left">
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center" class="style6">
                课程名：</td>
            <td align="left">
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center" class="style6">
                成绩：</td>
            <td align="left">
                <asp:Label ID="Label5" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="删除" />
            </td>
        </tr>
    </table>
    </div>
</asp:Content>
