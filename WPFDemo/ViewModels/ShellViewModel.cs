using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFDemo.Models;

namespace WPFDemo.ViewModels {
    // Screen allows more control over opening and closing it. we get events when the user closes the app. we can use to display save prompts (you have unsaved changed, do you want to save before closing?).
    public class ShellViewModel : Screen {

        private string _firstName = "JOVY";
        private string _lastName;
        private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();
        private PersonModel _personModel;


        public ShellViewModel() {
            People.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            People.Add(new PersonModel { FirstName = "Bill", LastName = "Jones" });
            People.Add(new PersonModel { FirstName = "Sue", LastName = "Storm" });
        }

        public string FirstName {
            get {
                return _firstName;
            }
            set {
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName); // notify anyone who want to listen that the FirstName property has changed
                NotifyOfPropertyChange(() => FullName); // whenever first name is changed, the full name is also changed. so notify property change of FullName 
            }
        }
        public string LastName {
            get { return _lastName; }
            set {
                _lastName = value;
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);
            }
        }
        public string FullName {
            get {
                return $"{FirstName} {LastName}";
            }
        }


        public BindableCollection<PersonModel> People {
            get { return _people; }
            set { _people = value; }
        }


        public PersonModel SelectedPerson {
            get { return _personModel; }
            set {
                _personModel = value;
                NotifyOfPropertyChange(() => SelectedPerson);
            }
        }

    }
}
