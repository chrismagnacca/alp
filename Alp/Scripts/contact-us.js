$(function () {
    
    $('#error-modal').modal({
        keyboard: true,
        show: false
    });

    $('#success-modal').modal({
        keyboard: true,
        show: false
    });

    $('.modal-close').on('click', function () {
        $('#error-modal').modal('hide');
        $('#success-modal').modal('hide');
    });

    $('#Send').on('click', function () {

        data = {
            'name': $('#Name').val(),
            'returnEmail': $('#Return').val(),
            'subject': $('#Subject').val() || 'no-subject',
            'message': $('#Message').val()
        }

        $.ajax({
            type: 'POST',
            url: '/Home/ContactUsEmail/',
            data: data,
            success: function (data, textStatus, jqXHR) {

                if (data["ErrorCode"] == -1) {
                    $('#error-modal').modal('show');
                } else {
                    $("#success-modal").modal("show");

                    $('#Name').val() = "";
                    $('#Return').val() = "";
                    $('#Subject').val() = "";
                    $('#Message').val() = "";
                }


            },
            error: function (jqXHR, textStatus, errorThrown) { },
            datatype: 'json'
        });
    });

});
