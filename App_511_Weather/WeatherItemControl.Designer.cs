namespace App_511_Weather
{
    partial class WeatherItemControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataPanel1 = new DataPanel();
            this.labelInfo = new Label();
            labelTitle = new Label();
            dataPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataPanel1
            // 
            dataPanel1.BackColor = Color.Transparent;
            dataPanel1.Controls.Add(this.labelInfo);
            dataPanel1.Controls.Add(labelTitle);
            dataPanel1.Location = new Point(3, 3);
            dataPanel1.Name = "dataPanel1";
            dataPanel1.Size = new Size(114, 74);
            dataPanel1.TabIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.labelInfo.ForeColor = Color.SteelBlue;
            this.labelInfo.Location = new Point(29, 41);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new Size(62, 20);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "<data>";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTitle.ForeColor = Color.WhiteSmoke;
            labelTitle.Location = new Point(29, 12);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(62, 20);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "<type>";
            // 
            // WeatherItemControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            Controls.Add(dataPanel1);
            Name = "WeatherItemControl";
            Size = new Size(120, 80);
            dataPanel1.ResumeLayout(false);
            dataPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataPanel dataPanel1;
        private Label labelInfo;
        private Label labelTitle;
    }
}
