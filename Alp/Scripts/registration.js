$(function () {

    $("#DaysTimes").hide();

    $("#ExtendedCareYes").on("click", function () {
        $("#DaysTimes").show();
    });

    $("#ExtendedCareNo").on("click", function () {
        $("#DaysTimes").hide();
    });

    $("#Telephone").mask("(999) 999 - 9999");

    $("#Telephone").on("blur", function () {
        var last = $(this).val().substr($(this).val().indexOf("-") + 1);

        if (last.length == 3) {
            var move = $(this).val().substr($(this).val().indexOf("-") - 1, 1);
            var lastfour = move + last;

            var first = $(this).val().substr(0, 9);

            $(this).val(first + '-' + lastfour);
        }
    });

    $('#RegSend').on('click', function () {
        data = {
            'childName': $('#FullChildName').val(),
            'dateOfBirth': $('#DOB').val(),
            'maleFemale': $('.malefemale.active').val(),
            'address': $('#Address').val(),
            'city': $('#City').val(),
            'zip': $('#Zip').val(),
            'ageChild': $('#AgeChild').val(),
            'guardians': $('#Guardians').val(),
            'telephone': $('#Telephone').val(),
            'email': $('#Email').val(),
            'enrollmentDays': $('.enrollment.active').val(),
            'extendedCare': $('.extended-care.active').val(),
            'extendedCareDaysTimes': $('#DaysTimes').val()
        }

        $.ajax({
            type: 'POST',
            url: '/Home/RegistrationEmail/',
            data: data,
            success: function (data, textStatus, jqXHR) {
                if (data["ErrorCode"] == -1) {
                    $('#error-modal').modal('show');
                } else {
                    $("#success-modal").modal("show");

                    $('#FullChildName').val("");
                    $('#DOB').val("");
                    $('.malefemale.active').val("");
                    $('#Address').val("");
                    $('#City').val("");
                    $('#Zip').val("");
                    $('#AgeChild').val("");
                    $('#Guardians').val("");
                    $('#Telephone').val("");
                    $('#Email').val("");
                    $('.enrollment.active').val("");
                    $('.extended-care.active').val("");
                    $('#DaysTimes').val("");
                }

            },
            error: function (jqXHR, textStatus, errorThrown) { },
            datatype: 'json'
        });
    });

});