﻿#pragma checksum "..\..\CarsWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "26F485E48716CE354C60B8D3EA73AC5E9C27139D2DB395818910BDB4A31F8B57"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using laba2;


namespace laba2 {
    
    
    /// <summary>
    /// CarsWindow
    /// </summary>
    public partial class CarsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\CarsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid CarsData;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\CarsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox modelBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\CarsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox numberBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\CarsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox colorBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\CarsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button modelButton;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\CarsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button numberButton;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\CarsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button colorButton;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\CarsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clearBotton;
        
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
            System.Uri resourceLocater = new System.Uri("/laba2;component/carswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CarsWindow.xaml"
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
            this.CarsData = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.modelBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.numberBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.colorBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.modelButton = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\CarsWindow.xaml"
            this.modelButton.Click += new System.Windows.RoutedEventHandler(this.modelButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.numberButton = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\CarsWindow.xaml"
            this.numberButton.Click += new System.Windows.RoutedEventHandler(this.numberButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.colorButton = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\CarsWindow.xaml"
            this.colorButton.Click += new System.Windows.RoutedEventHandler(this.colorButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.clearBotton = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\CarsWindow.xaml"
            this.clearBotton.Click += new System.Windows.RoutedEventHandler(this.clearBotton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

