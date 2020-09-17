using System;

namespace Notes.Models
{
    //defines a Note model that will store data about each note in app
    public class Note
    {
        public string Filename { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

    }
}
