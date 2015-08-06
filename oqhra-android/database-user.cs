using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Android.Content;
using OQHRA2011;

namespace oqhra_android
{
    public class database_user
    {
        public database_user(Database d)
        {
        }

        public void getFavourites(Database db, string featType, Action<List<Favorites>> callback)
        {
            List<Favorites> faves = new List<Favorites>();
            faves = db.GetFave(Convert.ToInt16(featType)).ToList();
            callback(faves);
        }

        public void getFeaturedMenu(Database db, Action<List<Featured>> callback)
        {
            List<Featured> feat = db.GetFeaturedMenu().ToList();
            callback(feat);
        }

        public void getSavedRuns(Database db, Action<List<SavedRunsList>> callback)
        {
            List<SavedRunsList> sr = new List<SavedRunsList>();
            sr = db.GetSavedRuns(0).ToList();
            callback(sr);
        }

        public void getRaceInfo(Database db, Action<List<InfoMenu>> callback)
        {
            List<InfoMenu> raceinfo = db.GetRIMenus().ToList();
            callback(raceinfo);
        }

        public void getSavedRuns(Database db, int sort, Action<List<SavedRunsList>> callback)
        {
            List<SavedRunsList> sr = db.GetSavedRuns(sort).ToList();
            callback(sr);
        }

        public void addFeaturedView(Database db, string id, string FeatType, string FeatLabel)
        {
            db.Execute("insert into Favorites (FavId,FaveType,FavLabel) values(" + id + "," + FeatType + ",'" + FeatLabel + "')");
        }

        public void FigureSI(Database db, string tr, string distance, Action<string> callback)
        {
            string retStr = "";
            bool cont = true;
            float timeRan = 0f;
            float SIrp = 0f;
            float SIfm = 0f;
            float SIwrd = 0f;
            List<SpeedIndex> rpSi = new List<SpeedIndex>();
            try
            {
                timeRan = float.Parse(tr);
            }
            catch (Exception oe)
            {
                retStr = "Sorry. Please check input value on time ran";
                callback(retStr);
            }

            string selRec = distance.Replace(" yards", "");
            int distanceRan = Convert.ToInt16(distance.Replace(" yards", ""));
            if (selRec == "")
            {
                cont = false;
            }

            if (cont)
            {
                rpSi = db.GetSI(selRec, timeRan, "RP").ToList();
                retStr += "In the " + distance + ", a " + timeRan.ToString() + " is unofficialy a: " + "\r";

                if (rpSi.Count > 0)
                {
                    retStr += "SI" + rpSi[0].SI + " at Remington Park\r";
                    SIrp = rpSi[0].SI;
                }
                else
                {
                    retStr += "Less than S25 at Remington Park\r";
                    SIrp = 0f;
                }

                rpSi = db.GetSI(distance.Replace(" yards", ""), timeRan, "WRD").ToList();
                if (rpSi.Count > 0)
                {
                    retStr += "SI" + rpSi[0].SI + " at Will Rogers Down\r";
                    SIwrd = rpSi[0].SI;
                }
                else
                {
                    SIrp = 0f;
                    retStr += "Less than S25 at Will Rogers Down\r";
                }

                rpSi = db.GetSI(distance.Replace(" yards", ""), timeRan, "FM").ToList();
                if (rpSi.Count > 0)
                {
                    retStr += "SI" + rpSi[0].SI + " at Fair Meadow Tulsa\r";
                    SIfm = rpSi[0].SI;
                }
                else
                {
                    SIfm = 0f;
                    retStr += "Less than S25 at Fair Meadow Tulsa\r";
                }
                callback(retStr);
            }
        }

        private string FigureSIr(Database db, string tr, string d)
        {
            var r = "";
            FigureSI(db, tr, d, res => { r = res; });
            return r;
        }

        public void getStakes(Database db, List<string> stats)
        { }

        public void SaveRun(Database db, List<string> stats, Action<string> callback)
        {
            bool cont = true;
            string MissingField = "";
            if (stats[0] == "")
            {
                MissingField = "Horse Name";
                cont = false;
            }
            if (stats[1] == "")
            {
                MissingField = "Track";
                cont = false;
            }
            if (stats[2] == "")
            {
                MissingField = "Time Ran";
                cont = false;
            }
            if (stats[3] == "")
            {
                MissingField = "Distance";
                cont = false;
            }
            if (stats[4] == "")
            {
                MissingField = "Date Ran";
                cont = false;
            }
            if (cont)
            {
                string sdfsdff = FigureSIr(db, stats[2], stats[3]);

                try
                {
                    stats[4] = stats[4].Substring(0, stats[4].IndexOf(" "));
                    string sqlStr = "insert into FTH_History (HorseName,Track,RunTime,DateRan,Distance) values('";
                    sqlStr += stats[0] + "','";
                    sqlStr += stats[1] + "','";
                    sqlStr += stats[2] + "','";
                    sqlStr += stats[4] + "','";
                    sqlStr += stats[3] + "')";
                    db.Execute(sqlStr);
                }
                catch (Exception oe)
                {
                    MissingField = oe.ToString();
                }
            }
            else
            {
                callback("Sorry. " + MissingField + " is empty");
            }
        }

        public static Database SessionDatabase { get; set; }
    }
}