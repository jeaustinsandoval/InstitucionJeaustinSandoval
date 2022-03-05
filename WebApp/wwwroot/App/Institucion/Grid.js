"use strict";
var GridInstitucion;
(function (GridInstitucion) {
    //MUESTRA MODAL DEL MENSAJE 
    if (MensajeApp != "") {
        Toast.fire({
            icon: "success",
            title: MensajeApp
        });
    }
    //MOSTRAR EL MODAL DE CONFIRMACION 
    function OnclickEliminar(id) {
        ComfirmAlert("¿Desea eliminar el registro?", "Eliminar", "warning", '#3085d6', '#d33')
            .then(function (result) {
            if (result.isConfirmed) {
                window.location.href = "Instituciones/Grid?handler=Eliminar&id=" + id;
            }
        });
    }
    GridInstitucion.OnclickEliminar = OnclickEliminar;
    /*Datable*/
    $("#GridView").DataTable();
})(GridInstitucion || (GridInstitucion = {}));
//# sourceMappingURL=Grid.js.map