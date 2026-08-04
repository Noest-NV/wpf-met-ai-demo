using System.Collections.ObjectModel;
using AI_WPF.Models;

namespace AI_WPF.Services
{
    public interface ICatalogueService
    {
        ObservableCollection<Robot> Robots { get; }
    }
}
