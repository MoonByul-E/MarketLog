using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace FIFA_ONLINE_4_Market_Log
{
    public partial class mainForm : MetroFramework.Forms.MetroForm
    {
        static string key_Location = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/";
        static string key_File = File.ReadAllText(key_Location + "/key.txt");

        string Key = key_File;
        List<string> FIFA4_MetaData_SPID_ID = new List<string>();
        List<string> FIFA4_MetaData_SPID_NAME = new List<string>();

        List<string> FIFA4_MetaData_SEASON_ID = new List<string>();
        List<string> FIFA4_MetaData_SEASON_NAME = new List<string>();
        List<string> FIFA4_MetaData_SEASON_URL = new List<string>();

        List<string> FIFA4_Markets_Buy_Log_SEASON = new List<string>();
        List<string> FIFA4_Markets_Buy_Log_NAME = new List<string>();
        List<string> FIFA4_Markets_Buy_Log_Grade = new List<string>();
        List<string> FIFA4_Markets_Buy_Log_Price = new List<string>();
        List<string> FIFA4_Markets_Buy_Log_Date = new List<string>();
        List<string> FIFA4_Markets_Buy_Log_Time = new List<string>();
        List<string> FIFA4_Markets_Buy_Log_ID = new List<string>();

        List<string> FIFA4_Markets_Sell_Log_SEASON = new List<string>();
        List<string> FIFA4_Markets_Sell_Log_NAME = new List<string>();
        List<string> FIFA4_Markets_Sell_Log_Grade = new List<string>();
        List<string> FIFA4_Markets_Sell_Log_Price = new List<string>();
        List<string> FIFA4_Markets_Sell_Log_Date = new List<string>();
        List<string> FIFA4_Markets_Sell_Log_Time = new List<string>();

        public mainForm()
        {
            InitializeComponent();
        }

        private string WebRequest(string URL, bool HeaderBool, string HeaderName = "", string HeaderValue = "")
        {
            string Result = "";

            try
            {
                var webRequest = System.Net.WebRequest.Create(URL);
                if (webRequest != null)
                {
                    webRequest.Method = "GET";
                    webRequest.Timeout = 12000;
                    webRequest.ContentType = "application/json";
                    if (HeaderBool == true) webRequest.Headers.Add(HeaderName, HeaderValue);
                    using (Stream s = webRequest.GetResponse().GetResponseStream())
                    {
                        using (StreamReader sr = new StreamReader(s))
                        {
                            var jsonResponse = sr.ReadToEnd();
                            Result = jsonResponse;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Result = "Error";
            }

            return Result;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            string FIFA4_MetaData_SPID_Url = "https://static.api.nexon.co.kr/fifaonline4/latest/spid.json";
            string FIFA4_MetaData_SPID_Html = WebRequest(FIFA4_MetaData_SPID_Url, false);
            JArray FIFA4_MetaData_SPID_Array = JArray.Parse(FIFA4_MetaData_SPID_Html);

            string FIFA4_MetaData_SEASON_Url = "https://static.api.nexon.co.kr/fifaonline4/latest/seasonid.json";
            string FIFA4_MetaData_SEASON_Html = WebRequest(FIFA4_MetaData_SEASON_Url, false);
            JArray FIFA4_MetaData_SEASON_Array = JArray.Parse(FIFA4_MetaData_SEASON_Html);

            foreach (JObject FIFA4_MetaData_SPID_Json in FIFA4_MetaData_SPID_Array)
            {
                FIFA4_MetaData_SPID_ID.Add(FIFA4_MetaData_SPID_Json["id"].ToString());
                FIFA4_MetaData_SPID_NAME.Add(FIFA4_MetaData_SPID_Json["name"].ToString());
            }

            foreach (JObject FIFA4_MetaData_SEASON_Json in FIFA4_MetaData_SEASON_Array)
            {
                FIFA4_MetaData_SEASON_ID.Add(FIFA4_MetaData_SEASON_Json["seasonId"].ToString());
                FIFA4_MetaData_SEASON_NAME.Add(FIFA4_MetaData_SEASON_Json["className"].ToString().Split('(')[0].TrimEnd());
                FIFA4_MetaData_SEASON_URL.Add(FIFA4_MetaData_SEASON_Json["seasonImg"].ToString());
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_NickName.Text == "")
            {
                MessageBox.Show("닉네임을 입력 해주세요.", "오류!");
                tb_NickName.Focus();
            }
            else
            {
                string FIFA4_UserData_Url = "https://api.nexon.co.kr/fifaonline4/v1.0/users?nickname=" + tb_NickName.Text;
                string FIFA4_UserData_Html = WebRequest(FIFA4_UserData_Url, true, "Authorization", Key);
                if (FIFA4_UserData_Html == "Error")
                {
                    MessageBox.Show("닉네임을 찾을 수 없습니다.", "오류!");
                    tb_NickName.Focus();
                }
                else
                {
                    FIFA4_Markets_Buy_Log_SEASON.Clear();
                    FIFA4_Markets_Buy_Log_NAME.Clear();
                    FIFA4_Markets_Buy_Log_Grade.Clear();
                    FIFA4_Markets_Buy_Log_Price.Clear();
                    FIFA4_Markets_Buy_Log_Date.Clear();
                    FIFA4_Markets_Buy_Log_Time.Clear();
                    FIFA4_Markets_Buy_Log_ID.Clear();

                    FIFA4_Markets_Sell_Log_SEASON.Clear();
                    FIFA4_Markets_Sell_Log_NAME.Clear();
                    FIFA4_Markets_Sell_Log_Grade.Clear();
                    FIFA4_Markets_Sell_Log_Price.Clear();
                    FIFA4_Markets_Sell_Log_Date.Clear();
                    FIFA4_Markets_Sell_Log_Time.Clear();

                    lv_BuyLog.Items.Clear();
                    lv_SellLog.Items.Clear();

                    JObject FIFA4_UserData_Json = JObject.Parse(FIFA4_UserData_Html);
                    string FIFA4_UserData_AccessID = FIFA4_UserData_Json["accessId"].ToString();

                    string FIFA4FIFA4_UserData_BuyLog_Url = "https://api.nexon.co.kr/fifaonline4/v1.0/users/" + FIFA4_UserData_AccessID + "/markets?tradetype=buy";
                    string FIFA4_UserData_BuyLog_Html = WebRequest(FIFA4FIFA4_UserData_BuyLog_Url, true, "Authorization", Key);

                    JArray FIFA4_UserData_BuyLog_Array = JArray.Parse(FIFA4_UserData_BuyLog_Html);
                    foreach (JObject FIFA4_UserData_BuyLog_Json in FIFA4_UserData_BuyLog_Array)
                    {
                        FIFA4_Markets_Buy_Log_SEASON.Add(FIFA4_MetaData_SEASON_NAME[FIFA4_MetaData_SEASON_ID.IndexOf(FIFA4_UserData_BuyLog_Json["spid"].ToString().Substring(0, 3))]);
                        FIFA4_Markets_Buy_Log_NAME.Add(FIFA4_MetaData_SPID_NAME[FIFA4_MetaData_SPID_ID.IndexOf(FIFA4_UserData_BuyLog_Json["spid"].ToString())]);
                        FIFA4_Markets_Buy_Log_Grade.Add(FIFA4_UserData_BuyLog_Json["grade"].ToString());
                        FIFA4_Markets_Buy_Log_Price.Add(String.Format("{0:#,0}", Convert.ToInt64(FIFA4_UserData_BuyLog_Json["value"])));
                        FIFA4_Markets_Buy_Log_Date.Add(FIFA4_UserData_BuyLog_Json["tradeDate"].ToString().Split(' ')[0]);
                        //FIFA4_Markets_Buy_Log_Time.Add(FIFA4_UserData_BuyLog_Json["tradeDate"].ToString().Split(' ')[1] + " " + FIFA4_UserData_BuyLog_Json["tradeDate"].ToString().Split(' ')[2]);
                        FIFA4_Markets_Buy_Log_ID.Add(FIFA4_UserData_BuyLog_Json["spid"].ToString());
                    }

                    lv_BuyLog.BeginUpdate();

                    for (int i = 0; i < FIFA4_Markets_Buy_Log_SEASON.Count; i++)
                    {
                        string[] FIFA4_Markets_Buy_Log_Temp = { FIFA4_Markets_Buy_Log_SEASON[i], FIFA4_Markets_Buy_Log_NAME[i], FIFA4_Markets_Buy_Log_Grade[i] + "강", FIFA4_Markets_Buy_Log_Price[i] + " BP", FIFA4_Markets_Buy_Log_Date[i]/*, FIFA4_Markets_Buy_Log_Time[i] */};
                        ListViewItem FIFA4_Markets_Buy_Log_Temp_Item = new ListViewItem(FIFA4_Markets_Buy_Log_Temp);
                        lv_BuyLog.Items.Add(FIFA4_Markets_Buy_Log_Temp_Item);
                    }

                    lv_BuyLog.EndUpdate();

                    for (int j = 0; j < lv_BuyLog.Columns.Count; j++) lv_BuyLog.Columns[j].Width = -2;

                    string FIFA4FIFA4_UserData_SellLog_Url = "https://api.nexon.co.kr/fifaonline4/v1.0/users/" + FIFA4_UserData_AccessID + "/markets?tradetype=sell";
                    string FIFA4_UserData_SellLog_Html = WebRequest(FIFA4FIFA4_UserData_SellLog_Url, true, "Authorization", Key);

                    JArray FIFA4_UserData_SellLog_Array = JArray.Parse(FIFA4_UserData_SellLog_Html);
                    foreach (JObject FIFA4_UserData_SellLog_Json in FIFA4_UserData_SellLog_Array)
                    {
                        FIFA4_Markets_Sell_Log_SEASON.Add(FIFA4_MetaData_SEASON_NAME[FIFA4_MetaData_SEASON_ID.IndexOf(FIFA4_UserData_SellLog_Json["spid"].ToString().Substring(0, 3))]);
                        FIFA4_Markets_Sell_Log_NAME.Add(FIFA4_MetaData_SPID_NAME[FIFA4_MetaData_SPID_ID.IndexOf(FIFA4_UserData_SellLog_Json["spid"].ToString())]);
                        FIFA4_Markets_Sell_Log_Grade.Add(FIFA4_UserData_SellLog_Json["grade"].ToString());
                        FIFA4_Markets_Sell_Log_Price.Add(String.Format("{0:#,0}", Convert.ToInt64(FIFA4_UserData_SellLog_Json["value"])));
                        FIFA4_Markets_Sell_Log_Date.Add(FIFA4_UserData_SellLog_Json["tradeDate"].ToString().Split(' ')[0]);
                        //FIFA4_Markets_Sell_Log_Time.Add(FIFA4_UserData_SellLog_Json["tradeDate"].ToString().Split(' ')[1] + " " + FIFA4_UserData_SellLog_Json["tradeDate"].ToString().Split(' ')[2]);
                    }

                    lv_SellLog.BeginUpdate();

                    for (int i = 0; i < FIFA4_Markets_Sell_Log_SEASON.Count; i++)
                    {
                        string[] FIFA4_Markets_Sell_Log_Temp = { FIFA4_Markets_Sell_Log_SEASON[i], FIFA4_Markets_Sell_Log_NAME[i], FIFA4_Markets_Sell_Log_Grade[i] + "강", FIFA4_Markets_Sell_Log_Price[i] + " BP", FIFA4_Markets_Sell_Log_Date[i]/*, FIFA4_Markets_Sell_Log_Time[i] */};
                        ListViewItem FIFA4_Markets_Sell_Log_Temp_Item = new ListViewItem(FIFA4_Markets_Sell_Log_Temp);
                        lv_SellLog.Items.Add(FIFA4_Markets_Sell_Log_Temp_Item);
                    }

                    lv_SellLog.EndUpdate();

                    for (int j = 0; j < lv_SellLog.Columns.Count; j++) lv_SellLog.Columns[j].Width = -2;

                }
            }
        }

        private void tb_NickName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Search_Click(sender, e);
            }
        }

        private void lv_BuyLog_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = lv_BuyLog.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void lv_SellLog_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = lv_BuyLog.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
    }
}
