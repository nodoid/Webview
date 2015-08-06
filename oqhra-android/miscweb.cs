using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Text;
using Android.Content;
using Android.Webkit;
using Android.Widget;
using OQHRA2011;

namespace oqhra_android
{
    public partial class webservice_webview
    {
        public string GetSavedHTMLScreen(List<SavedRunsList> srl)
        {
            string htmlStr = "<head>";
            try
            {
                htmlStr += "<meta http-equiv=\"Content-Type\" content=\"text/html; charset=iso-8859-1\" />";
                htmlStr += "<title>Untitled Document</title>";
                htmlStr += "<STYLE TYPE=\"text/css\">";
                htmlStr += "<!--";
                htmlStr += "TD{font-family: Arial; font-size: 9pt;}";
                htmlStr += "--->";
                htmlStr += "</STYLE>";
                htmlStr += "</head>";
                htmlStr += "<body>";
                htmlStr += "<table width=\"100%\" border=\"0\">";
                htmlStr += " <tr>";
                htmlStr += "    <td></td>";
                htmlStr += "    <td></td>";
                htmlStr += "    <td></td>";
                htmlStr += "    <td></td>";
                htmlStr += "    <td></td>";
                htmlStr += "  </tr>";
                htmlStr += " <tr>";
                htmlStr += "    <td></td>";
                htmlStr += "    <td></td>";
                htmlStr += "    <td></td>";
                htmlStr += "    <td></td>";
                htmlStr += "    <td></td>";
                htmlStr += "  </tr>";
                htmlStr += " <tr>";
                htmlStr += "    <td></td>";
                htmlStr += "    <td></td>";
                htmlStr += "    <td></td>";
                htmlStr += "    <td></td>";
                htmlStr += "    <td></td>";
                htmlStr += "  </tr>";
                htmlStr += " <tr>";
                htmlStr += "    <td></td>";
                htmlStr += "    <td></td>";
                htmlStr += "    <td></td>";
                htmlStr += "    <td></td>";
                htmlStr += "    <td></td>";
                htmlStr += "  </tr>";
                htmlStr += " <tr>";
                htmlStr += "    <td></td>";
                htmlStr += "    <td></td>";
                htmlStr += "    <td></td>";
                htmlStr += "    <td></td>";
                htmlStr += "    <td></td>";
                htmlStr += "  </tr>";
                htmlStr += " <tr>";
                htmlStr += "    <td></td>";
                htmlStr += "    <td></td>";
                htmlStr += "    <td></td>";
                htmlStr += "    <td></td>";
                htmlStr += "    <td></td>";
                htmlStr += "  </tr>";
                htmlStr += " <tr>";
                htmlStr += "    <td>Horse Name</font></td>";
                htmlStr += "    <td>Track</td>";
                htmlStr += "    <td>Time</td>";
                htmlStr += "    <td>Distance</td>";
                htmlStr += "    <td>Date</td>";
                htmlStr += "  </tr>";

                for (int i = 0; i < srl.Count; i++)
                {

                    string DateRan = srl[i].DateRan.Trim();
                    if (DateRan != "")
                    {
                        DateRan = DateRan.Substring(0, DateRan.IndexOf(" "));
                    }
                    htmlStr += " <tr>";
                    htmlStr += "    <td>" + srl[i].HorseName + "</td>";
                    htmlStr += "    <td>" + srl[i].Track + "</td>";
                    htmlStr += "    <td>" + srl[i].RunTime + "</td>";
                    htmlStr += "    <td>" + srl[i].Distance + "</td>";
                    htmlStr += "    <td>" + DateRan + "</td>"; //.Substring(0,sr[i].DateRan.IndexOf(" ")) + "</td>";
                    htmlStr += "  </tr>";
                }

                htmlStr += "</table></body></html></head>";
            }
            catch (Exception oe)
            {
                return oe.ToString();
            }
            return htmlStr;
        }

        public void grabAFile(string url, Context c)
        {
            WebClient webClient = new WebClient();

            webClient.DownloadFileCompleted += delegate(object s, AsyncCompletedEventArgs e) { Completed(s, e, c); };
            webClient.DownloadFileAsync(new System.Uri(url), Android.OS.Environment.ExternalStorageDirectory + "/OQHRA");
        }

        private void Completed(object sender, AsyncCompletedEventArgs e, Context c)
        {
            Toast.MakeText(c, "Download completed. Saved to your SD Card", ToastLength.Long).Show();
        }

        public void loadIntoWebview(WebView v, string url)
        {
            v.Settings.JavaScriptEnabled = true;
            v.LoadDataWithBaseURL(null, convertStringToHTML(url, true), "text/html", null, null);
            v.SetWebViewClient(new websiteviewClient());
        }

        /*private class websiteviewClient : WebViewClient
        {
            public override bool ShouldOverrideUrlLoading(WebView view, string url)
            {
                //view.LoadUrl(url);
                return false;
            }
        }*/

        private string convertStringToHTML(string url, bool allow)
        {
            StringBuilder sb = new StringBuilder(url);
            sb.Replace("  ", " &nbsp;");
            if (!allow)
            {
                sb.Replace("<", "&lt;");
                sb.Replace(">", "&gt;");
                sb.Replace("\"", "&quot;");
            }

            StringReader sr = new StringReader(sb.ToString());
            StringWriter sw = new StringWriter();
            while (sr.Peek() > -1)
            {
                string temp = sr.ReadLine();
                sw.Write(temp + "<br>");
            }
            return sw.GetStringBuilder().ToString();
        }
    }
}
