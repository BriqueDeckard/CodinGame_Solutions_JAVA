Create a project named "appName.CrossCutting.IoC" ;

Into CrossCutting.IoC :
	Add nuget package Unity - version=4.0.1
	Create a class named IoCUnityContainer that inherits from UnityContainer;
	Implements Initialize()

Into appName project :
	Add nuget package Prism.Unity - version= 6.3.0
	Create a BootStrapper class that inherits from UnityBootsrapper

	Into App.xaml.cs, Override the OnStartupMethod, instantiate the Bootstrapper into it, and invoke the Bootstrapper.run method.

	Into the BootStrapper class :
		Override and implement ConfigureContainer(), and add the IoCUnityContainer extension to the bootstrapper container.
		Override and implement the CreateShell() method, that uses the container to resolve the main window and return it into a DependencyObject.     using Microsoft.Practices.Unity;
		Override and implement Initialize module. Instantiate a new MainWindosw, and Show/Activate/Focus it.
		Override and implement InitializeShell and set the shell into the CurrentMainWindows 

Create a project named "appName.Core" ;
	Into Core : 
		Create a ViewModelBase class that implements IDisposable
		Into ViewModelBase :
			Add the ImplementPropertyChanged attribute  (package id="PropertyChanged.Fody" version="1.53.0")
			Add IEventAggregator and IRegionManager properties
			Add a constructor that Resolve the EventAggregator and the RegionManager by using the ServiceLocator ( package id="CommonServiceLocator" version="1.3")

	Into appName project :
	- Into app.xaml
		Remove the StartupUri
	- Into the BootStrapper class :
		Override and implement ConfigureViewModelLocator
		Set the ViewModelLocationProvider and initialize the view model before returning it.

into the MainWindows .xaml
	Define the regions into the MainWindows .xaml
	Add xmlns:prism="http://prismlibrary.com/"
Add prism:ViewModelLocator.AutoWireViewModel="True"

And you're done with the ViewModelBase

Create a specialized view model for MainWindow that inherit from ViewModelBase


Create a Library that will contain some views, and add id="Prism.Wpf" version="6.3.0"  to it


