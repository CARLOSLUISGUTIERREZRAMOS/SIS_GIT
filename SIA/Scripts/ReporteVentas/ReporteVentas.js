$(function () {

    if (typeof $('#ValModal').val() != "undefined") {
        $('#modal-danger').modal('show');
    }
    /* =================================================================================
                              PERSONALIZANDO NUESTRO DATATABLE             
     ==================================================================================*/
     
    $('#dataTable').DataTable({
        //"bPaginate": false,
        "aLengthMenu": [[5, 10, 25, 50, -1], [5, 10, 25, 50, "All"]],
        "iDisplayLength": 5,
        "bFilter": true,
        "autoWidth": false
        
    });

    /*==================================================================================*/

    /*
     * INICIALIZANDO LOS INPUTS
     * SE CARGAN DE LA VISTA PARCIAL '_FiltrosReportes.cshtml'
     * INPUTS USAN LAS LIBRERIAS DESCARGADAS DEL PAQUEQUE ADMINLTE-MVC
     */
    $('#fecrep').daterangepicker({
        format: 'DD/MM/YYYY'
    });
    $('#mask_contable').inputmask('dd/mm/yyyy', { 'placeholder': 'dd/mm/yyyy' })
    $('#mask_agente').inputmask('9999999')
    $('#reporte').inputmask('999999', { 'placeholder': '000000' })

    // .INICIALIZANDO LOS INPUTS

    /*
     * ================================================================================
     * ARMANDO SELECT DINAMICOS
     * 1. ARMAMOS UN JSON CON LOS CONTROLADORES A USAR Y 
     * LOS ID DE LOS SELECT'S A LLENAR  -> 'controlador': 'id_select'
     * 2. ITERAMOS CON LOS VALORES DE JSON ARMADO. 
     * 3. RESPUESTA: SE ARMA EN LA VISTA PARCIAL LOS DATOS DE LOS SELECTS 
    */
    var jsonItemsSelect = {
        "TipoAgente": "s_tipoagente",
        "PubOrigen": "s_tipoventa",
        "EstadoRv": "s_estadorv"
    };
    
    $.each(jsonItemsSelect, function (Controller, IdSelect) {

        $.ajax({
            type: 'POST',
            url: '/' + Controller+'/getAll',
            dataType: 'json',
            success: function (data){
                $.each(data, function (i, item) {
                    $("#" + IdSelect).append('<option value="' + item.Value + '">' + item.Text + '</option>');
                });
            }
        });
    });
    /*
    .ARMANDO SELECT DINAMICOS
    =====================================================================================
    */

});