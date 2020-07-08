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
            primerApellido: {
                required: true,
                minlength: 3,
                maxlength: 10
            },
            segundoApellido: {
                required: true
            },
            nombre: {
                required: true
            },
            cedula: {
                required: true,
                minlength: 9,
                maxlength: 15
            },
            correo: {
                required: true,
                email: true
            },
            telefono: {
                required: true,
                maxlength: 12
            },
            direccion: {
                required: true,
                maxlength: 150
            },
            provincia: {
                required: true
            },
            canton: {
                required: true
            },
            distrito: {
                required: true
            },
        }
    });
}
