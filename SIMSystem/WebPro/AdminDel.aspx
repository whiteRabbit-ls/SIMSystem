<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminDel.aspx.cs" Inherits="SIMSystem.WebPro.AdminDel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div>
        用户ID：<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br /><br />
        权限：<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br /><br />
        <asp:Label ID="Label3" runat="server" Text="你确定要删除该用户吗"></asp:Label>
        <br /><br />
        <asp:Button ID="Button1" runat="server" Text="删除" onclick="Button1_Click" />
        &nbsp;
        <asp:Button ID="Button2" runat="server" Text="取消" onclick="Button2_Click" 
            style="height: 21px" />

    </div>
</asp:Content>
