using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using SQLite;//
using System.IO;//
using Windows.Storage;//

namespace diary1
{
    public partial class PageSet : PhoneApplicationPage
    {
        // The database path.
       public static string DB_PATH = Path.Combine(Path.Combine
           (ApplicationData.Current.LocalFolder.Path, "sample.sqlite"));

       private SQLiteConnection dbConn;


        public PageSet()
        {
           InitializeComponent();
           Date.Text = DateTime.Now.Date.ToShortDateString() + "";
           Time.Text = DateTime.Now.TimeOfDay.ToString()+ "";

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Add1_Click(object sender, RoutedEventArgs e)
        {
            dbConn = new SQLiteConnection(DB_PATH);
            dbConn.CreateTable<Diary>();
            Diary task = new Diary()
            {
                Title = Title.Text,
                Text = Notes.Text,
                CreationDate = Date.Text,
                CreationTime = Time.Text
            };

            //inserting into database
            dbConn.Insert(task);



           

        }

       
       

        

       
    }
}