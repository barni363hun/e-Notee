﻿#pragma checksum "..\..\..\SubWindows\NoteEditor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "483BE66D551A57E4DE96BF5B9B0F03051CF0DCF61C7CA6D2D85509F38C4FD163"
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
using e_Note.SubWindows;


namespace e_Note.SubWindows {
    
    
    /// <summary>
    /// NoteEditor
    /// </summary>
    public partial class NoteEditor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\SubWindows\NoteEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label L_Cím;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\SubWindows\NoteEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label L_Tartalom;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\SubWindows\NoteEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label L_Címkék;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\SubWindows\NoteEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Cim;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\SubWindows\NoteEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Címkék;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\SubWindows\NoteEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tartalom;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\SubWindows\NoteEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Kész;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\SubWindows\NoteEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteJegyzet;
        
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
            System.Uri resourceLocater = new System.Uri("/e-Note;component/subwindows/noteeditor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SubWindows\NoteEditor.xaml"
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
            this.L_Cím = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.L_Tartalom = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.L_Címkék = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.Cim = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Címkék = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Tartalom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Kész = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\SubWindows\NoteEditor.xaml"
            this.Kész.Click += new System.Windows.RoutedEventHandler(this.Kész_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DeleteJegyzet = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\SubWindows\NoteEditor.xaml"
            this.DeleteJegyzet.Click += new System.Windows.RoutedEventHandler(this.DeleteJegyzet_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

