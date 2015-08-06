using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Android.Content;
using Android.Net;

namespace oqhra_android
{
    public partial class webservice_user
    {
        private string NETFAULT;

        public webservice_user()
        {
            NETFAULT = "No network available";
        }

        private bool checkForNetwork()
        {
            ConnectivityManager connectivityManager = (ConnectivityManager)Android.App.Application.Context.GetSystemService(Android.Content.Context.ConnectivityService);
            NetworkInfo networkMob = connectivityManager.GetNetworkInfo(Android.Net.ConnectivityType.Mobile);
            NetworkInfo networkWifi = connectivityManager.GetNetworkInfo(Android.Net.ConnectivityType.Wifi);
            if (networkMob != null)
            {
                if (networkMob.IsConnected || networkMob.IsConnectedOrConnecting || networkWifi.IsConnected || networkWifi.IsConnectedOrConnecting)
                    return true;
                else
                    return false;
            }
            else
            {
                if (networkWifi.IsConnected || networkWifi.IsConnectedOrConnecting)
                    return true;
                else
                    return false;
            }
        }

        public void getUpcomingRacesCallBack(string track, Action<List<POHWS.webservice.UpcomingRaces>> callback)
        {
            var tableData = new List<POHWS.webservice.UpcomingRaces>();
            if (checkForNetwork() != true)
            {
                tableData.Add(new POHWS.webservice.UpcomingRaces() { PostTime = NETFAULT });
                callback(tableData);
            }
            else
            {
                POHWS.webservice.Service1 Service3 = new POHWS.webservice.Service1();
                try
                {
                    Service3.BeginGetUpcomingRacesList(track, delegate(IAsyncResult iar)
                        {
                            tableData = Service3.EndGetUpcomingRacesList(iar).ToList();
                            Android.App.Application.SynchronizationContext.Post(delegate
                                {
                                    if (tableData == null)
                                    {
                                        tableData[0].PostTime = "No Upcoming Races Found within the next 7 days";
                                        callback(tableData);
                                    }
                                    else
                                    {
                                        callback(tableData);
                                    }
                                }, null);
                        }, null);
                }
                catch (Exception oe)
                {
                    tableData.Add(new POHWS.webservice.UpcomingRaces() { PostTime = oe.ToString() });
                    callback(tableData);
                }
            }
        }

        public void getFeaturedList(int rInt, Action<List<POHWS.webservice.FeatureInfo>> callback)
        {
            var tableData = new List<POHWS.webservice.FeatureInfo>();
            if (checkForNetwork() != true)
            {
                tableData.Add(new POHWS.webservice.FeatureInfo() { FirstName = NETFAULT });
                callback(tableData);
            }
            else
            {
                try
                {
                    POHWS.webservice.Service1 Service3 = new POHWS.webservice.Service1();
                    Service3.BeginGetFeaturedNew(rInt, delegate(IAsyncResult iar)
                        {
                            tableData = Service3.EndGetFeaturedNew(iar).ToList();
                            callback(tableData);
                        }, null);
                }
                catch (Exception oe)
                {
                    tableData.Add(new POHWS.webservice.FeatureInfo() { FirstName = oe.ToString() });
                    callback(tableData);
                }
            }
        }

