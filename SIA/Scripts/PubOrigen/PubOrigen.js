$(function () {

    $.ajax({
        type: 'POST',
        url: "/PubOrigen/BuscarTipoVentas",
        dataType: 'json',
        //content: "application/json; charset=utf-8", 
        success: function (PubOrigen) {
            $.each(PubOrigen, function (i, data) {
                $("#tipoventa").append('<option value="' + data.Value + '">' + data.Text + '</option>');
            });
        },
    });

});