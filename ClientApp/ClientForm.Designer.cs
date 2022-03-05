namespace ClientApp
{
    partial class ClientForm
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
            this.txtDestPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpConnectionLog = new System.Windows.Forms.GroupBox();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.sslblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslblMargin = new System.Windows.Forms.ToolStripStatusLabel();
            this.gpOperation = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSourcePort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbSettings.SuspendLayout();
            this.gpConnectionLog.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.gpOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSettings
            // 
            this.gbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSettings.Controls.Add(this.txtSourcePort);
            this.gbSettings.Controls.Add(this.label5);
            this.gbSettings.Controls.Add(this.txtDestPort);
            this.gbSettings.Controls.Add(this.label2);
            this.gbSettings.Controls.Add(this.btnStart);
            this.gbSettings.Controls.Add(this.btnEnd);
            this.gbSettings.Controls.Add(this.txtAddress);
            this.gbSettings.Controls.Add(this.label1);
            this.gbSettings.Location = new System.Drawing.Point(12, 15);
            this.gbSettings.Margin = new System.Windows.Forms.Padding(5);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Padding = new System.Windows.Forms.Padding(5);
            this.gbSettings.Size = new System.Drawing.Size(460, 82);
            this.gbSettings.TabIndex = 1;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "設定";
            // 
            // txtDestPort
            // 
            this.txtDestPort.Location = new System.Drawing.Point(105, 48);
            this.txtDestPort.Name = "txtDestPort";
            this.txtDestPort.Size = new System.Drawing.Size(124, 23);
            this.txtDestPort.TabIndex = 1;
            this.txtDestPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "接続先ポート番号";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(295, 46);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 25);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "接続";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Enabled = false;
            this.btnEnd.Location = new System.Drawing.Point(376, 46);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 25);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "切断";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(105, 19);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(124, 23);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.Text = "127.0.0.1";
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "接続先IPアドレス";
            // 
            // gpConnectionLog
            // 
            this.gpConnectionLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpConnectionLog.Controls.Add(this.lbLog);
            this.gpConnectionLog.Location = new System.Drawing.Point(12, 195);
            this.gpConnectionLog.Margin = new System.Windows.Forms.Padding(4);
            this.gpConnectionLog.Name = "gpConnectionLog";
            this.gpConnectionLog.Padding = new System.Windows.Forms.Padding(4);
            this.gpConnectionLog.Size = new System.Drawing.Size(460, 240);
            this.gpConnectionLog.TabIndex = 5;
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
            this.lbLog.Size = new System.Drawing.Size(452, 216);
            this.lbLog.TabIndex = 0;
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
            this.ssStatus.TabIndex = 6;
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
            // gpOperation
            // 
            this.gpOperation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpOperation.Controls.Add(this.btnSend);
            this.gpOperation.Controls.Add(this.label3);
            this.gpOperation.Controls.Add(this.label4);
            this.gpOperation.Controls.Add(this.txtMessage);
            this.gpOperation.Controls.Add(this.txtName);
            this.gpOperation.Location = new System.Drawing.Point(11, 100);
            this.gpOperation.Margin = new System.Windows.Forms.Padding(4);
            this.gpOperation.Name = "gpOperation";
            this.gpOperation.Padding = new System.Windows.Forms.Padding(4);
            this.gpOperation.Size = new System.Drawing.Size(460, 87);
            this.gpOperation.TabIndex = 7;
            this.gpOperation.TabStop = false;
            this.gpOperation.Text = "操作";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(103, 23);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "名無しさん";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(106, 52);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(265, 23);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "メッセージ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "名前";
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(377, 51);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 25);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "送信";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSourcePort
            // 
            this.txtSourcePort.Location = new System.Drawing.Point(327, 19);
            this.txtSourcePort.Name = "txtSourcePort";
            this.txtSourcePort.Size = new System.Drawing.Size(124, 23);
            this.txtSourcePort.TabIndex = 2;
            this.txtSourcePort.Text = "0";
            this.txtSourcePort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "接続元ポート番号";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.gpOperation);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.gpConnectionLog);
            this.Controls.Add(this.gbSettings);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.gpConnectionLog.ResumeLayout(false);
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.gpOperation.ResumeLayout(false);
            this.gpOperation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.TextBox txtDestPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpConnectionLog;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel sslblStatus;
        private System.Windows.Forms.ToolStripStatusLabel sslblMargin;
        private System.Windows.Forms.GroupBox gpOperation;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSourcePort;
        private System.Windows.Forms.Label label5;
    }
}

