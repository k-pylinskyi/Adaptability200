﻿#pragma checksum "..\..\..\View\DBView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BD5007E1D7B54DB1F0B239CB53609D8A0C9A9E819E4EDE76FB0ADDE98F3405C2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Adaptability200.View;
using Adaptability200.ViewModel;
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


namespace Adaptability200.View {
    
    
    /// <summary>
    /// DBView
    /// </summary>
    public partial class DBView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\View\DBView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PassBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\View\DBView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PasswordButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\View\DBView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FindByNameBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\View\DBView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FindByNameButton;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\View\DBView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid BaseGrid;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\View\DBView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Adaptability200;component/view/dbview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\DBView.xaml"
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
            this.PassBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 2:
            this.PasswordButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\View\DBView.xaml"
            this.PasswordButton.Click += new System.Windows.RoutedEventHandler(this.PasswordButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FindByNameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.FindByNameButton = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\View\DBView.xaml"
            this.FindByNameButton.Click += new System.Windows.RoutedEventHandler(this.FindByNameButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BaseGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.UpdateButton = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\View\DBView.xaml"
            this.UpdateButton.Click += new System.Windows.RoutedEventHandler(this.UpdateButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

