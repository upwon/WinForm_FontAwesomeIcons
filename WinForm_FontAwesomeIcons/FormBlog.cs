using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using  CefSharp.WinForms;


namespace WinForm_FontAwesomeIcons
{
    public partial class FormBlog : Form
    {
        public FormBlog()
        {
            InitializeComponent();
            InitBrowser();
        }
        public ChromiumWebBrowser browser;
        public void InitBrowser()
        {
            
        //    Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("https://www.lifeee.top");
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
            browser.IsBrowserInitializedChanged += OnIsBrowserInitializedChanged;
         //   browser.LoadingStateChanged += OnLoadingStateChanged;
            browser.ConsoleMessage += OnBrowserConsoleMessage;
         //   browser.StatusMessage += OnBrowserStatusMessage;
            browser.TitleChanged += OnBrowserTitleChanged;
         //  browser.AddressChanged += OnBrowserAddressChanged;

            var version = string.Format("Chromium: {0}, CEF: {1}, CefSharp: {2}",
                Cef.ChromiumVersion, Cef.CefVersion, Cef.CefSharpVersion);



#if NETCOREAPP
            // .NET Core
            var environment = string.Format("Environment: {0}, Runtime: {1}",
                System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture.ToString().ToLowerInvariant(),
                System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription);
#else
            // .NET Framework
            var bitness = Environment.Is64BitProcess ? "x64" : "x86";
            var environment = String.Format("Environment: {0}", bitness);
#endif

            DisplayOutput(string.Format("{0}, {1}", version, environment));
        }

        public void DisplayOutput(string output)
        {
            this.InvokeOnUiThreadIfRequired(() => outputLabel.Text = output);
        }


        private void OnIsBrowserInitializedChanged(object sender, EventArgs e)
        {
            var b = ((ChromiumWebBrowser)sender);

            this.InvokeOnUiThreadIfRequired(() => b.Focus());
        }

        private void OnBrowserConsoleMessage(object sender, ConsoleMessageEventArgs args)
        {
            DisplayOutput(string.Format("Line: {0}, Source: {1}, Message: {2}", args.Line, args.Source, args.Message));
        }

    

   
        private void OnBrowserTitleChanged(object sender, TitleChangedEventArgs args)
        {
            this.InvokeOnUiThreadIfRequired(() => Text = args.Title);
        }

     

    
  
     
       
        private void ExitMenuItemClick(object sender, EventArgs e)
        {
            browser.Dispose();
            Cef.Shutdown();
            Close();
        }

   
        private void BackButtonClick(object sender, EventArgs e)
        {
            browser.Back();
        }

        private void ForwardButtonClick(object sender, EventArgs e)
        {
            browser.Forward();
        }

  

        private void LoadUrl(string url)
        {
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                browser.Load(url);
            }
        }

        private void ShowDevToolsMenuItemClick(object sender, EventArgs e)
        {
            browser.ShowDevTools();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            browser.Back();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            browser.Forward();
        }

        private void iconButtonGo_Click(object sender, EventArgs e)
        {
            LoadUrl(textBoxURL.Text);
        }
    }
}
