$(function () {
    ///llamamos a la función que se encargará de crear los eventos
    //que nos permitirán controlar cuando se haga una selección en las respectivas listas
    estableceEventosChange();
    ///Carga inicialmente la lista der provincias, ya que es 
    //la lista con la que iniciaremos.
    var provincia = $("#id_Provincia").val();
    cargaDropdownListProvincias(provincia);
});

//función que registrará los eventos necesarios para "monitorear"
//cuando se ejecute el método change de las respectivas listas
function estableceEventosChange() {
    ///Evento change de la lista de provincias
    $("#id_Provincia").change(function () {
        ///obtenemos el id de la provincia seleccionada
        var provincia = $("#id_Provincia").val();
        ///llamamos a la funcion que nos permite cargar
        ///todos los cantones asociados a la provincia seleccionada
        cargaDropdownListCantones(provincia);

        ///Al escoger una provincia nueva, elminamos la seleccion actual del distrito
        ///mediante selector nos posicionamos sobre la lista distritos
        var ddlDistritos = $("#Id_Distrito");
        ///limpiamos todas las opciones de la lista de distritos
        ddlDistritos.empty();
    });

    ///Evento change de la lista de cantones
    $("#Id_Canton").change(function () {
        ///obtenemos el id de la canton seleccionada
        var canton = $("#Id_Canton").val();
        ///llamamos a la funcion que nos permite cargar
        ///todos los distritos asociados al canton seleccionado
        cargaDropdownListDistritos(canton);
    });
}


///carga los registros de las provincias
function cargaDropdownListProvincias(pIdProvincia) {
    ///dirección a donde se enviarán los datos
    var url = '/Geografia/RetornaProvincias';
    ///parámetros del método, es CASE-SENSITIVE
    var parametros = {
        id_Provincia: pIdProvincia
    };
    ///invocar el método
    $.ajax({
        url: url,
        dataType: 'json',
        type: 'post',
        contentType: 'application/json',
        data: JSON.stringify(parametros),
        success: function (data, textStatus, jQxhr) {
            procesarResultadoProvincias(data);
        },
        error: function (jQxhr, textStatus, errorThrown) {
            alert(errorThrown);
        },
    });
}

/*
 * toma el resultado del método RetornaProvincias
 * y lo procesa, recorriendo cada posición
 */
function procesarResultadoProvincias(data) {
    ///mediante selector nos posicionamos sobre la lista provincias
    var ddlProvincias = $("#id_Provincia");
    /*///limpiamos todas las opciones de la lista de provincias
    //ddlProvincias.empty();
    ///creamos la primera opcion de la lista, con un valor vacio y el texto de "seleccione un valor"
    //var nuevaOpcion = "<option value=''>Seleccione una provincia</option>";
    ///agregamos la opcion al dropdownlist
    //ddlProvincias.append(nuevaOpcion);
    ///empezamos a recorrer cada uno de los registros obtenidos
    $(data).each(function () {
        ///obtenemos el objeto de tipo provincia haciendo uso de la clausula "this"
        ///ahora podemos acceder a todas las propiedades
        ///por ejemplo provinciaActual.nombre nos retorna el nombre de la provincia
        var provinciaActual = this;
        ///creacion la opcion de la lista, con el valor del id de la provincia y el texto con el nombre
        nuevaOpcion = "<option value='" + provinciaActual.id_provincia + "'>" + provinciaActual.nombre + "</option>";
        ///agregamos la opcion al dropdownlist
        ddlProvincias.append(nuevaOpcion);
    });*/
}

///carga los registros de los cantones
function cargaDropdownListCantones(pIdProvincia) {

    ///dirección a donde se enviarán los datos
    var url = '/Geografia/RetornaCantones';
    ///parámetros del método, es CASE-SENSITIVE
    var parametros = {
        id_Provincia: pIdProvincia
    };
    ///invocar el método
    $.ajax({
        url: url,
        dataType: 'json',
        type: 'post',
        contentType: 'application/json',
        data: JSON.stringify(parametros),
        success: function (data, textStatus, jQxhr) {
            procesarResultadoCantones(data);
        },
        error: function (jQxhr, textStatus, errorThrown) {
            alert(errorThrown);
        },
    });
}


function procesarResultadoCantones(data) {
    ///mediante selector nos posicionamos sobre la lista cantones
    var ddlCantones = $("#Id_Canton");
    ///limpiamos todas las opciones de la lista de cantones
    ddlCantones.empty();
    ///creamos la primera opcion de la lista, con un valor vacio y el texto de "seleccione un valor"
    var nuevaOpcion = "<option value=''>Seleccione un canton</option>";
    ///agregamos la opcion al dropdownlist
    ddlCantones.append(nuevaOpcion);
    ///empezamos a recorrer cada uno de los registros obtenidos
    $(data).each(function () {
        ///obtenemos el objeto de tipo provincia haciendo uso de la clausula "this"
        ///ahora podemos acceder a todas los cantones de la provincia seleccionada
        ///por ejemplo cantonActual.nombre nos retorna el nombre del canton
        var cantonActual = this;
        ///creacion la opcion de la lista, con el valor del id del canton y el texto con el nombre
        nuevaOpcion = "<option value='" + cantonActual.id_canton + "'>" + cantonActual.nombre + "</option>";
        ///agregamos la opcion al dropdownlist
        ddlCantones.append(nuevaOpcion);
    });
}

///carga los registros de los distritos
function cargaDropdownListDistritos(pIdCanton) {

    ///dirección a donde se enviarán los datos
    var url = '/Geografia/RetornaDistritos';
    ///parámetros del método, es CASE-SENSITIVE
    var parametros = {
        id_Canton: pIdCanton
    };
    ///invocar el método
    $.ajax({
        url: url,
        dataType: 'json',
        type: 'post',
        contentType: 'application/json',
        data: JSON.stringify(parametros),
        success: function (data, textStatus, jQxhr) {
            procesarResultadoDistritos(data);
        },
        error: function (jQxhr, textStatus, errorThrown) {
            alert(errorThrown);
        },
    });
}

function procesarResultadoDistritos(data) {
    ///mediante selector nos posicionamos sobre la lista distritos
    var ddlDistritos = $("#Id_Distrito");
    ///limpiamos todas las opciones de la lista de distritos
    ddlDistritos.empty();
    ///creamos la primera opcion de la lista, con un valor vacio y el texto de "seleccione un valor"
    var nuevaOpcion = "<option value=''>Seleccione un distrito</option>";
    ///agregamos la opcion al dropdownlist
    ddlDistritos.append(nuevaOpcion);
    ///empezamos a recorrer cada uno de los registros obtenidos
    $(data).each(function () {
        ///obtenemos el objeto de tipo provincia haciendo uso de la clausula "this"
        ///ahora podemos acceder a todas los distritos del canton seleccionado
        ///por ejemplo distritoActual.nombre nos retorna el nombre del canton
        var distritoActual = this;
        ///creacion la opcion de la lista, con el valor del id del distrito y el texto con el nombre
        nuevaOpcion = "<option value='" + distritoActual.id_distrito + "'>" + distritoActual.nombre + "</option>";
        ///agregamos la opcion al dropdownlist
        ddlDistritos.append(nuevaOpcion);
    });
}