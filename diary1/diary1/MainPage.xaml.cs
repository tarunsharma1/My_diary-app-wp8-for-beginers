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
using SQLite;//1
using System.IO;//2
using Windows.Storage;//4
using System.Windows.Navigation;//3





namespace diary1
{
    public partial class MainPage : PhoneApplicationPage
    {
        /// <summary>
        /// The database path.
        /// </summary>
       // public static string DB_PATH = System.IO.Path.Combine(System.IO.Path.Combine(ApplicationData.Current.LocalFolder.Path, "sample.sqlite"));
        /// <summary>
        /// The sqlite connection.
        /// </summary>

        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }
       
       

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PageSet.xaml", UriKind.Relative));
        }

        private void Retrieve_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PageGet.xaml",UriKind.Relative));
        }
        

    }
    public sealed class Diary
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string CreationDate { get; set; }
        public string CreationTime { get; set; }
    }
    
}