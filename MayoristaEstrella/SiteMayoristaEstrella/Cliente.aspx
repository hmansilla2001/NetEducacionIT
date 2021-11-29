<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="SiteMayoristaEstrella.Cliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <script type="text/javascript">

    function CheckPrime(sender, args) {
        var iPrime = parseInt(args.Value);
        var iSqrt = parseInt(Math.sqrt(iPrime));

        for (var iLoop = 2; iLoop <= iSqrt; iLoop++)
            if (iPrime % iLoop == 0) {
                args.IsValid = false;
                return;
            }

        args.IsValid = true;
    }

     </script>


     <div>
            <h1>Validadores</h1>
            <table>
                <tr>
                    <td>Ingrese nombre:</td>
                    <td>
                        <asp:TextBox ID="TextBoxNombre" MaxLength="10" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                            ControlToValidate="TextBoxNombre" ErrorMessage="El nombre es obligatorio.">

                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Ingrese password:</td>
                    <td>
                        <asp:TextBox ID="TextBoxPassword1" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                            ControlToValidate="TextBoxPassword1" ErrorMessage="La password es obligatoria.">
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Reingrese password:</td>
                    <td>
                        <asp:TextBox ID="TextBoxPassword2" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:CompareValidator ID="CompareValidator1" runat="server"
                            ControlToCompare="TextBoxPassword1" ControlToValidate="TextBoxPassword2"
                            ErrorMessage="Las passwords no coinciden."></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>Ingrese email:</td>
                    <td>
                        <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
                    </td>
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                        ControlToValidate="TextBoxEmail" ErrorMessage="El email es obligatorio.">
                        </asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                            ControlToValidate="TextBoxEmail" ErrorMessage="No es un email válido."
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                        </asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Ingrese nota (1-10):</td>
                    <td>
                        <asp:TextBox ID="TextBoxNivel" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RangeValidator ID="RangeValidator1" runat="server"
                            ControlToValidate="TextBoxNivel" ErrorMessage="Nivel inválido." MaximumValue="10"
                            MinimumValue="1" Type="Integer"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td>Ingrese número primo:</td>
                    <td>
                        <asp:TextBox ID="TextBoxNumeroPrimo" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:CustomValidator ID="CustomValidator1" runat="server"
                            ClientValidationFunction="CheckPrime" ControlToValidate="TextBoxNumeroPrimo"
                            ErrorMessage="No es un número primo"></asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <br />
                        <asp:Button ID="Button1" runat="server" Text="Enviar" />
                    </td>
                </tr>
            </table>
        </div>

</asp:Content>
