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
                title: "Get Acquainted Day",
                start: new Date("September 3, 2013 9:00"),
                className: 'cal-event',
            },
            {
                title: "First Full Day of Preschool & Extended Care",
                start: new Date("September 4, 2013 9:00"),
                className: 'cal-event',
            },
            {
                title: "All School Fall Fundraiser Begins",
                start: new Date("September 11, 2013 9:00"),
                end: new Date("September 11, 2013 5:00"),
                className: 'cal-event',
            },
            {
                title: "Parent Assembly, Church Sanctuary",
                start: new Date("September 11, 2013 18:30"),
                end: new Date(" September 11, 2013 19:30"),
                className: 'cal-event',
            },
            {
                title: "All School Fall Fundraiser Ends",
                start: new Date("September 25, 2013 9:00"),
                className: 'cal-event',
            },
            {
                title: "Fall School Pictures",
                start: new Date("October 1, 2013 9:00"),
                className: 'cal-event',
            },
            {
                title: "Fall Administrator's Lunch",
                start: new Date("October 2, 2013"),
                className: 'cal-event',
            },
            {
                title: "Speech & Hearing Screenings (Optional)",
                start: new Date("October 9, 2013 9:00"),
                className: 'cal-event',
            },
            {
                title: "Parent's Forum (Babysitting Provided)",
                start: new Date("October 9, 2013 18:30"),
                end: new Date("October 9, 2013 20:00"),
                className: 'cal-event',
            },
            {
                title: "Costume Parade (Acton Hall) & Parties",
                start: new Date("October 23, 2013 9:00"),
                className: 'cal-event',
            },
            {
                title: "Progress Reports Sent Home",
                start: new Date("November 4, 2013 9:00"),
                className: 'cal-event',
            },
            {
                title: "Vision Screening (Optional)",
                start: new Date("November 11, 2013"),
                className: 'cal-event',
            },
            {
                title: "All School Family Harvest Potluck (Haimerl Center)",
                start: new Date("November 20, 2013 12:00"),
                className: 'cal-event',
            },
            {
                title: "Thanksgiving Vacation (No School)",
                start: new Date("November 27, 2013 9:00"),
                end: new Date("November 29, 2013 17:00"),
                className: 'cal-event',
            },
            {
                title: "Secret Santa Shop",
                start: new Date("December 10, 2013 9:00"),
                className: 'cal-event',
            },
            {
                title: "Secret Santa Shop",
                start: new Date("December 11, 2013 9:00"),
                className: 'cal-event',
            },
            {
                title: "Winterfest Holiday Celebration & Potluck",
                start: new Date("December 18, 2013"),
                className: 'cal-event',
            },
            {
                title: "Christmas Vacation (No School)",
                start: new Date("December 19, 2013 9:00"),
                end: new Date("January 3, 2014 9:00"),
                className: 'cal-event',
            },
            {
                title: "Classes & Extended Care Resume",
                start: new Date("January 6, 2014 9:00"),
                className: 'cal-event',
            },
            {
                title: "Martin Luther King Day (No School)",
                start: new Date("January 20, 2014 9:00"),
                className: 'cal-event',
            },
            {
                title: "Valentine's Day Parties",
                start: new Date("February 12, 2014 9:00"),
                className: 'cal-event',
            },
            {
                title: "President's Day (No School)",
                start: new Date("February 17, 2014 9:00"),
                className: 'cal-event',
            },
            {
                title: "Bedtime Story Night (PM)",
                start: new Date("February 26, 2014 12:00"),
                className: 'cal-event',
            },
            {
                title: "Professional In-Service Day (No School)",
                start: new Date("March 5, 2014 9:00"),
                className: 'cal-event',
            },
            {
                title: "Parent/Teacher Conferences (No School / Ext. Care)",
                start: new Date("March 17, 2014 9:00"),
                className: 'cal-event',
            },
            {
                title: "Spring School Pictures",
                start: new Date("March 18, 2014 9:00"),
                className: 'cal-event',
            },
            {
                title: "Spring Fling",
                start: new Date("March 24, 2014 9:00"),
                end: new Date("March 28, 2014 17:00"),
                className: 'cal-event',
            },
            {
                title: "Spring Fling Fun Fair (PM)",
                start: new Date("March 25, 2014 9:00"),
                className: 'cal-event',
            },
            {
                title: "Ident-A-Kid (identification Cards Optional)",
                start: new Date("March 26, 2014 9:00"),
                className: 'cal-event',
            },
            {
                title: "Spring Classroom Parties",
                start: new Date("April 9, 2014 9:00"),
                className: 'cal-event',
            },
            {
                title: "Spring Vacation (No School)",
                start: new Date("April 11, 2014 17:00"),
                end: new Date("April 21, 2014 17:00"),
                className: 'cal-event',
            },
            {
                title: "Spring Administrator's Lunch",
                start: new Date("April 30, 2014 12:00"),
                className: 'cal-event',
            },
            {
                title: "7th Annual Bike-A-Thon Funraiser",
                start: new Date("May 6, 2014 9:00"),
                className: 'cal-event',
            },
            {
                title: "Spring Art Show/Silent Auction",
                start: new Date("May 18, 2014 9:00"),
                end: new Date("May 23, 2014 17:00"),
                className: 'cal-event',
            },
            {
                title: "Grandparent's Day",
                start: new Date("May 21, 2014 9:00"),
                className: 'cal-event',
            },
            {
                title: "Memorial Day (No School)",
                start: new Date("May 26, 2014 9:00"),
                className: 'cal-event',
            },
            {
                title: "Year-End Assembly (Haimerl Center)",
                start: new Date("May 28, 2014 10:30"),
                className: 'cal-event',
            },
            {
                title: "All School Potluck Picnic",
                start: new Date("May 28, 2014 11:00"),
                className: 'cal-event',
            },
            {
                title: "Last Day of Preschool & Ext. Care",
                start: new Date("May 29, 2014 9:00"),
                className: 'cal-event',
            },
            {
                title: "Open House",
                start: new Date("August 27, 2014 17:30"),
                end: new Date(" August 27, 2014 19:00"),
                className: 'cal-event',
            },
            {
                title: "Get Acquainted Day",
                start: new Date("September 2, 2014 9:00"),
                className: 'cal-event',
            },
            {
                title: "First Full Day of Preschool & Extended Care",
                start: new Date("September 3, 2014 9:00"),
                className: 'cal-event',
            },
            {
                title: "All School Fall Fundraiser Begins",
                start: new Date("September 10, 2014 9:00"),
                end: new Date("September 10, 2014 5:00"),
                className: 'cal-event',
            },
            {
                title: "Parent Assembly, Church Sanctuary",
                start: new Date("September 10, 2014 18:30"),
                end: new Date(" September 10, 2014 19:30"),
                className: 'cal-event',
            },
            {
                title: "All School Fall Fundraiser Ends",
                start: new Date("September 24, 2014 9:00"),
                className: 'cal-event',
            },
            {
                title: "Fall School Pictures",
                start: new Date("October 7, 2014 9:00"),
                className: 'cal-event',
            },
            {
                title: "Speech & Hearing Screenings (Optional)",
                start: new Date("October 8, 2014 9:00"),
                className: 'cal-event',
            },
            {
                title: "Parent's Forum (Babysitting Provided)",
                start: new Date("October 8, 2014 18:30"),
                end: new Date("October 8, 2014 20:00"),
                className: 'cal-event',
            },
            {
                title: "Fall Administrator's Lunch",
                start: new Date("October 15, 2014"),
                className: 'cal-event',
            },
            {
                title: "Costume Parade (Acton Hall) & Parties",
                start: new Date("October 22, 2014 9:00"),
                className: 'cal-event',
            },
            {
                title: "Progress Reports Sent Home",
                start: new Date("November 3, 2014 9:00"),
                className: 'cal-event',
            },
            {
                title: "Vision Screening (Optional)",
                start: new Date("November 10, 2014"),
                className: 'cal-event',
            },
            {
                title: "All School Family Harvest Potluck (Haimerl Center)",
                start: new Date("November 19, 2014 12:00"),
                className: 'cal-event',
            },
            {
                title: "Thanksgiving Vacation (No School)",
                start: new Date("November 26, 2014 9:00"),
                end: new Date("November 28, 2014 17:00"),
                className: 'cal-event',
            },
            {
                title: "Secret Santa Shop",
                start: new Date("December 9, 2014 9:00"),
                className: 'cal-event',
            },
            {
                title: "Secret Santa Shop",
                start: new Date("December 10, 2014 9:00"),
                className: 'cal-event',
            },
            {
                title: "Winterfest Holiday Celebration & Potluck",
                start: new Date("December 17, 2014"),
                className: 'cal-event',
            },
            {
                title: "Christmas Vacation (No School)",
                start: new Date("December 18, 2014 9:00"),
                end: new Date("January 2, 2015 9:00"),
                className: 'cal-event',
            },
            {
                title: "Classes & Extended Care Resume",
                start: new Date("January 5, 2015 9:00"),
                className: 'cal-event',
            },
            {
                title: "Martin Luther King Day (No School)",
                start: new Date("January 19, 2015 9:00"),
                className: 'cal-event',
            },
            {
                title: "Valentine's Day Parties",
                start: new Date("February 11, 2015 9:00"),
                className: 'cal-event',
            },
            {
                title: "President's Day (No School)",
                start: new Date("February 16, 2015 9:00"),
                className: 'cal-event',
            },
            {
                title: "Bedtime Story Night (PM)",
                start: new Date("February 18, 2015 12:00"),
                className: 'cal-event',
            },
            {
                title: "Spring School Pictures",
                start: new Date("March 3, 2015 9:00"),
                className: 'cal-event',
            },
            {
                title: "Professional In-Service Day (No School)",
                start: new Date("March 4, 2015 9:00"),
                className: 'cal-event',
            },
            {
                title: "Spring Fling Fun Fair (PM)",
                start: new Date("March 10, 2015 9:00"),
                className: 'cal-event',
            },
            {
                title: "Spring Fling",
                start: new Date("March 9, 2015 9:00"),
                end: new Date("March 13, 2015 17:00"),
                className: 'cal-event',
            },
            {
                title: "Parent/Teacher Conferences (No School / Ext. Care)",
                start: new Date("March 16, 2015 9:00"),
                className: 'cal-event',
            },
            {
                title: "Spring Classroom Parties",
                start: new Date("April 1, 2015 9:00"),
                className: 'cal-event',
            },
            {
                title: "Spring Vacation (No School)",
                start: new Date("April 3, 2015 17:00"),
                end: new Date("April 10, 2015 17:00"),
                className: 'cal-event',
            },
            {
                title: "Spring Administrator's Lunch",
                start: new Date("April 22, 2015 12:00"),
                className: 'cal-event',
            },
            {
                title: "8th Annual Bike-A-Thon Funraiser",
                start: new Date("May 5, 2015 9:00"),
                className: 'cal-event',
            },
            {
                title: "Spring Art Show/Silent Auction",
                start: new Date("May 18, 2015 9:00"),
                end: new Date("May 22, 2015 17:00"),
                className: 'cal-event',
            },
            {
                title: "Grandparent's Day",
                start: new Date("May 20, 2015 9:00"),
                className: 'cal-event',
            },
            {
                title: "Memorial Day (No School)",
                start: new Date("May 25, 2015 9:00"),
                className: 'cal-event',
            },
            {
                title: "Year-End Assembly (Haimerl Center)",
                start: new Date("May 27, 2015 10:30"),
                className: 'cal-event',
            },
            {
                title: "All School Potluck Picnic",
                start: new Date("May 27, 2015 11:00"),
                className: 'cal-event',
            },
            {
                title: "Last Day of Preschool & Ext. Care",
                start: new Date("May 28, 2015 9:00"),
                className: 'cal-event',
            }

        ]
    });

});
