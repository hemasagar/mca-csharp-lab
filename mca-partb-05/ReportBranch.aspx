<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReportBranch.aspx.cs" Inherits="ReportsBranch" MasterPageFile="~/MasterPage.master" %>

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
                ID="DropDownListBranch" runat="server" AutoPostBack="True" Height="24px" Width="154px" 
                onselectedindexchanged="DropDownListBranch_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:GridView ID="GridView1" runat="server" BackColor="White" 
                BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                style="font-size: large">
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
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
        }
        
        #Reset1
    {
        width: 97px;
    }
        
    </style>
       
</asp:Content>

