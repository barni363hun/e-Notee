﻿#pragma checksum "..\..\..\SubWindows\AddWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2EE3BC82288CAA9F1DCA055CE57019198467119973DB20DFB6DB6DB921BAA15A"
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
using e_Note;


namespace e_Note {
    
    
    /// <summary>
    /// AddWindow
    /// </summary>
    public partial class AddWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\SubWindows\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal e_Note.AddWindow Addwindow;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\SubWindows\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid háttér;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\SubWindows\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Felsorolás;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\SubWindows\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Táblázat;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\SubWindows\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Jegyzet;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\SubWindows\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Add;
        
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
            System.Uri resourceLocater = new System.Uri("/e-Note;component/subwindows/addwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SubWindows\AddWindow.xaml"
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
            this.Addwindow = ((e_Note.AddWindow)(target));
            return;
            case 2:
            this.háttér = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.Felsorolás = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.Táblázat = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\SubWindows\AddWindow.xaml"
            this.Táblázat.Click += new System.Windows.RoutedEventHandler(this.table_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Jegyzet = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\SubWindows\AddWindow.xaml"
            this.Jegyzet.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Add = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
