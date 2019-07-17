using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HorarioDominio;
using HorarioNegocio;
using System.Data;
using System.Data.SqlClient;

public partial class Prueba : System.Web.UI.Page
{
    Profesor objProfesor = new Profesor();
    ProfesorNeg objProfesorNeg;
    protected void Page_Load(object sender, EventArgs e)
    {
        objProfesorNeg = new ProfesorNeg();
        //esto no es en capas:C
        this.leer_datos("SELECT Nombre1, Nombre2, Apellido1,Apellido2, Correo FROM T_Profesor", ref resultados, "T_Profesor");
        this.filtro = ((DataTable)resultados.Tables["T_Profesor"]).DefaultView;
        this.TablaProfes.DataSource = filtro;
        //TablaProfes.DataBind();
        panelTablaProfes.Visible = false;
        panelTablaClase.Visible = false;
        panelTablaHorario.Visible = false;        
    }
    DataSet resultados = new DataSet();
    DataView filtro;

    public void leer_datos(string query, ref DataSet dsPrincipal, string tabla)
    {
        try
        {
            string cadena = "data source=DESKTOP-JD6AVD3\\SQLEXPRESS;initial catalog=HORARIOURP;integrated security=SSPI; User ID=Anderley; Password=2014lunahuana";
            SqlConnection cn = new SqlConnection(cadena);
            SqlCommand cmd = new SqlCommand(query, cn);
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dsPrincipal, tabla);
            da.Dispose();
            cn.Close();
        }
        catch (Exception)
        {

            throw;
        }
    }
    private void cargarProfesores()
    {
        ProfesorNeg objProfesorNeg = new ProfesorNeg();
        DataSet dsProfesores = objProfesorNeg.LeerProfesores();
        TablaProfes.DataSource = dsProfesores.Tables[0];
        TablaProfes.DataBind();
    }
    
    protected void btnBuscarProfesor_Click(object sender, EventArgs e)
    {
        string salida_datos = "";
        string[] palabras_busqueda = txtNombreProfesor.Text.Split(' ');       
        foreach (var palabra in palabras_busqueda)
        {
            if(salida_datos.Length == 0)
            {
                salida_datos = "(Nombre1 LIKE '%" + palabra + "%' OR Nombre2 LIKE '%" + palabra + "%' OR Apellido1 LIKE '%" + palabra + "%' OR Apellido2 LIKE '%" + palabra + "%')";
            }
            else
            {
                salida_datos += "AND (Nombre1 LIKE '%" + palabra + "%' OR Nombre2 LIKE '%" + palabra + "%' OR Apellido1 LIKE '%" + palabra + "%' OR Apellido2 LIKE '%" + palabra + "%')";
            }
        }
        this.filtro.RowFilter = salida_datos;
        TablaProfes.DataBind();
        //Muestra la tabla de profes
        panelTablaProfes.Visible = true;
        panelTablaClase.Visible = false;
        panelTablaHorario.Visible = false;
    }
    protected void txtNombreProfesor_TextChanged(object sender, EventArgs e)
    {
        string salida_datos = "";
        string[] palabras_busqueda = txtNombreProfesor.Text.Split(' ');
        foreach (var palabra in palabras_busqueda)
        {
            if (salida_datos.Length == 0)
            {
                salida_datos = "(Nombre1 LIKE '%" + palabra + "%' OR Nombre2 LIKE '%" + palabra + "%' OR Apellido1 LIKE '%" + palabra + "%' OR Apellido2 LIKE '%" + palabra + "%')";
            }
            else
            {
                salida_datos += "AND (Nombre1 LIKE '%" + palabra + "%' OR Nombre2 LIKE '%" + palabra + "%' OR Apellido1 LIKE '%" + palabra + "%' OR Apellido2 LIKE '%" + palabra + "%')";
            }
        }
        this.filtro.RowFilter = salida_datos;
        panelTablaProfes.Visible = true;
        panelTablaClase.Visible = false;
        panelTablaHorario.Visible = false;
    }
    ClaseNeg objClaseNeg;
    
    string codigo_profesor;
    public void buscarClaseProfesor(String codigo_profesor)
    {
        ClaseNeg objClaseNeg = new ClaseNeg();
        DataSet dsClase = objClaseNeg.BuscarClasePorProfesor(codigo_profesor);
        TablaClase.DataSource = dsClase.Tables[0];
        TablaClase.DataBind();
    }
    public void buscarHorarioProfesor(String codigo_profesor)
    {
        HorarioNeg objHorarioNeg = new HorarioNeg();
        DataSet dsHorario = objHorarioNeg.BuscarHorarioPorProfesor(codigo_profesor);
        TablaHorario.DataSource = dsHorario.Tables[0];
        TablaHorario.DataBind();
    }
    protected void TablaProfes_SelectedIndexChanged(object sender, EventArgs e)
    {        
        objProfesor = new Profesor();
        Session["Nombre1"] = TablaProfes.SelectedRow.Cells[1].Text;
        Session["Nombre2"] = TablaProfes.SelectedRow.Cells[2].Text;
        Session["Apellido1"] = TablaProfes.SelectedRow.Cells[3].Text;
        Session["Apellido2"] = TablaProfes.SelectedRow.Cells[4].Text;
        Session["Correo"] = TablaProfes.SelectedRow.Cells[5].Text;

        objProfesor.Nombre1 = (string)Session["Nombre1"];
        objProfesor.Nombre2 = (string)Session["Nombre2"];
        objProfesor.Apellido1 = (string)Session["Apellido1"];
        objProfesor.Apellido2 = (string)Session["Apellido2"];
        objProfesor.Correo = (string)Session["Correo"];        
        objProfesorNeg.buscarCodigoProfesorPorCorreo(objProfesor);
        codigo_profesor = objProfesor.Codigo;
        buscarHorarioProfesor(codigo_profesor);

        panelTablaProfes.Visible = false;
        panelTablaClase.Visible = false;
        panelTablaHorario.Visible = true;

        lblNombreProfe.Text = "Se muestra el horario del profesor: "+ objProfesor.Nombre1 + " " + objProfesor.Apellido1 + "\n";
    }

}