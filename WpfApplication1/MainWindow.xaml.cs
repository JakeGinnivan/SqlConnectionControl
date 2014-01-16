using System.ComponentModel;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : INotifyPropertyChanged
    {
        private SqlConnectionString _test;

        public MainWindow()
        {
            InitializeComponent();
        }

        public SqlConnectionString Test
        {
            get { return _test; }
            set
            {
                _test = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Test"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
