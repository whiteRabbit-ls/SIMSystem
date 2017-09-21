<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ManagerR.aspx.cs" Inherits="SIMSystem.SIMSystem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table align="center"><tr><td colspan ="3"><font size="4" face = "微软雅黑">请在右侧输入修改后的信息，不需要修改的项空过即可</font></td></tr>
    <tr><td>学号：</td><td><asp:Label ID="Xuehao" runat="server" Text=""></asp:Label></td><td>
        学号不可修改</td></tr>
    <tr><td>姓名：</td><td><asp:TextBox ID="Xingming" runat="server"></asp:TextBox></td><td></td></tr>
    <tr><td>身份证号：</td><td><asp:Label ID="Shenfenzhenghao" runat="server"></asp:Label></td><td>
        身份证号不可修改
        </td></tr>
    <tr><td>照片：</td><td colspan="1">
        <asp:FileUpload ID="Picture" runat="server" /></td><td>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label></td></tr>
    <tr><td>年级：</td><td><asp:TextBox ID="GradeNew" runat="server" 
            ontextchanged="GradeNew_TextChanged"></asp:TextBox></td><td></td></tr>
    <tr><td>院系：</td><td>
        <asp:TextBox ID="Xueyuan" runat="server"></asp:TextBox>
    </td><td></td></tr>
    <tr><td>专业：</td><td>
        <asp:TextBox ID="Zhuanye" runat="server"></asp:TextBox>
    </td><td>
            &nbsp;</td></tr>
    <tr><td>班级：</td><td>
        <asp:TextBox ID="Banji" runat="server"></asp:TextBox>
    </td><td>
            &nbsp;</td></tr>
    <tr><td>入学日期：</td><td><asp:TextBox ID="Ruxueriqi" runat="server"></asp:TextBox></td><td>
        </td></tr>
    <tr><td>政治面貌：</td><td>
        <asp:TextBox ID="Zhengzhi" runat="server"></asp:TextBox></td><td></td></tr>
    <tr><td>备注：</td><td>
        <asp:TextBox ID="Beizhu" runat="server" TextMode="MultiLine"></asp:TextBox></td><td></td></tr>
    <tr><td colspan="3" align ="center">
        <asp:Button ID="Baocun" runat="server" Text="保存" onclick="Zhuce_Click" /></td></tr>
    <tr><td>
    <asp:Label ID="Yichang" runat="server" Text=""></asp:Label></td></tr>
    </table>
</asp:Content>
