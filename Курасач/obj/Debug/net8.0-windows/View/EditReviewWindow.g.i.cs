// Updated by XamlIntelliSenseFileGenerator 07.05.2025 14:10:44
#pragma checksum "..\..\..\..\View\EditReviewWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4B7893E0106103B2D44B5CD2F41F072CD47B4927"
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
using System.Windows.Controls.Ribbon;
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
using Курасач.View;


namespace Курасач.View
{


    /// <summary>
    /// EditReviewWindow
    /// </summary>
    public partial class EditReviewWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.2.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Курасач;component/view/editreviewwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\View\EditReviewWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.AddNewReviewWnd = ((Курасач.View.EditReviewWindow)(target));
                    return;
                case 2:
                    this.ReviewRatingBlock = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.ReviewDateBlock = ((System.Windows.Controls.DatePicker)(target));
                    return;
                case 4:
                    this.ReviewClientIdBlock = ((System.Windows.Controls.TextBox)(target));
                    return;
            }
            this._contentLoaded = true;
        }
        internal System.Windows.Window EditReviewWnd;
        internal System.Windows.Controls.TextBox EditReviewRatingBlock;
        internal System.Windows.Controls.TextBox EditReviewCommentsBlock;
        internal System.Windows.Controls.DatePicker EditReviewDateBlock;
        internal System.Windows.Controls.TextBox EditReviewClientIdBlock;
    }
}

