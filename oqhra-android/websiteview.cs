using System;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Webkit;

namespace oqhra_android
{
    [Activity(Theme = "@android:style/Theme.NoTitleBar")]
    public class websiteview : Activity
    {
        WebView web_view;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.webview);
#if DEBUG
            Console.Write("in websiteview - oncreate");
#endif
            web_view = FindViewById<WebView>(Resource.Id.webviewer);
            web_view.Settings.JavaScriptEnabled = true;
            string url = base.Intent.GetStringExtra("url");
            web_view.LoadUrl(url);
            web_view.SetWebViewClient(new websiteviewClient());
        }

        private class websiteviewClient : WebViewClient
        {
            public override bool ShouldOverrideUrlLoading(WebView view, string url)
            {
                view.LoadUrl(url);
                return true;
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