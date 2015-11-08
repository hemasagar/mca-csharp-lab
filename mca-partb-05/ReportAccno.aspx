<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReportAccno.aspx.cs" Inherits="ReportAccno" MasterPageFile="~/MasterPage.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID=ContentPlaceHolder1 runat=server>
   
    <!-- Comment: div tag is used to control the positioning limitation of content in design mode-->
   <div class="feedformstyle">
        <p class="style12">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp; Select a bank
            <asp:DropDownList 
                ID="DropDownListBank" runat="server" AutoPostBack="True" Height="24px" Width="154px" 
                onselectedindexchanged="DropDownListBank_SelectedIndexChanged">
            </asp:DropDownList>
        </p>
        <p class="style12">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            Select a branch
            <asp:DropDownList 
                ID="DropDownListBranch" runat="server" AutoPostBack="True" Height="24px" Width="154px" >
            </asp:DropDownList>
        </p>
        <p class="style12">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            Enter Account No<asp:TextBox ID="txtBoxAccno" runat="server" Height="26px" 
                Width="150px"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                Text="Check Balance" Width="102px" />
        </p>
        <p class="style12">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <span class="style13"><span class="style14">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            Account Balance = </span>
            <asp:Label ID="Label2" runat="server" style="font-size: large" Text="Label"></asp:Label>
            </span>
        </p>      
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
            width: 622px;
            height: 323px;
        }
        .style12
        {
            text-align: left;
            font-size: x-large;
            left:40px;
        }
        
        #Reset1
        {
        width: 97px;
        }
        .style13
        {
            color: #FF0000;
        }
        .style14
        {
            font-size: large;
        }
    </style>
       
</asp:Content>


