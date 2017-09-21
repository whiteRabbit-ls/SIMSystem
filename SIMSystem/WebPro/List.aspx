<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="List.aspx.cs" Inherits="SIMSystem.List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
        
            <tr>
            <td>学号</td><td>姓名</td><td>班级</td><td>操作</td><td>操作</td></tr>
            <asp:Repeater ID="Liebiao" runat="server">
            <ItemTemplate>
                <tr>
                    <td>
                        <%#Eval("id") %>
                    </td>
                    <td>
                       <%#Eval("name") %>
                    </td>
                    <td>
                        <%#Eval("classes") %>
                    </td>
                    <td>
                    <a href="StrInforShow.aspx?id=<%#Eval("id") %>" class="red">查看</a>
                    </td>
                    <td>
                    <a href="ManagerR.aspx?id=<%#Eval("id") %>" class="red">修改</a>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</asp:Content>
