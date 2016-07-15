﻿using BasicWpfMVVM.Base;
using BasicWpfMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BasicWpfMVVM.View
{
    /// <summary>
    /// Interaction logic for SecondBuildingView.xaml
    /// </summary>
    public partial class SecondBuildingView : UserControlBase
    {
        public SecondBuildingView()
        {
            InitializeComponent();
        }

        public SecondBuildingViewModel ViewModel
        {
            get
            {
                return (SecondBuildingViewModel)DataContext;
            }
        }
    }
}
