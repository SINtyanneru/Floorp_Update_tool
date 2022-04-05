namespace Floorp_UpdateTool
{
    partial class Main_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Profile_listView = new System.Windows.Forms.ListView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.columnHeader_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Profile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Start_button = new System.Windows.Forms.Button();
            this.log_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Floorpをアップデートしよう！";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "プロファイルを移動したりするよ！";
            // 
            // Profile_listView
            // 
            this.Profile_listView.CheckBoxes = true;
            this.Profile_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Profile,
            this.columnHeader_Name,
            this.columnHeader_ID});
            this.Profile_listView.HideSelection = false;
            this.Profile_listView.Location = new System.Drawing.Point(18, 108);
            this.Profile_listView.Name = "Profile_listView";
            this.Profile_listView.Size = new System.Drawing.Size(509, 330);
            this.Profile_listView.TabIndex = 2;
            this.Profile_listView.UseCompatibleStateImageBehavior = false;
            this.Profile_listView.View = System.Windows.Forms.View.Details;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-12, 60);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Maximum = 100000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1030, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 99999;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "プロファイルを選んでね！";
            // 
            // columnHeader_Name
            // 
            this.columnHeader_Name.Text = "名前";
            this.columnHeader_Name.Width = 122;
            // 
            // columnHeader_ID
            // 
            this.columnHeader_ID.Text = "ID";
            this.columnHeader_ID.Width = 212;
            // 
            // columnHeader_Profile
            // 
            this.columnHeader_Profile.Text = "プロファイル";
            this.columnHeader_Profile.Width = 167;
            // 
            // Start_button
            // 
            this.Start_button.Location = new System.Drawing.Point(534, 108);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(455, 23);
            this.Start_button.TabIndex = 5;
            this.Start_button.Text = "すたーと！！！！！";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start);
            // 
            // log_label
            // 
            this.log_label.BackColor = System.Drawing.Color.Black;
            this.log_label.ForeColor = System.Drawing.Color.Lime;
            this.log_label.Location = new System.Drawing.Point(532, 134);
            this.log_label.Name = "log_label";
            this.log_label.Size = new System.Drawing.Size(457, 307);
            this.log_label.TabIndex = 6;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.log_label);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Profile_listView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main_Form";
            this.Text = "Floorpアップデートツール";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView Profile_listView;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_ID;
        private System.Windows.Forms.ColumnHeader columnHeader_Profile;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Label log_label;
    }
}

