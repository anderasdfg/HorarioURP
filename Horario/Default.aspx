<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Prueba" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="app-page-title">
        <div class="page-title-wrapper">
            <div class="page-title-heading">
                <div class="page-title-icon">
                    <i class="pe-7s-culture icon-gradient bg-mean-fruit"></i>
                </div>
                <div>
                      <h2><b>UNIVERSIDAD RICARDO PALMA - Horarios de profesores</b></h2>
                                        <div class="page-title-subheading">
                                           <h5>Escribe el nombre del profesor</h5>
                                        </div>
                </div>
            </div>
        </div>
    </div>
    <asp:Panel ID="panelBuscarProfesor" runat="server">
         <div class="tab-pane tabs-animation fade show active" id="tab-content-0" role="tabpanel">
        <div class="main-card mb-3 card">
            <div class="card-body">
                <h1 class="card-title">EMPIEZA TU BÚSQUEDA</h1>                
                    <div class="position-relative form-group">
                        <label for="ejProfesor" class="">Profesor</label>
                       <asp:TextBox ID="txtNombreProfesor" placeholder="Escriba el nombre del profesor(a)" class="form-control" runat="server" OnTextChanged="txtNombreProfesor_TextChanged"></asp:TextBox>                        
                    </div>
                        <asp:Button ID="btnBuscarProfesor" PostBackUrl="#pProfesores" class="mt-12 btn btn-warning" runat="server" Text="Buscar" OnClick="btnBuscarProfesor_Click" />                
            </div>
        </div>
    </div>
    </asp:Panel>
    <asp:Panel ID="panelTablaProfes" runat="server" >
    <div class="row" id="pProfesores">
        <div class="col-lg-12">
            <div class="main-card mb-3 card">
                <div class="card-body">
                    <h5 class="card-title responsive">PROFESORES</h5>
                    <div class="mb-0">                     
                        <asp:GridView ID="TablaProfes" runat="server" CssClass="mb-0 table table-borderless" border="0" OnSelectedIndexChanged="TablaProfes_SelectedIndexChanged">
                            <Columns>
                                <asp:CommandField SelectText="Ver" ShowSelectButton="True" />
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </asp:Panel>
    <asp:Panel ID="panelTablaClase" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="main-card mb-3 card">
                <div class="card-body">
                    <h5 class="card-title responsive">CLASE</h5>
                    <div class="mb-0 table">                     
                        <asp:GridView ID="TablaClase" runat="server" CssClass="mb-0 table-bordered table">
                            
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </asp:Panel>
    <asp:Panel ID="panelTablaHorario" runat="server">
     <div class="row">
        <div class="col-lg-12">
            <div class="main-card mb-3 card bg-tempting-azure">
                <div class="card-body">
                    <h5 class="card-title responsive">HORARIO</h5>
                    <h5 class="card-title responsive"><asp:Label ID="lblNombreProfe" runat="server" Text="NombreProfesor"></asp:Label></h5>
                    <div class="mb-0 table">                     
                        <asp:GridView ID="TablaHorario" runat="server" CssClass="mb-0 table-borderless table bg-tempting-azure" border="0">                            
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </asp:Panel>
</asp:Content>

