namespace App_511_Weather
{
    public partial class Form1 : Form
    {
        private WeatherManager weatherManager = new();
        private WeatherResponse currentWeather;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            SetBackground();
        }

        private void SetBackground()
        {
            this.BackgroundImage = Image.FromFile("Backgrounds/clouds_bg.jpg");
        }

        private void ShowWeatherData(WeatherResponse weather)
        {
            if (weather != null)
            {
                labelCity.Text = $"{weather.Name}, {weather.Sys.Country}";
                labelTemperature.Text = $"{(int)weather.Main.Temp}°C";
                labelSummary.Text = $"Feels like {Math.Round(weather.Main.Feels_Like)}°C, " +
                    $"{WeatherDataConverter.GetCloudinessDescription(weather.Clouds.All)}, " +
                    $"{WeatherDataConverter.WindSpeedToDescription(weather.Wind.Speed)}";

                try
                {
                    string iconUrl = $"http://openweathermap.org/img/w/{weather.Weather[0].Icon}.png";
                    pictureBoxIcon.LoadAsync(iconUrl);
                }
                catch (Exception ex)
                { }
            }
            else
            {
                labelCity.Text = "Error occurred";
                labelTemperature.Text = "?°C";
                labelSummary.Text = "Unknown info";
            }
        }

        private async Task<WeatherResponse> GetWeatherData(string city)
        {
            WeatherResponse weather = await weatherManager.GetWeatherAsync(city);

            return weather;
        }

        private async void buttonGetData_Click(object sender, EventArgs e)
        {
            currentWeather = await GetWeatherData(textBoxCityName.Text);
            ShowWeatherData(currentWeather);

            weatherItemsPanel.Controls.Clear();
            List<WeatherItemData> items = FillDataItems(currentWeather);
            for (int i = 0; i < items.Count; i++)
            {
                weatherItemsPanel.Controls.Add(new WeatherItemControl(items[i]));
            }
        }

            //Wind,
            //Humidity,
            //Pressure,
            //Clouds,
            //Visibility,
            //Sunset
        private List<WeatherItemData> FillDataItems(WeatherResponse weather)
        {
            var items = new List<WeatherItemData>()
            {
                new WeatherItemData(WeatherItemType.Wind,
                    $"{Math.Round(weather.Wind.Speed)} m/s {WeatherDataConverter.WindDirectionToCompass(weather.Wind.Deg, true)}"),
                new WeatherItemData(WeatherItemType.Humidity,
                    $"{weather.Main.Humidity} %"),
                new WeatherItemData(WeatherItemType.Pressure,
                    $"{weather.Main.Pressure} hPa"),
                new WeatherItemData(WeatherItemType.Clouds,
                    $"{WeatherDataConverter.GetCloudinessDescription(weather.Clouds.All)}"),
                new WeatherItemData(WeatherItemType.Visibility,
                    $"{weather.Visibility / 1000} km"),
                new WeatherItemData(WeatherItemType.Sunset,
                    $"{WeatherDataConverter.ConvertUnixTimestampToDateTime(weather.Sys.Sunset)}")
            };

            return items;
        }
    }
}
