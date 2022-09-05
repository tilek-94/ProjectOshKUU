using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OshKUU.ViewModels.BaseViewModels
{
    public class BaseView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
        protected virtual bool Set<T>(ref T filed, T value, [CallerMemberName] string PropertyName = null)
        {
            if (Equals(filed, value)) return false;
            filed = value;
            OnPropertyChanged(PropertyName);
            return true;
        }
        public void Dispose()
        {
            Dispose(true);
        }
        private bool _Disposed;
        protected virtual void Dispose(bool Disposing)
        {
            if (!Disposing || _Disposed) return;
            _Disposed = true;
        }

       

    #region PropertiesOsnov
    private string _NameToilet;
        public string NameToilet
        {
            get { return _NameToilet; }
            set { Set(ref _NameToilet, value); }
        }
        private string _LabrName;
        public string LabrName
        {
            get { return _LabrName; }
            set { Set(ref _LabrName, value); }
        }
        private string _Restorant;
        public string Restorant
        {
            get { return _Restorant; }
            set { Set(ref _Restorant, value); }
        }
        private string _SingleWindow;
        public string SingleWindow
        {
            get { return _SingleWindow; }
            set { Set(ref _SingleWindow, value); }
        }
        private string _Location;
        public string Location
        {
            get { return _Location; }
            set { Set(ref _Location, value); }
        }
        #endregion PropertiesOsnov

       
    }
}
