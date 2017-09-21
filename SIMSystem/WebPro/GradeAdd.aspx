<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="GradeAdd.aspx.cs" Inherits="SIMSystem.addgrade" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style6
        {
            width: 81px;
        }
        .style7
        {
            width: 81px;
            height: 23px;
        }
        .style8
        {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div>
         添加成绩：<br />
        <table align="left" style="width: 50%;">
            <tr>
                <td align="center" class="style7">
                    学号：</td>
                <td align="left" class="style8">
                    <asp:TextBox ID="TextBox2" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center" class="style7">
        课程号：</td>
                <td align="left" class="style8">
                    <asp:DropDownList ID="DropDownList1" runat="server" >
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td align="center" class="style6">
                    课程名：</td>
                <td align="left">
                    <asp:Label ID="Label3" runat="server">#课程名</asp:Label>
                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="刷新" />
                </td>
            </tr>
            <tr>
                <td align="center" class="style6">
                    成绩：</td>
                <td align="left">
                    <asp:TextBox ID="TextBox1" runat="server" Width="107px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="确认" />
                </td>
            </tr>
        </table>
   </div>
</asp:Content>
