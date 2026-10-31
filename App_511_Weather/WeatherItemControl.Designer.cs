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
            PanelName = new FlowLayoutPanel();
            pictureBoxIcon = new PictureBox();
            labelTitle = new Label();
            labelInfo = new Label();
            dataPanel1.SuspendLayout();
            PanelName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // dataPanel1
            // 
            dataPanel1.BackColor = Color.Transparent;
            dataPanel1.Controls.Add(PanelName);
            dataPanel1.Controls.Add(labelInfo);
            dataPanel1.Location = new Point(5, 5);
            dataPanel1.Margin = new Padding(5);
            dataPanel1.Name = "dataPanel1";
            dataPanel1.Size = new Size(185, 118);
            dataPanel1.TabIndex = 0;
            // 
            // PanelName
            // 
            PanelName.Anchor = AnchorStyles.None;
            PanelName.AutoSize = true;
            PanelName.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelName.Controls.Add(pictureBoxIcon);
            PanelName.Controls.Add(labelTitle);
            PanelName.Location = new Point(20, 20);
            PanelName.Name = "PanelName";
            PanelName.Size = new Size(146, 38);
            PanelName.TabIndex = 3;
            PanelName.WrapContents = false;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Location = new Point(3, 3);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(32, 32);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 2;
            pictureBoxIcon.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTitle.ForeColor = Color.WhiteSmoke;
            labelTitle.Location = new Point(43, 0);
            labelTitle.Margin = new Padding(5, 0, 5, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(98, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "<type>";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelInfo.ForeColor = Color.SteelBlue;
            labelInfo.Location = new Point(37, 73);
            labelInfo.Margin = new Padding(5, 0, 5, 0);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(98, 32);
            labelInfo.TabIndex = 1;
            labelInfo.Text = "<data>";
            labelInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WeatherItemControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            Controls.Add(dataPanel1);
            Margin = new Padding(5);
            Name = "WeatherItemControl";
            Size = new Size(195, 128);
            dataPanel1.ResumeLayout(false);
            dataPanel1.PerformLayout();
            PanelName.ResumeLayout(false);
            PanelName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataPanel dataPanel1;
        private Label labelInfo;
        private Label labelTitle;
        private PictureBox pictureBoxIcon;
        private FlowLayoutPanel PanelName;
    }
}
