using Avalonia.Media.Imaging;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Extensions;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp.ViewModels
{
    public partial class WeatherViewModel : ViewModelBase
    {
        WeatherService _weatherService;

        public WeatherViewModel(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

    }
}
