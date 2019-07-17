using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using HorarioNegocio;
using HorarioDominio;
using System.Data;

public partial class Cuenta_Login : System.Web.UI.Page
{
    Administrador objAdministrador = new Administrador();
    AdministradorNeg objAdministradorNeg;
    protected void Page_Load(object sender, EventArgs e)
    {
        objAdministradorNeg = new AdministradorNeg();
    }
    
    protected void btnIniciarSesion_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        objAdministrador.Usuario = txtUsuario.Text;
        objAdministrador.Contrasenia = txtContrasenia.Text;
        dt = objAdministradorNeg.AccesoSistema(objAdministrador);
        if (dt.Rows.Count > 0)
        {
            objAdministrador.Usuario = dt.Rows[0][0].ToString();
            objAdministrador.Contrasenia = dt.Rows[0][1].ToString();
            Response.Redirect("Default.aspx");
        }
        else
        {
            lblMensaje.Text = "Usuario o contraseña incorrectos";
        }
    }
}

