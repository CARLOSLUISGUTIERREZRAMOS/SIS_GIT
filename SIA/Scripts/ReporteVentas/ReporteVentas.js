$(function () {

    $('#fecrep').daterangepicker()
    $('#mask_contable').inputmask('dd/mm/yyyy', { 'placeholder': 'dd/mm/yyyy' })
    $('#nav_reportesVentas').hide();
    $('#btn_reporteVentas').click(function () {

        $('#nav_reportesVentas').show();
    });
    
});