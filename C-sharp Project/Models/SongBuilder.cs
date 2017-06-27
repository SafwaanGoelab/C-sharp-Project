using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace C_sharp_Project.Models
{
    public class SongBuilder
    {
        public Song CreateSong(DataRow dr)
        {

            Song x = new Song()
            {
                Id =  Convert.ToInt32(dr["id"]),
                Artist = Convert.ToInt32(dr["artist"]),
                Title = dr["title"].ToString()
                Year = dr["year"].ToString()
            };

            return x;
        }
    }
}