        public void featuredProfile(string profileId, Action<string> callback)
        {
            if (checkForNetwork() != true)
            {
                callback(NETFAULT);
            }
            else
            {
                POHWS.webservice.Service1 s4 = new POHWS.webservice.Service1();
                string newId = s4.GetSpID(profileId);

                POHWS.webservice.Service1 Service4 = new POHWS.webservice.Service1();
                string retStr = "";
                try
                {
                    Service4.BeginGetHRSponsor(newId, delegate(IAsyncResult iar1)
                        {
                            POHWS.webservice.Sponsors sponsor = Service4.EndGetHRSponsor(iar1);
                            Android.App.Application.SynchronizationContext.Post(delegate
                                {
                                    retStr = "";
                                    retStr += "<div style=\"background-image:url(file:///android_asset/Back_Profile.png); background-position:center \">";
                                    retStr += "<div style=\"position:relative; top:0px; width:100%; height:150px; display:table; background-color:transparent\">";
                                    retStr += "<div style=\"position:absolute; top:10px; left:10px; width:140px; height:130px; display:table-cell; text-align:center; vertical-align:middle\">";
                                    retStr += "<img src=\"http://mobile.oqhra.com/" + sponsor.Image + "\" style=\"border:5px solid #000000; max-height:100%; max-width:100%\" />";
                                    retStr += "</div>";
                                    retStr += "<div style=\"position:absolute; top:10px; left:160px; display:table-cell; height:130px; width:150px; text-align:center; vertical-align:middle\">";
                                    retStr += "<span style=\"font-family:Arial, Helvetica, sans-serif; font-size:18px; font-weight:bold; margin-left:10px; margin-right:10px; color:#FFFFFF\">" + sponsor.Headline + "</span>";
                                    retStr += "<br />";
                                    retStr += "<span style=\"font-family:Arial, Helvetica, sans-serif; font-size:12px; font-weight:bold; margin-left:10px; margin-right:10px; line-height:35px; color:#FFFFFF\">" + sponsor.HeadlineSubCopy + "</span>";
                                    retStr += "</div></div>";
                                    retStr += "<div style=\"position:relative; top:10px; margin-left:10px; margin-right:10px\">";
                                    retStr += "<span style=\"color:White; font-family:Arial, Helvetica, sans-serif; font-size:12px\">" + sponsor.Description + "</span>";
                                    retStr += "</div>";
                                    retStr += "<div style=\"position:relative; top:20px; color:White; font-family: Arial, Helvetica, sans-serif; font-size:12px; margin-left:10px; margin-right:10px\">";
                                    retStr += "<table width=\"100%\" style=\"color:White\"; font-family: Arial, Helvetica, sans-serif; font-size:12px>";
                                    retStr += "<tr><td style=\"font-size:12px\">Address 1: </td><td style=\"font-size:12px\">" + sponsor.Address1 + "</td></tr>";
                                    retStr += "<tr><td style=\"font-size:12px\">Address 2: </td><td style=\"font-size:12px\">" + sponsor.Address2 + "</td></tr>";
                                    retStr += "<tr><td style=\"font-size:12px\">City: </td><td style=\"font-size:12px\">" + sponsor.City + "</td></tr>";
                                    retStr += "<tr><td style=\"font-size:12px\">State: </td><td style=\"font-size:12px\">" + sponsor.State + "</td></tr>";
                                    retStr += "<tr><td style=\"font-size:12px\">Zip: </td><td style=\"font-size:12px\">" + sponsor.Zip + "</td></tr>";
                                    retStr += "<tr><td></td><td></td></tr>";
                                    retStr += "<tr><td style=\"font-size:12px\">Phone: </td><td style=\"font-size:12px; color:White\">" + sponsor.Phone + "</td></tr>";
                                    retStr += "<tr><td></td><td></td></tr>";
                                    retStr += "<tr><td style=\"font-size:12px\">eMail: </td><td style=\"font-size:12px\"><a href=\"mailto:" + sponsor.Email + "\" style=\"color:White\">" + sponsor.Email + "</a></td></tr>";
                                    retStr += "<tr><td style=\"font-size:12px\">Website: </td><td style=\"font-size:12px\"><a href=\"http://" + sponsor.link + "\" target=\"_blank\" style=\"color:White\">" + sponsor.link + "</a></td></tr>";
                                    retStr += "<tr height=\"20px\"><td></td><td></td></tr>";
                                    retStr += "<tr><td></td><td></td></tr>";
                                    retStr += "</table>";
                                    retStr += "</div>";
                                    retStr += "</div>";
                                    callback(retStr);
                                }, null);
                        }, null);
                }
                catch (Exception oe)
                {
                    callback(oe.ToString());
                }
            }
        }

        public void getRaceResults(string rTrack, Action<List<POHWS.webservice.UpcomingRaces>> callback)
        {
            var tableData = new List<POHWS.webservice.UpcomingRaces>();
            if (checkForNetwork() != true)
            {
                tableData.Add(new POHWS.webservice.UpcomingRaces() { PostTime = NETFAULT });
                callback(tableData);
            }
            else
            {
                POHWS.webservice.Service1 Service3 = new POHWS.webservice.Service1();
                try
                {
                    Service3.BeginGetResultsListV2(rTrack, delegate(IAsyncResult iar)
                        {
                            tableData = Service3.EndGetResultsListV2(iar).ToList();
                            callback(tableData);
                        }, null);
                }
                catch (Exception oe)
                {
                    tableData.Add(new POHWS.webservice.UpcomingRaces() { PostTime = oe.ToString() });
                    callback(tableData);
                }
            }
        }

