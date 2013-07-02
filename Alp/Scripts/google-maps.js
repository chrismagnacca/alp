function initialize() {
    var myLatLng = new google.maps.LatLng(40.060307, -82.98064);
    var mapLatLng = new google.maps.LatLng(40.069862, -82.980423);

    var mapOptions = {
        center: mapLatLng,
        zoom: 13,

        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    var map = new google.maps.Map(document.getElementById("map-canvas"),
        mapOptions);

    var contentString = "Ascension Lutheran Preschool<br/>" +
                        "1479 Morse Road <br />" +
                        "Columbus, OH 43229";

    var infowindow = new google.maps.InfoWindow({
        content: contentString
    });

    var marker = new google.maps.Marker({
        position: myLatLng,
        map: map,
        title: "Hello World!"
    });
    google.maps.event.addListener(marker, 'click', function () {
        infowindow.open(map, marker);
    });


    marker.setMap(map);
}
google.maps.event.addDomListener(window, 'load', initialize);
