﻿using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Курасач.View;
using Курасач.View_Model;

namespace Курасач;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new DataManager();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }

    private void Button_Click_1(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Это приложение созданно Комковым Никитой по варианту Страховое агентство", "Инфо", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void Button_Click_2(object sender, RoutedEventArgs e)
    {
        MessageWindowDB wnd = new MessageWindowDB();
        wnd.Show();
    }

    private void Button_Click_3(object sender, RoutedEventArgs e)
    {
        MessageContactWindowDB wnd = new MessageContactWindowDB();
        wnd.Show();
    }
}