        public void featuredLists(string featType, Action<List<POHWS.webservice.FeatureInfo>> callback)
        {
            var feats = new List<POHWS.webservice.FeatureInfo>();
            if (checkForNetwork() != true)
            {
                feats.Add(new POHWS.webservice.FeatureInfo() { FirstName = NETFAULT });
                callback(feats);
            }
            else
            {
                POHWS.webservice.Service1 Service4 = new POHWS.webservice.Service1();
                Service4.BeginGetFeatured(Convert.ToInt16(featType), delegate(IAsyncResult iar1)
                    {
                        feats = Service4.EndGetFeatured(iar1).ToList();
                        callback(feats);
                    }, null);
            }
        }

        public void displayTracks(string track, Context c, Action<string> callback)
        {
            if (checkForNetwork() != true)
            {
                callback(NETFAULT);
            }
            else
            {
                POHWS.webservice.Service1 Service3 = new POHWS.webservice.Service1();
                string retStr = "";
                Service3.BeginGetTrack(track, delegate(IAsyncResult iar)
                    {
                        POHWS.webservice.Track tableData = Service3.EndGetTrack(iar);
#if DEBUG
                        Console.WriteLine("in displayTracks : track = {0}, tableData.Content = {1}.", track, tableData.Content);
#endif
                        Android.App.Application.SynchronizationContext.Post(delegate
                            {
                                string uri = "StyleSheet.css";
                                string settings = string.Empty;

                                var input = c.Assets.Open(uri);
                                using (StreamReader sr = new System.IO.StreamReader(input))
                                {
                                    settings = sr.ReadToEnd();
                                }

                                string CSS = "<html><head><style>" + settings + "</style></head><body style='height:600px;background: url(file:///android_asset/Back_AQHA.png)' >";
                                retStr = CSS + tableData.Content + "</body></html>";
                                callback(retStr);
                            }, null);
                    }, null);
            }
        }

        private string FormatMoney(string moneystr)
        {
            decimal purseAmount = 0.00m;
            try
            {
                purseAmount = decimal.Parse(moneystr);
                moneystr = String.Format("{0:C}", purseAmount);
            }
            catch (Exception oe)
            {
                return oe.ToString();
            }

            return moneystr;
        }

        private string FinishPosition(string finalPosition, string postIndicator)
        {
            return (finalPosition == postIndicator && (postIndicator == "1" || postIndicator == "2" || postIndicator == "3")) ? "Y" : "N";
        }

        private string CheckDate(string dt)
        {
            return dt.Trim().Length == 1 ? "0" + dt : dt;
        }

        public void raceResults(string track, Action<List<POHWS.webservice.UpcomingRaces>> callback)
        {
            var tableData = new List<POHWS.webservice.UpcomingRaces>();
            if (checkForNetwork() != true)
            {
                tableData.Add(new POHWS.webservice.UpcomingRaces() { PostTime = NETFAULT });
                callback(tableData);
            }
            else
            {
                POHWS.webservice.Service1 Service3 = new POHWS.webservice.Service1();
                try
                {
                    Service3.BeginGetResultsListV2(track, delegate(IAsyncResult iar)
                        {
                            tableData = Service3.EndGetResultsListV2(iar).ToList();
                            callback(tableData);
                        }, null);
                }
                catch (Exception oe)
                {
                    tableData.Add(new POHWS.webservice.UpcomingRaces() { PostTime = oe.ToString() });
                    callback(tableData);
                }
            }
        }

