<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="detalhes.aspx.cs" Inherits="GYMachines.detalhes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container d-flex justify-content-center align-items-center">
            <div class="container">
                <asp:Image ID="Image1" runat="server" BorderStyle="Groove" Height="273px" ImageUrl="~/Images/Logo.jpg" Width="304px" />
            </div>
            
            <div class="container">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM Maquinas WHERE (ID = @ID)">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="ID" QueryStringField="id" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:DetailsView ID="DetailsView1" runat="server" BorderStyle="None" DataSourceID="SqlDataSource1" GridLines="None" Height="50px" Width="560px">
                </asp:DetailsView>

                <%if (Session["user"] != null) { %>       
                    <Button type="button" ID="Bt_AddCarrinho" class="btn btn-success" data-toggle="modal" data-target="#myModal" style="Width:184px"> Comprar</Button>
                <%} %>
            </div>
    </div>
</asp:Content>
