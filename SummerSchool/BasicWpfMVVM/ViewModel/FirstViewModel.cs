using BasicWpfMVVM.Base;
using BasicWpfMVVM.Commands;
using BasicWpfMVVM.Model;
using System.Windows;

namespace BasicWpfMVVM.ViewModel
{
    public class FirstViewModel : ViewModelBase
    {
        #region  Must Be

           private readonly IViewService _viewService;

           public FirstViewModel(IViewService viewService)
           {
               _viewService = viewService;
               InitializeCommands();
           }
           private void InitializeCommands()
           {
               // commands that are used in the view FirstView and its functions
         
               BackToHome = new DelegateCommand(OnBackToHomeCommandExecute);
               GoBack = new DelegateCommand(OnGoBackCommandExecute);

           }

        
           /// <summary>
           /// Define for the button BackToHome
           /// </summary>
           public DelegateCommand BackToHome { get; private set; }
           /// <summary>
           /// Define for the button Navigate
           /// </summary>
           public DelegateCommand GoBack { get; private set; }

        #endregion

        #region  Properties

        
        #endregion

        #region Commands
           private ViewContext _currentContext;

           protected override void OnSetContext(object context)
           {
               base.OnSetContext(context);
               _currentContext = (ViewContext)context;
               GoBackToView = _currentContext.GoBackToView;
           }

           private void OnBackToHomeCommandExecute()
           {
               _viewService.ShowView(Globals.ViewNameHomeView);
           }

          private void OnGoBackCommandExecute()
          {
            _viewService.ShowView(GoBackToView);
          }

      
        #endregion


          public string GoBackToView { get; set; }
    }
}

