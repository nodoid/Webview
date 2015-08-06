using System;

using Android.App;
using Android.OS;
using Android.Views;
using Android.Webkit;

namespace oqhra_android
{
    [Activity(Theme = "@android:style/Theme.NoTitleBar")]
    public partial class webservice_webview : Activity
    {
        WebView web_view;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.webview);
            string res = base.Intent.GetStringExtra("content");
#if DEBUG
            Console.WriteLine("passed over length = {0}", res.Length);
#endif
            if (res.Length > 0)
            {
                web_view = FindViewById<WebView>(Resource.Id.webviewer);
                web_view.Settings.JavaScriptEnabled = true;
                web_view.LoadDataWithBaseURL(null, convertStringToHTML(res, true), "text/html", null, null);
            }
            else
                return;
        }

        private class websiteviewClient : WebViewClient
        {
            public override bool ShouldOverrideUrlLoading(WebView view, string url)
            {
                //view.LoadData(url, "text/html", null);
                return false;
            }
        }

        public override bool OnKeyDown(Android.Views.Keycode keyCode, Android.Views.KeyEvent e)
        {
            if (keyCode == Keycode.Back && web_view.CanGoBack())
            {
                web_view.GoBack();
                return true;
            }

            return base.OnKeyDown(keyCode, e);
        }
    }
}