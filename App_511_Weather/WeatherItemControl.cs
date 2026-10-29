using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App_511_Weather
{
    public partial class WeatherItemControl : UserControl
    {
        private WeatherItemData itemData;


        public WeatherItemControl()
        {
            InitializeComponent();

            SetBackColor();
        }

        public WeatherItemControl(WeatherItemData itemData)
        {
            InitializeComponent();

            this.itemData = itemData;

            SetBackColor();

            this.Load += WeatherItemControl_Load;
        }

        private void WeatherItemControl_Load(object? sender, EventArgs e)
        {
            ShowItemData();
        }

        private void SetBackColor()
        {
            this.BackColor = Color.Transparent;
        }

        private void ShowItemData()
        {
            if (itemData != null)
            {
                labelTitle.Text = itemData.Title;
                labelInfo.Text = itemData.Data;
            }
        }



    }
}
