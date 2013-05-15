$(function () {
    $('.bio-wrapper').mouseover(function () {
        $(this).css('opacity', '1');        
        $('#focused-image img').attr('src', $(this).children().first().attr('src'));
    });

    $('.bio-wrapper').mouseout(function () {
        $(this).css('opacity', '0.4');
    });


});