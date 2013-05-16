$(function () {
    $('.bio-wrapper').mouseover(function () {
        $(this).css('opacity', '1');        
        $('#focused-image img').attr('src', $(this).children().first().attr('src'));
        $('#bio-content div').html($(this).children().last().html());
    });

    $('.bio-wrapper').mouseout(function () {
        $(this).css('opacity', '0.4');
    });

    $('#focused-image img').attr('src', $('#1-1 div.bio-wrapper').children().first().attr('src'));
    $('#bio-content div').html($('#1-1 div.bio-text').html());
});