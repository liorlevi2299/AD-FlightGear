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

namespace AD_FlightGear.Controls
{
    /// <summary>
    /// Interaction logic for speed.xaml
    /// </summary>
    public partial class speed : UserControl
    {

        public speed()
        {
            InitializeComponent();
            this.input.Text = "1.0";
        }

        private speedVM vm;
        public speedVM VM
        {
            get { return vm; }
            set { this.vm = value; }
        }

        public void setVM(speedVM newvm) /// לבדוק אם הוא יכול גם ללכת לסטר של התכונה
        {
            this.vm = newvm;
            DataContext = vm;
        }


        private void input_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        /*        private void Button_Click(object sender, RoutedEventArgs e)
                {
        *//*            this.textCheck.Text = input.Text;
                    vm.VM_Speed = input.Text;*//*
                }*/

        private void KeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                vm.VM_Speed = input.Text;
            }
        }
    }
}