﻿#pragma checksum "..\..\..\UserControlLayout\BangKeNhapXuat.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D8B1A8A964EC4BCDFD14CCA7F62605019DC5AA3C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using QuanLyTonKho.UserControlLayout;
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


namespace QuanLyTonKho.UserControlLayout {
    
    
    /// <summary>
    /// BangKeNhapXuat
    /// </summary>
    public partial class BangKeNhapXuat : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\UserControlLayout\BangKeNhapXuat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePicker;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\UserControlLayout\BangKeNhapXuat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePicker2;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\UserControlLayout\BangKeNhapXuat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbLoaiBangKe;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\UserControlLayout\BangKeNhapXuat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvBangKeNhapXuat;
        
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
            System.Uri resourceLocater = new System.Uri("/QuanLyTonKho;component/usercontrollayout/bangkenhapxuat.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControlLayout\BangKeNhapXuat.xaml"
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
            
            #line 16 "..\..\..\UserControlLayout\BangKeNhapXuat.xaml"
            ((QuanLyTonKho.UserControlLayout.BangKeNhapXuat)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.cbLoaiBangKe_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.datePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.datePicker2 = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.cbLoaiBangKe = ((System.Windows.Controls.ComboBox)(target));
            
            #line 43 "..\..\..\UserControlLayout\BangKeNhapXuat.xaml"
            this.cbLoaiBangKe.KeyDown += new System.Windows.Input.KeyEventHandler(this.cbLoaiBangKe_KeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 52 "..\..\..\UserControlLayout\BangKeNhapXuat.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lvBangKeNhapXuat = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

