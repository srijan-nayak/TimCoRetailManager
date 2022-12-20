using Caliburn.Micro;
using System;
using System.Threading.Tasks;
using TRMDesktopUI.Helpers;

namespace TRMDesktopUI.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _userName;
        private string _password;
        private IAPIHelper _apiHelper;

        public LoginViewModel(IAPIHelper aPIHelper)
        {
            _apiHelper = aPIHelper;
        }

        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                NotifyOfPropertyChange(() => UserName);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }

        public bool CanLogIn => !string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(Password);

        public async Task LogIn()
        {
            try
            {
                var result = await _apiHelper.Authenticate(UserName, Password);

            }
            catch (Exception ex)
            {
                // TODO: Handle incorrect credentials for user login
                Console.WriteLine(ex.Message);
            }
        }
    }
}
