namespace App_511_Weather
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataPanel1 = new DataPanel();
            labelSummary = new Label();
            labelTemperature = new Label();
            pictureBoxIcon = new PictureBox();
            labelCity = new Label();
            button1 = new Button();
            buttonGetData = new Button();
            weatherItemsPanel = new FlowLayoutPanel();
            textBoxCityName = new TextBox();
            dataPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // dataPanel1
            // 
            dataPanel1.BackColor = Color.Transparent;
            dataPanel1.Controls.Add(labelSummary);
            dataPanel1.Controls.Add(labelTemperature);
            dataPanel1.Controls.Add(pictureBoxIcon);
            dataPanel1.Controls.Add(labelCity);
            dataPanel1.Controls.Add(button1);
            dataPanel1.Location = new Point(20, 19);
            dataPanel1.Margin = new Padding(5);
            dataPanel1.Name = "dataPanel1";
            dataPanel1.Size = new Size(618, 336);
            dataPanel1.TabIndex = 0;
            // 
            // labelSummary
            // 
            labelSummary.AutoSize = true;
            labelSummary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelSummary.ForeColor = Color.WhiteSmoke;
            labelSummary.Location = new Point(28, 259);
            labelSummary.Margin = new Padding(5, 0, 5, 0);
            labelSummary.Name = "labelSummary";
            labelSummary.Size = new Size(155, 37);
            labelSummary.TabIndex = 6;
            labelSummary.Text = "Feels like...";
            // 
            // labelTemperature
            // 
            labelTemperature.AutoSize = true;
            labelTemperature.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            labelTemperature.ForeColor = Color.WhiteSmoke;
            labelTemperature.Location = new Point(315, 109);
            labelTemperature.Margin = new Padding(5, 0, 5, 0);
            labelTemperature.Name = "labelTemperature";
            labelTemperature.Size = new Size(217, 106);
            labelTemperature.TabIndex = 5;
            labelTemperature.Text = "10°C";
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Location = new Point(28, 86);
            pictureBoxIcon.Margin = new Padding(5);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(100, 100);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 4;
            pictureBoxIcon.TabStop = false;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelCity.ForeColor = Color.WhiteSmoke;
            labelCity.Location = new Point(28, 30);
            labelCity.Margin = new Padding(5, 0, 5, 0);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(338, 51);
            labelCity.TabIndex = 3;
            labelCity.Text = "Unknown city, AA";
            // 
            // button1
            // 
            button1.Location = new Point(-262, 438);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(153, 46);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonGetData
            // 
            buttonGetData.Location = new Point(484, 706);
            buttonGetData.Margin = new Padding(5);
            buttonGetData.Name = "buttonGetData";
            buttonGetData.Size = new Size(153, 46);
            buttonGetData.TabIndex = 4;
            buttonGetData.Text = "Get data";
            buttonGetData.UseVisualStyleBackColor = true;
            buttonGetData.Click += buttonGetData_Click;
            // 
            // weatherItemsPanel
            // 
            weatherItemsPanel.BackColor = Color.Transparent;
            weatherItemsPanel.Location = new Point(20, 389);
            weatherItemsPanel.Margin = new Padding(5);
            weatherItemsPanel.Name = "weatherItemsPanel";
            weatherItemsPanel.Size = new Size(618, 288);
            weatherItemsPanel.TabIndex = 5;
            // 
            // textBoxCityName
            // 
            textBoxCityName.Location = new Point(20, 707);
            textBoxCityName.Margin = new Padding(5);
            textBoxCityName.Name = "textBoxCityName";
            textBoxCityName.Size = new Size(452, 39);
            textBoxCityName.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(654, 762);
            Controls.Add(textBoxCityName);
            Controls.Add(weatherItemsPanel);
            Controls.Add(buttonGetData);
            Controls.Add(dataPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            dataPanel1.ResumeLayout(false);
            dataPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataPanel dataPanel1;
        private RoundedPictureBox roundedPictureBox1;
        private Button buttonGetData;
        private Button button1;
        private Label labelSummary;
        private Label labelTemperature;
        private PictureBox pictureBoxIcon;
        private Label labelCity;
        private FlowLayoutPanel weatherItemsPanel;
        private TextBox textBoxCityName;
    }
}
