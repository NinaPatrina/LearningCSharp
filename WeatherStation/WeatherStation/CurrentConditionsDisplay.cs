using System;

namespace WeatherStation
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
        {
            private float temperature;
            private float humidity;
            readonly ISubject weatherData;

            public  CurrentConditionsDisplay(ISubject weatherData)
            {
                this.weatherData = weatherData;
                weatherData.RegisterObserver(this);
            }
            public void Update(float temperature, float humidity, float pressure)
            {
                this.temperature = temperature;
                this.humidity = humidity;
                Display();
            }
            public void Display()
            {
                Console.WriteLine("Current conditions:  " + temperature + "F degrees and  " + humidity + "% humidity");
            }
        }
    

    } 
