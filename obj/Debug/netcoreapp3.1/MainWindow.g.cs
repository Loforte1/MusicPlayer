﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83D85A6CDCF79BCAF78DA352F9F3C89B1808604A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MusicPlayer;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MusicPlayer {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid_Grid;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Player_Grid;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Buttons_Grid;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider Volume_Slider;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Volume_Image;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image PlayButton_Image;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image PauseButton_Image;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image RewindButton_Image;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image FowardButton_Image;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox VolumeNumber_TextBox;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MusicPlaying_TextBox;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FileBrowser_Button;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ArtistName_Label;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SongName_Label;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image AlbumArt_Image;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SongList_Grid;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListOfSongs_ListView;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MusicPlayer;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\MainWindow.xaml"
            ((MusicPlayer.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MainGrid_Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.Player_Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.Buttons_Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.Volume_Slider = ((System.Windows.Controls.Slider)(target));
            
            #line 12 "..\..\..\MainWindow.xaml"
            this.Volume_Slider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.Volume_Slider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Volume_Image = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.PlayButton_Image = ((System.Windows.Controls.Image)(target));
            
            #line 14 "..\..\..\MainWindow.xaml"
            this.PlayButton_Image.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Play_Button_Test_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.PauseButton_Image = ((System.Windows.Controls.Image)(target));
            
            #line 29 "..\..\..\MainWindow.xaml"
            this.PauseButton_Image.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.PauseButton_Image_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.RewindButton_Image = ((System.Windows.Controls.Image)(target));
            
            #line 44 "..\..\..\MainWindow.xaml"
            this.RewindButton_Image.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.RewindButton_Image_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 10:
            this.FowardButton_Image = ((System.Windows.Controls.Image)(target));
            
            #line 59 "..\..\..\MainWindow.xaml"
            this.FowardButton_Image.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.FowardButton_Image_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 11:
            this.VolumeNumber_TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.MusicPlaying_TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.FileBrowser_Button = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\MainWindow.xaml"
            this.FileBrowser_Button.Click += new System.Windows.RoutedEventHandler(this.FileBrowser_Button_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.ArtistName_Label = ((System.Windows.Controls.Label)(target));
            return;
            case 15:
            this.SongName_Label = ((System.Windows.Controls.Label)(target));
            return;
            case 16:
            this.AlbumArt_Image = ((System.Windows.Controls.Image)(target));
            return;
            case 17:
            this.SongList_Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 18:
            this.ListOfSongs_ListView = ((System.Windows.Controls.ListView)(target));
            
            #line 84 "..\..\..\MainWindow.xaml"
            this.ListOfSongs_ListView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListOfSongs_ListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

