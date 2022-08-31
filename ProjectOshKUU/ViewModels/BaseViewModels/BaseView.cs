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

        #region Properties
        private string? _Number1;
        public string? Number1
        {
            get
            {
                return _Number1;
            }
            set
            {
                Set(ref _Number1, value);
            }
        }
        private string? _Number2;
        public string? Number2
        {
            get
            {
                return _Number2;
            }
            set
            {
                Set(ref _Number2, value);
            }
        }

        private string? _Number3;
        public string? Number3
        {
            get
            {
                return _Number3;
            }
            set
            {
                Set(ref _Number3, value);
            }
        }
        private string? _Number4;
        public string? Number4
        {
            get
            {
                return _Number4;
            }
            set
            {
                Set(ref _Number4, value);
            }
        }

        private string? _Number5;
        public string? Number5
        {
            get
            {
                return _Number5;
            }
            set
            {
                Set(ref _Number5, value);
            }
        }

        private string? _Number6;
        public string? Number6
        {
            get
            {
                return _Number6;
            }
            set
            {
                Set(ref _Number6, value);
            }
        }
        private string? _Number7;
        public string? Number7
        {
            get
            {
                return _Number7;
            }
            set
            {
                Set(ref _Number7, value);
            }
        }
        private string? _Number8;
        public string? Number8
        {
            get
            {
                return _Number8;
            }
            set
            {
                Set(ref _Number8, value);
            }
        }
        private string? _Number9;
        public string? Number9
        {
            get
            {
                return _Number9;
            }
            set
            {
                Set(ref _Number9, value);
            }
        }
        private string? _Number10;
        public string? Number10
        {
            get
            {
                return _Number10;
            }
            set
            {
                Set(ref _Number10, value);
            }
        }
        private string? _Number11;
        public string? Number11
        {
            get
            {
                return _Number11;
            }
            set
            {
                Set(ref _Number11, value);
            }
        }
        private string? _Number12;
        public string? Number12
        {
            get
            {
                return _Number12;
            }
            set
            {
                Set(ref _Number12, value);
            }
        }

        private string? _Number13;
        public string? Number13
        {
            get
            {
                return _Number13;
            }
            set
            {
                Set(ref _Number13, value);
            }
        }
        private string? _Number14;
        public string? Number14
        {
            get
            {
                return _Number14;
            }
            set
            {
                Set(ref _Number14, value);
            }
        }

        private string? _Number15;
        public string? Number15
        {
            get
            {
                return _Number15;
            }
            set
            {
                Set(ref _Number15, value);
            }
        }

        private string? _Number16;
        public string? Number16
        {
            get
            {
                return _Number16;
            }
            set
            {
                Set(ref _Number16, value);
            }
        }
        private string? _Number17;
        public string? Number17
        {
            get
            {
                return _Number17;
            }
            set
            {
                Set(ref _Number17, value);
            }
        }
        private string? _Number18;
        public string? Number18
        {
            get
            {
                return _Number18;
            }
            set
            {
                Set(ref _Number18, value);
            }
        }
        private string? _Number19;
        public string? Number19
        {
            get
            {
                return _Number19;
            }
            set
            {
                Set(ref _Number19, value);
            }
        }
        private string? _Number21;
        public string? Number21
        {
            get
            {
                return _Number21;
            }
            set
            {
                Set(ref _Number21, value);
            }
        }
        private string? _Number22;
        public string? Number22
        {
            get
            {
                return _Number22;
            }
            set
            {
                Set(ref _Number22, value);
            }
        }

        private string? _Number23;
        public string? Number23
        {
            get
            {
                return _Number23;
            }
            set
            {
                Set(ref _Number23, value);
            }
        }
        private string? _Number24;
        public string? Number24
        {
            get
            {
                return _Number24;
            }
            set
            {
                Set(ref _Number24, value);
            }
        }

        private string? _Number25;
        public string? Number25
        {
            get
            {
                return _Number25;
            }
            set
            {
                Set(ref _Number25, value);
            }
        }

        private string? _Number26;
        public string? Number26
        {
            get
            {
                return _Number26;
            }
            set
            {
                Set(ref _Number26, value);
            }
        }
        private string? _Number27;
        public string? Number27
        {
            get
            {
                return _Number27;
            }
            set
            {
                Set(ref _Number27, value);
            }
        }
        private string? _Number28;
        public string? Number28
        {
            get
            {
                return _Number28;
            }
            set
            {
                Set(ref _Number28, value);
            }
        }
        private string? _Number29;
        public string? Number29
        {
            get
            {
                return _Number29;
            }
            set
            {
                Set(ref _Number29, value);
            }
        }
        private string? _Number20;
        public string? Number20
        {
            get
            {
                return _Number20;
            }
            set
            {
                Set(ref _Number20, value);
            }
        }


        #endregion Properties
    }
}
