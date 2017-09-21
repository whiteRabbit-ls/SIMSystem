<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ManagerS.aspx.cs" Inherits="SIMSystem.ManagerS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
请输入学号<br />
    <asp:TextBox ID="GetXuehaoS" runat="server"></asp:TextBox>
    <asp:Button ID="Queren"
        runat="server" Text="查看" onclick="Queren_Click" />
    <asp:Button ID="Xiugai" runat="server"
            Text="修改" onclick="Xiugai_Click" /><asp:Button ID="Shanchu" 
        runat="server" Text="删除" onclick="Shanchu_Click" /><asp:Label ID="Shanchujieguo" runat="server"
            Text=""></asp:Label>
    <br />
<asp:Label ID="Yichang" runat="server" Text=""></asp:Label>
</asp:Content>
