using MobileAppRenata.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MobileAppRenata.ViewModel
{
    public class LandingViewModel : BaseViewModel
    {
        public LandingViewModel()
        {
            services = GetServices();
        }
        public ObservableCollection<Services> services { get; set; }
        public ObservableCollection<Services> Services
        {
            get { return services; }
            set
            {
                Services = value;
                OnPropertyChanged();
            }
        }
        private Services selectedServices
        {
            get { return selectedServices; }
            set
            {
                selectedServices = value;
                OnPropertyChanged();
            }
        }
        public IComand SelectionComand => new Comand(DisplayServices);

        public void DisplayServices()
        {
            if (selectedServices != null)
            {
                var viewModel = new DetailsViewModel { SelectedServices = selectedServices, Services = services, Position = services.IndexOf };
                var detailsPage = new DetailsPage { BindingContext = viewModel };
                var navigation = Application.Current.MainPage as NavigationPage;
                navigation.PushAsync(detailsPage, true);
            }
        }
        private ObservableCollection<Services> GetServices()
        {
            return new ObservableCollection<Services>
            {
                new Services { Name = "Manichiura", Price = 12.99f, Image = "manichure.png", Description = "Lorem ipsum sit amet" },
                new Services { Name = "Pedichiura", Price = 14.99f, Image = "pedicure.png", Description = "Lorem ipsum sit amet" },
                new Services { Name = "Machiaj", Price = 20.98f, Image = "makeup.png", Description = "Lorem ipsum sit amet" },
                new Services { Name = "Masaj", Price = 40.99f, Image = "massage.png", Description = "Lorem ipsum sit amet" },
                new Services { Name = "Coafor", Price = 32.90f, Image = "hair.png", Description = "Lorem ipsum sit amet" },
                new Services { Name = "Tratamente faciale", Price = 52.99f, Image = "face.png", Description = "Lorem ipsum sit amet" }
            };
        }
    }
}
