<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Bank.aspx.cs" Inherits="bank" MasterPageFile="~/MasterPage.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID=ContentPlaceHolder1 runat=server>
   
    <!-- Comment: div tag is used to control the positioning limitation of content in design mode-->
   <div class="feedformstyle">
        <p class="style12">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="style13"><strong>New Bank Details</strong><table class="style14">
                <tr>
                    <td class="style15">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Label ID="Label1" runat="server" 
                            style="text-align: left; " Text="Bank ID" CssClass="style17"></asp:Label>
                    </td>
                    <td class="style16">
                        <asp:TextBox ID="txtBoxBankid" runat="server" Height="25px" Width="208px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="txtBoxBankid" ErrorMessage="Empty Bank ID" 
                            Font-Size="Medium" style="color: #FF0000"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style15">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label2" runat="server" 
                            Text="Bank Name" CssClass="style17"></asp:Label>
                    </td>
                    <td class="style16">
            <span class="style13">
                        <asp:TextBox ID="txtBoxBankname" runat="server" Height="25px" Width="208px"></asp:TextBox>
                        </span>
                    </td>
                    <td>
            <span class="style13">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="txtBoxBankname" ErrorMessage="Empty Bank Name" 
                            Font-Size="Medium" style="color: #FF0000"></asp:RequiredFieldValidator>
                        </span>
                    </td>
                </tr>
                <tr>
                    <td class="style15">
                        &nbsp;</td>
                    <td class="style16">
                        <asp:Button ID="Button1" runat="server" Text="Submit" Width="107px" 
                            onclick="Button1_Click" />
&nbsp;<input id="Reset1" type="reset" value="Reset" /></td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
            </span></p>
            <p class="style12">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Font-Size="Large" style="color: #FF0000"></asp:Label>
            &nbsp;</p>      
    </div>
</asp:Content>


<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    
    <style type="text/css">
        /* Adjust the top and left style to be place the div tag according to desired position, ignore the design mode output*/
        .feedformstyle
        {
            position:relative;
            left:355px;
            top:-257px;
            width: 540px;
            height: 216px;
        }
        .style12
        {
            text-align: left;
        }
        
        .style13
        {
            font-size: xx-large;
        }
        
    .style14
    {
        width: 100%;
    }
    .style15
    {
        width: 154px;
    }
    .style16
    {
        width: 226px;
    }
    #Reset1
    {
        width: 97px;
    }
        
        .style17
        {
            font-size: large;
        }
        
    </style>
       
</asp:Content>



