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
                Id =  (dr["id"] != DBNull.Value && dr["id"] != "" ? Convert.ToInt32(dr["id"]) : 0),
                Artist = dr["artist"].ToString(),
                Title = dr["title"].ToString(),
                Year  = dr["year"].ToString(),
                Genre = dr["genre"].ToString(),
                File = dr["file"].ToString(),


            };

            return x;
        }
    }
}