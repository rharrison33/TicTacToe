﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1EB4E11B9758693F18D2163558DF75D6BAAD4B4F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace TicTacToe {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid BoardGrid;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Square00;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Square01;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Square02;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Square10;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Square11;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Square12;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Square20;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Square21;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Square22;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TicTacToe;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BoardGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Square00 = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\MainWindow.xaml"
            this.Square00.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            
            #line 20 "..\..\MainWindow.xaml"
            this.Square00.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MouseEnterHandler);
            
            #line default
            #line hidden
            
            #line 20 "..\..\MainWindow.xaml"
            this.Square00.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MouseExitHandler);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Square01 = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\MainWindow.xaml"
            this.Square01.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            
            #line 21 "..\..\MainWindow.xaml"
            this.Square01.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MouseEnterHandler);
            
            #line default
            #line hidden
            
            #line 21 "..\..\MainWindow.xaml"
            this.Square01.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MouseExitHandler);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Square02 = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\MainWindow.xaml"
            this.Square02.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            
            #line 22 "..\..\MainWindow.xaml"
            this.Square02.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MouseEnterHandler);
            
            #line default
            #line hidden
            
            #line 22 "..\..\MainWindow.xaml"
            this.Square02.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MouseExitHandler);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Square10 = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\MainWindow.xaml"
            this.Square10.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            
            #line 23 "..\..\MainWindow.xaml"
            this.Square10.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MouseEnterHandler);
            
            #line default
            #line hidden
            
            #line 23 "..\..\MainWindow.xaml"
            this.Square10.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MouseExitHandler);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Square11 = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\MainWindow.xaml"
            this.Square11.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            
            #line 24 "..\..\MainWindow.xaml"
            this.Square11.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MouseEnterHandler);
            
            #line default
            #line hidden
            
            #line 24 "..\..\MainWindow.xaml"
            this.Square11.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MouseExitHandler);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Square12 = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\MainWindow.xaml"
            this.Square12.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            
            #line 25 "..\..\MainWindow.xaml"
            this.Square12.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MouseEnterHandler);
            
            #line default
            #line hidden
            
            #line 25 "..\..\MainWindow.xaml"
            this.Square12.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MouseExitHandler);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Square20 = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\MainWindow.xaml"
            this.Square20.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            
            #line 26 "..\..\MainWindow.xaml"
            this.Square20.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MouseEnterHandler);
            
            #line default
            #line hidden
            
            #line 26 "..\..\MainWindow.xaml"
            this.Square20.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MouseExitHandler);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Square21 = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\MainWindow.xaml"
            this.Square21.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            
            #line 27 "..\..\MainWindow.xaml"
            this.Square21.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MouseEnterHandler);
            
            #line default
            #line hidden
            
            #line 27 "..\..\MainWindow.xaml"
            this.Square21.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MouseExitHandler);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Square22 = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\MainWindow.xaml"
            this.Square22.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            
            #line 28 "..\..\MainWindow.xaml"
            this.Square22.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MouseEnterHandler);
            
            #line default
            #line hidden
            
            #line 28 "..\..\MainWindow.xaml"
            this.Square22.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MouseExitHandler);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 31 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Reset_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

