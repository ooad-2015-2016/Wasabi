﻿#pragma checksum "D:\OOAD\Wasabi\Prodavnica\Prodavnica\DodajUposlenika.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "84FCF1283FF9400EDB16730E772C499D"
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
    partial class DodajUposlenika : 
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
                    this.imeUposlenika = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 2:
                {
                    this.prezimeUposlenika = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.pozicijaSelection = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 14 "..\..\..\DodajUposlenika.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.pozicijaSelection).SelectionChanged += this.comboBox_SelectionChanged;
                    #line default
                }
                break;
            case 5:
                {
                    this.smjenaSelection = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 6:
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 24 "..\..\..\DodajUposlenika.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).Click += this.button_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.korisnickoIme = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8:
                {
                    this.sifra = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9:
                {
                    this.Jutarnja = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 10:
                {
                    this.Popodnevna = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 11:
                {
                    this.Nocna = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 12:
                {
                    this.Prodavac = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 13:
                {
                    this.Supervizor = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 14:
                {
                    this.Menadzer = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
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

