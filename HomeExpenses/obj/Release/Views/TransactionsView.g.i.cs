﻿#pragma checksum "..\..\..\Views\TransactionsView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BE9FAB2153F6E52CD55B8AC2B92F1CFE73812E90EAF7D6474A6B873388939B27"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Caliburn.Micro;
using HomeExpenses.Views;
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


namespace HomeExpenses.Views {
    
    
    /// <summary>
    /// TransactionsView
    /// </summary>
    public partial class TransactionsView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\Views\TransactionsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Search;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Views\TransactionsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ToDefault;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Views\TransactionsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker StartDate;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Views\TransactionsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker FinishDate;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\Views\TransactionsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Transactions;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\..\Views\TransactionsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TotalCredit;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\..\Views\TransactionsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TotalDebit;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\..\Views\TransactionsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TotalProfit;
        
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
            System.Uri resourceLocater = new System.Uri("/HomeExpenses;component/views/transactionsview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\TransactionsView.xaml"
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
            this.Search = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.ToDefault = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.StartDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.FinishDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.Transactions = ((System.Windows.Controls.DataGrid)(target));
            
            #line 107 "..\..\..\Views\TransactionsView.xaml"
            this.Transactions.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Transactions_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TotalCredit = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TotalDebit = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.TotalProfit = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

