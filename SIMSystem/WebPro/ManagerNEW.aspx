<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ManagerNEW.aspx.cs" Inherits="SIMSystem.ManagerNEW" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center"><tr><td colspan ="3"><font size="4" face = "微软雅黑">请填写表中信息，带*的为必填项</font></td></tr>
    <tr><td>姓名：</td><td><asp:TextBox ID="Xingming" runat="server"></asp:TextBox>*</td><td>
        <asp:Label ID="YanzhengXingming" runat="server" Text=""></asp:Label>
        </td></tr>
    <tr><td>性别：</td><td><asp:TextBox ID="Xingbie" runat="server"></asp:TextBox></td></tr>
    <tr><td>身份证号：</td><td><asp:TextBox ID="Shenfenzhenghao" runat="server"></asp:TextBox>*</td><td>
        <asp:Label ID="YanzhengPIN" runat="server" Text=""></asp:Label>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="Shenfenzhenghao" ErrorMessage="请输入合法的身份证号" 
            ValidationExpression="\d{17}[\d|X]|\d{15}"></asp:RegularExpressionValidator>
        </td></tr>
    <tr><td>照片：</td><td colspan="1">
        <asp:FileUpload ID="Picture" runat="server" /></td><td>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label></td></tr>
    <tr><td>年级：</td><td><asp:TextBox ID="grade" runat="server"></asp:TextBox></td></tr>
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
    <tr><td>学号：</td><td>
        <asp:TextBox ID="Xuehao" runat="server"></asp:TextBox>
        *</td><td><asp:Button ID="NewXuehao" runat="server" Text="合法性检测" 
                onclick="NewXuehao_Click" /><asp:Label ID="HeFa" runat="server"
                Text=""></asp:Label></td></tr>
    <tr><td>入学日期：</td><td>
        <asp:DropDownList ID="Nian1" runat="server" AutoPostBack="True" 
            onselectedindexchanged="Nian1_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:DropDownList ID="Yue1" runat="server" AutoPostBack="True" 
            onselectedindexchanged="Yue1_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:DropDownList ID="Ri1" runat="server">
        </asp:DropDownList>
        </td><td>
        <asp:Button ID="Today" runat="server" Text="刷新" /></td></tr>
    <tr><td>政治面貌：</td><td>
        <asp:TextBox ID="Zhengzhi" runat="server"></asp:TextBox></td><td></td></tr>
    <tr><td>通讯地址：</td><td><asp:TextBox ID="Dizhi" runat="server"></asp:TextBox></td></tr>
    <tr><td>邮政编码：</td><td><asp:TextBox ID="YouBian" runat="server"></asp:TextBox></td></tr>
    <tr><td>备注：</td><td>
        <asp:TextBox ID="Beizhu" runat="server" TextMode="MultiLine"></asp:TextBox></td><td></td></tr>
    <tr><td colspan="3" align ="center">
        <asp:Button ID="Zhuce" runat="server" Text="注册" onclick="Zhuce_Click" /></td></tr>
    <tr><td>
        <asp:Label ID="YiChang" runat="server"></asp:Label></td></tr>
    </table>
</asp:Content>
