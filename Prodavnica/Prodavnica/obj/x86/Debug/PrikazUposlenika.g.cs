﻿#pragma checksum "C:\Users\mesud\Desktop\Wasabi\Prodavnica\Prodavnica\PrikazUposlenika.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "256CEF43720BCDB1E3E4C874F53A277A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prodavnica
{
    partial class PrikazUposlenika : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.prikazUposlenika = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 11 "..\..\..\PrikazUposlenika.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.prikazUposlenika).SelectionChanged += this.prikazUposlenika_SelectionChanged;
                    #line default
                }
                break;
            case 2:
                {
                    this.imeUposlenika = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3:
                {
                    this.txtBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.textBlock1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.prezimeUposlenika = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6:
                {
                    this.textBlock2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.korisnickoIme = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8:
                {
                    this.izmijeniPodatke = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 30 "..\..\..\PrikazUposlenika.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.izmijeniPodatke).Click += this.izmijeniPodatke_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 31 "..\..\..\PrikazUposlenika.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).Click += this.button_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

