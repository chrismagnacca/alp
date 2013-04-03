$(function () {
    $("#slides").slidesjs({
        width: 560,
        height: 360,
        start: 1,
        play: {
            active: false,
            effect: "slide",
            interval: 5000,
            auto: true,
            pauseOnHover: true,
            restartDelay: 2500,
        },
    });

    $('.slidesjs-previous').text('');
    $('.slidesjs-next').text('');
    $('.slidesjs-previous').addClass('icon-chevron-left icon-2x');
    $('.slidesjs-next').addClass('icon-chevron-right icon-2x');
});