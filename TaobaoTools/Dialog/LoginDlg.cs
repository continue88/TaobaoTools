using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Top.Api;
using Top.Api.Request;
using Top.Api.Response;
using Top.Api.Util;

namespace TaobaoTools.Dialog
{
    public partial class LoginDlg : UserControl
    {
        public LoginDlg()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            String text = webBrowser1.DocumentText;
            string session_tag = "top_session=";
            int session_begin = text.IndexOf(session_tag);
            if (session_begin < 0)
                return;

            session_begin += session_tag.Length;

            string session = text.Substring(session_begin);
            session = session.Substring(0, session.IndexOf('&'));

            if (session.Length == 0)
                OnSessionEmpty();
            else
                OnSession(session);
        }

        private void OnSessionEmpty()
        {
            MessageBox.Show("对不起，您的账号无法正常使用本软件，请确认是合法的淘宝卖家用户。");
            Application.Exit();
        }

        private void OnSession(String session)
        {
            Global.SessionKey = session;

            Global.MainForm.OnLogginSucess();
        }
    }
}
