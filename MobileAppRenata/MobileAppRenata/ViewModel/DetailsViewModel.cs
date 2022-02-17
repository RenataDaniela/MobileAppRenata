using MobileAppRenata.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MobileAppRenata.ViewModel
{
    public class DetailsViewModel : BaseViewModel
    {
        ObservableCollection <Services> services;
        public ObservableCollection <Services> Services;
    {
        get { return services; }
        set
        {
            services = value;
            OnPropertyChanged();
        }
    }
    private Services selectedServices
    public Services SelectedServices
    {
        get { return selectedServices; }
        set
        {
            selectedServices = value;
            OnPropertyChanged();
        }
    }
private int position;
public int Position
{
    get
    {
        if (position != services.IndexOf(selectedServices))
            return services.IndexOf(selectedServices);
        return position;
    }
    set
    {
        position = value;
        selectedServices = services[position];
        OnPropertyChanged();
        OnPropertyChanged(nameof(SelectedServices));
    }
}
public IComand ChangePositionComand => new Comand(ChangePosition);
public void ChangePosition (object obj, int Position, object services)
{
    string direction = (string)obj;
    if (direction == "L")
    {
        if (position == 0)
        {
            Position = services.Count - 1;
            return;
        }
        Position -= 1;
    }
    else if (direction == "R")
    {
        if (Position == services.Count -1)
        {
            Position = 0;
            return;
        }
        Position += 1;
    }
}
    }
}
void OnPropertyChanged(string v)
{
    throw new NotImplementedException();
}

object SelectedServices()
{
    throw new NotImplementedException();
}