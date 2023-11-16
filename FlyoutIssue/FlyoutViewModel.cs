using System.ComponentModel;

namespace FlyoutIssue
{
    internal class FlyoutViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private bool _isFlyoutOpen;

        public bool IsFlyoutOpen
        {
            get => _isFlyoutOpen;
            set
            {
                _isFlyoutOpen = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsFlyoutOpen)));
            }
        }
    }
}
