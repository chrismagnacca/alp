$(function () {
    $('nav ul li').click(function () {
        var clickedLi = $(this);
        var lis = $('nav ul li');
        
        for (var i = 0; i < lis.length; i++) {
            if ($(lis[i]).hasClass('current')) {
                $(lis[i]).removeClass('current');
            }
        }

        clickedLi.addClass('current');
    });
});