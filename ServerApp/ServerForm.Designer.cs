namespace ServerApp
{
    partial class ServerForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.sslblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslblMargin = new System.Windows.Forms.ToolStripStatusLabel();
            this.gpConnectingClient = new System.Windows.Forms.GroupBox();
            this.lbConnectingClient = new System.Windows.Forms.ListBox();
            this.gpConnectionLog = new System.Windows.Forms.GroupBox();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.gbSettings.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.gpConnectingClient.SuspendLayout();
            this.gpConnectionLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSettings
            // 
            this.gbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSettings.Controls.Add(this.btnStart);
            this.gbSettings.Controls.Add(this.btnEnd);
            this.gbSettings.Controls.Add(this.txtPort);
            this.gbSettings.Controls.Add(this.lblPort);
            this.gbSettings.Location = new System.Drawing.Point(12, 15);
            this.gbSettings.Margin = new System.Windows.Forms.Padding(4);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Padding = new System.Windows.Forms.Padding(4);
            this.gbSettings.Size = new System.Drawing.Size(460, 58);
            this.gbSettings.TabIndex = 0;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "設定";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(297, 20);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 25);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Enabled = false;
            this.btnEnd.Location = new System.Drawing.Point(378, 20);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 25);
            this.btnEnd.TabIndex = 2;
            this.btnEnd.Text = "終了";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(167, 21);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(124, 23);
            this.txtPort.TabIndex = 1;
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(12, 25);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(130, 15);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "監視ポート番号(0-65535)";
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslblStatus,
            this.sslblMargin});
            this.ssStatus.Location = new System.Drawing.Point(0, 439);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.ssStatus.Size = new System.Drawing.Size(484, 22);
            this.ssStatus.TabIndex = 2;
            this.ssStatus.Text = "statusStrip1";
            // 
            // sslblStatus
            // 
            this.sslblStatus.Name = "sslblStatus";
            this.sslblStatus.Size = new System.Drawing.Size(43, 17);
            this.sslblStatus.Text = "状態：";
            // 
            // sslblMargin
            // 
            this.sslblMargin.Name = "sslblMargin";
            this.sslblMargin.Size = new System.Drawing.Size(31, 17);
            this.sslblMargin.Text = "        ";
            // 
            // gpConnectingClient
            // 
            this.gpConnectingClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpConnectingClient.Controls.Add(this.lbConnectingClient);
            this.gpConnectingClient.Location = new System.Drawing.Point(12, 81);
            this.gpConnectingClient.Margin = new System.Windows.Forms.Padding(4);
            this.gpConnectingClient.Name = "gpConnectingClient";
            this.gpConnectingClient.Padding = new System.Windows.Forms.Padding(4);
            this.gpConnectingClient.Size = new System.Drawing.Size(460, 104);
            this.gpConnectingClient.TabIndex = 3;
            this.gpConnectingClient.TabStop = false;
            this.gpConnectingClient.Text = "接続中クライアント";
            // 
            // lbConnectingClient
            // 
            this.lbConnectingClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbConnectingClient.FormattingEnabled = true;
            this.lbConnectingClient.ItemHeight = 15;
            this.lbConnectingClient.Location = new System.Drawing.Point(4, 20);
            this.lbConnectingClient.Margin = new System.Windows.Forms.Padding(4);
            this.lbConnectingClient.Name = "lbConnectingClient";
            this.lbConnectingClient.Size = new System.Drawing.Size(452, 80);
            this.lbConnectingClient.TabIndex = 3;
            // 
            // gpConnectionLog
            // 
            this.gpConnectionLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpConnectionLog.Controls.Add(this.lbLog);
            this.gpConnectionLog.Location = new System.Drawing.Point(13, 193);
            this.gpConnectionLog.Margin = new System.Windows.Forms.Padding(4);
            this.gpConnectionLog.Name = "gpConnectionLog";
            this.gpConnectionLog.Padding = new System.Windows.Forms.Padding(4);
            this.gpConnectionLog.Size = new System.Drawing.Size(460, 242);
            this.gpConnectionLog.TabIndex = 4;
            this.gpConnectionLog.TabStop = false;
            this.gpConnectionLog.Text = "ログ";
            // 
            // lbLog
            // 
            this.lbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 15;
            this.lbLog.Location = new System.Drawing.Point(4, 20);
            this.lbLog.Margin = new System.Windows.Forms.Padding(4);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(452, 218);
            this.lbLog.TabIndex = 2;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.gpConnectionLog);
            this.Controls.Add(this.gpConnectingClient);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.gbSettings);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "ServerForm";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.gpConnectingClient.ResumeLayout(false);
            this.gpConnectionLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel sslblStatus;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.ToolStripStatusLabel sslblMargin;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox gpConnectingClient;
        private System.Windows.Forms.ListBox lbConnectingClient;
        private System.Windows.Forms.GroupBox gpConnectionLog;
        private System.Windows.Forms.ListBox lbLog;
    }
}

