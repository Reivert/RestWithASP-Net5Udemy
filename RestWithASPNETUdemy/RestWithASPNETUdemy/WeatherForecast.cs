using System;

namespace RestWithASPNETUdemy
{
    public class WeatherForecast
    {
        ///D/ProjetosW4D/Projetos/Udemy/RestWithASP-Net5Udemy/RestWithASP-Net5Udemy
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
