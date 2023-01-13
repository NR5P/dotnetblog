using System;
using System.Collections.Generic;
using dotnethomepage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dotnethomepage.Pages
{
    public class AboutModel : PageModel
    {
        public List<AboutItem> aboutList = new List<AboutItem> {
            new AboutItem{title="My career in software development", body=@"
                Most of my software developer career has been working in financial institutions. 
                Working as a full stack developer in the financial space I've been able to have 
                experience with many different technologies including C#/.NET, ReactJS, PHP and 
                Python. I've found it pretty easy to switch between technologies and feel software 
                development’s good practices are good practices no matter the platform. 
                A majority of my experience has been as a C#/.NET developer using SQL databases 
                along with both kendoUI and React front ends. This also included both building and 
                consuming a number of REST JSON api's and SOAP api's. Along with web apps, 
                I've built user based applications for bank employees and many of these were based 
                on Jack Henry's system in both PowerOn and Workflow. I've also built out complex 
                excel spreadsheets that took in report data and had many graphs and features to 
                analyze information. 
            "},
            new AboutItem{title="Ham radio & electronics, where it started", body=@"
                I've always enjoyed electronics and ham radio. Homebrewing and repairing electronics 
                has always been an enjoyable hobby for me. I also enjoy growing plants and at some 
                point I ended up wanting to develop an irrigation controller that would also be 
                capable of controlling temp and humidity in a greenhouse. This is how I ended up 
                getting started in software development. I got a raspberry pi and started learning 
                Python, html, css, javascript, and Linux. 
            "},
            new AboutItem{title="I love hardware and software", body=@"
                I love making real things work. I think my experience with hardware, both engineering 
                and repairing circuits, helps in my development of software. I am used to learning 
                new technologies on the fly and I enjoy expanding my knowledge. Professionally, at 
                Performance Cattle Company, I was able to combine my passions. I built a system that 
                used Intel Realsense 3d cameras which were pointed at a scale. When the cattle walked 
                onto the scale the 3d cameras mounted on two sides would gather a 3d image of the 
                cow which calculated all dimensions. A UHF RFID reader would read the ear tag of the 
                cow for identification. This information along with the weight was put into a database 
                to be analyzed later. This was a fun project. I got to gain more experience with 
                OpenCV libraries for computer vision, 3d cameras, and I even back engineered the 
                library for the RFID reader by reading the serial usb data. 
            "},
            new AboutItem{title="My future, and where I want to go", body=@"
                Someday I want to have a software company but in the mean time I love building and 
                maintaining software. I don't have a favorite or specific language or framework. I 
                like to analyze the situation and use the best tool for the job. I've had experience 
                with a variety of programming languages and frameworks and enjoy learning new things 
                and optimizing my current knowledge. 
            "}
        };
        public void OnGet()
        {
        }
    }
}
