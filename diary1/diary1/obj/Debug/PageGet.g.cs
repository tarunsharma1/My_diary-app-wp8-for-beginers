﻿#pragma checksum "c:\users\tarun_000\documents\visual studio 2012\Projects\diary1\diary1\PageGet.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E7F0241226B41B52E45F1C58201E8690"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace diary1 {
    
    
    public partial class PageGet : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox Date1;
        
        internal System.Windows.Controls.TextBox Time1;
        
        internal System.Windows.Controls.TextBox Title1;
        
        internal System.Windows.Controls.TextBox Notes1;
        
        internal System.Windows.Controls.Button Back1;
        
        internal System.Windows.Controls.Button Retrieve1;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/diary1;component/PageGet.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Date1 = ((System.Windows.Controls.TextBox)(this.FindName("Date1")));
            this.Time1 = ((System.Windows.Controls.TextBox)(this.FindName("Time1")));
            this.Title1 = ((System.Windows.Controls.TextBox)(this.FindName("Title1")));
            this.Notes1 = ((System.Windows.Controls.TextBox)(this.FindName("Notes1")));
            this.Back1 = ((System.Windows.Controls.Button)(this.FindName("Back1")));
            this.Retrieve1 = ((System.Windows.Controls.Button)(this.FindName("Retrieve1")));
        }
    }
}

