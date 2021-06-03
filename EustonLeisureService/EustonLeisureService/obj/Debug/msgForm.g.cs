﻿#pragma checksum "..\..\msgForm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7828A2FFD9AFAE50B1A72B5D2EB24659D8BC6A4E848BB1D619B74776316A8241"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EustonLeisureService;
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


namespace EustonLeisureService {
    
    
    /// <summary>
    /// msgForm
    /// </summary>
    public partial class msgForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\msgForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox headerBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\msgForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox bodyBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\msgForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sendBtn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\msgForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button finishBtn;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\msgForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backBtn;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\msgForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox processedMsgType;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\msgForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox processedMsgHeader;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\msgForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox processedMsgBody;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\msgForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button viewBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/EustonLeisureService;component/msgform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\msgForm.xaml"
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
            this.headerBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.bodyBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.sendBtn = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\msgForm.xaml"
            this.sendBtn.Click += new System.Windows.RoutedEventHandler(this.sendBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.finishBtn = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\msgForm.xaml"
            this.finishBtn.Click += new System.Windows.RoutedEventHandler(this.finishBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.backBtn = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\msgForm.xaml"
            this.backBtn.Click += new System.Windows.RoutedEventHandler(this.backBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.processedMsgType = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.processedMsgHeader = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.processedMsgBody = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.viewBtn = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\msgForm.xaml"
            this.viewBtn.Click += new System.Windows.RoutedEventHandler(this.viewBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
