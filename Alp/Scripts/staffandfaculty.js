$(function () {
    $('.bio-wrapper').mouseover(function () {
        $(this).css('opacity', '1');
    });

    $('.bio-wrapper').mouseout(function () {
        $(this).css('opacity', '0.4');
    });
});