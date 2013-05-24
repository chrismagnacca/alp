$(function () {
    $('#Send').on('click', function () {
        data = {
            'name': $('#Name').val(),
            'returnEmail': $('#Return').val(),
            'subject': $('#Subject').val(),
            'message' : $('#Message').val()
        }

        $.ajax({
            type: 'POST',
            url: '/Home/Email/',
            data: data,
            success: function (data, textStatus, jqXHR) { },
            datatype: 'json'
        });
    });
});
