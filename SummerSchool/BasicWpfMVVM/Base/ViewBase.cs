using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;

namespace BasicWpfMVVM.Base
{
    public class UserControlBase : UserControl
    {
        public UserControlBase()
        {
        }

        public void SetViewModelContext(object context)
        {
            ((ViewModelBase)DataContext).SetContext(context);
        }    
    }
}
