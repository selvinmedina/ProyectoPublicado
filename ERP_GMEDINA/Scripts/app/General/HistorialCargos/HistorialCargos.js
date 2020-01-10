﻿$(document).ready(function () {
    llenarTabla();
});
function llenarTabla() {
    _ajax(null,
       '/HistorialCargos/llenarTabla',
       'POST',
       function (Lista) {
           tabla.clear();
           tabla.draw();
           $.each(Lista, function (index, value) {
               tabla.row.add({
                   Id: value.hcar_Id,
                   Encargado: value.Encargado,
                   Anterior: value.car_Anterior,
                   Nuevo: value.car_Nuevo,
                   Fecha: FechaFormato(value.hcar_Fecha).substring(0,10)
               });
           });
           tabla.draw();
       });
}
$(document).ready(function () {
    llenarTabla();
});

$('#IndexTable tbody').on('click', 'td.details-control', function () {
    var tr = $(this).closest('tr');
    var row = tabla.row(tr);

    if (row.child.isShown()) {
        row.child.hide();
        tr.removeClass('shown');
    }
    else {
        id = row.data().Id;
        hola = row.data().hola;
        _ajax({ id: parseInt(id) },
            '/HistorialCargos/ChildRowData',
            'GET',
            function (obj) {
                if (obj != "-1" && obj != "-2" && obj != "-3") {
                    row.child(format(obj)).show();
                    tr.addClass('shown');
                }
            });
    }

});

function btnAgregar() {
    var modalnuevo = $("#ModalNuevo");
    modalnuevo.modal('show');
}

$("#btnGuardar").click(function () {
    var data1 = $("#FormNuevo").serializeArray();
    data = serializar(data1);
    if (data != null) {
        data = JSON.stringify({ tbEmpleados: data });
        debugger
        _ajax(data,
            '/HistorialCargos/Create',
            'POST',
            function (obj) {
                if (obj != "-1" && obj != "-2" && obj != "-3") {
                    CierraPopups();
                    llenarTabla();
                    LimpiarControles(["sue_Cantidad"]);

                    MsgSuccess("¡Exito!", "Se ha agregado el registro");
                } else {
                    MsgError("Error", "Codigo:" + obj + ". contacte al administrador.(Verifique si el registro ya existe)");
                }
            });
    } else {
        MsgError("Error", "por favor llene todas las cajas de texto");
    }

});