        public void raceResultsDetail(string dateStr, string raceNumber, string track, Action<string> callback)
        {
            string retStr = "";
            if (checkForNetwork() != true)
            {
                callback(NETFAULT);
            }
            else
            {
                DateTime dt = DateTime.Parse(dateStr);
                string eqbString = "http://www.equibase.com/static/chart/pdf/";
                string eqDate = CheckDate(dt.Month.ToString()) + CheckDate(dt.Day.ToString()) + dt.Year.ToString().Substring(2);
                dateStr = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
#if DEBUG
                Console.WriteLine("dateStr = {0}, raceNumber = {1}, track = {2}", dateStr, raceNumber, track);
#endif

                POHWS.webservice.Service1 Service3 = new POHWS.webservice.Service1();

                try
                {
                    Service3.BeginGetRaceResultsEntriesFromEQ("RP", dateStr, raceNumber, "D", delegate(IAsyncResult iar)
                        {
                            List<POHWS.webservice.RaceResults> rs = Service3.EndGetRaceResultsEntriesFromEQ(iar).ToList();
                            Android.App.Application.SynchronizationContext.Post(delegate
                                {
                                    eqbString += rs[0].track.Trim() + eqDate + "USA" + raceNumber.Trim() + ".pdf";
                                    retStr = "<html><body>";
                                    retStr += "<div style=\"background-color:#001d2a; position:absolute; width:100%; top: 0px; left: 0px; background-position: center top; background-repeat: no-repeat; background-size: cover; \">";
                                    retStr += "<div id=\"Div3\" runat=\"server\" align=\"right\">";
                                    retStr += "<a href=\"" + eqbString + "\"><img src=\"file:///android_asset/eqbpower.png\" /></a>";
                                    retStr += "</div>";
                                    retStr += "<div id=\"ResultsInfo\" runat=\"server\" class=\"ResultsOtherNew\">";
                                    retStr += "<b>Race Number</b>";
                                    retStr += "&nbsp;-" + rs[0].number;
                                    retStr += "&nbsp;<b>Track Name</b>";
                                    retStr += "&nbsp;-" + track;
                                    retStr += "<br><b>Race Date</b> -" + rs[0].date.month + "/" + rs[0].date.day + "/" + rs[0].date.year;
                                    retStr += "<br />";
                                    if (rs[0].name.Trim() != "")
                                    {
                                        retStr += "<br />";
                                        retStr += "<b>Race Name:</b> " + rs[0].name;
                                        retStr += "<br />";
                                    }
                                    retStr += "<b>Race Type:</b> " + rs[0].type;
                                    retStr += "<br />";
                                    retStr += "<B>Purse:</b> $" + FormatMoney(rs[0].purse);
                                    retStr += "<br />";
                                    retStr += "<b>Distance:</b> " + rs[0].distance;
                                    retStr += "<br />";
                                    retStr += "</div>";
                                    retStr += "<div id=\"ResultsWinners\" runat=\"server\">";
                                    retStr += "<table width=\"100%\" cellpadding=\"0px\" cellspacing=\"0px\">";
                                    retStr += "<tr class=\"ResultsHeadline\" valign=\"bottom\">";
                                    retStr += "<td>Pgmr</td>";
                                    retStr += "<td>Horse</td>";
                                    retStr += "<td>Win</td>";
                                    retStr += "<td>Place</td>";
                                    retStr += "<td>Show</td>";
                                    retStr += "</tr>";

                                    for (int i = 0; i < rs[0].starters.Length; i++)
                                    {
                                        retStr += "<tr class=\"ResultsNew\" valign=\"top\">";
                                        retStr += "<td>" + rs[0].starters[i].programNumber + "</td>";
                                        retStr += "<td>";
                                        retStr += "<b>" + rs[0].starters[i].Horse.name + "</b>";
                                        retStr += "<br />";
                                        retStr += rs[0].starters[i].Jockey.firstName + " " + rs[0].starters[i].Jockey.lastName;
                                        retStr += "<br />";
                                        retStr += rs[0].starters[i].Owner.firstName + " " + rs[0].starters[i].Owner.lastName;
                                        retStr += "<br />";
                                        retStr += "T:" + rs[0].starters[i].Trainer.firstName + " " + rs[0].starters[i].Trainer.lastName;
                                        retStr += "</td>";

                                        retStr += "<td align=\"center\">" + FinishPosition(rs[0].starters[i].finishPosition, "1");//finishPosition
                                        retStr += "<td align=\"center\">" + FinishPosition(rs[0].starters[i].finishPosition, "2");
                                        retStr += "<td align=\"center\">" + FinishPosition(rs[0].starters[i].finishPosition, "3");
                                        retStr += "</tr>";
                                    }
                                    retStr += "<tr align=\"center\"><td colspan=5>&nbsp;</td></tr>";
                                    retStr += "<tr align=\"center\"><td colspan=5 class=\"ResultsNew\" align=\"center\"><a href=\"" + eqbString + "\">Tap Here For More Details</a></td><tr>";
                                    retStr += "</table>";
                                    retStr += "</div>";

                                    retStr += "<div id=\"ResultsWagers\" class=\"ResultsNew\" runat=\"server\">";
                                    retStr += "<table>";
                                    retStr += "<tr>";
                                    retStr += "<td class=\"ResultsNew\" >Wager Type</td>";
                                    retStr += "<td class=\"ResultsNew\" >Winning Numbers</td>";
                                    retStr += "<td class=\"ResultsNew\" >Payoff</td>";
                                    retStr += "<td class=\"ResultsNew\" >Number Right</td>";
                                    retStr += "</tr>";

                                    for (int i = 0; i < rs[0].exoticPayoffs.Length; i++)
                                    {
                                        retStr += "<tr>";
                                        retStr += "<td class=\"ResultsNew\" >" + rs[0].exoticPayoffs[i].name + "</td>";
                                        retStr += "<td class=\"ResultsNew\" >" + rs[0].exoticPayoffs[i].winningNumbers + "</td>";
                                        retStr += "<td class=\"ResultsNew\" >" + FormatMoney(rs[0].exoticPayoffs[i].payoffAmount.ToString()) + "</td>"; //+ FormatMoney(.ToString()) + "</td>"; //PayoffAmount
                                        retStr += "<td class=\"ResultsNew\" >" + rs[0].exoticPayoffs[i].numberOfRights + "</td>";
                                        retStr += "</tr>";
                                        retStr += "</tr>";
                                    }

                                    retStr += "</table>";
                                    retStr += "</div></div></body></html>";
                                    callback(retStr);
                                }, null);
                        }, null);
                }
                catch (Exception oe)
                {
                    callback(oe.ToString());
                }
            }
        }

