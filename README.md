# Clase 5 de Práctica - "Layouts, Partial Views y Validaciones"

En esta clase hicimos ejemplos prácticos repasando los siguientes temas:
### Layouts
1. @RenderBody() - /Views/Shared/_Layout.cshtml
2. @RenderSection - /Views/Shared/_LayoutConRegiones.cshtml
3. Anidación de Layouts - _LayoutAnidado.cshtml

### Partial Views
1. Partial View simple, solo con html. Referenciadas desde /Views/Shared/_Layout.cshtml utilizando @{ Html.RenderPartial("~/Views/Shared/_pvTopMenuLinks.cshtml"); }
    + /Views/Shared/_pvFooter.cshtml
    + /Views/Shared/_pvTopMenuLinks.cshtml
2. Partial View Tipada /Views/Home/_pvLinkUsuario.cshtml
    + Mostrando Avatar de usuario
    + Nobre de usuario
    + Puntos
### Validaciones (del lado del Servidor y del lado del Cliente)
Agregamos validaciones en la clase /Models/**Usuario** y hicimos un ejemplo de:
+ Required
+ StringLength
+ Range
+ Compare
+ EmailAddress
+ RegularExpression
+ CustomValidation
+ ValidationSummary

_Nota: Para habilitar las validaciones del lado del cliente (javascript), instalamos los paquetes de nuget jQuery.Validation y Microsoft.jQuery.Unobtrusive.Validation, luego incluimos en el html los scripts:_
+ <script src="~/Scripts/jquery-1.8.0.min.js"></script>
+ <script src="~/Scripts/jquery.validate.js"></script>
+ <script src="~/Scripts/jquery.validate.unobtrusive.min.js"></script>


		
# Como Ejecutar
1. Abrir el archivo **Clase5LayoutsValidaciones.sln** con el Visual Studio
2. Click derecho en la solución, Restaurar paquetes de Nuget
3. F5
