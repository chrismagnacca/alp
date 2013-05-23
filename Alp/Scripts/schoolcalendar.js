$(function () {
    
    var date = new Date();
    var d = date.getDate();
    var m = date.getMonth();
    var y = date.getFullYear();

    $('#calendar').fullCalendar({
        header: {
            left: 'prev,next today',
            center: 'title',
            right: ''
            
        },
        disableDragging: true,
        events: [
            {
                title: "Get Acquianted Day Sessions 1 & 2",
                start: new Date("September 3, 2013 9:00:00"),
                className: 'cal-event' 
            },
            {
                title: "First Full Day of Preschool & Extended Care",
                start: new Date("September 4, 2013 9:00:00"),
                className: 'cal-event'
            },
            {
                title: "All School Fall Fundraiser Begins",
                start: new Date("September 11, 2013 9:00:00"),
                end: new Date("September 11, 2013 5:00:00"),
                className: 'cal-event'
            },
            {
                title: "Parent Assembly, Church Sanctuary",
                start: new Date("September 11, 2013 18:30:00"),
                end: new Date("September 11, 2013 17:30:00"),
                className: 'cal-event'
            },
            {
                title: "All School Fall Fundraiser Ends",
                start: new Date("September 25, 2013 9:00:00"),
                className: 'cal-event'
            },
            {
                title: "Fall School Pictures",
                start: new Date("October 1, 2013 9:00:00"),
                className: 'cal-event'
            }
        ]
    });

});
