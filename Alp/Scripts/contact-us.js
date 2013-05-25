$(function () {

    $('#Send').on('click', function () {
        $('contact-us-form').validate();        

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
            success: function (data, textStatus, jqXHR) { alert('DERP') },
            error: function(jqXHR, textStatus, errorThrown) {alert('DERP')},
            datatype: 'json'
        });
    });
});
