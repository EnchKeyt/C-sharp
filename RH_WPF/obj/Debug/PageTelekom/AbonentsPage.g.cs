﻿#pragma checksum "..\..\..\PageTelekom\AbonentsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "43D324D4F6B5CA963CB00AC204FB407F630D733D835E96D3EC721967C9A7356E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using RH_WPF.PageTelekom;
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


namespace RH_WPF.PageTelekom {
    
    
    /// <summary>
    /// AbonentsPage
    /// </summary>
    public partial class AbonentsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\PageTelekom\AbonentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid AbonentsGrid;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\PageTelekom\AbonentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton NeAktivRadioButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\PageTelekom\AbonentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton VseRadioButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\PageTelekom\AbonentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton AktivnRadioButton;
        
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
            System.Uri resourceLocater = new System.Uri("/RH_WPF;component/pagetelekom/abonentspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PageTelekom\AbonentsPage.xaml"
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
            
            #line 10 "..\..\..\PageTelekom\AbonentsPage.xaml"
            ((RH_WPF.PageTelekom.AbonentsPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AbonentsGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 25 "..\..\..\PageTelekom\AbonentsPage.xaml"
            this.AbonentsGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AbonentsGrid_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 25 "..\..\..\PageTelekom\AbonentsPage.xaml"
            this.AbonentsGrid.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.AbonentsGrid_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NeAktivRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 35 "..\..\..\PageTelekom\AbonentsPage.xaml"
            this.NeAktivRadioButton.Checked += new System.Windows.RoutedEventHandler(this.NeAktivRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.VseRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 36 "..\..\..\PageTelekom\AbonentsPage.xaml"
            this.VseRadioButton.Checked += new System.Windows.RoutedEventHandler(this.VseRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AktivnRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 37 "..\..\..\PageTelekom\AbonentsPage.xaml"
            this.AktivnRadioButton.Checked += new System.Windows.RoutedEventHandler(this.AktivnRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

