using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO;//
using Windows.Storage;//
using SQLite;//

namespace diary1
{
    public partial class PageGet : PhoneApplicationPage
    {
        public static string DB_PATH = Path.Combine(Path.Combine
            (ApplicationData.Current.LocalFolder.Path, "sample.sqlite"));
        // The sqlite connection.
        //
        private SQLiteConnection dbConn;
        
        public PageGet()
        {
            InitializeComponent();
        }

        private void Back1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Retrieve1_Click(object sender, RoutedEventArgs e)
        {
            dbConn = new SQLiteConnection(DB_PATH);
            var tpdata = dbConn.Query<Diary>
                ("select * from diary where Title ='" 
                + Title1.Text + "'").FirstOrDefault();
            Title1.Text = tpdata.Title;
            Notes1.Text = tpdata.Text;
            Time1.Text = tpdata.CreationTime;
            Date1.Text = tpdata.CreationDate;
        }

       
    }
}