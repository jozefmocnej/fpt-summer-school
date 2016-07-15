using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicWpfMVVM.Base
{
    public interface IViewService
    {
        void ShowView(string viewName);
        void ShowView(string viewName, object context);
    }
}
