$(function () {

    $('#Send').on('click', function () {

        data = {
            'name': $('#Name').val(),
            'returnEmail': $('#Return').val(),
            'subject': $('#Subject').val() || 'no-subject',
            'message' : $('#Message').val()
        }

        $.ajax({
            type: 'POST',
            url: '/Home/ContectUsEmail/',
            data: data,
            success: function (data, textStatus, jqXHR) {  },
            error: function(jqXHR, textStatus, errorThrown) { },
            datatype: 'json'
        });
    });

});
