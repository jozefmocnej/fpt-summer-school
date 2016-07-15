using BasicWpfMVVM.Base;
using BasicWpfMVVM.Model;
using BasicWpfMVVM.View;
using BasicWpfMVVM.ViewModel;
using Microsoft.Practices.Unity;
using System.ComponentModel;
using System.Windows;

namespace BasicWpfMVVM
{
    public class UnityConfiguration
    {
        public IUnityContainer Container
        {
            get
            {
                if (IsInDesignModeStatic)
                {
                    return DesignConfiguration;
                }
                else
                {
                    return DefaultConfiguration;
                }
            }
        }

        #region Register ViewModels
         public ViewModelBase FirstViewModel
         {
             get
             {
                 return Container.Resolve<FirstViewModel>();
             }
         }
         public ViewModelBase SecondViewModel
         {
             get
             {
                 return Container.Resolve<SecondViewModel>();
             }
         }

         public ViewModelBase HomeViewModel
         {
             get
             {
                 return Container.Resolve<HomeViewModel>();
             }
         }

        public ViewModelBase BuildingsViewModel
         {
             get
             {
                 return Container.Resolve<BuildingsViewModel>();
             }
         }

        public ViewModelBase B1Floor0ViewModel
        {
            get
            {
                return Container.Resolve<B1Floor0ViewModel>();
            }
        }

        public ViewModelBase B1Floor1ViewModel
        {
            get
            {
                return Container.Resolve<B1Floor1ViewModel>();
            }
        }
        
        public ViewModelBase FirstBuildingViewModel
        {
            get
            {
                return Container.Resolve<FirstBuildingViewModel>();
            }
        }
        
        public ViewModelBase SecondBuildingViewModel
        {
            get
            {
                return Container.Resolve<SecondBuildingViewModel>();
            }
        }

        public ViewModelBase SearchViewModel
        {
            get
            {
                return Container.Resolve<SearchViewModel>();
            }
        }

        public ViewModelBase StatisticViewModel
        {
            get
            {
                return Container.Resolve<StatisticViewModel>();
            }
        }

        public ViewModelBase RoomViewModel
        {
            get
            {
                return Container.Resolve<RoomViewModel>();
            }
        }

        public ViewModelBase InfoViewModel
        {
            get
            {
                return Container.Resolve<InfoViewModel>();
            }
        }



        #endregion

        #region Default Configuration
        private IUnityContainer _defaultConfiguration;

        public IUnityContainer DefaultConfiguration
        {
            get
            {
                if (_defaultConfiguration == null)
                {
                    _defaultConfiguration = CreateDefaultConfiguration();
                }

                return _defaultConfiguration;
            }
        }

        /// <summary>
        /// add View models and Views into Container
        /// </summary>
        /// <returns></returns>
        private IUnityContainer CreateDefaultConfiguration()
        {
            var unityContainer = new UnityContainer();
            unityContainer.RegisterType<FirstViewModel>();
            unityContainer.RegisterType<SecondViewModel>();
            unityContainer.RegisterType<BuildingsViewModel>();
            unityContainer.RegisterType<HomeViewModel>();
            unityContainer.RegisterType<SearchViewModel>();
            unityContainer.RegisterType<B1Floor0ViewModel>();
            unityContainer.RegisterType<B1Floor1ViewModel>();
            unityContainer.RegisterType<FirstBuildingViewModel>();
            unityContainer.RegisterType<SecondBuildingViewModel>();
            unityContainer.RegisterType<StatisticViewModel>();
            unityContainer.RegisterType<RoomViewModel>();
            unityContainer.RegisterType<InfoViewModel>();

            unityContainer.RegisterType<UserControlBase, FirstView>(Globals.ViewNameFirstView);
            unityContainer.RegisterType<UserControlBase, SecondView>(Globals.ViewNameSecondView);
            unityContainer.RegisterType<UserControlBase, BuildingsView>(Globals.ViewNameBuildingsView);
            unityContainer.RegisterType<UserControlBase, HomeView>(Globals.ViewNameHomeView);
            unityContainer.RegisterType<UserControlBase, B1Floor0View>(Globals.ViewNameB1Floor0View);
            unityContainer.RegisterType<UserControlBase, B1Floor1View>(Globals.ViewNameB1Floor1View);
            unityContainer.RegisterType<UserControlBase, SearchView>(Globals.ViewNameSearchView);
           unityContainer.RegisterType<UserControlBase, FirstBuildingView>(Globals.ViewNameFirstBuildingsView);
           unityContainer.RegisterType<UserControlBase, SecondBuildingView>(Globals.ViewNameSecondBuildingsView);
           unityContainer.RegisterType<UserControlBase, StatisticView>(Globals.ViewNameStatisticView);
           unityContainer.RegisterType<UserControlBase, InfoView>(Globals.ViewNameInfoView);
           unityContainer.RegisterType<UserControlBase, RoomView>(Globals.RoomView);

            return unityContainer;
        }
        #endregion

        #region Design Mode Support
        private IUnityContainer _designerConfiguration;
        public IUnityContainer DesignConfiguration
        {
            get
            {
                if (_designerConfiguration == null)
                {
                    _designerConfiguration = CreateDesignerConfiguration();
                }

                return _designerConfiguration;
            }
        }

        private IUnityContainer CreateDesignerConfiguration()
        {

            var container = new UnityContainer();
            return container;
        }

        private static bool? _isInDesignMode;
        /// <summary>
        /// Gets a value indicating whether the control is in design mode
        /// (running in Blend or Visual Studio).
        /// </summary>
        public static bool IsInDesignModeStatic
        {
            get
            {
                if (!_isInDesignMode.HasValue)
                {
                    var prop = DesignerProperties.IsInDesignModeProperty;
                    _isInDesignMode
                        = (bool)DependencyPropertyDescriptor
                                     .FromProperty(prop, typeof(FrameworkElement))
                                     .Metadata.DefaultValue;
                }

                return _isInDesignMode.Value;
            }
        }
        #endregion
    }
}
