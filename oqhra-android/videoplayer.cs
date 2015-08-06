using System;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using Android.App;
using Android.Media;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace oqhra_android
{
    [Activity(Theme = "@android:style/Theme.NoTitleBar")]
    public class videoplayer : Activity, ISurfaceHolderCallback, MediaPlayer.IOnErrorListener
    {
        private MediaPlayer mp;
        private string url;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.video);
            url = base.Intent.GetStringExtra("url");
            int x = base.Intent.GetIntExtra("xSize", 300);
            int y = base.Intent.GetIntExtra("ySize", 500);
            string urlHost = "http://replays.robertsstream.com/racereplays/replaysmobile.php?";
            //urlHost = "rtsp://66.209.93.10:554/2012/_definst_/300/mp4:" + url + "_300.mp4?";

            string pk = "oq56rfju4vnjkm789grt";

            DateTime d1 = new DateTime(1970, 1, 1);
            DateTime d2 = DateTime.UtcNow;
            TimeSpan ts = new TimeSpan(d2.Ticks - d1.Ticks);

            double sd = ts.TotalMilliseconds;

            string UTC = sd.ToString().Substring(0, 10);
            string MD5String = UTC + pk + url;
            MD5String = GetMD5Hash(MD5String);

            urlHost += "race=" + url;
            urlHost += "&cust=OQHRA";
            urlHost += "&t=" + UTC;
            urlHost += "&h=" + MD5String;

            url = resolveRedirect(urlHost);
            if (url == "cant")
                return;

            if (mp != null)
            {
                mp.Reset();
                mp.Release();
            }
            mp = new Android.Media.MediaPlayer();
            mp.SetOnErrorListener(this);
            var surface = FindViewById<SurfaceView>(Resource.Id.surfaceView);
            var holder = surface.Holder;
#if DEBUG
            Console.WriteLine("surface.Holder = {0}", surface.Holder);
#endif
            holder.AddCallback(this);
            holder.SetType(Android.Views.SurfaceType.PushBuffers);
            holder.SetFixedSize(x - 50, y - 75);
#if DEBUG
            Console.WriteLine("videoplayer - url = {0}, x - 50 = {1}, y - 75 = {2}, mp.Info = {3}", url, x - 50, y - 75, mp);
#endif
            Button btnClose = FindViewById<Button>(Resource.Id.btnClose);
            btnClose.Click += (object s, EventArgs e) => { this.Finish(); };
        }

        public void SurfaceDestroyed(ISurfaceHolder holder)
        {
            mp.Release();
        }

        public bool OnError(MediaPlayer mp, Android.Media.MediaError e, int s)
        {
#if DEBUG
            Console.WriteLine("{0}", e.ToString());
#endif
            return true;
        }

#if LAPTOP
        public void SurfaceChanged(ISurfaceHolder holder, Android.Graphics.Format a, int b, int c)
#else
        public void SurfaceChanged (ISurfaceHolder holder, int a, int b, int c)
#endif
        { }

        public void SurfaceCreated(ISurfaceHolder holder)
        {
            try
            {
                mp.SetDisplay(holder);
                mp.SetDataSource(url);
                mp.Prepared += new EventHandler(startPlayer);
                mp.PrepareAsync();
            }
            catch (Java.Lang.IllegalStateException e)
            {
                Toast.MakeText(this, e.ToString(), ToastLength.Long).Show();
            }
            catch (System.Exception e)
            {
                Toast.MakeText(this, e.ToString(), ToastLength.Long).Show();
            }
        }

        public void startPlayer(object s, EventArgs e)
        {
            mp.Start();
        }

        public static string GetMD5Hash(string input)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            return s.ToString();
        }

        private string resolveRedirect(string url)
        {
            WebRequest request = WebRequest.Create(url);
            if (url == null)
                return "cant";
            WebResponse response = request.GetResponse();
#if DEBUG
            Console.WriteLine(response.ResponseUri);
#endif
            return response.ResponseUri.ToString();
        }
    }
}