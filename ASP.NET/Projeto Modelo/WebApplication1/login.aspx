<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1.WebForm7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>

    <script type="text/javascript">
        function successalert() {
            swal({
                title: 'Recuperação Password',
                text: 'Foi enviado um link para o seu email com instruções',
                type: 'success'
            })
        }
    </script>

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="container" style="width:250px; height:120px"/>
        
        <div class="card card-container">
          
            <!-- Preencher as credenciais com os dados da cookie -->
            <%if (Request.Cookies["user"] != null)
              {
                    if (System.IO.File.Exists(Server.MapPath("imagens/utilizadores/" + Request.Cookies["User"].Value + ".jpg")))
                    {%>
                        <img id="profile-img" class="profile-img-card" src="imagens/utilizadores/<%Response.Write(Request.Cookies["user"].Value); %>.jpg" / style="width:250px; height:220px">
                  <%}
                    else
                    { %>
                        <img id="profile-img" class="profile-img-card" src="//ssl.gstatic.com/accounts/ui/avatar_2x.png" / style="width:250px; height:220px">
                 <% }
                     }
                     //else
                     //{ %>
                    <%--<img id="profile-img" class="profile-img-card" src="//ssl.gstatic.com/accounts/ui/avatar_2x.png" / style="width:250px; height:220px">-->--%>
            <%//} %>

            <p id="profile-name" class="profile-name-card"></p>
            
                <span id="reauth-email" class="reauth-email"></span>
<%--                <input type="email" id="inputEmail" class="form-control" placeholder="Email address" style="width:250px" runat="server">--%>
                <input type="text" id="txt_user" class="form-control" placeholder="User" style="width:250px" runat="server">
                <input type="password" id="inputPassword" class="form-control" placeholder="Password" required style="width:250px" runat="server">
                
                <div id="remember" class="checkbox" >
                    <label>
                        <asp:CheckBox  ID="Chk_remember" runat="server" AutoPostBack="False" />
                        &nbsp;Remember me              
                    </label>
                </div>
                
                <button id="login" class="btn btn-lg btn-primary btn-block btn-signin" type="submit" style="width:250px" runat="server" onserverclick="login_ServerClick">Sign in</button>
   
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Esqueceu-se da Password?</asp:LinkButton>
            
            <br />
<%--            <asp:Label ID="lbl_erro" runat="server" ForeColor="Red"></asp:Label>--%>
            <asp:Label ID="lbl_erro" runat="server" Font-Bold="True" ForeColor="Red" Text="Login incorreto" Visible="False"></asp:Label>
        </div>

</asp:Content>
