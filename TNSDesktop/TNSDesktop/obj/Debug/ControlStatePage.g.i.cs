﻿#pragma checksum "..\..\ControlStatePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CDCADB58D4320FC11BE626297FCA3742E144FD2C567FC9F020763AACBD0B5E68"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using TNSDesktop;


namespace TNSDesktop {
    
    
    /// <summary>
    /// ControlStatePage
    /// </summary>
    public partial class ControlStatePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\ControlStatePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LbMagistralDevice;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ControlStatePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LbLineDevice;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\ControlStatePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LbAbonentDevices;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\ControlStatePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbFindNameDevice;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\ControlStatePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbFindLocationDevice;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\ControlStatePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border CRed;
        
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
            System.Uri resourceLocater = new System.Uri("/TNSDesktop;component/controlstatepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ControlStatePage.xaml"
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
            this.LbMagistralDevice = ((System.Windows.Controls.ListBox)(target));
            
            #line 20 "..\..\ControlStatePage.xaml"
            this.LbMagistralDevice.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LbMagistralDevice_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 20 "..\..\ControlStatePage.xaml"
            this.LbMagistralDevice.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.LbMagistralDevice_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LbLineDevice = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.LbAbonentDevices = ((System.Windows.Controls.ListBox)(target));
            
            #line 30 "..\..\ControlStatePage.xaml"
            this.LbAbonentDevices.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LbAbonentDevices_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 30 "..\..\ControlStatePage.xaml"
            this.LbAbonentDevices.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.LbAbonentDevices_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 34 "..\..\ControlStatePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateStatusDevices_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TbFindNameDevice = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\ControlStatePage.xaml"
            this.TbFindNameDevice.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TbFindNameDevice_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TbFindLocationDevice = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\ControlStatePage.xaml"
            this.TbFindLocationDevice.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TbFindLocationDevice_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CRed = ((System.Windows.Controls.Border)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

