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
            },
            {
                title: "Get Acquainted Day",
                start: new Date("September 8, 2015 9:00"),
                className: 'cal-event',
            },
            {
                title: "First Full Day of Preschool & Extended Care",
                start: new Date("September 9, 2015 9:00"),
                className: 'cal-event',
            },
            {
                title: "All School Fall Fundraiser Begins",
                start: new Date("September 16, 2015 9:00"),
                end: new Date("September 16, 2015 5:00"),
                className: 'cal-event',
            },
            {
                title: "Parent Assembly, Church Sanctuary",
                start: new Date("September 16, 2015 18:30"),
                end: new Date(" September 16, 2015 19:30"),
                className: 'cal-event',
            },
            {
                title: "All School Fall Fundraiser Ends",
                start: new Date("September 30, 2015 9:00"),
                className: 'cal-event',
            },
            {
                title: "Fall School Pictures",
                start: new Date("October 6, 2015 9:00"),
                className: 'cal-event',
            },
            {
                title: "Speech & Hearing Screenings (Optional)",
                start: new Date("October 7, 2015 9:00"),
                className: 'cal-event',
            },
            {
                title: "Parent's Forum (Babysitting Provided)",
                start: new Date("October 7, 2015 18:30"),
                end: new Date("October 7, 2015 20:00"),
                className: 'cal-event',
            },
            {
                title: "Fall Administrator's Lunch",
                start: new Date("October 14, 2015"),
                className: 'cal-event',
            },
            {
                title: "Costume Parade (Acton Hall) & Parties",
                start: new Date("October 21, 2015 9:00"),
                className: 'cal-event',
            },
            {
                title: "Progress Reports Sent Home",
                start: new Date("November 2, 2015 9:00"),
                className: 'cal-event',
            },
            {
                title: "Vision Screening (Optional)",
                start: new Date("November 16, 2015"),
                className: 'cal-event',
            },
            {
                title: "All School Family Harvest Potluck (Haimerl Center)",
                start: new Date("November 18, 2015 12:00"),
                className: 'cal-event',
            },
            {
                title: "Thanksgiving Vacation (No School)",
                start: new Date("November 25, 2015 9:00"),
                end: new Date("November 27, 2015 17:00"),
                className: 'cal-event',
            },
            {
                title: "Secret Santa Shop",
                start: new Date("December 8, 2015 9:00"),
                className: 'cal-event',
            },
            {
                title: "Secret Santa Shop",
                start: new Date("December 9, 2015 9:00"),
                className: 'cal-event',
            },
            {
                title: "Winterfest Holiday Celebration & Potluck",
                start: new Date("December 16, 2015"),
                className: 'cal-event',
            },
            {
                title: "Christmas Vacation (No School)",
                start: new Date("December 17, 2015 9:00"),
                end: new Date("January 1, 2015 9:00"),
                className: 'cal-event',
            },
            {
                title: "Classes & Extended Care Resume",
                start: new Date("January 4, 2016 9:00"),
                className: 'cal-event',
            },
            {
                title: "Martin Luther King Day (No School)",
                start: new Date("January 18, 2016 9:00"),
                className: 'cal-event',
            },
            {
                title: "Valentine's Day Parties",
                start: new Date("February 10, 2016 9:00"),
                className: 'cal-event',
            },
            {
                title: "President's Day (No School)",
                start: new Date("February 15, 2016 9:00"),
                className: 'cal-event',
            },
            {
                title: "Parent/Teacher Conferences (No School / Ext. Care)",
                start: new Date("February 16, 2016 9:00"),
                className: 'cal-event',
            },
            {
                title: "Bedtime Story Night (PM)",
                start: new Date("February 24, 2016 12:00"),
                className: 'cal-event',
            },
            {
                title: "Professional In-Service Day (No School)",
                start: new Date("March 2, 2016 9:00"),
                className: 'cal-event',
            },
            {
                title: "Spring School Pictures",
                start: new Date("March 8, 2016 9:00"),
                className: 'cal-event',
            },
            {
                title: "Spring Classroom Parties",
                start: new Date("March 23, 2016 9:00"),
                className: 'cal-event',
            },
            {
                title: "Spring Vacation (No School)",
                start: new Date("March 25, 2016 17:00"),
                end: new Date("April 1, 2016 17:00"),
                className: 'cal-event',
            },
            {
                title: "Spring Fling Fun Fair (PM)",
                start: new Date("April 19, 2016 9:00"),
                className: 'cal-event',
            },
            {
                title: "Spring Fling",
                start: new Date("April 18, 2016 9:00"),
                end: new Date("April 22, 2016 17:00"),
                className: 'cal-event',
            },
            {
                title: "Muffins and Donuts for Moms and Dads",
                start: new Date("April 27, 2016 9:00"),
                className: 'cal-event',
            },
            {
                title: "9th Annual Bike-A-Thon Funraiser",
                start: new Date("May 3, 2016 9:00"),
                className: 'cal-event',
            },
            {
                title: "Spring Art Show/Silent Auction",
                start: new Date("May 16, 2016 9:00"),
                end: new Date("May 20, 2016 17:00"),
                className: 'cal-event',
            },
            {
                title: "Grandparent's Day",
                start: new Date("May 18, 2016 9:00"),
                className: 'cal-event',
            },
            {
                title: "Memorial Day (No School)",
                start: new Date("May 30, 2016 9:00"),
                className: 'cal-event',
            },
            {
                title: "Year-End Assembly (Haimerl Center)",
                start: new Date("June 1, 2016 10:30"),
                className: 'cal-event',
            },
            {
                title: "All School Potluck Picnic",
                start: new Date("June 1, 2016 11:00"),
                className: 'cal-event',
            },
            {
                title: "Last Day of Preschool & Ext. Care",
                start: new Date("June 2, 2016 9:00"),
                className: 'cal-event',
            }


        ]
    });

});
