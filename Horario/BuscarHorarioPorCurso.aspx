<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="BuscarHorarioPorCurso.aspx.cs" Inherits="BuscarHorario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
<%--    <script src="http://code.jquery.com/jquery-1.10.2.js"></script>  --%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="app-page-title">
        <div class="page-title-wrapper">
            <div class="page-title-heading">
                <div class="page-title-icon">
                    <i class="pe-7s-glasses icon-gradient bg-grow-early"></i>
                </div>
                <div>
                    <h2><b>UNIVERSIDAD RICARDO PALMA - Horarios de profesores</b></h2>
                    <div class="page-title-subheading">
                        <h5>Buscar horarios por curso.</h5>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <asp:Panel ID="panelBuscarCurso" runat="server">
        <div class="tab-pane tabs-animation fade show active" id="tab-content-0" role="tabpanel">
            <div class="main-card mb-3 card">
                <div class="card-body">
                    <h1 class="card-title">EMPIEZA TU BÚSQUEDA</h1>
                    <div class="position-relative form-group">
                        <label for="ejCurso" class="">Curso</label>
                        <asp:TextBox ID="txtCurso" placeholder="Escriba el nombre del curso" class="form-control" runat="server" OnTextChanged="txtCurso_TextChanged"></asp:TextBox>
                    </div>
                    <asp:Button ID="btnBuscarCurso" class="mt-12 btn btn-primary bg-warning" BorderWidth="0" runat="server" Text="Buscar" OnClick="btnBuscarCurso_Click" BorderStyle="None" />
                </div>
            </div>
        </div>
    </asp:Panel>
    <asp:Panel ID="panelTablaCurso" runat="server">
        <div class="row">
            <div class="col-lg-12">
                <div class="main-card mb-3 card">
                    <div class="card-body">
                        <h5 class="card-title responsive">CURSO</h5>
                        <div class="mb-0">
                            <asp:GridView ID="TablaCurso" runat="server" CssClass="mb-0 table table-borderless" border="0" OnSelectedIndexChanged="TablaCurso_SelectedIndexChanged">
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
    <asp:Panel ID="panelTablaProfesor" runat="server">
        <div class="row">
            <div class="col-lg-12">
                <div class="main-card mb-3 card bg-tempting-azure">
                    <div class="card-body">
                        <h5 class="card-title responsive">Horario de profesores del curso: </h5>
                        <h3 class="card-title responsive">
                            <asp:Label ID="lblNombreCurso" runat="server" Text="NombreCurso"></asp:Label></h3>
                        <div class="mb-0">
                            <asp:GridView ID="TablaProfesor" runat="server" CssClass="mb-0 table table-borderless  bg-tempting-azure" border="0" OnSelectedIndexChanged="TablaProfesor_SelectedIndexChanged">
                            </asp:GridView>                            
                        </div>                       
                    </div>
                </div>
            </div>
        </div>
    </asp:Panel>
    <script type="text/javascript" src="js/main.js"></script>
 <%--   <script type="text/javascript" src="js/util.js"></script>
    <script type="text/javascript" src="js/common.js"></script>--%>
     <asp:Panel ID="panelTablaHorario" runat="server">
        <div class="row">
            <div class="col-lg-12">
                <div class="main-card mb-3 card bg-tempting-azure">
                    <div class="card-body">
                        <h5 class="card-title responsive">CURSO</h5>
                        <div class="mb-0">
                            <asp:GridView ID="tablaHorario" runat="server" CssClass="mb-0 table table-borderless bg-tempting-azure" border="0">                                
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </asp:Panel>
   <%-- <div class="modal fade" id="modalHorario" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" style="display: none;" aria-hidden="true">
    <div class="modal-dialog" role="document">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLabel">HORARIO DE </h5>
                <h5 class="modal-title"><asp:Label ID="lblNombreProfeModal" runat="server" Text="Nombre Apellido"></asp:Label></h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">×</span>
                </button>
            </div>
            <div class="modal-body">                
                <asp:GridView ID="tablaHorario" runat="server"></asp:GridView>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Aceptar</button>                
            </div>
        </div>
    </div>
</div>--%>
</asp:Content>

