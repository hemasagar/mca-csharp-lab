<%@ Page Language="C#" AutoEventWireup="true" CodeFile="feedback.aspx.cs" Inherits="feedback" MasterPageFile="~/MasterPage.master" %>


<asp:Content ID="Content1" ContentPlaceHolderID=ContentPlaceHolder1 runat=server>
   
    <!-- Comment: div tag is used to control the positioning limitation of content in design mode-->
   <div class="feedformstyle">
        <p class="style12">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Feedback Form</p>
    
    <table class="style10">
        <tr>
            <td class="style11">
                <asp:Label ID="Label1" runat="server" Text="Name" Font-Size="Large"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtBoxName" runat="server" Height="31px" Width="394px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtBoxName" ErrorMessage="Name empty" Font-Size="Medium" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style11">
                <asp:Label ID="Label2" runat="server" Text="Address" Font-Size="Large"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtBoxAddr" runat="server" Height="31px" Width="394px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtBoxAddr" ErrorMessage="Message empty empty" Font-Size="Medium" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style11">
                <asp:Label ID="Label3" runat="server" Text="Message" Font-Size="Large"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtBoxMsg" runat="server" Height="31px" 
                    style="margin-left: 0px" Width="394px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txtBoxMsg" ErrorMessage="Address empty" Font-Size="Medium" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style11">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Submit" Width="149px" 
                    onclick="Button1_Click" Height="34px"/>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>       
    </div>
</asp:Content>


<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    
    <style type="text/css">
        /* Adjust the top and left style to be place the div tag according to desired position, ignore the design mode output*/
        .feedformstyle
        {
            position:relative;
            left:180px;
            top:-80px;
            width: 540px;
            height: 216px;
        }
        .style10
        {
            width: 51%;
        }
        .style11
        {
            width: 353px;
            text-align: right;
        }
        .style12
        {
            text-align: left;
        }
        
    </style>
       
</asp:Content>
