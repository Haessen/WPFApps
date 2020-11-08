using Caliburn.Micro;
using System.Windows;

namespace CM
{
    public class ShellViewModel : PropertyChangedBase, IShell
    {
        /*------------------------------------------ Fields ------------------------------------------*/
        private string _firstName = "Óà";
        private string _lastName = "îñºè";

        /*---------------------------------------- Properties ----------------------------------------*/
        public string FullName => $"{FirstName} {LastName}";
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName == value) { return; }
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName == value) { return; }
                _lastName = value;
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        /*----------------------------------- Dependency Properties ----------------------------------*/

        /*--------------------------------------- Constructors ---------------------------------------*/

        /*-------------------------------------- Public Methods --------------------------------------*/
        public void Test(string firstname, string lastname)
        {
            FirstName = null;
            LastName = null;
        }
        public bool CanTest(string firstname, string lastname)
        {
            return !string.IsNullOrWhiteSpace(firstname) || !string.IsNullOrWhiteSpace(lastname);
        }

        /*-------------------------------------- Private Methods -------------------------------------*/










    }


}