using System.Windows;

namespace CM
{
    public class ShellViewModel : Caliburn.Micro.PropertyChangedBase, IShell
    {
        public string Data { get; set; } = "Hello";

        public void Test()
        {
            MessageBox.Show("It's a Button.");
        }

        private string _dataTest = "Hello";

        public string DataTest
        {
            get { return _dataTest; }
            set
            {
                if (_dataTest == value) { return; }
                _dataTest = value;
                NotifyOfPropertyChange(() => DataTest);
            }
        }

    }

    
}