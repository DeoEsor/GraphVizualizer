﻿#pragma checksum "..\..\..\Windows\AlgorithPathResult.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5DF36D8E652B6660CE501629504923AE9320EB6D647BC087863E9AF8038A7E81"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using GraphDesktop.UserContols;
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


namespace GraphDesktop.Windows {
    
    
    /// <summary>
    /// AlgorithPathResult
    /// </summary>
    public partial class AlgorithPathResult : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\Windows\AlgorithPathResult.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox StartList;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Windows\AlgorithPathResult.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox EndList;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Windows\AlgorithPathResult.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DistText;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Windows\AlgorithPathResult.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DistResult;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Windows\AlgorithPathResult.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox PathBox;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Windows\AlgorithPathResult.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox AlgoBoxChoice;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\Windows\AlgorithPathResult.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox HueristicBoxChoice;
        
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
            System.Uri resourceLocater = new System.Uri("/GraphDesktop;component/windows/algorithpathresult.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\AlgorithPathResult.xaml"
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
            this.StartList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 36 "..\..\..\Windows\AlgorithPathResult.xaml"
            this.StartList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.StartChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.EndList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 56 "..\..\..\Windows\AlgorithPathResult.xaml"
            this.EndList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.EndChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DistText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.DistResult = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.PathBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.AlgoBoxChoice = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.HueristicBoxChoice = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
