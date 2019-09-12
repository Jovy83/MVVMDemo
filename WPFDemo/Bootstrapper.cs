using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFDemo.ViewModels;

namespace WPFDemo {
    // starting point for our application with caliburn micro mvvm
    public class Bootstrapper : BootstrapperBase {
        public Bootstrapper() {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e) {
            DisplayRootViewFor<ShellViewModel>(); // shellviewmodel is like the base/standard viewmodel. it's like mainwindow.xaml is for the default template

            // we're basically saying: this is what we want to launch which is the ShellVM
        }

    }
}
