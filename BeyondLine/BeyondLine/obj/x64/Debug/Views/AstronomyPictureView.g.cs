﻿#pragma checksum "D:\programer\Github\SkyTrip\BeyondLine\BeyondLine\Views\AstronomyPictureView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "45487DE9168D6873B54C4868FAC315B11C19C515F570C88B87ED9CE266A09F60"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NasaApiExplorer.Views
{
    partial class AstronomyPictureView : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_Xaml_Interactions_Core_InvokeCommandAction_Command(global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(global::Windows.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ProgressRing_IsActive(global::Windows.UI.Xaml.Controls.ProgressRing obj, global::System.Boolean value)
            {
                obj.IsActive = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_NasaApiExplorer_Behaviors_DateChangedTriggerBehavior_Command(global::NasaApiExplorer.Behaviors.DateChangedTriggerBehavior obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class AstronomyPictureView_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IAstronomyPictureView_Bindings
        {
            private global::NasaApiExplorer.Views.AstronomyPictureView dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction obj2;
            private global::Windows.UI.Xaml.Controls.ProgressRing obj3;
            private global::Windows.UI.Xaml.Controls.Image obj4;
            private global::Windows.UI.Xaml.Controls.TextBlock obj5;
            private global::Windows.UI.Xaml.Controls.TextBlock obj6;
            private global::Windows.UI.Xaml.Controls.TextBlock obj7;
            private global::Windows.UI.Xaml.Controls.TextBlock obj8;
            private global::Windows.UI.Xaml.Controls.Button obj10;
            private global::Windows.UI.Xaml.Controls.Button obj11;
            private global::Windows.UI.Xaml.Controls.Button obj12;
            private global::NasaApiExplorer.Behaviors.DateChangedTriggerBehavior obj13;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2CommandDisabled = false;
            private static bool isobj3IsActiveDisabled = false;
            private static bool isobj4SourceDisabled = false;
            private static bool isobj5TextDisabled = false;
            private static bool isobj6TextDisabled = false;
            private static bool isobj7TextDisabled = false;
            private static bool isobj8TextDisabled = false;
            private static bool isobj10CommandDisabled = false;
            private static bool isobj11CommandDisabled = false;
            private static bool isobj12CommandDisabled = false;
            private static bool isobj13CommandDisabled = false;

            private AstronomyPictureView_obj1_BindingsTracking bindingsTracking;

            public AstronomyPictureView_obj1_Bindings()
            {
                this.bindingsTracking = new AstronomyPictureView_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 16 && columnNumber == 39)
                {
                    isobj2CommandDisabled = true;
                }
                else if (lineNumber == 76 && columnNumber == 13)
                {
                    isobj3IsActiveDisabled = true;
                }
                else if (lineNumber == 64 && columnNumber == 25)
                {
                    isobj4SourceDisabled = true;
                }
                else if (lineNumber == 44 && columnNumber == 32)
                {
                    isobj5TextDisabled = true;
                }
                else if (lineNumber == 45 && columnNumber == 32)
                {
                    isobj6TextDisabled = true;
                }
                else if (lineNumber == 46 && columnNumber == 32)
                {
                    isobj7TextDisabled = true;
                }
                else if (lineNumber == 47 && columnNumber == 32)
                {
                    isobj8TextDisabled = true;
                }
                else if (lineNumber == 54 && columnNumber == 67)
                {
                    isobj10CommandDisabled = true;
                }
                else if (lineNumber == 55 && columnNumber == 70)
                {
                    isobj11CommandDisabled = true;
                }
                else if (lineNumber == 56 && columnNumber == 80)
                {
                    isobj12CommandDisabled = true;
                }
                else if (lineNumber == 51 && columnNumber == 71)
                {
                    isobj13CommandDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Views\AstronomyPictureView.xaml line 16
                        this.obj2 = (global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction)target;
                        break;
                    case 3: // Views\AstronomyPictureView.xaml line 69
                        this.obj3 = (global::Windows.UI.Xaml.Controls.ProgressRing)target;
                        break;
                    case 4: // Views\AstronomyPictureView.xaml line 60
                        this.obj4 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 5: // Views\AstronomyPictureView.xaml line 44
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 6: // Views\AstronomyPictureView.xaml line 45
                        this.obj6 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 7: // Views\AstronomyPictureView.xaml line 46
                        this.obj7 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 8: // Views\AstronomyPictureView.xaml line 47
                        this.obj8 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 10: // Views\AstronomyPictureView.xaml line 54
                        this.obj10 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 11: // Views\AstronomyPictureView.xaml line 55
                        this.obj11 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 12: // Views\AstronomyPictureView.xaml line 56
                        this.obj12 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 13: // Views\AstronomyPictureView.xaml line 51
                        this.obj13 = (global::NasaApiExplorer.Behaviors.DateChangedTriggerBehavior)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IAstronomyPictureView_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::NasaApiExplorer.Views.AstronomyPictureView)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::NasaApiExplorer.Views.AstronomyPictureView obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::NasaApiExplorer.ViewModels.AstronomyPictureViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_LoadApodCommand(obj.LoadApodCommand, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_IsLoading(obj.IsLoading, phase);
                        this.Update_ViewModel_AstronomyPictureOfTheDay(obj.AstronomyPictureOfTheDay, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_DownloadPhotosCommand(obj.DownloadPhotosCommand, phase);
                        this.Update_ViewModel_SetWallpaperCommand(obj.SetWallpaperCommand, phase);
                        this.Update_ViewModel_UpdateDateCommand(obj.UpdateDateCommand, phase);
                    }
                }
            }
            private void Update_ViewModel_LoadApodCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\AstronomyPictureView.xaml line 16
                    if (!isobj2CommandDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_Xaml_Interactions_Core_InvokeCommandAction_Command(this.obj2, obj, null);
                    }
                    // Views\AstronomyPictureView.xaml line 54
                    if (!isobj10CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj10, obj, null);
                    }
                }
            }
            private void Update_ViewModel_IsLoading(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\AstronomyPictureView.xaml line 69
                    if (!isobj3IsActiveDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ProgressRing_IsActive(this.obj3, obj);
                    }
                }
            }
            private void Update_ViewModel_AstronomyPictureOfTheDay(global::NasaApiExplorer.AstronomyPictureOfTheDay obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_AstronomyPictureOfTheDay_Url(obj.Url, phase);
                        this.Update_ViewModel_AstronomyPictureOfTheDay_Title(obj.Title, phase);
                        this.Update_ViewModel_AstronomyPictureOfTheDay_Date(obj.Date, phase);
                        this.Update_ViewModel_AstronomyPictureOfTheDay_Explanation(obj.Explanation, phase);
                        this.Update_ViewModel_AstronomyPictureOfTheDay_Copyright(obj.Copyright, phase);
                    }
                }
            }
            private void Update_ViewModel_AstronomyPictureOfTheDay_Url(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\AstronomyPictureView.xaml line 60
                    if (!isobj4SourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj4, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                    }
                }
            }
            private void Update_ViewModel_AstronomyPictureOfTheDay_Title(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\AstronomyPictureView.xaml line 44
                    if (!isobj5TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj5, obj, null);
                    }
                }
            }
            private void Update_ViewModel_AstronomyPictureOfTheDay_Date(global::System.DateTime obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\AstronomyPictureView.xaml line 45
                    if (!isobj6TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj6, obj.ToString(), null);
                    }
                }
            }
            private void Update_ViewModel_AstronomyPictureOfTheDay_Explanation(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\AstronomyPictureView.xaml line 46
                    if (!isobj7TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj7, obj, null);
                    }
                }
            }
            private void Update_ViewModel_AstronomyPictureOfTheDay_Copyright(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\AstronomyPictureView.xaml line 47
                    if (!isobj8TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj8, obj, null);
                    }
                }
            }
            private void Update_ViewModel_DownloadPhotosCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\AstronomyPictureView.xaml line 55
                    if (!isobj11CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj11, obj, null);
                    }
                }
            }
            private void Update_ViewModel_SetWallpaperCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\AstronomyPictureView.xaml line 56
                    if (!isobj12CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj12, obj, null);
                    }
                }
            }
            private void Update_ViewModel_UpdateDateCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\AstronomyPictureView.xaml line 51
                    if (!isobj13CommandDisabled)
                    {
                        XamlBindingSetters.Set_NasaApiExplorer_Behaviors_DateChangedTriggerBehavior_Command(this.obj13, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class AstronomyPictureView_obj1_BindingsTracking
            {
                private global::System.WeakReference<AstronomyPictureView_obj1_Bindings> weakRefToBindingObj; 

                public AstronomyPictureView_obj1_BindingsTracking(AstronomyPictureView_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<AstronomyPictureView_obj1_Bindings>(obj);
                }

                public AstronomyPictureView_obj1_Bindings TryGetBindingObject()
                {
                    AstronomyPictureView_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModel(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    AstronomyPictureView_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::NasaApiExplorer.ViewModels.AstronomyPictureViewModel obj = sender as global::NasaApiExplorer.ViewModels.AstronomyPictureViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_IsLoading(obj.IsLoading, DATA_CHANGED);
                                bindings.Update_ViewModel_AstronomyPictureOfTheDay(obj.AstronomyPictureOfTheDay, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "IsLoading":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_IsLoading(obj.IsLoading, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "AstronomyPictureOfTheDay":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_AstronomyPictureOfTheDay(obj.AstronomyPictureOfTheDay, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::NasaApiExplorer.ViewModels.AstronomyPictureViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::NasaApiExplorer.ViewModels.AstronomyPictureViewModel obj)
                {
                    if (obj != cache_ViewModel)
                    {
                        if (cache_ViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel).PropertyChanged -= PropertyChanged_ViewModel;
                            cache_ViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 3: // Views\AstronomyPictureView.xaml line 69
                {
                    this.progressRing = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 4: // Views\AstronomyPictureView.xaml line 60
                {
                    this.imgPictureOfDay = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 9: // Views\AstronomyPictureView.xaml line 49
                {
                    this.Dayapod = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\AstronomyPictureView.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    AstronomyPictureView_obj1_Bindings bindings = new AstronomyPictureView_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

