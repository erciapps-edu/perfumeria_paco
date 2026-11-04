using CommunityToolkit.Mvvm.ComponentModel;
using PerfumeriaPaco.Services;
using PerfumeriaPaco.Views;

namespace PerfumeriaPaco.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public NavigationService Navegacion { get; } = new();
    

    public MainViewModel()
    {
        var home = new HomeViewModel();
        
        Navegacion.ListaVistas.Add(home);

        Navegacion.VistaActual = home;
    }
}