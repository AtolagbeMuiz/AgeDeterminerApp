<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Age_Determiner.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td style="width: 136px; height: 24px;" class="text-center">
                <strong>
                <asp:Label ID="lblBirthdate" runat="server" Text="Enter Birthdate"></asp:Label>
                </strong>
            </td>
            <td style="width: 197px; height: 24px;">
                <strong>
                <asp:TextBox ID="txtbox5" runat="server"></asp:TextBox>
                </strong>
            </td>
            <td style="height: 24px"></td>
        </tr>
        <tr>
            <td style="width: 136px; height: 24px">&nbsp;</td>
            <td style="width: 197px; height: 24px">
                <strong>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="DETERMINE" ForeColor="White" style="font-family: Arial; font-size: 11pt; font-weight: bold; background-color: #000000" />
                </strong>
            </td>
            <td style="height: 24px">&nbsp;</td>
        </tr>
        
        <asp:Panel ID="Panel1" runat="server">
        <tr>
            <td style="width: 136px">
                <asp:Label ID="Label1" runat="server" Text="DAY"></asp:Label>
            </td>
            <td style="width: 197px">
                <asp:TextBox ID="txtbox1" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 136px">
                <asp:Label ID="Label2" runat="server" Text="MONTH"></asp:Label>
            </td>
            <td style="width: 197px">
                <asp:TextBox ID="txtbox2" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 136px; height: 24px">
                <asp:Label ID="Label3" runat="server" Text="YEAR"></asp:Label>
            </td>
            <td style="width: 197px; height: 24px">
                <asp:TextBox ID="txtbox3" runat="server"></asp:TextBox>
            </td>
            <td style="height: 24px"></td>
        </tr>

       </asp:Panel>
        
        </table>
</asp:Content>
