<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="StuInforShow.aspx.cs" Inherits="SIMSystem.StuInforShow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center">
    <tr><td><table>
    <tr><td colspan="4"><font size="3" face="微软雅黑">基本信息：</font> </td></tr>
    <tr><td align= "right"><font size="2" face="黑体"><b>学号：</b></font></td><td>
        <asp:Label ID="Idxuehao" runat="server" Text="<空>"></asp:Label>
        </td><td align= "right"><font size="2" face="黑体"><b>姓名：</b></font></td><td>
        <asp:Label ID="Xingming" runat="server" Text="<空>"></asp:Label>
        </td></tr>
    <tr><td align= "right"><font size="2" face="黑体"><b>性别：</b></font></td><td>
        <asp:Label ID="Xingbie" runat="server" Text="<空>"></asp:Label>
        </td><td align= "right"><font size="2" face="黑体"><b>身份证号：</b></font></td><td>
        <asp:Label ID="Shenfenzhenghao" runat="server" Text="<空>"></asp:Label>
        </td></tr>
    <tr><td align= "right"><font size="2" face="黑体"><b>出生年月：</b></font></td><td>
        <asp:Label ID="Shengri" runat="server" Text="<空>"></asp:Label>
        </td><td align= "right"><font size="2" face="黑体"><b>政治面貌：</b></font></td><td>
        <asp:Label ID="Zhengzhi" runat="server" Text="<空>"></asp:Label>
        </td></tr>
    <tr><td align= "right"><font size="2" face="黑体"><b>通讯地址：</b></font></td><td>
        <asp:Label ID="Dizhi" runat="server" Text="<空>"></asp:Label>
        </td><td align= "right"><font size="2" face="黑体"><b>邮政编码：</b></font></td><td>
        <asp:Label ID="Youbian" runat="server" Text="<空>"></asp:Label>
        </td></tr>
    <tr><td colspan="4"><font size="3" face="微软雅黑">在校信息：</font></td></tr>
    <tr><td align= "right"><font size="2" face="黑体"><b>入学日期：</b></font></td><td>
        <asp:Label ID="Ruxue" runat="server" Text="<空>"></asp:Label>
        </td><td align= "right"><font size="2" face="黑体"><b>院系：</b></font></td><td>
        <asp:Label ID="Xueyuan" runat="server" Text="<空>"></asp:Label>
        </td></tr>
    <tr><td align= "right"><font size="2" face="黑体"><b>专业：</b></font></td><td>
        <asp:Label ID="Zhuanye" runat="server" Text="<空>"></asp:Label>
        </td><td align= "right"><font size="2" face="黑体"><b>方向：</b></font></td><td>
        <asp:Label ID="Fangxiang" runat="server" Text="<空>"></asp:Label>
        </td></tr>
    <tr><td align= "right"><font size="2" face="黑体"><b>年级：</b></font></td><td>
        <asp:Label ID="Nianji" runat="server" Text="<空>"></asp:Label>
        </td><td align= "right"><font size="2" face="黑体"><b>班级：</b></font></td><td>
        <asp:Label ID="Banji" runat="server" Text="<空>"></asp:Label>
        </td></tr>

    <tr><td colspan="4"><font size="3" face="微软雅黑">其他信息：</font></td></tr>
    <tr><td align= "right"><font size="2" face="黑体"><b>是否已毕业：</b></font></td><td colspan="3"><asp:Label ID="毕业情况" runat="server" Text="<空>"></asp:Label></td></tr>
    <tr><td align= "right"><font size="2" face="黑体"><b>毕业证书编号：</b></font></td><td colspan="3"><asp:Label ID="IDbiyezhengshu" runat="server" Text="<空>"></asp:Label></td></tr>
    <tr><td align= "right"><font size="2" face="黑体"><b>毕业日期：</b></font></td><td colspan="3"><asp:Label ID="Daybiye" runat="server" Text="<空>"></asp:Label></td></tr>
    <tr><td align= "right"><font size="2" face="黑体"><b>备注1：</b></font></td><td colspan="3"><asp:Label ID="Beizhu1" runat="server" Text="<空>"></asp:Label></td></tr>
    <tr><td align= "right"><font size="2" face="黑体"><b>备注2：</b></font></td><td colspan="3"><asp:Label ID="Beizhu2" runat="server" Text="<空>"></asp:Label></td></tr>
    <tr><td align= "right"><font size="2" face="黑体"><b>备注3：</b></font></td><td colspan="3"><asp:Label ID="Beizhu3" runat="server" Text="<空>"></asp:Label></td></tr>
    </table></td><td rowspan="4">
        <asp:Image ID="Imagetouxiang" runat="server" ImageUrl="~/images/9.jpg" />
        </td></tr>
        <tr>
        <td>
            <asp:Label ID="Yichang" runat="server" Text=""></asp:Label>
        </td>
        </tr>
        </table>
</asp:Content>
