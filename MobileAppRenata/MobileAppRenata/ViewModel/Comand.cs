using System;

namespace MobileAppRenata.ViewModel
{
    internal class Comand : IComand
    {
        private Action displayServices;

        public Comand(Action displayServices)
        {
            this.displayServices = displayServices;
        }
    }
}