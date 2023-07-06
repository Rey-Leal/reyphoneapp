using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace ReyPhoneApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, RoutedEventArgs e)
        {
            if (txtTexto.Text.Equals("") || txtTexto.Text.Equals(" "))
            {
                MessageBox.Show("Digite um texto...", "Meu texto", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show(txtTexto.Text, "Meu texto", MessageBoxButton.OK);
            }
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            txtTexto.Text = "";
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do aplicativo?", "Logout", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                base.OnBackKeyPress(e);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}