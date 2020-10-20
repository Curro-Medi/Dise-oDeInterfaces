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
using System.Windows.Shapes;

namespace Practica_1_en_WPF
{
    /// <summary>
    /// Lógica de interacción para Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        private List<Persona> listapersonas;
        private MainWindow mainWindow;

        public Window3()
        {
            InitializeComponent();
        }

        public Window3(List<Persona> listapersonas, MainWindow mainWindow)
        {
            this.listapersonas = listapersonas;
            this.mainWindow = mainWindow;
        }
    }
}
