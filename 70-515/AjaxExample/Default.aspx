﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    
    <h2>Suppliers</h2>
    <hr />
    
    <div>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" style="margin: 20px 0px 20px 40px; width:50%; float:left;">
            <ContentTemplate>
                Company<br />
                <asp:TextBox ID="TextBoxCompany" runat="server" Width="200"></asp:TextBox>
                <br />
                Contact Name<br />
                <asp:TextBox ID="TextBoxContact" runat="server" Width="200"></asp:TextBox>
                <br />
                City<br />
                <asp:TextBox ID="TextBoxCity" runat="server" Width="200"></asp:TextBox>
                <br />
                Phone<br />
                <asp:TextBox ID="TextBoxPhone" runat="server" Width="200"></asp:TextBox>
                <br />
                <asp:Button ID="ButtonSave" runat="server" Text="add" Style="margin-top: 15px" OnClick="ButtonSave_Click" />    
            </ContentTemplate>
        </asp:UpdatePanel>
            
        <asp:UpdatePanel ID="UpdatePanel3" runat="server" style="width:40%; float:left;">
            <ContentTemplate>
                <asp:Label Text="Advertisement" runat="server" />
                <br />
                <asp:Image ID="advertisementImage" runat="server" ImageUrl="~/Images/contoso.png" Width="130" Height="78" />
                <asp:Timer ID="Timer1" runat="server" Interval="4000" ontick="Timer1_Tick">
                </asp:Timer>
            </ContentTemplate>
        </asp:UpdatePanel>
        
    </div>

    <br class="clear" />
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="ButtonSave" EventName="Click" />
        </Triggers>
        <ContentTemplate>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="SupplierID" DataSourceID="SqlDataSourceNwd" AllowPaging="True">
                <Columns>
                    <asp:BoundField DataField="SupplierID" HeaderText="SupplierID" InsertVisible="False" ReadOnly="True" SortExpression="SupplierID" />
                    <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" />
                    <asp:BoundField DataField="ContactName" HeaderText="ContactName" SortExpression="ContactName" />
                    <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                    <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSourceNwd" runat="server" ConnectionString="<%$ ConnectionStrings:NwdConnectionString %>" SelectCommand="SELECT [SupplierID], [CompanyName], [ContactName], [City], [Phone] FROM [Suppliers] ORDER BY [CompanyName]" InsertCommand="INSERT INTO Suppliers(CompanyName, ContactName, City, Phone) VALUES (@company, @contact, @city, @phone)">
                <InsertParameters>
                    <asp:ControlParameter ControlID="TextBoxCompany" Name="company" PropertyName="Text" />
                    <asp:ControlParameter ControlID="TextBoxContact" Name="contact" PropertyName="Text" />
                    <asp:ControlParameter ControlID="TextBoxCity" Name="city" PropertyName="Text" />
                    <asp:ControlParameter ControlID="TextBoxPhone" Name="phone" PropertyName="Text" />
                </InsertParameters>
            </asp:SqlDataSource>
            
            <asp:UpdateProgress ID="UpdateProgress1" runat="server">                
                <ProgressTemplate>
                    <div style="margin-top: 20px; font-size: larger; color: Green">
                        Processing, please wait ...
                    </div>
                </ProgressTemplate>
            </asp:UpdateProgress>
        </ContentTemplate>        
    </asp:UpdatePanel>

</asp:Content>
