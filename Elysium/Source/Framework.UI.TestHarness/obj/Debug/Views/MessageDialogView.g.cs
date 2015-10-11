﻿#pragma checksum "..\..\..\Views\MessageDialogView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "83AC868ADEC3C38D540DB49FE8215F84"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Elysium.Parameters;
using Framework.UI;
using Framework.UI.Commands;
using Framework.UI.Controls;
using Framework.UI.Converters;
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


namespace Framework.UI.TestHarness.Views {
    
    
    /// <summary>
    /// MessageDialogView
    /// </summary>
    public partial class MessageDialogView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\Views\MessageDialogView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HeaderTextBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Views\MessageDialogView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ContentTextBox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Views\MessageDialogView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ButtonComboBox;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Views\MessageDialogView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TypeComboBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Framework.UI.TestHarness;component/views/messagedialogview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MessageDialogView.xaml"
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
            this.HeaderTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.ContentTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ButtonComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.TypeComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            
            #line 73 "..\..\..\Views\MessageDialogView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnShowMessageDialogView);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 79 "..\..\..\Views\MessageDialogView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnShowCustomMessageDialogView);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

