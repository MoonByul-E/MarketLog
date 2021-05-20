
namespace FIFA_ONLINE_4_Market_Log
{
    partial class mainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_NickName = new MetroFramework.Controls.MetroTextBox();
            this.btn_Search = new MetroFramework.Controls.MetroButton();
            this.tc_Log = new MetroFramework.Controls.MetroTabControl();
            this.tp_BuyLog = new MetroFramework.Controls.MetroTabPage();
            this.tp_SellLog = new MetroFramework.Controls.MetroTabPage();
            this.lv_BuyLog = new System.Windows.Forms.ListView();
            this.ch_Season = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Player = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Grade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_SellLog = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tc_Log.SuspendLayout();
            this.tp_BuyLog.SuspendLayout();
            this.tp_SellLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_NickName
            // 
            // 
            // 
            // 
            this.tb_NickName.CustomButton.Image = null;
            this.tb_NickName.CustomButton.Location = new System.Drawing.Point(88, 1);
            this.tb_NickName.CustomButton.Name = "";
            this.tb_NickName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_NickName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_NickName.CustomButton.TabIndex = 1;
            this.tb_NickName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_NickName.CustomButton.UseSelectable = true;
            this.tb_NickName.CustomButton.Visible = false;
            this.tb_NickName.Lines = new string[0];
            this.tb_NickName.Location = new System.Drawing.Point(23, 63);
            this.tb_NickName.MaxLength = 32767;
            this.tb_NickName.Name = "tb_NickName";
            this.tb_NickName.PasswordChar = '\0';
            this.tb_NickName.PromptText = "닉네임";
            this.tb_NickName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_NickName.SelectedText = "";
            this.tb_NickName.SelectionLength = 0;
            this.tb_NickName.SelectionStart = 0;
            this.tb_NickName.ShortcutsEnabled = true;
            this.tb_NickName.Size = new System.Drawing.Size(110, 23);
            this.tb_NickName.TabIndex = 0;
            this.tb_NickName.UseSelectable = true;
            this.tb_NickName.WaterMark = "닉네임";
            this.tb_NickName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_NickName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NickName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_NickName_KeyDown);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(139, 63);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(44, 23);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "검색";
            this.btn_Search.UseSelectable = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tc_Log
            // 
            this.tc_Log.Controls.Add(this.tp_BuyLog);
            this.tc_Log.Controls.Add(this.tp_SellLog);
            this.tc_Log.Location = new System.Drawing.Point(23, 92);
            this.tc_Log.Name = "tc_Log";
            this.tc_Log.SelectedIndex = 0;
            this.tc_Log.Size = new System.Drawing.Size(554, 318);
            this.tc_Log.TabIndex = 2;
            this.tc_Log.UseSelectable = true;
            // 
            // tp_BuyLog
            // 
            this.tp_BuyLog.Controls.Add(this.lv_BuyLog);
            this.tp_BuyLog.HorizontalScrollbarBarColor = true;
            this.tp_BuyLog.HorizontalScrollbarHighlightOnWheel = false;
            this.tp_BuyLog.HorizontalScrollbarSize = 10;
            this.tp_BuyLog.Location = new System.Drawing.Point(4, 38);
            this.tp_BuyLog.Name = "tp_BuyLog";
            this.tp_BuyLog.Size = new System.Drawing.Size(546, 276);
            this.tp_BuyLog.TabIndex = 0;
            this.tp_BuyLog.Text = "구매 기록";
            this.tp_BuyLog.VerticalScrollbarBarColor = true;
            this.tp_BuyLog.VerticalScrollbarHighlightOnWheel = false;
            this.tp_BuyLog.VerticalScrollbarSize = 10;
            // 
            // tp_SellLog
            // 
            this.tp_SellLog.Controls.Add(this.lv_SellLog);
            this.tp_SellLog.HorizontalScrollbarBarColor = true;
            this.tp_SellLog.HorizontalScrollbarHighlightOnWheel = false;
            this.tp_SellLog.HorizontalScrollbarSize = 10;
            this.tp_SellLog.Location = new System.Drawing.Point(4, 38);
            this.tp_SellLog.Name = "tp_SellLog";
            this.tp_SellLog.Size = new System.Drawing.Size(546, 276);
            this.tp_SellLog.TabIndex = 1;
            this.tp_SellLog.Text = "판매 기록";
            this.tp_SellLog.VerticalScrollbarBarColor = true;
            this.tp_SellLog.VerticalScrollbarHighlightOnWheel = false;
            this.tp_SellLog.VerticalScrollbarSize = 10;
            // 
            // lv_BuyLog
            // 
            this.lv_BuyLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Season,
            this.ch_Player,
            this.ch_Grade,
            this.ch_Price,
            this.ch_Data});
            this.lv_BuyLog.FullRowSelect = true;
            this.lv_BuyLog.GridLines = true;
            this.lv_BuyLog.HideSelection = false;
            this.lv_BuyLog.Location = new System.Drawing.Point(3, 3);
            this.lv_BuyLog.Name = "lv_BuyLog";
            this.lv_BuyLog.Size = new System.Drawing.Size(540, 270);
            this.lv_BuyLog.TabIndex = 2;
            this.lv_BuyLog.UseCompatibleStateImageBehavior = false;
            this.lv_BuyLog.View = System.Windows.Forms.View.Details;
            this.lv_BuyLog.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lv_BuyLog_ColumnWidthChanging);
            // 
            // ch_Season
            // 
            this.ch_Season.Text = "시즌";
            // 
            // ch_Player
            // 
            this.ch_Player.Text = "선수";
            // 
            // ch_Grade
            // 
            this.ch_Grade.Text = "강화";
            // 
            // ch_Price
            // 
            this.ch_Price.Text = "가격";
            // 
            // ch_Data
            // 
            this.ch_Data.Text = "구매 날짜";
            this.ch_Data.Width = 72;
            // 
            // lv_SellLog
            // 
            this.lv_SellLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lv_SellLog.FullRowSelect = true;
            this.lv_SellLog.GridLines = true;
            this.lv_SellLog.HideSelection = false;
            this.lv_SellLog.Location = new System.Drawing.Point(3, 3);
            this.lv_SellLog.Name = "lv_SellLog";
            this.lv_SellLog.Size = new System.Drawing.Size(540, 270);
            this.lv_SellLog.TabIndex = 3;
            this.lv_SellLog.UseCompatibleStateImageBehavior = false;
            this.lv_SellLog.View = System.Windows.Forms.View.Details;
            this.lv_SellLog.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lv_SellLog_ColumnWidthChanging);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "시즌";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "선수";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "강화";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "가격";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "구매 날짜";
            this.columnHeader5.Width = 72;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 433);
            this.Controls.Add(this.tc_Log);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_NickName);
            this.Name = "mainForm";
            this.Text = "FIFA ONLINE 4 Market Log";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tc_Log.ResumeLayout(false);
            this.tp_BuyLog.ResumeLayout(false);
            this.tp_SellLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tb_NickName;
        private MetroFramework.Controls.MetroButton btn_Search;
        private MetroFramework.Controls.MetroTabControl tc_Log;
        private MetroFramework.Controls.MetroTabPage tp_BuyLog;
        private System.Windows.Forms.ListView lv_BuyLog;
        private System.Windows.Forms.ColumnHeader ch_Season;
        private System.Windows.Forms.ColumnHeader ch_Player;
        private System.Windows.Forms.ColumnHeader ch_Grade;
        private System.Windows.Forms.ColumnHeader ch_Price;
        private System.Windows.Forms.ColumnHeader ch_Data;
        private MetroFramework.Controls.MetroTabPage tp_SellLog;
        private System.Windows.Forms.ListView lv_SellLog;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

