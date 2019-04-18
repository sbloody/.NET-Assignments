using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;


namespace Assignment5
{
    public class Multimedia
    {
        public enum MediaType
        {
            CD,
            DVD
        };

        public string _title { get; private set; }
        public string _artist { get; private set; }
        public string _genre { get; private set; }
        public MediaType _type { get; private set; }

        public Multimedia(String title, String artist, String genre, MediaType type)
        {
            this._title = title;
            this._artist = artist;
            this._genre = genre;
            this._type = type;
        }

        public Multimedia()
        {

        }

    }

}
