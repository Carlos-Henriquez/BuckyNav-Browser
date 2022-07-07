using EasyTabs;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuckyNav_Browser
{
    public partial class frmBrowser : Form
    {
        public frmBrowser()
        {
            InitializeComponent();

            var appName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + " .exe";
            using (var Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true))
                Key.SetValue(appName, 99999, RegistryValueKind.DWord);

                webBrowser1.Navigate("https://www.google.com/");
        }

        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            searchUrlBox.Text = webBrowser1.Url.AbsoluteUri;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack) 
                webBrowser1.GoBack();
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
                webBrowser1.GoForward();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/");
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void searchUrlBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && searchUrlBox.Text.Trim().Length > 0)
            {
                if (searchUrlBox.Text.Contains("."))
                {
                    webBrowser1.Navigate(searchUrlBox.Text.Trim());

                }
                else
                {
                    webBrowser1.Navigate("https://www.google.com/search?client=opera&q=" + searchUrlBox.Text.Trim().Replace(" ", "+") + "&sourceid=opera&ie=UTF-8&oe=UTF-8");
                }
            }
        }


    }
}

//Carlos Henriquez 2020-10203
