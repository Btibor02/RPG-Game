﻿#pragma checksum "..\..\Diáktanya.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5FF51954C3C97632DF9E7CD59038457C2F511F95A3D1C9CA4AF3FC919562269E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Jedlik_RPG;
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


namespace Diákt {
    
    
    /// <summary>
    /// Diáktanya
    /// </summary>
    public partial class Diáktanya : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\Diáktanya.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Spell1;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Diáktanya.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Spell2;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Diáktanya.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Spell3;
        
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
            System.Uri resourceLocater = new System.Uri("/Jedlik-RPG;component/di%c3%a1ktanya.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Diáktanya.xaml"
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
            this.Btn_Spell1 = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Diáktanya.xaml"
            this.Btn_Spell1.Click += new System.Windows.RoutedEventHandler(this.Btn_Spell1_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Btn_Spell2 = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Diáktanya.xaml"
            this.Btn_Spell2.Click += new System.Windows.RoutedEventHandler(this.Btn_Spell2_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Btn_Spell3 = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Diáktanya.xaml"
            this.Btn_Spell3.Click += new System.Windows.RoutedEventHandler(this.Btn_Spell3_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

