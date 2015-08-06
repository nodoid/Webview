using System;
using System.Collections.Generic;
using System.IO;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using OQHRA2011;

namespace oqhra_android
{
    [Activity(Theme = "@style/Theme.Splash", NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            StartActivity(typeof(oqhra_android));
        }
    }

    [Activity(Label = "@string/appname", MainLauncher = true, Theme = "@android:style/Theme.NoTitleBar", Icon = "@drawable/launcher")]
    public partial class oqhra_android : Activity
    {
        private List<int> screen;
        private int addFactor;
        private double xAcross, xScale, yDown;
        private static string NETFAULT = "No network available";
        Database db;
        database_user dbu;

        private static double VERSION = 0.91;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.main_original);

            xAcross = WindowManager.DefaultDisplay.Width;
            xScale = (xAcross * 90) / 100;
            yDown = WindowManager.DefaultDisplay.Height;
            createEvents(1, false);
#if DEBUG
            Console.WriteLine("90% width = {0}, xAcross = {1}, height = {2}", Convert.ToInt32(xScale), xAcross, yDown);
#endif
            TextView title = FindViewById<TextView>(Resource.Id.textTitle);
            title.Text = Resources.GetString(Resource.String.MainTitle);
            screen = new List<int>();
            var external = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "OQHRA");
            if (!File.Exists(/*dir*/ external))
            {
                System.IO.Directory.CreateDirectory(/*dir*/ external);
            }
            var dest = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "OQHRA2011.db");
            if (!File.Exists(dest))
            {
                using (var readDB = Assets.Open("OQHRA2011.db"))
                using (var writeDB = File.Create(dest))
                    readDB.CopyTo(writeDB);
            }
            db = new Database(dest);
            dbu = new database_user(db);
            screen.Add(0);
            addFactor = 0;
        }

        private void createEvents(int a, bool init = true)
        {
#if DEBUG
            Console.WriteLine("In createEvent xs = {0}, a = {1}, init = {2}", xScale, a, init);
#endif            
            if (a == 1)
            {
                ListView listView = FindViewById<ListView>(Resource.Id.listView);
                listView.LayoutParameters.Width = Convert.ToInt32(xScale);
                listView.RequestLayout();
                if (init == false)
                {
                    string[] falco = Resources.GetStringArray(Resource.Array.frontpage);
                    listView.Adapter = new ArrayAdapter<string>(this, Resource.Layout.listview_layout, falco);
                }
                listView.ItemClick += new EventHandler<AdapterView.ItemClickEventArgs>(listView_ItemClick);
                listView.Divider = null;
            }
            ImageView image = FindViewById<ImageView>(Resource.Id.imgBack);
            image.Focusable = true;
            image.Clickable = true;
            if (init != true)
            {
                image.Click += image_Click;
                image.Visibility = ViewStates.Invisible;
            }
            else
                image.Click += image_Click2;
        }

        private void vtList(Context c)
        {
            TextView text = FindViewById<TextView>(Resource.Id.textTitle);
            ListView listView = FindViewById<ListView>(Resource.Id.listView);
            listView.SetMinimumWidth(Convert.ToInt32(xScale));
            createEvents(3);
            int f = 0;
            string track = "";
#if DEBUG
            Console.WriteLine("vtList - text.Text = {0}", text.Text);
#endif
            if (text.Text == Resources.GetString(Resource.String.RP))
            {
                f = Resource.String.RP;
                track = "RED";
            }
            if (text.Text == Resources.GetString(Resource.String.FM))
            {
                f = Resource.String.FM;
                track = "FMT";
            }
            if (text.Text == Resources.GetString(Resource.String.WR))
            {
                track = "WRD";
                f = Resource.String.WR;
            }
#if DEBUG
            Console.WriteLine("track = {0}", track);
#endif
            string[] races = listviewInfo(Resource.Array.RaceTracks, Resource.Drawable.back_racehorseplace, f);
            ProgressDialog dp4 = ProgressDialog.Show(c, "Please wait", "Loading videos list", true);
            List<POHWS.webservice.VideoDates> vtDates = new List<POHWS.webservice.VideoDates>();
            webservice_user getVideos = new webservice_user();
            //bool k = false;
            getVideos.getVideoDates(track, res =>
                {
                    RunOnUiThread(delegate
                        {
                            vtDates = res;
                            dp4.Dismiss();
                            if (vtDates[0].raceTrack == NETFAULT)
                            {
                                toasty(NETFAULT);
                                //k = true;
                            }
                            else
                                generateTwoLine(listView, vtDates, c);
                        });
                });
            //if (k == false)
            //    addFactor = 140;
        }

        /*private void videoList(object s, EventArgs e)
        private void videoList(Context c)
        {
            vtList(c);
        }*/

        private void image_Click(object s, EventArgs e)
        {
#if DEBUG
            Console.WriteLine("image_Click : screen count = {0}", screen.Count);
#endif
            if (screen.Count == 0)
                return;
            backScreen();
        }

        private void image_Click2(object s, EventArgs e)
        {
#if DEBUG
            Console.WriteLine("image_Click2 : screen count = {0}", screen.Count);
#endif
            SetContentView(Resource.Layout.main_original);
            createEvents(1, false);
            if (screen.Count == 0)
                return;
            backScreen();
        }

        private void backScreen()
        {
            string[] races = Resources.GetStringArray(Resource.Array.frontpage);
            ListView listView = FindViewById<ListView>(Resource.Id.listView);
            listView.SetMinimumWidth(Convert.ToInt32(xScale));
            View currentview = FindViewById<View>(Resource.Id.relLayout);
            TextView text = FindViewById<TextView>(Resource.Id.textTitle);
            listView.Adapter = new ArrayAdapter<string>(this, Resource.Layout.listview_layout, races);
            currentview.SetBackgroundDrawable(Resources.GetDrawable(Resource.Drawable.back_home));
            text.Text = Resources.GetString(Resource.String.MainTitle);
#if DEBUG
            Console.WriteLine("In backScreen : click tracker");
            Console.WriteLine("Screen.Count = {0}", screen.Count);
            foreach (int r in screen)
                Console.WriteLine("{0}, ", r);
#endif
            if (screen.Count >= 1)
            {
                addFactor = screen[screen.Count - 1];
                listView.ItemClick += new EventHandler<AdapterView.ItemClickEventArgs>(listView_ItemClick);
                screen.RemoveAt(screen.Count - 1);
                if (vienna == true)
                    vienna = false;
                if (screen[screen.Count - 1] == -1)
                {
                    ImageView image = FindViewById<ImageView>(Resource.Id.imgBack);
                    image.Visibility = ViewStates.Invisible;
                }
                else
                    generateNewScreen(addFactor != 0 ? addFactor : 0);
            }
            else
            {
                ImageView image = FindViewById<ImageView>(Resource.Id.imgBack);
                image.Visibility = ViewStates.Invisible;
            }
        }

        private void listView_ItemClick(object s, AdapterView.ItemClickEventArgs e)
        {
            int t = (int)e.Id;
#if DEBUG
            Console.WriteLine("in listview_itemclick - t = {0}, screen.Count = {1}", t, screen.Count);
#endif
            screen.Add(t);
            generateNewScreen(t);
        }

        private void toasty(string s)
        {
            View currentview = FindViewById<View>(Resource.Id.relLayout);
            Context c = currentview.Context;
            modal m = new modal();
            m.showAlertDialog(c, s);
        }

        private string[] listviewInfo(int raceData, int image, int data)
        {
            string[] races = new string[] { };
            View currentview = FindViewById<View>(Resource.Id.relLayout);
            TextView text = FindViewById<TextView>(Resource.Id.textTitle);
            races = Resources.GetStringArray(raceData);
            currentview.SetBackgroundDrawable(Resources.GetDrawable(image));
            if (data != 0)
                text.Text = Resources.GetString(data);
            return races;
        }

        private void doProgress(Context c)
        {
            ProgressDialog dp = ProgressDialog.Show(c, "Please wait", "Loading", true);
        }

        private string rDate, raceNumber, vDate, vTrack, vRace;
        private int noRaces, vtChoice;

        private void generateTwoLine(ListView v, List<POHWS.webservice.UpcomingRaces> races, bool genEvents = false)
        {
            List<string> f = new List<string>();
            noRaces = races.Count;
#if DEBUG
            Console.WriteLine("noRaces = {0}", noRaces);
#endif
            for (int i = 0; i < races.Count; ++i)
                f.Add(races[i].PostTime + "\n" + races[i].RaceCount + " races");
            v.Adapter = new ArrayAdapter<string>(this, Resource.Layout.listview_layout, f.ToArray());
            if (genEvents == true)
            {
                v.ItemClick -= listView_ItemClick;
                v.ItemClick += new EventHandler<AdapterView.ItemClickEventArgs>(itemClick_GetDates);
            }
        }

        private void generateTwoLine(ListView v, List<POHWS.webservice.VideoDates> dates, Context c)
        {
            List<string> f = new List<string>();
#if DEBUG
            Console.WriteLine("noRaces = {0}, track = {1}", noRaces, dates[0].raceTrack);
#endif
            string trackName = "";
            switch (dates[0].raceTrack)
            {
                case "RP":
                case "RED":
                case "REM":
                    trackName = "Remington Park";
                    vTrack = "RED";
                    break;
                case "WRD":
                case "WD":
                    trackName = "Will Rogers Down";
                    vTrack = "WRD";
                    break;
                case "FM":
                case "FMT":
                    trackName = "Fair Meadows Tulsa";
                    vTrack = "FMT";
                    break;
            }
#if DEBUG
            Console.WriteLine("trackName = {0}, dates[0].raceTrack = {1}", trackName, dates[0].raceTrack);
#endif
            char[] delim = new char[] { ' ' };
            for (int i = 0; i < dates.Count; ++i)
            {
                string[] dt = dates[i].raceDate.Split(delim);
                f.Add(dt[0] + "\n" + trackName);
            }
            v.Adapter = new ArrayAdapter<string>(this, Resource.Layout.listview_layout, f.ToArray());
            v.ItemClick -= listView_ItemClick;
            v.ItemClick += delegate(object s, AdapterView.ItemClickEventArgs e)
            {
                videoRaceNumber(s, e, v, dates, c);
            };
        }

        private void videoRaceNumber(object s, AdapterView.ItemClickEventArgs e, ListView v, List<POHWS.webservice.VideoDates> dates, Context c)
        {
            string selected = (v.GetItemAtPosition(e.Position)).ToString();
#if DEBUG
            Console.WriteLine("videoRaceNumber - selected = {0}", selected);
#endif
            List<string> t = new List<string>();
            char[] delim = new char[] { '\n' };
            string[] dt = selected.Split(delim);
            for (int i = 0; i < dates.Count; ++i)
                t.Add(dt[0] + "\n" + "Race " + (i + 1).ToString());
            v.Adapter = new ArrayAdapter<string>(this, Resource.Layout.listview_layout, t.ToArray());
            v.ItemClick -= delegate(object ss, AdapterView.ItemClickEventArgs ee)
            {
                videoRaceNumber(ss, ee, v, dates, c);
            };
            v.ItemClick += delegate(object so, AdapterView.ItemClickEventArgs ev)
            {
                videoChoice(so, ev, c);
            };
        }

        private void itemClick_GetDates(object s, AdapterView.ItemClickEventArgs e)
        {
            ListView v = (ListView)s;
            string text = (v.GetItemAtPosition(e.Position)).ToString();
            char[] delimiters = new char[] { '\n' };
            string[] getInfo = text.Split(delimiters);
            rDate = getInfo[0];
#if DEBUG
            Console.WriteLine("Date returned {0}", rDate);
#endif
            createResults2(v, e);
        }

        private void videoChoice(object s, AdapterView.ItemClickEventArgs e, Context c)
        {
            ListView v = (ListView)s;
            string text = (v.GetItemAtPosition(e.Position)).ToString();
            vtChoice = (int)e.Id;
            char[] delimiters = new char[] { '\n' };
            string[] getInfo = text.Split(delimiters);
            vDate = getInfo[0];
            vRace = getInfo[1];
#if DEBUG
            Console.WriteLine("getVideoChoice - vTrack = {0}, vDate = {1}, vRace = {2}", vTrack, vDate, vRace);
#endif
            v.ItemClick -= delegate(object ss, AdapterView.ItemClickEventArgs ee)
            {
                videoChoice(ss, ee, c);
            };
            v.ItemClick += listView_ItemClick;
            getVideos(c);
        }

        private void createResults2(ListView v, AdapterView.ItemClickEventArgs e)
        {
            List<string> f = new List<string>();
            for (int i = 0; i < noRaces; ++i)
                f.Add(rDate + "\n" + "Race " + (i + 1).ToString());
            v.Adapter = new ArrayAdapter<string>(this, Resource.Layout.listview_layout, f.ToArray());
            v.ItemClick -= itemClick_GetDates;
            string text = (v.GetItemAtPosition(e.Position)).ToString();
            char[] delimiters = new char[] { '\n' };
            string[] getInfo = text.Split(delimiters);
            rDate = getInfo[0];
            string[] race = getInfo[1].Split(' ');
            raceNumber = race[1];
#if DEBUG
            Console.WriteLine("rdate = {0}, raceNumber = {1}", rDate, raceNumber);
#endif
            v.ItemClick += new EventHandler<AdapterView.ItemClickEventArgs>(listView_ItemClick);
        }

        private void getUpcomingRaces(ListView listView, Context c, string track)
        {
            List<POHWS.webservice.UpcomingRaces> race = new List<POHWS.webservice.UpcomingRaces>();
            ProgressDialog dp = ProgressDialog.Show(c, "Please wait", "Loading upcoming races", true);
            webservice_user getRace = new webservice_user();
            getRace.getUpcomingRacesCallBack("RP", res =>
                {
                    RunOnUiThread(delegate
                        {
                            race = res;
                            dp.Dismiss();
                            if (race[0].PostTime == NETFAULT)
                                toasty(NETFAULT);
                            else
                                generateTwoLine(listView, race);
                        });
                });
        }

        private void getResults(ListView listView, Context c, string track)
        {
            List<POHWS.webservice.UpcomingRaces> race2 = new List<POHWS.webservice.UpcomingRaces>();
            ProgressDialog dp2 = ProgressDialog.Show(c, "Please wait", "Loading race results", true);
            webservice_user getResults = new webservice_user();
            getResults.raceResults("RP", res =>
                {
                    RunOnUiThread(delegate
                        {
                            race2 = res;
                            dp2.Dismiss();
                            if (race2[0].PostTime == NETFAULT)
                                toasty(NETFAULT);
                            else
                                generateTwoLine(listView, race2, res[0].PostTime == "No Upcoming Races Found within the next 7 days" ? false : true);
                        });
                });
        }

        private void getVideos(Context c)
        {
            ProgressDialog dp5 = ProgressDialog.Show(c, "Please wait", "Loading video information", true);
            List<POHWS.webservice.Videos> vtInfo = new List<POHWS.webservice.Videos>();
            webservice_user getVideoSessions = new webservice_user();
            getVideoSessions.videoSessions(vDate, vTrack, res =>
                {
                    RunOnUiThread(delegate
                        {
                            vtInfo = res;
                            dp5.Dismiss();
                            if (vtInfo.Count != 0)
                            {
#if DEBUG
                                Console.WriteLine("getVideos - modulename = {0}", vtInfo[vtChoice].mobilefilename);
#endif
                                Intent intent = new Intent();
                                intent.SetClass(this, typeof(videoplayer));
                                intent.PutExtra("url", vtInfo[vtChoice].mobilefilename);
                                intent.PutExtra("xSize", Convert.ToInt32(xAcross));
                                intent.PutExtra("ySize", Convert.ToInt32(yDown));
                                intent.AddFlags(ActivityFlags.NewTask);
                                StartActivity(intent);
                            }
                            else
                                toasty("No videos returned");
                        });
                });
        }

        private void resizeListView(ListView v)
        {
            v.SetMinimumWidth(Convert.ToInt32(xScale));
        }

        private void resizeWebView(WebView v)
        {
            v.SetMinimumWidth(Convert.ToInt32(xScale));
        }

        private void resizeButtons(List<Button> btn)
        {
            foreach (Button b in btn)
                b.SetMinimumWidth(Convert.ToInt32(xAcross / btn.Count));
        }

        bool vienna = false, amadeus = true;

        private void generateNewScreen(int t)
        {
            string[] races = new string[] { };
            View currentview = FindViewById<View>(Resource.Id.relLayout);
            Context c = currentview.Context;
            TextView text = FindViewById<TextView>(Resource.Id.textTitle);
            ListView listView = FindViewById<ListView>(Resource.Id.listView);
            resizeListView(listView);
            ImageView image = FindViewById<ImageView>(Resource.Id.imgBack);
            image.Visibility = ViewStates.Visible;
            webservice_webview wu = new webservice_webview();
            webservice_user wsu = new webservice_user();
#if DEBUG
            Console.WriteLine("generate new screen  - t = {0}, addFactor = {1}", t, addFactor);
#endif
            switch (addFactor)
            {
                case 0:
                    switch (t)
                    {
                        case 0:
                            races = listviewInfo(Resource.Array.RaceTracks, Resource.Drawable.back_racehorseplace, Resource.String.Tracks);
                            vienna = true;
                            addFactor = 50;
                            break;
                        case 1:
                            currentview.SetBackgroundDrawable(Resources.GetDrawable(Resource.Drawable.back_bobmoore));
                            text.Text = Resources.GetString(Resource.String.ComingSoon);
                            addFactor = 0;
                            getUpcomingRaces(listView, c, "RP");
                            break;
                        case 2:
                            currentview.SetBackgroundDrawable(Resources.GetDrawable(Resource.Drawable.back_bobmoore));
                            text.Text = Resources.GetString(Resource.String.RaceRes);
                            getResults(listView, c, "RP");
                            addFactor = 30;
                            break;
                        case 3:
                            races = listviewInfo(Resource.Array.horsemen, Resource.Drawable.back_markel, Resource.String.ForHorse);
                            addFactor = 40;
                            break;
                        case 4:
                            races = listviewInfo(Resource.Array.RaceTracks, Resource.Drawable.back_lazye, Resource.String.vids);
                            addFactor = 50;
                            break;
                        case 5:
                            races = listviewInfo(Resource.Array.currentstandings, Resource.Drawable.back_markel, Resource.String.standings);
                            addFactor = 60;
                            break;
                        case 6:
                            SetContentView(Resource.Layout.threebuttons);
                            View cview = FindViewById<View>(Resource.Id.relLayout);
                            Context cv = currentview.Context;
                            text = FindViewById<TextView>(Resource.Id.textTitle);
                            text.Text = Resources.GetString(Resource.String.ChooseBetTitle);
                            string racer = Resources.GetString(Resource.String.cbintro);
                            toasty(racer);
                            createEvents(3);
                            addFactor = 0;
                            Button tb1 = FindViewById<Button>(Resource.Id.btnCalculate);
                            tb1.Click += (object s, EventArgs e) =>
                            {
                                startBetting();
                            };
                            Button tb2 = FindViewById<Button>(Resource.Id.btnExplore);
                            Button tb3 = FindViewById<Button>(Resource.Id.btnTipSheet);
                            List<Button> btn = new List<Button>();
                            btn.AddRange(new Button[] { tb1, tb2, tb3 });
                            resizeButtons(btn);
#if DEBUG
                            Console.WriteLine("In three buttons");
#endif
                            string r = "";
                            tb2.Click += (object o, EventArgs e) =>
                            {
                                amadeus = false;
                            };
                            tb3.Click += (object o, EventArgs e) =>
                            {
                                amadeus = false;
#if DEBUG
                                Console.WriteLine("Tipsheet");
#endif
                                ProgressDialog dp5 = ProgressDialog.Show(c, "Please wait", "Obtaining tip sheet", true);
                                wsu.tipSheet(cv, res =>
                                    {
                                        r = res;
                                        dp5.Dismiss();
                                        if (r != "")
                                        {
                                            Intent i = new Intent(this, typeof(webservice_webview));
                                            i.PutExtra("content", r);
                                            StartActivity(i);
                                        }
                                        else
                                            toasty("No tips available");
                                    });
                            };
                            if (amadeus == true)
                                startBetting();
                            break;
                        case 7:
                            races = listviewInfo(Resource.Array.rprofs, Resource.Drawable.back_yearsley, Resource.String.profiles);
                            addFactor = 80;
                            break;
                        case 8:
                            Intent ir = new Intent(this, typeof(websiteview));
                            ir.PutExtra("url", "http://www.oqhra.com");
                            StartActivity(ir);
                            addFactor = 0;
                            break;
                        case 9:
                        case 10:
                            addFactor = 0;
                            races = listviewInfo(Resource.Array.shopatt, Resource.Drawable.back_business, (t == 9 ? Resource.String.shopping : Resource.String.dining));
                            listView.Adapter = new ArrayAdapter<string>(this, Resource.Layout.advert_layout, races);
                            break;
                    }
                    if (t == 0 || (t > 2 && t < 6) || t == 7)
                        listView.Adapter = new ArrayAdapter<string>(this, Resource.Layout.listview_layout, races);
                    break;
            /*case 10:
                    SetContentView(Resource.Layout.fourbuttons);
                    text = FindViewById<TextView>(Resource.Id.textTitle);
                    createEvents(3);
                    addFactor = 100;
                    switch (t)
                    {
                        case 0: text.Text = Resources.GetString(Resource.String.RP);
                            break;
                        case 1: text.Text = Resources.GetString(Resource.String.FM);
                            break;
                        case 2: text.Text = Resources.GetString(Resource.String.WR);
                            break;
                    }
                    break;
                case 20: addFactor = 0;
                    break;*/
                case 30:
                    string race3 = "";
                    text.Text = Resources.GetString(Resource.String.RaceRes);
#if DEBUG
                    Console.WriteLine("rDate = {0}, raceNumber = {1}", rDate, raceNumber);
#endif
                    ProgressDialog dp3 = ProgressDialog.Show(c, "Please wait", "Loading final results", true);
                    RunOnUiThread(delegate
                        {
                            dp3.Dismiss();
                            wsu.raceResultsDetail(rDate, raceNumber, "RP", res =>
                                {
                                    race3 = res;
#if DEBUG
                                    Console.WriteLine("returned = {0}", race3);
#endif
                                    if (race3.Length > 0 && race3 != NETFAULT)
                                    {
                                        Intent intent = new Intent(this, typeof(webservice_webview));
                                        intent.PutExtra("content", race3);
                                        StartActivity(intent);
                                    }
                                    else
                                        toasty(NETFAULT);
                                });
                        });
                    addFactor = 0;
                    break;
                case 40:
                    switch (t)
                    {
                        case 0: 
                            SetContentView(Resource.Layout.speedindex);
                            createEvents(3);
                            text = FindViewById<TextView>(Resource.Id.textTitle);
                            text.Text = Resources.GetString(Resource.String.speedind);
                            Spinner spinner = FindViewById<Spinner>(Resource.Id.spinnerSelDist);
                            spinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(distSpinner_Select);
                            var adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.racedistance, Android.Resource.Layout.SimpleSpinnerItem);
                            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
                            spinner.Adapter = adapter;
                            break;
                        case 1:
                            string race5 = "";
                            text.Text = Resources.GetString(Resource.String.RaceRes);
                            ProgressDialog dp5 = ProgressDialog.Show(c, "Please wait", "Loading overnights", true);
                            RunOnUiThread(delegate
                                {
                                    dp5.Dismiss();
                                    wsu.getOvernights(this, res =>
                                        {
                                            race5 = res;
                                            if (race5.Length > 0 && race5 != NETFAULT)
                                            {
                                                Intent intent = new Intent(this, typeof(webservice_webview));
                                                intent.PutExtra("content", race5);
                                                StartActivity(intent);
                                            }
                                            else
                                                toasty(NETFAULT);
                                        });
                                });
                            break;
                        case 2:
                            List<SavedRunsList> srl = new List<SavedRunsList>();
                            SetContentView(Resource.Layout.five_buttons);
                            createEvents(3);
                            text.Text = Resources.GetString(Resource.String.savedruns);
                            ProgressDialog dp6 = ProgressDialog.Show(c, "Please wait", "Loading saved runs", true);
                            RunOnUiThread(delegate
                                {
                                    dp6.Dismiss();
                                    dbu.getSavedRuns(db, res =>
                                        {
                                            srl = res;
                                            if (srl.Count > 0)
                                                wu.GetSavedHTMLScreen(srl);
                                            else
                                                toasty("No saved races");
                                        });
                                });
                            break;
                        case 3: 
                            SetContentView(Resource.Layout.five_buttons);
                            createEvents(3);
                            addFactor = 0;
                            break;
                        case 4: 
                            Intent ir1 = new Intent(this, typeof(websiteview));
                            ir1.PutExtra("url", "http://mobile.oqhra.com/standings/Standings.html");
                            StartActivity(ir1);
                            break;
                        case 5: 
                            wu.grabAFile("http://www.oqhra.com/conditions/index.pdf", c);
                            break;
                        case 6: 
                            wu.grabAFile("http://www.oqhra.com/conditions/cb.pdf", c);
                            break;
                    }
                    break;
                case 50:
#if DEBUG
                    Console.WriteLine("addFilter = {0}, t = {1}, vienna = {2}", addFactor, t, vienna.ToString());
#endif
                    SetContentView(Resource.Layout.fourbuttons);
                    createEvents(3);
                    WebView wv = FindViewById<WebView>(Resource.Id.webviewInfo);
                    listView = FindViewById<ListView>(Resource.Id.listView);

                    if (vienna == false)
                    {
                        listView.Visibility = ViewStates.Visible;
                        wv.Visibility = ViewStates.Invisible;
                    }
                    else
                    {
                        listView.Visibility = ViewStates.Invisible;
                        wv.Visibility = ViewStates.Visible;
                    }
                    resizeWebView(wv);
                    resizeListView(listView);
                    text = FindViewById<TextView>(Resource.Id.textTitle);
                    string trackShort = "", tr = "";

                    //addFactor = 140;
#if DEBUG
                    Console.WriteLine("case 50 : t = {0}", t);
#endif
                    if (t == 0)
                    {
                        text.Text = "Remington Park";
                        trackShort = "RP";
                    }
                    else if (t == 1)
                    {
                        text.Text = "Fair Meadows";
                        trackShort = "FMT";
                    }
                    else if (t == 2)
                    {
                        text.Text = "Will Rogers Downs";
                        trackShort = "WRD";
                    }
#if DEBUG
                    Console.WriteLine("Trackshort = {0}", trackShort);
#endif
                    if (vienna == true)
                    {
                        RunOnUiThread(delegate
                            {
                                wsu.displayTracks(trackShort, c, res =>
                                    {
                                        tr = res;
                                        if (tr.Length > 0)
                                        {
                                            wu.loadIntoWebview(wv, tr);
                                        }
                                    });
                            });
                    }
                    Button fb1 = FindViewById<Button>(Resource.Id.btnInfo);
                    fb1.Click += (object s, EventArgs e) =>
                    {
                        if (wv.Visibility == ViewStates.Invisible)
                        {
                            wv.Visibility = ViewStates.Visible;
                            listView.Visibility = ViewStates.Invisible;
                        }
                        RunOnUiThread(delegate
                            {
                                wsu.displayTracks(trackShort, c, res =>
                                    {
                                        tr = res;
                                        if (tr.Length > 0)
                                        {
                                            wu.loadIntoWebview(wv, tr);
                                        }
                                    });
                            });
                    };
                    fb1.SetMinimumWidth(Convert.ToInt32(xAcross / 4));
                    Button fb2 = FindViewById<Button>(Resource.Id.btnUpcoming);
                    fb2.SetMinimumWidth(Convert.ToInt32(xAcross / 4));
                    fb2.Click += (object s, EventArgs e) =>
                    {
                        if (listView.Visibility == ViewStates.Invisible)
                        {
                            wv.Visibility = ViewStates.Invisible;
                            listView.Visibility = ViewStates.Visible;
                            resizeListView(listView);
                        }
                        getUpcomingRaces(listView, c, trackShort);
                    };
                    Button fb3 = FindViewById<Button>(Resource.Id.btnResults);
                    fb3.SetMinimumWidth(Convert.ToInt32(xAcross / 4));
                    fb3.Click += (object s, EventArgs e) =>
                    {
                        if (listView.Visibility == ViewStates.Invisible)
                        {
                            wv.Visibility = ViewStates.Invisible;
                            listView.Visibility = ViewStates.Visible;
                            resizeListView(listView);
                        }
                        getResults(listView, c, trackShort);
                    };
                    Button fb4 = FindViewById<Button>(Resource.Id.btnVideos);
                    fb4.SetMinimumWidth(Convert.ToInt32(xAcross / 4));
                    fb4.Click += (object s, EventArgs e) =>
                    {
                        if (listView.Visibility == ViewStates.Invisible)
                        {
                            wv.Visibility = ViewStates.Invisible;
                            listView.Visibility = ViewStates.Visible;
                            resizeListView(listView);
                        }
                        vtList(c);
                    };
                    if (vienna == false)
                        vtList(c);
                    break;
                case 60:
                    addFactor = 0;
                    Intent ira = new Intent(this, typeof(websiteview));
                    ira.PutExtra("url", "http://mobile.oqhra.com/standings/Standings.html");
                    StartActivity(ira);
                    break;
                case 70: /*Button tb1 = FindViewById<Button>(Resource.Id.btnCalc);
                    Button tb2 = FindViewById<Button>(Resource.Id.btnExplore);
                    Button tb3 = FindViewById<Button>(Resource.Id.btnTipSheet);
                    Console.WriteLine("In three buttons");
                    string r = "";
                    tb3.Click += (object o, EventArgs e) =>
                    {
                        Console.WriteLine("Tipsheet");
                        webservice_user web = new webservice_user();
                        web.tipSheet(res =>
                            {
                                r = res;
                                if (r != "")
                                {
                                    Intent i = new Intent(this, typeof(webservice_webview));
                                    i.PutExtra("content", r);
                                    StartActivity(i);
                                }
                                else
                                    toasty("No tips available");
                            });
                    };
                    tb1.Click += (object o, EventArgs e) => { startBetting(); };*/
                    break;
            /*case 140: addFactor = 0;
                    getVideos(c);
                    break;*/
            }
            if (addFactor != screen[screen.Count - 1]) // dont' add if it's not the same as the previous one
            {
#if DEBUG
                Console.WriteLine("In main selector - adding {0}, screen[count - 1] = {1}", addFactor, screen[screen.Count - 1]);
#endif
                screen.Add(addFactor);
            }
        }

        private void distSpinner_Select(object s, AdapterView.ItemSelectedEventArgs e)
        {
        }

        private void startBetting()
        {
            bool w = false;
            int betVal = 1, wage = 0, bet1 = 1, bet2 = 0;
            EditText wager = FindViewById<EditText>(Resource.Id.editWager);
            EditText r1 = FindViewById<EditText>(Resource.Id.editRace1);
            EditText r2 = FindViewById<EditText>(Resource.Id.editRace2);
            Button calc = FindViewById<Button>(Resource.Id.btnCalculator);
            Spinner bet = FindViewById<Spinner>(Resource.Id.spinnerBetType);
            var adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.choosebet, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            bet.ItemSelected += (object s, AdapterView.ItemSelectedEventArgs e) =>
            {
                Spinner k = (Spinner)s;
                betVal = k.SelectedItemPosition;
            };
            bet.Adapter = adapter;
            wager.TextChanged += (object t, Android.Text.TextChangedEventArgs e) =>
            {
                if (wager.Text != "")
                    w = true;
                calc.Enabled = true;
                wage = Convert.ToInt32(wager.Text);
            };
            r1.TextChanged += (object t, Android.Text.TextChangedEventArgs e) =>
            {
                bet1 = r1.Text != "" ? Convert.ToInt32(r1.Text) : 0;
            };
            r2.TextChanged += (object t, Android.Text.TextChangedEventArgs e) =>
            {
                bet2 = r2.Text != "" ? Convert.ToInt32(r2.Text) : 0;
            };
            calc.Enabled = false;
            calc.Click += delegate(object s, EventArgs e)
            {
                calc_Click(s, e, betVal, wage, bet1, bet2);
            };
        }

        private void calc_Click(object s, EventArgs e, int betVal, int wage, int bet1, int bet2)
        {
            betting bet = new betting();
            double returns = 0;
            string money = "";
#if DEBUG
            Console.WriteLine("spinner pos = {0}, bet1 = {1}, bet2 = {2}, wager = {3}", betVal, bet1, bet2, wage);
#endif
            if (betVal == 0)
            {
                returns = bet.calcReturns(bet1, bet2, wage);
                money = "A " + bet1 + " to " + bet2 + " straight win bet of $" + wage +
                " would pay $" + returns.ToString();
            }
            else
            {
                returns = bet.calcWagers(bet1, bet2, wage, betVal);
                switch (betVal)
                {
                    case 1:
                        if (bet1 != 1 && bet2 != 1)
                            money = "The wagering cost for this Daily Double Part-Wheel wager would be: $" + returns.ToString();
                        else
                            money = "The wagering cost for a Straight Daily Double wager would be: $" + returns.ToString();
                        break;
                    case 2:
                        if (bet1 < 2)
                            money = "This type of bet requires 2 or more horses.";
                        else
                            money = "The wagering cost for an Exacta Box wager such as this would be: $" + returns.ToString();
                        break;
                    case 3:
                        if (bet1 < 2)
                            money = "This type of bet requires 2 or more horses.";
                        else
                            money = "The wagering cost for an Exacata Part-Wheel wager such as this would be: $" + returns.ToString();
                        break;
                    case 4:
                        if (bet1 < 2)
                            money = "This type of bet requires 2 or more horses.";
                        else
                            money = "The wagering cost for an Trifecta Box wager such as this would be: $" + returns.ToString();
                        break;
                }
            }
            toasty(money);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            var menuItem1 = menu.Add(0, 1, 1, Resource.String.menu_home);
            var menuItem2 = menu.Add(0, 2, 2, Resource.String.menu_stakes);
            var menuItem3 = menu.Add(0, 3, 3, Resource.String.menu_calendar);
            var menuItem4 = menu.Add(0, 4, 4, Resource.String.menu_news);
            var menuItem5 = menu.Add(0, 5, 5, Resource.String.menu_copyright);
            var menuItem6 = menu.Add(0, 6, 6, Resource.String.menu_quit);
            menuItem1.SetIcon(Resource.Drawable.home_icon);
            menuItem2.SetIcon(Resource.Drawable.silks);
            menuItem3.SetIcon(Resource.Drawable.calendar);
            menuItem4.SetIcon(Resource.Drawable.news);
            menuItem5.SetIcon(Resource.Drawable.exclaim);
            menuItem6.SetIcon(Resource.Drawable.close);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case 1:
                    SetContentView(Resource.Layout.main_original);
                    createEvents(1, false);
                    backScreen();
                    break;
                case 2:
                    screen.Add(100);
                    startStakes();
                    break;
                case 3:
                    screen.Add(200);
                    startCalendar(DateTime.Now.Month, DateTime.Now.Year);
                    break;
                case 4:
                    screen.Add(300);
                    startNews();
                    break;
                case 5:
                    toasty("OQHRA for Android\n\n(c) 2012 Paul F. Johnson\n\niPhone version by Steve Maddox\n\nVersion " + VERSION.ToString());
                    break;
                case 6:
                    System.Environment.Exit(-1);
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }

        private void startStakes()
        {
            /*SetContentView(Resource.Layout.stakes);
            createEvents(2);
            TextView tv = FindViewById<TextView>(Resource.Id.textTitle);
            tv.Text = "Stakes";

            TableLayout tl = FindViewById<TableLayout>(Resource.Id.tableStake);
            tl.SetMinimumWidth(Convert.ToInt32(xScale));

            Spinner race = FindViewById<Spinner>(Resource.Id.spinnerTrack);
            var adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.stakescourses, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            race.Adapter = adapter;
            race.Enabled = false;

            Spinner grade = FindViewById<Spinner>(Resource.Id.spinnerGrade);
            var gAdapter = ArrayAdapter.CreateFromResource(this, Resource.Array.racegrade, Android.Resource.Layout.SimpleSpinnerItem);
            gAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            grade.Adapter = gAdapter;
            grade.Enabled = false;

            Spinner sex = FindViewById<Spinner>(Resource.Id.spinnerSex);
            var sAdapter = ArrayAdapter.CreateFromResource(this, Resource.Array.racesex, Android.Resource.Layout.SimpleSpinnerItem);
            sAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            sex.Adapter = sAdapter;
            sex.Enabled = false;

            Spinner breed = FindViewById<Spinner>(Resource.Id.spinnerBreed);
            var bAdapter = ArrayAdapter.CreateFromResource(this, Resource.Array.racebreed, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            breed.Adapter = bAdapter;
            breed.Enabled = false;

            Spinner dist = FindViewById<Spinner>(Resource.Id.spinnerDist);
            var dAdapter = ArrayAdapter.CreateFromResource(this, Resource.Array.racedistance, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            dist.Adapter = dAdapter;
            dist.Enabled = false;

            EditText etAge = FindViewById<EditText>(Resource.Id.editAge);
            etAge.Text = "1";

            Button bRace = FindViewById<Button>(Resource.Id.btnRaceTrac);
            Button bGrade = FindViewById<Button>(Resource.Id.btnGrade);
            Button bSex = FindViewById<Button>(Resource.Id.btnSex);
            Button bBreed = FindViewById<Button>(Resource.Id.btnBreed);
            Button bAge = FindViewById<Button>(Resource.Id.btnAge);
            Button bDist = FindViewById<Button>(Resource.Id.btnDistance);
            Button bFind = FindViewById<Button>(Resource.Id.btnProcess);

            bFind.SetMinimumWidth(Convert.ToInt32(xScale));

            bRace.Click += (object s, EventArgs e) =>
            {
                if (race.Enabled == true)
                    race.Enabled = false;
                else
                    race.Enabled = true;
            };
            bGrade.Click += (object s, EventArgs e) =>
            {
                if (grade.Enabled == true)
                    grade.Enabled = false;
                else
                    grade.Enabled = true;
            };
            bSex.Click += (object s, EventArgs e) =>
            {
                if (sex.Enabled == true)
                    sex.Enabled = false;
                else
                    sex.Enabled = true;
            };
            bBreed.Click += (object s, EventArgs e) =>
            {
                if (breed.Enabled == true)
                    breed.Enabled = false;
                else
                    breed.Enabled = true;
            };
            bDist.Click += (object s, EventArgs e) =>
            {
                if (dist.Enabled == true)
                    dist.Enabled = false;
                else
                    dist.Enabled = true;
            };
            bAge.Click += (object s, EventArgs e) =>
            {
                if (etAge.Enabled == true)
                    etAge.Enabled = false;
                else
                    etAge.Enabled = true;
            };

            bFind.Click += (object s, EventArgs e) =>
                {
                    List<string> options = new List<string>();
                    options.AddRange(new string[] { bRace.Text, bGrade.Text, etAge.Text, bSex.Text, bBreed.Text, bDist.Text, bAge.Text });
                    List<InfoMenu> info = new List<InfoMenu>();
                    dbu.getRaceInfo(db, res =>
                    {
                        info = res;
                    });
                };*/
            Intent ira = new Intent(this, typeof(websiteview));
            ira.PutExtra("url", "http://mobile.oqhra.com/stakes.aspx");
            StartActivity(ira);
        }

        private void startCalendar(int month, int year)
        {
            SetContentView(Resource.Layout.calendar);
            createEvents(2);
            List<int> cal = new List<int>();
            List<string> monthNames = new List<string>();
            monthNames.AddRange(new string[]
                {"January", "February", "March", "April", "May", "June", "July", "August",
                    "September", "October", "November", "December"
                });
            TextView moN = FindViewById<TextView>(Resource.Id.textMonthYear);
            TextView title = FindViewById<TextView>(Resource.Id.textTitle);
            title.Text = "Calendar";
            moN.Text = monthNames[month - 1];
            calendar c = new calendar();
            cal = c.generateCalendar(month, year);
            List<TextView> t = new List<TextView>();

            int[] id = new int[]
            {
                Resource.Id.textDate1, Resource.Id.textDate2, Resource.Id.textDate3, Resource.Id.textDate4,
                Resource.Id.textDate5, Resource.Id.textDate6, Resource.Id.textDate7, Resource.Id.textDate8,
                Resource.Id.textDate9, Resource.Id.textDate10, Resource.Id.textDate11, Resource.Id.textDate12,
                Resource.Id.textDate13, Resource.Id.textDate14, Resource.Id.textDate15, Resource.Id.textDate16,
                Resource.Id.textDate17, Resource.Id.textDate18, Resource.Id.textDate19, Resource.Id.textDate20,
                Resource.Id.textDate21, Resource.Id.textDate22, Resource.Id.textDate23, Resource.Id.textDate24,
                Resource.Id.textDate25, Resource.Id.textDate26, Resource.Id.textDate27, Resource.Id.textDate28,
                Resource.Id.textDate29, Resource.Id.textDate30, Resource.Id.textDate31, Resource.Id.textDate32,
                Resource.Id.textDate33, Resource.Id.textDate34, Resource.Id.textDate35, Resource.Id.textDate36,
                Resource.Id.textDate37, Resource.Id.textDate38, Resource.Id.textDate39, Resource.Id.textDate40,
                Resource.Id.textDate41, Resource.Id.textDate42
            };
            foreach (int i in id)
                t.Add(FindViewById<TextView>(i));

            for (int i = 0; i < 42; ++i)
            {
                t[i].Text = "";
                t[i].Click += new EventHandler(calendarAdd);
            }

            int p = 0;
            for (int i = 0; i < cal.Count; ++i)
            {
                if (cal[i] == 0)
                    t[i].Text = "";
                else
                    t[i].Text = cal[i].ToString();
                p++;
            }
            for (int i = p; p < 42; ++p)
                t[i].Text = "";

            Button prev = FindViewById<Button>(Resource.Id.btnPrevMonth);
            prev.Click += (object s, EventArgs e) =>
            {
                if (month == 1)
                {
                    month = 12;
                    year--;
                }
                else
                    month--;
                startCalendar(month, year);
            };
            Button next = FindViewById<Button>(Resource.Id.btnNextMonth);
            next.Click += (object s, EventArgs e) =>
            {
                if (month == 12)
                {
                    month = 1;
                    year++;
                }
                else
                    month++;
                startCalendar(month, year);
                /*modal m = new modal();
                    View currentview = FindViewById<View>(Resource.Id.textMonthYear);
                    Context cv = currentview.Context;
                    m.showAlertDialog(cv, "You have pressed the forward button to the next month. Yay!!!");*/
            };
        }

        private void calendarAdd(object s, EventArgs e)
        {
            TextView date = (TextView)s;
#if DEBUG
            Console.WriteLine("calendarAdd - date clicked = {0}", date.Text);
#endif
        }

        private void startNews()
        {
            Intent ira = new Intent(this, typeof(websiteview));
            ira.PutExtra("url", "http://www.BobMooreFarms.com");
            StartActivity(ira);
        }
    }
}
