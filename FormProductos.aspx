<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="FormProductos.aspx.cs" Inherits="CapaPresentacion.FormProductos" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main-content">
        <asp:DataList ID="listaDatos" runat="server" RepeatColumns="4" OnItemCommand="listaDatos_ItemCommand">
            <ItemTemplate>
                <asp:Panel ID="Panel1" runat="server" Width="250" Height="300px">
                    <table>
                        <tr>
                            <td align="center">
                                <asp:ImageButton Width="150" Height="150" ID="ImageButton1" runat="server" ImageUrl='<%#Eval("imagen") %>' />
                            </td>
                        </tr>
                        <tr>
                            <td align="center" style="font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif; color: #0020D4; font-size: 15px;">
                                <asp:Label ID="Label1" runat="server" Text='<%#Eval("descripcion")%>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" style="font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif; color: #0020D4; font-size: 15px;">
                                <asp:Label ID="Label2" runat="server" Text='<%#"S/ "+Eval("precio")%>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                <asp:ImageButton OnClientClick="return false;" data-target="#exampleModal" class="btn btn-primary" data-toggle="modal" ID="ImageButton2" tite="Agregar" CommandName="add" CommandArgument='<%#Eval("idProducto") %>' runat="server" ImageUrl="~/productos/mas.png" />

                                <asp:ImageButton ID="ImageButton3" tite="Finalizar" CommandName="fin" CommandArgument='<%#Eval("idProducto") %>' runat="server" ImageUrl="~/productos/finalizar.png" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </ItemTemplate>
        </asp:DataList>
    </div>



    <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Detalle&nbsp;pedido</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <form>
                        <div class="form-group">
                            <label for="recipient-name" class="col-form-label">id Producto:</label>
                            <!--<input type="text" class="form-control" id="idproducto-name" disabled>-->
                            <asp:TextBox CssClass="form-control" ID="idproducto_name" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="recipient-name" class="col-form-label">Producto:</label>
                            <!--<input type="text" class="form-control" id="producto_name" disabled>-->
                            <asp:TextBox CssClass="form-control" ID="producto_name" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="message-text" class="col-form-label">Cantidad:</label>
                            <!--<input class="form-control" id="cantidad_text">-->
                            <asp:TextBox CssClass="form-control" ID="cantidad_text" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="message-text" class="col-form-label">Precio:</label>
                            <!--<input class="form-control" id="precio_text" disabled>-->
                            <asp:TextBox CssClass="form-control" ID="precio_text" runat="server"></asp:TextBox>
                        </div>
                    </form>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                    <!--<button type="button" class="btn btn-primary">Aceptar</button>-->
                    <asp:Button CssClass="btn btn-primary" ID="Button1" runat="server" Text="Aceptar" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