        /*public void raceResultsSession(string dateStr, Action<List<POHWS.webservice.RaceResults>> callback)
        {
            var tableData = new List<POHWS.webservice.RaceResults>();

            if (checkForNetwork() != true)
            {
                tableData[0].name = "No network available";
                callback(tableData);
            }
            else
            {
                POHWS.webservice.Service1 Service3 = new POHWS.webservice.Service1();
                try
                {
                    Service3.BeginGetRacesResultsFromEQ("RP", dateStr, delegate(IAsyncResult iar)
                    {
                        tableData = Service3.EndGetRacesResultsFromEQ(iar).ToList();
                        callback(tableData);
                    }, null);
                }
                catch (Exception oe)
                {
                    tableData[0].name = oe.ToString();
                    callback (tableData);
                }
            }
        }*/

        public void tipSheet(Context c, Action<string> callback)
        {
            string retStr = "";
#if DEBUG
            Console.WriteLine("Context passed = {0}", c);
#endif
            if (checkForNetwork() != true)
            {
                callback(NETFAULT);
            }
            else
            {
                POHWS.webservice.Service1 Service4 = new POHWS.webservice.Service1();
                Service4.BeginGetTipSheets(delegate(IAsyncResult iar1)
                    {
                        string spon = Service4.EndGetTipSheets(iar1);
                        Android.App.Application.SynchronizationContext.Post(delegate
                            {
                                string uri = "StyleSheet.css";
                                string settings = string.Empty;
                                var input = c.Assets.Open(uri);
                                using (StreamReader sr = new System.IO.StreamReader(input))
                                {
                                    settings = sr.ReadToEnd();
                                }

                                string CSS = "<html><head><style>" + settings + "</style></head><body style=\"background: url(file:///android_asset/Back-Markel.jpg);Height:1000px\">";
                                retStr = CSS + spon + "</body></html>";
                                callback(retStr);
                            }, null);
                    }, null);
            }
        }

