﻿using System;
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
using System.Windows.Threading;
using System.Xaml;
using RasPi_Controller.Extension_Methods;
using RasPi_Controller.Models;
using RasPi_Controller.ViewModels;
using RasPi_Controller.Helpers;

namespace RasPi_Controller
{
    /// <summary>
    /// Interaction logic for RasPiControllerWindow.xaml
    /// </summary>
    public partial class RasPiControllerWindow : Window
    {
        public RasPiControllerWindow()
        {
            InitializeComponent();
            DataContext = new RasPiControllerWindowViewModel();
        }

        #region Changed Text

        private void TbxRasPiNetworkName_KeyDown(object sender, KeyEventArgs e)
        {
            //TextRange content = new TextRange(TbxRasPiNetworkName.Document.ContentStart, TbxRasPiNetworkName.Document.ContentEnd);
            //content.ApplyPropertyValue(ForegroundProperty, Brushes.Black);
        }

        private void TbxRasPiIpAddress_KeyDown(object sender, KeyEventArgs e)
        {
            //TextRange content = new TextRange(TbxRasPiIpAddress.Document.ContentStart, TbxRasPiIpAddress.Document.ContentEnd);
            //content.ApplyPropertyValue(ForegroundProperty, Brushes.Black);
        }

        private void TbxRasPiId_KeyDown(object sender, KeyEventArgs e)
        {
            //TextRange content = new TextRange(TbxRasPiId.Document.ContentStart, TbxRasPiId.Document.ContentEnd);
            //content.ApplyPropertyValue(ForegroundProperty, Brushes.Black);
        }

        private void TbxScriptId_KeyDown(object sender, KeyEventArgs e)
        {
            //TextRange content = new TextRange(TbxScriptId.Document.ContentStart, TbxScriptId.Document.ContentEnd);
            //content.ApplyPropertyValue(ForegroundProperty, Brushes.Black);
        }

#endregion

        private void EnableAll()
        {
            LbRasPis.IsEnabled = IsEnabled;
            LbxRasPis.IsEnabled = IsEnabled;
            LbScripts.IsEnabled = IsEnabled;
            LbxScripts.IsEnabled = IsEnabled;

            LbRasPiHeader.IsEnabled = IsEnabled;
            LbRasPiId.IsEnabled = IsEnabled;
            TbxRasPiId.IsEnabled = IsEnabled;
            LbRasPiNetworkName.IsEnabled = IsEnabled;
            TbxRasPiNetworkName.IsEnabled = IsEnabled;
            LbRasPiIpAddress.IsEnabled = IsEnabled;
            TbxRasPiIpAddress.IsEnabled = IsEnabled;
            LbRasPiUsername.IsEnabled = IsEnabled;
            TbxRasPiUsername.IsEnabled = IsEnabled;
            LbRasPiPassword.IsEnabled = IsEnabled;
            PwPasPiPassword.IsEnabled = IsEnabled;

            LbScriptHeader.IsEnabled = IsEnabled;
            LbScriptId.IsEnabled = IsEnabled;
            TbxScriptId.IsEnabled = IsEnabled;
            LbScriptName.IsEnabled = IsEnabled;
            TbxScriptName.IsEnabled = IsEnabled;
            LbScriptArguments.IsEnabled = IsEnabled;
            TbxScriptArguments.IsEnabled = IsEnabled;
            LbScriptDescription.IsEnabled = IsEnabled;
            TbxScriptDescription.IsEnabled = IsEnabled;
            LbScriptArgumentFormat.IsEnabled = IsEnabled;
            TbxScriptArgumentFormat.IsEnabled = IsEnabled;

            BtnSend.IsEnabled = IsEnabled;
            BtnTestIpAddress.IsEnabled = IsEnabled;
            BtnTestNetworkName.IsEnabled = IsEnabled;
            BtnSaveRasPi.IsEnabled = IsEnabled;
            BtnSaveScript.IsEnabled = IsEnabled;
            BtnSaveConfig.IsEnabled = IsEnabled;
        }

        private void BtnSend_Click(object sender, RoutedEventArgs e)
        {
        }
        private void BtnSaveScript_Click(object sender, RoutedEventArgs e)
        {
        }
        private void BtnSaveRasPi_Click(object sender, RoutedEventArgs e)
        {
        }
        private void BtnTestNetworkName_Click(object sender, RoutedEventArgs e)
        {
        }
        private void BtnTestIpAddress_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}