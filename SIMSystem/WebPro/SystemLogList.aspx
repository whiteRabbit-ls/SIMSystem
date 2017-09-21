<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SystemLogList.aspx.cs" Inherits="SIMSystem.WebPro.SystemLogList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
        .auto-style1 {
        height: 20px;
    }
    .auto-style2 {
        width: 147%;
        height: 67px;
    }
    .auto-style3 {
        height: 20px;
        width: 44px;
    }
    .auto-style4 {
        width: 44px;
    }
    .auto-style5 {
        height: 20px;
        width: 59px;
    }
    .auto-style6 {
        width: 59px;
    }
    .auto-style7 {
        height: 20px;
        width: 73px;
    }
    .auto-style8 {
        width: 73px;
    }
    .auto-style9 {
        height: 20px;
        width: 77px;
    }
    .auto-style10 {
        width: 77px;
    }
    .auto-style11 {
        height: 20px;
        width: 70px;
    }
    .auto-style12 {
        width: 70px;
    }
    .auto-style13 {
        height: 20px;
        width: 48px;
    }
    .auto-style14 {
        width: 48px;
    }
    .auto-style15 {
        font-size: xx-large;
    }
    .auto-style16 {
        font-size: large;
    }
    .auto-style17 {
        width: 146%;
        height: 77px;
    }
    .auto-style18 {
        height: 87px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<span class="auto-style15">日志系统<br />
       <br />
       </span>
       <span class="auto-style16">日志总量：<asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <br />
       <br />
    </div>
    <table class="auto-style17">
        <tr>
            <td height="50">
                日期：<asp:TextBox ID="TextBox1" runat="server" Width="47px"></asp:TextBox>
                -<asp:TextBox ID="TextBox2" runat="server" Width="49px"></asp:TextBox>
&nbsp;&nbsp; 关键字：<asp:TextBox ID="TextBox3" runat="server" Width="90px"></asp:TextBox>
&nbsp;&nbsp;&nbsp; 每页：<asp:TextBox ID="TextBox4" runat="server" Width="69px"></asp:TextBox>
&nbsp;&nbsp;<br />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <asp:Button ID="Button1" runat="server" Text="查询" />
&nbsp;<asp:Button ID="Button2" runat="server" Text="下载" />
            </td>
        </tr>
       </span><br />
      
       

       <table border="1" class="auto-style2">
           <tr>
               <td align="center" class="auto-style3">LogID</td>
               <td align="center" class="auto-style5">Operator</td>
               <td align="center" class="auto-style7">DateTime</td>
               <td align="center" class="auto-style9">IPAdd</td>
               <td align="center" class="auto-style11">Activity</td>
               <td align="center" class="auto-style13">Status</td>
               <td align="center" class="auto-style1">DetailInfo</td>
           </tr>
           <asp:Repeater ID="Repeater_SystemLog" runat="server">
           <ItemTemplate>
           <tr>
               <td align="center" class="auto-style3"><%#Eval("LogID") %></td>
               <td align="center" class="auto-style5"><%#Eval("Operator") %></td>
               <td align="center" class="auto-style7"><%#Eval("DateTime")%></td>
               <td align="center" class="auto-style9"><%#Eval("IPAdd") %></td>
               <td align="center" class="auto-style11"><%#Eval("Activity")%></td>
               <td align="center" class="auto-style13"><%#Eval("Status") %></td>
               <td align="center" class="auto-style1"><%#Eval("DetailInfo")%></td>

           </tr>

           </ItemTemplate>
           </asp:Repeater>

       </table>
       <br />

       </div>
</asp:Content>
