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
public partial class BuscarHorario : System.Web.UI.Page
{
    Curso objCurso = new Curso();
    Clase objClase = new Clase();
    Profesor objProfesor = new Profesor();
    CursoNeg objCursoNeg;
    ClaseNeg objClaseNeg;
    DataSet resultados = new DataSet();
    DataView filtro;
    protected void Page_Load(object sender, EventArgs e)
    {
        objCursoNeg = new CursoNeg();
        objClaseNeg = new ClaseNeg();
        //esto no es en capas:C
        this.leer_datos("SELECT Codigo, Nombre FROM T_Curso", ref resultados, "T_Curso");
        this.filtro = ((DataTable)resultados.Tables["T_Curso"]).DefaultView;
        this.TablaCurso.DataSource = filtro;

        this.panelTablaCurso.Visible = false;
        this.panelTablaProfesor.Visible = false;
        panelTablaHorario.Visible = false;
    }
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


    protected void btnBuscarCurso_Click(object sender, EventArgs e)
    {
        string salida_datos = "";
        string[] palabras_busqueda = txtCurso.Text.Split(' ');
        foreach (var palabra in palabras_busqueda)
        {
            if (salida_datos.Length == 0)
            {
                salida_datos = "(Nombre LIKE '%" + palabra + "%')";
            }
            else
            {
                salida_datos += "AND (Nombre LIKE '%" + palabra + "%')";
            }
        }
        this.filtro.RowFilter = salida_datos;
        TablaCurso.DataBind();
        this.panelTablaCurso.Visible = true;
        this.panelTablaProfesor.Visible = false;
    }
    public void buscarProfesorXCurso(Curso objCurso)
    {
        CursoNeg objCursoNeg = new CursoNeg();
        DataSet dsProfesor = objCursoNeg.BuscarProfesorPorCurso(objCurso);
        TablaProfesor.DataSource = dsProfesor.Tables[0];
        TablaProfesor.DataBind();
    }
    public void buscarHorarioXClase(String codigoClase)
    {
        HorarioNeg objHorarioNeg = new HorarioNeg();
        DataSet dsHorario = objHorarioNeg.BuscarHorarioPorClase(codigoClase);
        tablaHorario.DataSource = dsHorario.Tables[0];
        tablaHorario.DataBind();
    }
    string codigo_Curso;
    protected void TablaCurso_SelectedIndexChanged(object sender, EventArgs e)
    {
        objCurso = new Curso();
        objClase = new Clase();
        Session["Codigo"] = TablaCurso.SelectedRow.Cells[1].Text;
        Session["Nombre"] = TablaCurso.SelectedRow.Cells[2].Text;

        objCurso.Codigo = (string)Session["Codigo"];
        objCurso.Nombre = (string)Session["Nombre"];

        lblNombreCurso.Text = " " +  objCurso.Nombre;
        buscarProfesorXCurso(objCurso);        

        this.panelTablaProfesor.Visible = true;     
    }

    protected void txtCurso_TextChanged(object sender, EventArgs e)
    {
        string salida_datos = "";
        string[] palabras_busqueda = txtCurso.Text.Split(' ');
        foreach (var palabra in palabras_busqueda)
        {
            if (salida_datos.Length == 0)
            {
                salida_datos = "(Nombre LIKE '%" + palabra + "%')";
            }
            else
            {
                salida_datos += "AND (Nombre LIKE '%" + palabra + "%')";
            }
        }
        this.filtro.RowFilter = salida_datos;
        TablaCurso.DataBind();
        this.panelTablaCurso.Visible = true;
        this.panelTablaProfesor.Visible = false;
    }
    protected void TablaProfesor_SelectedIndexChanged(object sender, EventArgs e)
    {
        objClase = new Clase();
        objProfesor = new Profesor();
        Session["Codigo"] = TablaProfesor.SelectedRow.Cells[1].Text;
        Session["Nombre1"] = TablaProfesor.SelectedRow.Cells[2].Text;
        Session["Apellido1"] = TablaProfesor.SelectedRow.Cells[3].Text;
        objClase.Codigo = (string)Session["Codigo"];
        objProfesor.Nombre1 = (string)Session["Nombre1"];
        objProfesor.Apellido1 = (string)Session["Apellido1"];

        string codigoClase;
        codigoClase = objClase.Codigo;

       // lblNombreProfeModal.Text = "Se muestra el horario de: " + objProfesor.Nombre1 + " " + objProfesor.Apellido1 + "\n";

        buscarHorarioXClase(codigoClase);
        panelTablaHorario.Visible = true;
    }

  
}
 
 