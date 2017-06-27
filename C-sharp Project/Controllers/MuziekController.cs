using C_sharp_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace C_sharp_Project.Controllers
{
    public class MuziekController : Controller
    {
        protected DataSet ds;
        private void DatasetInit()
        {
            ds = new DataSet("music");

            DataTable dtSongs = new DataTable("number");

            DataColumn dcId = new DataColumn("id");
            DataColumn dcArtist = new DataColumn("artist");
            DataColumn dcTitle = new DataColumn("title");
            DataColumn dcYear = new DataColumn("year");
            DataColumn dcGenre = new DataColumn("genre");
            DataColumn dcFile = new DataColumn("file");



            ds.Tables.Add(dtSongs);
            dtSongs.Columns.Add(dcId);
            dtSongs.Columns.Add(dcArtist);
            dtSongs.Columns.Add(dcTitle);
            dtSongs.Columns.Add(dcYear);
            dtSongs.Columns.Add(dcGenre);
            dtSongs.Columns.Add(dcFile);

            ds.ReadXml(Server.MapPath(@"~/App_Data/XMLFile1.xml"));

            Session["xmlDataSet"] = ds;

        }
        // GET: Muziek
        public ActionResult Index()
        {
            DatasetInit();
            List<Song> liedjes = new List<Song>();
            SongBuilder sb = new SongBuilder();


            foreach (DataRow dr in ds.Tables[0].Rows)
            {

                Song s = sb.CreateSong(dr);
                liedjes.Add(s);
            }


            return View(liedjes);
        }
        public ActionResult Create()
        {
            DatasetInit();
            return View();
        }
        public ActionResult Delete()
        {
            DatasetInit();
            return View();
        }
        public ActionResult Wijzig()
        {
            DatasetInit();
            return View();
        }
    }
}