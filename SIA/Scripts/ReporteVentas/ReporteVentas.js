$(function () {

    $('#dataTable').DataTable({
        //"bPaginate": false,
        "bFilter": false
    })

    

    //Controlador : idSelect
    var jsonItemsSelect = {
        "TipoAgente": "s_tipoagente",
        "PubOrigen": "s_tipoventa",
        "EstadoRv": "s_estadorv"
    };
    
    
        $('#fecrep').daterangepicker();
        $('#mask_contable').inputmask('dd/mm/yyyy', { 'placeholder': 'dd/mm/yyyy' })
        $('#mask_agente').inputmask('9999999')
        $('#reporte').inputmask('999999')
        //$('#nav_reportesVentas').hide();
        //$('#btn_reporteVentas').click(function () {
        //    $('#nav_reportesVentas').show();
        //});
     
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
    

});