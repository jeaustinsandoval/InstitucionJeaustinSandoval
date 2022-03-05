namespace GridInstitucion {

    declare var MensajeApp;

    //MUESTRA MODAL DEL MENSAJE 

    if (MensajeApp != "") {
        Toast.fire({
            icon: "success",
            title: MensajeApp
        });
    }

    //MOSTRAR EL MODAL DE CONFIRMACION 
    export function OnclickEliminar(id) {
        ComfirmAlert("¿Desea eliminar el registro?", "Eliminar", "warning", '#3085d6', '#d33')
            .then(result => {
                if (result.isConfirmed) {
                    window.location.href = "Instituciones/Grid?handler=Eliminar&id=" + id;
                }

            });

    }

    /*Datable*/
    $("#GridView").DataTable();





}