using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidad;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class FormProductos : System.Web.UI.Page
    {
        static List<producto> lista;
        static int contador = 0;
        detalleFactura cabecera = new detalleFactura();
        detalleFactura detalle;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string idPresentacion = Request.QueryString["idPresentacion"].ToString();
                lista = producto_ne.obtenerProductos(Convert.ToInt32(idPresentacion));
                obtenerProductos(lista);
            }
        }
        private void obtenerProductos(List<producto> lista)
        {
            listaDatos.DataSource = lista;
            listaDatos.DataBind();
        }

        protected void listaDatos_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "add")
            {
                int posicion = e.Item.ItemIndex;
                //idproducto_name.Text = Convert.ToString(lista[posicion].idProducto);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert(' UNO " + e.CommandArgument.ToString() + "')", true);
            }
            else
            /*if (e.CommandName == "add")
            {
                if (contador >= 0)
                {
                    if (contador == 0)
                    {
                        //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert(' UNO " + e.CommandArgument.ToString() + "')", true);
                    }
                    int posicion = e.Item.ItemIndex;
                    detalle = new detalleFactura();
                    detalle.idProducto = lista[posicion].idProducto;
                    detalle.cantidad = 2;
                    detalle.precio = lista[posicion].precio;
                    preferencesPedido.listaDetalle.Add(detalle);
                }
                contador++;
            }*/
            if (e.CommandName == "fin")
            {
                string cadena = "";
                for (int i = 0; i < preferencesPedido.listaDetalle.Count; i++)
                {
                    cadena += preferencesPedido.listaDetalle[i].idProducto + " - ";
                }
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert(' DET " + cadena + "')", true);
            }
        }
    }
}