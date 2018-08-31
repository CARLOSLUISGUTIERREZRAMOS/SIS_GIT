$(function () {

    $.ajax({
        type: 'POST',
        url: "/TipoAgente/BuscarTipoAgentes",
        dataType: 'json',

        success: function (TipoAgentes) {
            $.each(TipoAgentes, function (i, data) {
                $("#tagente").append('<option value="'+ data.Value + '">' + data.Text + '</option>');
            });
        }
    })

});



