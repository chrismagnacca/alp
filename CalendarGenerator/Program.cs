using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var line = "";
            var file = new StreamReader("2013-2014_school_calendar.txt");
            var output = new StreamWriter("calendar.js");

            while ((line = file.ReadLine()) != null) {
                var results = line.Split('|');
                output.WriteLine("{");
                output.WriteLine("title: \"" + results[0] + "\",");
                output.WriteLine("start: new Date(\"" + results[1] + "\"),");

                if (results[2] != "")
                    output.WriteLine("end: new Date(\"" + results[2] + "\"),");

                output.WriteLine("className: 'cal-event',");
                output.WriteLine("},");
            }
            file.Close();
            output.Close();
        }
    }
}