        public void getVideoDates(string track, Action<List<POHWS.webservice.VideoDates>> callback)
        {
            var tableData = new List<POHWS.webservice.VideoDates>();
            if (checkForNetwork() != true)
            {
                tableData.Add(new POHWS.webservice.VideoDates() { raceTrack = NETFAULT });
                callback(tableData);
            }
            else
            {
                DateTime dt = DateTime.Now.AddDays(-7);
                string dateStr = dt.Year.ToString() + CheckDate(dt.Month.ToString()) + CheckDate(dt.Day.ToString());

                POHWS.webservice.Service1 OQHRAService = new POHWS.webservice.Service1();

                try
                {
                    POHWS.webservice.Service1 Service3 = new POHWS.webservice.Service1();
                    Service3.BeginGetVideosListNew(track, dateStr, delegate(IAsyncResult iar)
                        {
                            tableData = Service3.EndGetVideosListNew(iar).ToList();
                            callback(tableData);
                        }, null);
                }
                catch (Exception oe)
                {
                    tableData.Add(new POHWS.webservice.VideoDates() { raceTrack = oe.ToString() });
                    callback(tableData);
                }
            }
        }

        public void videoSessions(string dateStr, string track, Action<List<POHWS.webservice.Videos>> callback)
        {
            var tableData = new List<POHWS.webservice.Videos>();
            if (checkForNetwork() != true)
            {
                tableData.Add(new POHWS.webservice.Videos() { race = NETFAULT });
                callback(tableData);
            }
            else
            {
                DateTime dt = DateTime.Parse(dateStr);
                dateStr = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
                POHWS.webservice.Service1 Service3 = new POHWS.webservice.Service1();
                try
                {
                    Service3.BeginGetVideosWA(track, dateStr, delegate(IAsyncResult iar)
                        {
                            tableData = Service3.EndGetVideosWA(iar).ToList();
#if DEBUG
                            Console.WriteLine("videoSessions - track = {0}, tableData.Count = {1}", track, tableData.Count);
#endif
                            if (tableData.Count == 0)
                            {
                                tableData[0].race = "No videos";
                                callback(tableData);
                            }
                            callback(tableData);
                        }, null);
                }
                catch (Exception oe)
                {
                    tableData.Add(new POHWS.webservice.Videos() { race = oe.ToString() });
                    callback(tableData);
                }
            }
        }

        public void getFeaturedView(string id, Action<POHWS.webservice.ProfileStuff> callback)
        {
            POHWS.webservice.ProfileStuff ps = null;
            if (checkForNetwork() != true)
            {
                ps.FirstName = NETFAULT;
                callback(ps);
            }
            else
            {
                POHWS.webservice.Service1 Service4 = new POHWS.webservice.Service1();
                Service4.BeginGetProfile(Convert.ToInt16(id), delegate(IAsyncResult iar1)
                    {
                        ps = Service4.EndGetProfile(iar1);
                        callback(ps);
                    }, null);
            }
        }

        public void getOvernights(Context c, Action<string> callback)
        {
            string retStr = "";
            if (checkForNetwork() != true)
            {
                callback(NETFAULT);
            }
            else
            {
                try
                {
                    POHWS.webservice.Service1 Service4 = new POHWS.webservice.Service1();
                    Service4.BeginGetOvernights(delegate(IAsyncResult iar1)
                        {
                            string spon = Service4.EndGetOvernights(iar1);
                            Android.App.Application.SynchronizationContext.Post(delegate
                                {
                                    string uri = "StyleSheet.css";
                                    string settings = string.Empty;
                                    var input = c.Assets.Open(uri);
                                    using (StreamReader sr = new System.IO.StreamReader(input))
                                    {
                                        settings = sr.ReadToEnd();
                                    }
                                    string CSS = "<html><head><style type=\"text/css\">" + settings + "</style></head><body style=\"background: url(file:///android_asset/Back_Markel.png);Height:1000px\">";
                                    retStr = CSS + spon + "</body></html>";
#if DEBUG
                                    Console.WriteLine(retStr);
#endif
                                    callback(retStr);
                                }, null);
                        }, null);
                }
                catch (Exception oe)
                {
                    callback(oe.ToString());
                }
            }
        }
    }
}