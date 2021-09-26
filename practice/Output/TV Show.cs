using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output
{
    public class TV_Show
    {
        public string Actors { get; set; }
        public string Awards { get; set; }
        public string Country { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public string Plot { get; set; }
        public string Poster { get; set; }
        public string Rated { get; set; }
        public string Released { get; set; }
        public string RuntimeInMinutes { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Writer { get; set; }
        public string Year { get; set; }
        public string imdbID { get; set; }
        public string imdbRating { get; set; }
        public string imdbVotes { get; set; }
        public string totalSeasons { get; set; }

        public TV_Show()
        {
            Actors = string.Empty;
            Awards = string.Empty;
            Country = string.Empty;
            Director = string.Empty;
            Genre = string.Empty;
            Language = string.Empty;
            Plot = string.Empty;
            Poster = string.Empty;
            Rated = string.Empty;
            Released = string.Empty;
            RuntimeInMinutes = string.Empty;
            Title = string.Empty;
            Type = string.Empty;
            Writer = string.Empty;
            Year = string.Empty;
            imdbID = string.Empty;
            imdbRating = string.Empty;
            imdbVotes = string.Empty;
            totalSeasons = string.Empty;


        }

        public TV_Show(string data)
        {
            var files = data.Split('\t');
            Actors = files[1];
            Awards = files[2];
            Country = files[3];
            Director = files[4];
            Genre = files[5];
            Language = files[6];
            Plot = files[7];
            Poster = files[8];
            Rated = files[9];
            Released = files[10];
            RuntimeInMinutes = files[11];
            Title = files[12];
            Type = files[13];
            Writer = files[14];
            Year = files[15];
            imdbID = files[16];
            imdbRating = files[17];
            imdbVotes = files[18];
            totalSeasons = files[19];


        }
        public override string ToString()
        {
            return $"{Title} is rated {Rated} vailable in {Country} in {Language} languages";
        }

    }
   
}
