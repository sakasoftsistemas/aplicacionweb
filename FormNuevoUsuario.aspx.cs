using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidad;
namespace CapaPresentacion
{
    public partial class FormNuevoUsuario : System.Web.UI.Page
    {
        private static string idTipoUsuario = "0";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<tipoUsuario> lista = tipoUsuario_ne.obtenerTipoUsuario();
                ddlTipoUsuario.DataSource = lista;
                ddlTipoUsuario.DataTextField = "descripcion";
                ddlTipoUsuario.DataValueField = "idTipoUsuario";
                ddlTipoUsuario.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string doc = dni.Text;
            string nombres = nombre.Text;
            string apellidoP = apellidoPaterno.Text;
            string apellidoM = apellidoMaterno.Text;
            string direcc = direccion.Text;
            string telef = telefono.Text;
            string corre = correo.Text;
            string user = usuario.Text;
            string clav = clave.Text;
            string confcla = ConfClave.Text;
            if (!doc.Equals("") && !nombres.Equals("") && !apellidoP.Equals("") && !apellidoM.Equals("") && !direcc.Equals("") && !telef.Equals("") && !corre.Equals("") && !user.Equals("") && !clav.Equals("") && !confcla.Equals("") && !idTipoUsuario.Equals("0"))
            {
                if (clav.Equals(confcla))
                {
                    Boolean flag = usuario_ne.registrarusuario(doc, nombres, apellidoP, apellidoM, direcc, telef, corre, user, clav, Convert.ToInt32(idTipoUsuario));
                    if (flag)
                    {
                        Page.ClientScript.RegisterStartupScript(Page.GetType(), "Message Box", "<script language = 'javascript'>alert('Usuario creado con exito')</script>");
                        Response.Redirect("FormLogin.aspx");
                    }
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(Page.GetType(), "Message Box", "<script language = 'javascript'>alert('Las contraseñas no coinciden')</script>");
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "Message Box", "<script language = 'javascript'>alert('Faltan datos')</script>");
            }
        }

        protected void ddlTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            idTipoUsuario = ddlTipoUsuario.SelectedValue;
        }
    }
}