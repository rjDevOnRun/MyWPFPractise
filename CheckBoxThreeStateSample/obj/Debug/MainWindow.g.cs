﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5B02D2E52C42807D7912D352F82F1F4E61D4BF2F"
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


namespace CheckBoxThreeStateSample {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbAllFeatures;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbFeatureAbc;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbFeatureXyz;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbFeatureWWW;
        
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
            System.Uri resourceLocater = new System.Uri("/CheckBoxThreeStateSample;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            this.cbAllFeatures = ((System.Windows.Controls.CheckBox)(target));
            
            #line 8 "..\..\MainWindow.xaml"
            this.cbAllFeatures.Checked += new System.Windows.RoutedEventHandler(this.cbAllFeature_CheckedChanged);
            
            #line default
            #line hidden
            
            #line 8 "..\..\MainWindow.xaml"
            this.cbAllFeatures.Unchecked += new System.Windows.RoutedEventHandler(this.cbAllFeature_CheckedChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbFeatureAbc = ((System.Windows.Controls.CheckBox)(target));
            
            #line 10 "..\..\MainWindow.xaml"
            this.cbFeatureAbc.Checked += new System.Windows.RoutedEventHandler(this.cbFeature_CheckedChanged);
            
            #line default
            #line hidden
            
            #line 10 "..\..\MainWindow.xaml"
            this.cbFeatureAbc.Unchecked += new System.Windows.RoutedEventHandler(this.cbFeature_CheckedChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbFeatureXyz = ((System.Windows.Controls.CheckBox)(target));
            
            #line 11 "..\..\MainWindow.xaml"
            this.cbFeatureXyz.Checked += new System.Windows.RoutedEventHandler(this.cbFeature_CheckedChanged);
            
            #line default
            #line hidden
            
            #line 11 "..\..\MainWindow.xaml"
            this.cbFeatureXyz.Unchecked += new System.Windows.RoutedEventHandler(this.cbFeature_CheckedChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbFeatureWWW = ((System.Windows.Controls.CheckBox)(target));
            
            #line 12 "..\..\MainWindow.xaml"
            this.cbFeatureWWW.Checked += new System.Windows.RoutedEventHandler(this.cbFeature_CheckedChanged);
            
            #line default
            #line hidden
            
            #line 12 "..\..\MainWindow.xaml"
            this.cbFeatureWWW.Unchecked += new System.Windows.RoutedEventHandler(this.cbFeature_CheckedChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
