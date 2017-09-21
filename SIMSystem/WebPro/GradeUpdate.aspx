<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="GradeUpdate.aspx.cs" Inherits="SIMSystem.Update_Grade" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style6
        {
            width: 80px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div>
    修改成绩：<br />
        <table align="left" style="width: 50%;">
            <tr>
                <td align="center" class="style6">
        课程号：</td>
                <td align="left">
                    <asp:Label ID="Label5" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center" class="style6">
                    课程名：</td>
                <td align="left">
                    <asp:Label ID="Label6" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center" class="style6">
                    成绩：</td>
                <td align="left">
                    <asp:TextBox ID="TextBox1" runat="server" Width="95px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="提交" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
