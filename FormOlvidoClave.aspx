<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormOlvidoClave.aspx.cs" Inherits="CapaPresentacion.FormOlvidoClave" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="styles/NuevoUsuario.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <h5>Recuperar&nbsp;contraseña</h5>

        <label for="dni">Dni:&nbsp;</label>
        <asp:TextBox ID="txtdni" MaxLength="8" runat="server" placeholder="Dni"></asp:TextBox>

        <label for="correo">Correo:&nbsp;</label>
        <asp:TextBox ID="txtcorreo" runat="server" placeholder="Correo"></asp:TextBox>

        <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
    </form>
</body>
</html>
