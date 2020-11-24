using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidad;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class Maestra : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<tipoProducto> lista = tipoProducto_ne.obtenerTipoProductos();
            //ScriptManager.RegisterClientScriptBlock(this, GetType(),"alertMessage", @"alert('"+lista[1].descripcion+ "')", true);
            //if (Session["usuario"] != null)
            //{
            //Label lblUserVal = (Label)Page.Master.FindControl("lblUsuario");
            //lblUserVal.Text = Session["usuario"].ToString();
            //}
            //else
            //{
            //Response.Redirect("~/FormLogin.aspx");
            //}
        }

        protected void cerrarSesion(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("~/FormLogin.aspx");
        }
    }
}