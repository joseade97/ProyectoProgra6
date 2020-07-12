///document on ready del view Registro de Clientes
$(function () {
    creaValidaciones();
});

///crea las validaciones para el formulario
function creaValidaciones() {
    $("#frmNuevoCliente").validate({
        ///objeto que contiene "las condiciones" que el formulario
        ///debe cumplir para ser considerado válido
        rules: {
            PrimerApellido: {
                required: true,
                minlength: 3,
                maxlength: 10
            },
            SegundoApellido: {
                required: true
            },
            Nombre: {
                required: true
            },
            Cedula: {
                required: true,
                minlength: 9,
                maxlength: 15
            },
            Correo_Electronico: {
                required: true,
                email: true
            },
            Telefono: {
                required: true,
                maxlength: 12
            },
            Direccion_Fisica: {
                required: true,
                maxlength: 150
            },
            id_Provincia: {
                required: true
            },
            Id_Canton: {
                required: true
            },
            Id_Distrito: {
                required: true
            },
        }
    });
}
