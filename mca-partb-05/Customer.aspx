<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Customer.aspx.cs" Inherits="Customer" MasterPageFile="~/MasterPage.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID=ContentPlaceHolder1 runat=server>
   
    <!-- Comment: div tag is used to control the positioning limitation of content in design mode-->
   <div class="feedformstyle">
        <p class="style12">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <span class="style13"><strong>New Customer Details</strong><table class="style14">
                <tr>
                    <td class="style15">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Bank 
                        Name</td>
                    <td class="style16">
                        <asp:DropDownList ID="DropDownListBank" runat="server" AutoPostBack="True" Height="31px" 
                            onselectedindexchanged="DropDownListBank_SelectedIndexChanged" Width="198px">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="DropDownListBank" CssClass="style17" 
                            ErrorMessage="Select bank" style="font-size: medium; color: #FF0000"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style15">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Branch Name</td>
                    <td class="style16">
                        <asp:DropDownList ID="DropDownListBranch" runat="server" Height="31px" 
                            Width="198px">
                        </asp:DropDownList>
                    </td>
                    <td class="style13">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="DropDownListBranch" CssClass="style17" 
                            ErrorMessage="Select Branch" style="font-size: medium; color: #FF0000"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style15">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Account 
                        No</td>
                    <td class="style16">
                        <asp:TextBox ID="txtBoxAccno" runat="server" Height="31px" Width="198px"></asp:TextBox>
                    </td>
                    <td class="style13">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="txtBoxAccno" CssClass="style17" 
                            ErrorMessage="Empty Account no" style="font-size: medium; color: #FF0000"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style15">
                        &nbsp;&nbsp;&nbsp;&nbsp;Customer Name</td>
                    <td class="style16">
                        <asp:TextBox ID="txtBoxCustomerName" runat="server" Height="31px" Width="198px"></asp:TextBox>
                    </td>
                    <td class="style13">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                            ControlToValidate="txtBoxCustomerName" CssClass="style17" 
                            ErrorMessage="Empty Customer name" style="font-size: medium; color: #FF0000"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style15">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        Address</td>
                    <td class="style16">
                        <asp:TextBox ID="txtBoxAddress" TextMode="multiline" runat="server" Height="58px" Width="198px"></asp:TextBox>
                    </td>
                    <td class="style13">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                            ControlToValidate="txtBoxAddress" CssClass="style17" 
                            ErrorMessage="Empty Address" style="font-size: medium; color: #FF0000"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style15">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        Contact No</td>
                    <td class="style16">
                        <asp:TextBox ID="txtBoxContact" runat="server" Height="31px" Width="198px"></asp:TextBox>
                    </td>
                    <td class="style13">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                            ControlToValidate="txtBoxContact" CssClass="style17" 
                            ErrorMessage="Empty Contact no" style="font-size: medium; color: #FF0000"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style15">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        Balance</td>
                    <td class="style18">
                        <asp:TextBox ID="txtBoxBalance" runat="server" Height="31px" Width="198px"></asp:TextBox>
                    </td>
                    <td class="style13">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                            ControlToValidate="txtBoxBalance" CssClass="style17" 
                            ErrorMessage="Empty Balance" style="font-size: medium; color: #FF0000"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style15">
                        &nbsp;</td>
                    <td class="style16">
                        <asp:Button ID="btnSubmitCustomer" runat="server" Text="Submit" Width="107px" 
                            onclick="btnSubmitCustomer_Click" />
&nbsp;<input id="Reset1" type="reset" value="Reset" /></td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
            </span></p>
            <p class="style12">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
            width: 568px;
            height: 389px;
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
            font-size: large;
        }
    .style16
    {
            width: 220px;
        }
    #Reset1
    {
        width: 97px;
    }
        
        .style18
        {
            width: 220px;
            font-size: xx-large;
        }
        
    </style>
       
</asp:Content>

