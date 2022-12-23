using Caliburn.Micro;
using TRMDesktopUI.EventModels;

namespace TRMDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogInEvent>
    {
        private IEventAggregator _eventAggregator;
        private SimpleContainer _container;
        private SalesViewModel _salesVM;

        public ShellViewModel(IEventAggregator eventAggregator, SimpleContainer container, SalesViewModel salesVM)
        {
            _eventAggregator = eventAggregator;
            _container = container;
            _salesVM = salesVM;

            _eventAggregator.Subscribe(this);

            ActivateItem(_container.GetInstance<LoginViewModel>());
        }

        public void Handle(LogInEvent _)
        {
            ActivateItem(_salesVM);
        }
    }
}
