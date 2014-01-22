using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

using DbLinq.Sqlite;
using System.Data.SQLite;

namespace WebixDemo.Controllers
{
    public class DataController : ApiController
    {
        private void SetJsonOutput()
        {
            var media = Configuration.Formatters.XmlFormatter.SupportedMediaTypes;
            var appXmlType = media.FirstOrDefault(t => t.MediaType == "application/xml");
            media.Remove(appXmlType);
        }

        private Main GetDb(){
            var conn = new SQLiteConnection(@"Data Source=|DataDirectory|\testdata.sqlite;");
            conn.Open();
            return new Main(conn, new SqliteVendor());
        }

        public class WebixResult
        {
            public string status;
            public int id;
            public int newid;
            public WebixResult(string result, int id, int newid = 0)
            {
                this.status = result;
                this.id = id;
                this.newid = (newid == 0 ? id : newid);
            }
        }

        //GET /api/data
        public ICollection<Films> Get()
        {
            SetJsonOutput();
            return GetDb().Films.ToArray();
        }

        // POST /api/data
        public WebixResult Post([FromBody]Films value)
        {
            SetJsonOutput();
            var db = GetDb();

            value.id = 0;//clear temporary id
            db.Films.InsertOnSubmit(value);
            db.SubmitChanges();

            return new WebixResult("success", -1, value.id);
        }


        // PUT /api/data/5
        public WebixResult Put(int id, [FromBody]Films value)
        {
            SetJsonOutput();
            var db = GetDb();

            var film = db.Films.First(i => i.id == id);
            film.Title = value.Title;
            film.Rank   = value.Rank;
            film.Rating = value.Rating;
            film.Votes  = value.Votes;

            db.SubmitChanges();
            return new WebixResult("success", id);
        }

        // DELETE /api/data/5
        public WebixResult Delete(int id) {
            SetJsonOutput();
            var db = GetDb();

            db.Films.DeleteOnSubmit(db.Films.First(i => i.id == id));
            db.SubmitChanges();

            return new WebixResult("success", id);
        }

    }
}
