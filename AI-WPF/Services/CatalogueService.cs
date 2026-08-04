using System.Collections.ObjectModel;
using AI_WPF.Models;

namespace AI_WPF.Services
{
    public class CatalogueService : ICatalogueService
    {
        public ObservableCollection<Robot> Robots { get; }

        public CatalogueService()
        {
            Robots = new ObservableCollection<Robot>
            {
                new Robot { Name = "Mecha-Scout",   Description = "Fast reconnaissance unit with dual-optics vision.",  Price =  1499m, ImagePath = "Images/robot1.png" },
                new Robot { Name = "Mecha-Guard",   Description = "Heavy defensive unit with reinforced plating.",       Price =  2199m, ImagePath = "Images/robot2.png" },
                new Robot { Name = "Mecha-Worker",  Description = "General-purpose industrial arm and lifter.",          Price =   999m, ImagePath = "Images/robot3.png" },
                new Robot { Name = "Mecha-Medic",   Description = "Field medical drone with diagnostics suite.",         Price =  1799m, ImagePath = "Images/robot4.png" },
                new Robot { Name = "Mecha-Chef",    Description = "Compact culinary assistant for small kitchens.",      Price =   799m, ImagePath = "Images/robot5.png" },
                new Robot { Name = "Mecha-Titan",   Description = "Flagship model. Reinforced, powerful, unforgettable.",Price =  4999m, ImagePath = "Images/robot6.png" },
            };
        }
    }
}
