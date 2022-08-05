// <autogenerated />
#pragma warning disable 618  // Ignore obsolete members warnings
#pragma warning disable 105  // Ignore duplicate namespaces
#pragma warning disable 1591 // Ignore missing XML comment warnings
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Uno.UI;
using Uno.UI.Xaml;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Text;
using Uno.Extensions;
using Uno;
using Uno.UI.Helpers.Xaml;
using Tutorial2.Droid;

#if __ANDROID__
using _View = Android.Views.View;
#elif __IOS__
using _View = UIKit.UIView;
#elif __MACOS__
using _View = AppKit.NSView;
#elif UNO_REFERENCE_API || NET461
using _View = Windows.UI.Xaml.UIElement;
#endif

namespace Tutorial2
{
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0056", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0058", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV1003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0085", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2001", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2004", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2005", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("dotnet", "CA1001", Justification="Generated code")]
	partial class MainPage : Windows.UI.Xaml.Controls.Page
	{
				private void InitializeComponent()
		{
			var __resourceLocator = new global::System.Uri("file:///C:/MySource/Tutorial2/Tutorial2/Tutorial2.Shared/MainPage.xaml");
			if(global::Uno.UI.ApplicationHelper.IsLoadableComponent(__resourceLocator))
			{
				global::Windows.UI.Xaml.Application.LoadComponent(this, __resourceLocator);
				return;
			}
			var nameScope = new global::Windows.UI.Xaml.NameScope();
			NameScope.SetNameScope(this, nameScope);
			base.IsParsing = true;
			Resources[
			"StringFormatConverter"
			] = 
			new global::BugTracker.Converters.StringFormatConverter
			{
				// Source ..\..\..\..\..\..\..\Tutorial2.Shared\MainPage.xaml (Line 10:10)
			}
			;
			// Source ..\..\..\..\..\..\..\Tutorial2.Shared\MainPage.xaml (Line 1:2)
			base.Content = 
			new global::Windows.UI.Xaml.Controls.Grid
			{
				IsParsing = true,
				RowDefinitions = 
				{
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, Auto, RowDefinition/Height */,
						// Source ..\..\..\..\..\..\..\Tutorial2.Shared\MainPage.xaml (Line 16:14)
					}
					,
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, Auto, RowDefinition/Height */,
						// Source ..\..\..\..\..\..\..\Tutorial2.Shared\MainPage.xaml (Line 17:14)
					}
					,
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, Auto, RowDefinition/Height */,
						// Source ..\..\..\..\..\..\..\Tutorial2.Shared\MainPage.xaml (Line 18:14)
					}
					,
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, Auto, RowDefinition/Height */,
						// Source ..\..\..\..\..\..\..\Tutorial2.Shared\MainPage.xaml (Line 19:14)
					}
					,
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, Auto, RowDefinition/Height */,
						// Source ..\..\..\..\..\..\..\Tutorial2.Shared\MainPage.xaml (Line 20:14)
					}
					,
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Star)/* Windows.UI.Xaml.GridLength/, *, RowDefinition/Height */,
						// Source ..\..\..\..\..\..\..\Tutorial2.Shared\MainPage.xaml (Line 21:14)
					}
					,
				}
				,
				// Source ..\..\..\..\..\..\..\Tutorial2.Shared\MainPage.xaml (Line 14:6)
				Children = 
				{
					new global::Windows.UI.Xaml.Controls.StackPanel
					{
						IsParsing = true,
						Orientation = global::Windows.UI.Xaml.Controls.Orientation.Horizontal/* Windows.UI.Xaml.Controls.Orientation/, Horizontal, StackPanel/Orientation */,
						Background = SolidColorBrushHelper.LightGray/* Windows.UI.Xaml.Media.Brush/, LightGray, StackPanel/Background */,
						Padding = new global::Windows.UI.Xaml.Thickness(5)/* Windows.UI.Xaml.Thickness/, 5, StackPanel/Padding */,
						// Source ..\..\..\..\..\..\..\Tutorial2.Shared\MainPage.xaml (Line 23:10)
						Children = 
						{
							new global::Windows.UI.Xaml.Controls.Canvas
							{
								IsParsing = true,
								Name = "IssueTypeIndicator",
								Background = SolidColorBrushHelper.Blue/* Windows.UI.Xaml.Media.Brush/, Blue, Canvas/Background */,
								Width = 10d/* double/, 10, Canvas/Width */,
								// Source ..\..\..\..\..\..\..\Tutorial2.Shared\MainPage.xaml (Line 24:14)
							}
							.MainPage_4ae8632034fa83762d4f119c617c899d_XamlApply((MainPage_4ae8632034fa83762d4f119c617c899dXamlApplyExtensions.XamlApplyHandler1)(c6 => 
							{
								nameScope.RegisterName("IssueTypeIndicator", c6);
								this.IssueTypeIndicator = c6;
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c6, "file:///C:/MySource/Tutorial2/Tutorial2/Tutorial2.Shared/MainPage.xaml");
								c6.CreationComplete();
							}
							))
							,
							new global::Windows.UI.Xaml.Controls.TextBlock
							{
								IsParsing = true,
								Margin = new global::Windows.UI.Xaml.Thickness(6,0)/* Windows.UI.Xaml.Thickness/, 6,0, TextBlock/Margin */,
								VerticalAlignment = global::Windows.UI.Xaml.VerticalAlignment.Center/* Windows.UI.Xaml.VerticalAlignment/, Center, TextBlock/VerticalAlignment */,
								// Source ..\..\..\..\..\..\..\Tutorial2.Shared\MainPage.xaml (Line 25:14)
							}
							.MainPage_4ae8632034fa83762d4f119c617c899d_XamlApply((MainPage_4ae8632034fa83762d4f119c617c899dXamlApplyExtensions.XamlApplyHandler2)(c7 => 
							{
								c7.SetBinding(
									global::Windows.UI.Xaml.Controls.TextBlock.TextProperty,
									new Windows.UI.Xaml.Data.Binding()
									{
										Mode = BindingMode.OneTime,
									}
										.BindingApply(___b =>  /*defaultBindModeOneTime Item.Id*/ global::Uno.UI.Xaml.BindingHelper.SetBindingXBindProvider(___b, this, ___ctx => ___ctx is global::Tutorial2.MainPage ___tctx ? (object)(___tctx.Item.Id) : null, null ))
								);
								/* _isTopLevelDictionary:False */
								this._component_0 = c7;
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c7, "file:///C:/MySource/Tutorial2/Tutorial2/Tutorial2.Shared/MainPage.xaml");
								c7.CreationComplete();
							}
							))
							,
							new global::Windows.UI.Xaml.Controls.ComboBox
							{
								IsParsing = true,
								Name = "IssueTypeBox",
								PlaceholderText = "Enter the Issue Type"/* string/, Enter the Issue Type, ComboBox/PlaceholderText */,
								HorizontalAlignment = global::Windows.UI.Xaml.HorizontalAlignment.Stretch/* Windows.UI.Xaml.HorizontalAlignment/, Stretch, ComboBox/HorizontalAlignment */,
								Margin = new global::Windows.UI.Xaml.Thickness(10,0,0,0)/* Windows.UI.Xaml.Thickness/, 10,0,0,0, ComboBox/Margin */,
								// Source ..\..\..\..\..\..\..\Tutorial2.Shared\MainPage.xaml (Line 26:14)
							}
							.MainPage_4ae8632034fa83762d4f119c617c899d_XamlApply((MainPage_4ae8632034fa83762d4f119c617c899dXamlApplyExtensions.XamlApplyHandler3)(c8 => 
							{
								nameScope.RegisterName("IssueTypeBox", c8);
								this.IssueTypeBox = c8;
								c8.SetBinding(
									global::Windows.UI.Xaml.Controls.ComboBox.ItemsSourceProperty,
									new Windows.UI.Xaml.Data.Binding()
									{
										Mode = BindingMode.OneTime,
									}
										.BindingApply(___b =>  /*defaultBindModeOneTime IssueTypeList*/ global::Uno.UI.Xaml.BindingHelper.SetBindingXBindProvider(___b, this, ___ctx => ___ctx is global::Tutorial2.MainPage ___tctx ? (object)(___tctx.IssueTypeList) : null, null ))
								);
								c8.SetBinding(
									global::Windows.UI.Xaml.Controls.ComboBox.SelectedItemProperty,
									new Windows.UI.Xaml.Data.Binding()
									{
										Mode = global::Windows.UI.Xaml.Data.BindingMode.TwoWay/* Windows.UI.Xaml.Data.BindingMode/Windows.UI.Xaml.Data.BindingMode, TwoWay, Bind/Mode */,
									}
										.BindingApply(___b =>  /*defaultBindModeOneTime Item.Type*/ global::Uno.UI.Xaml.BindingHelper.SetBindingXBindProvider(___b, this, ___ctx => ___ctx is global::Tutorial2.MainPage ___tctx ? (object)(___tctx.Item.Type) : null, (___ctx, __value) => { if(___ctx is global::Tutorial2.MainPage ___tctx) ___tctx.Item.Type = (Tutorial2.Models.IssueType)global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(Tutorial2.Models.IssueType), __value); } , new [] {"Item.Type"}))
								);
								var SelectionChanged_IssueType_SelectionChanged_That = (this as global::Uno.UI.DataBinding.IWeakReferenceProvider).WeakReference;
								/* second level */ c8.SelectionChanged += (IssueType_SelectionChanged_sender,IssueType_SelectionChanged_e) => (SelectionChanged_IssueType_SelectionChanged_That.Target as global::Tutorial2.MainPage)?.IssueType_SelectionChanged(IssueType_SelectionChanged_sender,IssueType_SelectionChanged_e);
								/* _isTopLevelDictionary:False */
								this._component_1 = c8;
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c8, "file:///C:/MySource/Tutorial2/Tutorial2/Tutorial2.Shared/MainPage.xaml");
								c8.CreationComplete();
							}
							))
							,
						}
					}
					.MainPage_4ae8632034fa83762d4f119c617c899d_XamlApply((MainPage_4ae8632034fa83762d4f119c617c899dXamlApplyExtensions.XamlApplyHandler4)(c9 => 
					{
						global::Windows.UI.Xaml.Controls.Grid.SetRow(c9, 0/* int/, 0, Grid/Row */);
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c9, "file:///C:/MySource/Tutorial2/Tutorial2/Tutorial2.Shared/MainPage.xaml");
						c9.CreationComplete();
					}
					))
					,
					new global::Windows.UI.Xaml.Controls.TextBox
					{
						IsParsing = true,
						AcceptsReturn = true/* bool/, True, TextBox/AcceptsReturn */,
						Header = @"Description"/* object/, Description, TextBox/Header */,
						Height = 200d/* double/, 200, TextBox/Height */,
						Margin = new global::Windows.UI.Xaml.Thickness(10,0)/* Windows.UI.Xaml.Thickness/, 10,0, TextBox/Margin */,
						PlaceholderText = "Enter Text Here"/* string/, Enter Text Here, TextBox/PlaceholderText */,
						// Source ..\..\..\..\..\..\..\Tutorial2.Shared\MainPage.xaml (Line 34:10)
					}
					.MainPage_4ae8632034fa83762d4f119c617c899d_XamlApply((MainPage_4ae8632034fa83762d4f119c617c899dXamlApplyExtensions.XamlApplyHandler5)(c10 => 
					{
						c10.SetBinding(
							global::Windows.UI.Xaml.Controls.TextBox.TextProperty,
							new Windows.UI.Xaml.Data.Binding()
							{
								Mode = global::Windows.UI.Xaml.Data.BindingMode.TwoWay/* Windows.UI.Xaml.Data.BindingMode/Windows.UI.Xaml.Data.BindingMode, TwoWay, Bind/Mode */,
							}
								.BindingApply(___b =>  /*defaultBindModeOneTime Item.Description*/ global::Uno.UI.Xaml.BindingHelper.SetBindingXBindProvider(___b, this, ___ctx => ___ctx is global::Tutorial2.MainPage ___tctx ? (object)(___tctx.Item.Description) : null, (___ctx, __value) => { if(___ctx is global::Tutorial2.MainPage ___tctx) ___tctx.Item.Description = (string)global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(string), __value); } , new [] {"Item.Description"}))
						);
						global::Windows.UI.Xaml.Controls.Grid.SetRow(c10, 2/* int/, 2, Grid/Row */);
						/* _isTopLevelDictionary:False */
						this._component_2 = c10;
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c10, "file:///C:/MySource/Tutorial2/Tutorial2/Tutorial2.Shared/MainPage.xaml");
						c10.CreationComplete();
					}
					))
					,
					new global::Windows.UI.Xaml.Controls.TextBlock
					{
						IsParsing = true,
						Text = "Planning"/* string/, Planning, TextBlock/Text */,
						FontWeight = global::Windows.UI.Text.FontWeights.Bold/* Windows.UI.Text.FontWeight/, Bold, TextBlock/FontWeight */,
						FontSize = 16d/* double/, 16, TextBlock/FontSize */,
						Margin = new global::Windows.UI.Xaml.Thickness(10,0)/* Windows.UI.Xaml.Thickness/, 10,0, TextBlock/Margin */,
						// Source ..\..\..\..\..\..\..\Tutorial2.Shared\MainPage.xaml (Line 41:10)
					}
					.MainPage_4ae8632034fa83762d4f119c617c899d_XamlApply((MainPage_4ae8632034fa83762d4f119c617c899dXamlApplyExtensions.XamlApplyHandler2)(c11 => 
					{
						global::Windows.UI.Xaml.Controls.Grid.SetRow(c11, 3/* int/, 3, Grid/Row */);
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c11, "file:///C:/MySource/Tutorial2/Tutorial2/Tutorial2.Shared/MainPage.xaml");
						c11.CreationComplete();
					}
					))
					,
					new global::Windows.UI.Xaml.Controls.StackPanel
					{
						IsParsing = true,
						Orientation = global::Windows.UI.Xaml.Controls.Orientation.Horizontal/* Windows.UI.Xaml.Controls.Orientation/, Horizontal, StackPanel/Orientation */,
						Margin = new global::Windows.UI.Xaml.Thickness(10,0)/* Windows.UI.Xaml.Thickness/, 10,0, StackPanel/Margin */,
						Spacing = 20d/* double/, 20, StackPanel/Spacing */,
						// Source ..\..\..\..\..\..\..\Tutorial2.Shared\MainPage.xaml (Line 43:10)
						Children = 
						{
							new global::Windows.UI.Xaml.Controls.StackPanel
							{
								IsParsing = true,
								Background = SolidColorBrushHelper.LightGray/* Windows.UI.Xaml.Media.Brush/, LightGray, StackPanel/Background */,
								Padding = new global::Windows.UI.Xaml.Thickness(20)/* Windows.UI.Xaml.Thickness/, 20, StackPanel/Padding */,
								// Source ..\..\..\..\..\..\..\Tutorial2.Shared\MainPage.xaml (Line 44:14)
								Children = 
								{
									new global::Windows.UI.Xaml.Controls.TextBlock
									{
										IsParsing = true,
										Text = "Effort"/* string/, Effort, TextBlock/Text */,
										FontWeight = global::Windows.UI.Text.FontWeights.Bold/* Windows.UI.Text.FontWeight/, Bold, TextBlock/FontWeight */,
										FontSize = 16d/* double/, 16, TextBlock/FontSize */,
										Margin = new global::Windows.UI.Xaml.Thickness(10,0)/* Windows.UI.Xaml.Thickness/, 10,0, TextBlock/Margin */,
										// Source ..\..\..\..\..\..\..\Tutorial2.Shared\MainPage.xaml (Line 45:18)
									}
									.MainPage_4ae8632034fa83762d4f119c617c899d_XamlApply((MainPage_4ae8632034fa83762d4f119c617c899dXamlApplyExtensions.XamlApplyHandler2)(c12 => 
									{
										global::Uno.UI.FrameworkElementHelper.SetBaseUri(c12, "file:///C:/MySource/Tutorial2/Tutorial2/Tutorial2.Shared/MainPage.xaml");
										c12.CreationComplete();
									}
									))
									,
									new global::Windows.UI.Xaml.Controls.TextBox
									{
										IsParsing = true,
										HorizontalTextAlignment = global::Windows.UI.Xaml.TextAlignment.Center/* Windows.UI.Xaml.TextAlignment/, Center, TextBox/HorizontalTextAlignment */,
										HorizontalAlignment = global::Windows.UI.Xaml.HorizontalAlignment.Center/* Windows.UI.Xaml.HorizontalAlignment/, Center, TextBox/HorizontalAlignment */,
										HorizontalContentAlignment = global::Windows.UI.Xaml.HorizontalAlignment.Center/* Windows.UI.Xaml.HorizontalAlignment/, Center, TextBox/HorizontalContentAlignment */,
										BorderBrush = SolidColorBrushHelper.Transparent/* Windows.UI.Xaml.Media.Brush/, Transparent, TextBox/BorderBrush */,
										Background = SolidColorBrushHelper.Transparent/* Windows.UI.Xaml.Media.Brush/, Transparent, TextBox/Background */,
										// Source ..\..\..\..\..\..\..\Tutorial2.Shared\MainPage.xaml (Line 46:18)
									}
									.MainPage_4ae8632034fa83762d4f119c617c899d_XamlApply((MainPage_4ae8632034fa83762d4f119c617c899dXamlApplyExtensions.XamlApplyHandler5)(c13 => 
									{
										c13.SetBinding(
											global::Windows.UI.Xaml.Controls.TextBox.TextProperty,
											new Windows.UI.Xaml.Data.Binding()
											{
												Mode = global::Windows.UI.Xaml.Data.BindingMode.TwoWay/* Windows.UI.Xaml.Data.BindingMode/Windows.UI.Xaml.Data.BindingMode, TwoWay, Bind/Mode */,
											}
												.BindingApply(___b =>  /*defaultBindModeOneTime Item.Effort*/ global::Uno.UI.Xaml.BindingHelper.SetBindingXBindProvider(___b, this, ___ctx => ___ctx is global::Tutorial2.MainPage ___tctx ? (object)(___tctx.Item.Effort) : null, (___ctx, __value) => { if(___ctx is global::Tutorial2.MainPage ___tctx) ___tctx.Item.Effort = (int)global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(int), __value); } , new [] {"Item.Effort"}))
										);
										/* _isTopLevelDictionary:False */
										this._component_3 = c13;
										global::Uno.UI.FrameworkElementHelper.SetBaseUri(c13, "file:///C:/MySource/Tutorial2/Tutorial2/Tutorial2.Shared/MainPage.xaml");
										c13.CreationComplete();
									}
									))
									,
									new global::Windows.UI.Xaml.Controls.Slider
									{
										IsParsing = true,
										Width = 100d/* double/, 100, Slider/Width */,
										Minimum = 0d/* double/, 0, Slider/Minimum */,
										Maximum = 15d/* double/, 15, Slider/Maximum */,
										// Source ..\..\..\..\..\..\..\Tutorial2.Shared\MainPage.xaml (Line 52:18)
									}
									.MainPage_4ae8632034fa83762d4f119c617c899d_XamlApply((MainPage_4ae8632034fa83762d4f119c617c899dXamlApplyExtensions.XamlApplyHandler6)(c14 => 
									{
										c14.SetBinding(
											global::Windows.UI.Xaml.Controls.Slider.ValueProperty,
											new Windows.UI.Xaml.Data.Binding()
											{
												Mode = global::Windows.UI.Xaml.Data.BindingMode.TwoWay/* Windows.UI.Xaml.Data.BindingMode/Windows.UI.Xaml.Data.BindingMode, TwoWay, Bind/Mode */,
											}
												.BindingApply(___b =>  /*defaultBindModeOneTime Item.Effort*/ global::Uno.UI.Xaml.BindingHelper.SetBindingXBindProvider(___b, this, ___ctx => ___ctx is global::Tutorial2.MainPage ___tctx ? (object)(___tctx.Item.Effort) : null, (___ctx, __value) => { if(___ctx is global::Tutorial2.MainPage ___tctx) ___tctx.Item.Effort = (int)global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(int), __value); } , new [] {"Item.Effort"}))
										);
										/* _isTopLevelDictionary:False */
										this._component_4 = c14;
										global::Uno.UI.FrameworkElementHelper.SetBaseUri(c14, "file:///C:/MySource/Tutorial2/Tutorial2/Tutorial2.Shared/MainPage.xaml");
										c14.CreationComplete();
									}
									))
									,
								}
							}
							.MainPage_4ae8632034fa83762d4f119c617c899d_XamlApply((MainPage_4ae8632034fa83762d4f119c617c899dXamlApplyExtensions.XamlApplyHandler4)(c15 => 
							{
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c15, "file:///C:/MySource/Tutorial2/Tutorial2/Tutorial2.Shared/MainPage.xaml");
								c15.CreationComplete();
							}
							))
							,
							new global::Windows.UI.Xaml.Controls.StackPanel
							{
								IsParsing = true,
								Background = SolidColorBrushHelper.LightGray/* Windows.UI.Xaml.Media.Brush/, LightGray, StackPanel/Background */,
								Padding = new global::Windows.UI.Xaml.Thickness(20)/* Windows.UI.Xaml.Thickness/, 20, StackPanel/Padding */,
								// Source ..\..\..\..\..\..\..\Tutorial2.Shared\MainPage.xaml (Line 54:14)
								Children = 
								{
									new global::Windows.UI.Xaml.Controls.TextBlock
									{
										IsParsing = true,
										Text = "Status"/* string/, Status, TextBlock/Text */,
										FontWeight = global::Windows.UI.Text.FontWeights.Bold/* Windows.UI.Text.FontWeight/, Bold, TextBlock/FontWeight */,
										FontSize = 16d/* double/, 16, TextBlock/FontSize */,
										Margin = new global::Windows.UI.Xaml.Thickness(10,0)/* Windows.UI.Xaml.Thickness/, 10,0, TextBlock/Margin */,
										// Source ..\..\..\..\..\..\..\Tutorial2.Shared\MainPage.xaml (Line 56:18)
									}
									.MainPage_4ae8632034fa83762d4f119c617c899d_XamlApply((MainPage_4ae8632034fa83762d4f119c617c899dXamlApplyExtensions.XamlApplyHandler2)(c16 => 
									{
										global::Uno.UI.FrameworkElementHelper.SetBaseUri(c16, "file:///C:/MySource/Tutorial2/Tutorial2/Tutorial2.Shared/MainPage.xaml");
										c16.CreationComplete();
									}
									))
									,
									new global::Windows.UI.Xaml.Controls.ComboBox
									{
										IsParsing = true,
										HorizontalAlignment = global::Windows.UI.Xaml.HorizontalAlignment.Stretch/* Windows.UI.Xaml.HorizontalAlignment/, Stretch, ComboBox/HorizontalAlignment */,
										// Source ..\..\..\..\..\..\..\Tutorial2.Shared\MainPage.xaml (Line 57:18)
									}
									.MainPage_4ae8632034fa83762d4f119c617c899d_XamlApply((MainPage_4ae8632034fa83762d4f119c617c899dXamlApplyExtensions.XamlApplyHandler3)(c17 => 
									{
										c17.SetBinding(
											global::Windows.UI.Xaml.Controls.ComboBox.ItemsSourceProperty,
											new Windows.UI.Xaml.Data.Binding()
											{
												Mode = BindingMode.OneTime,
											}
												.BindingApply(___b =>  /*defaultBindModeOneTime StatusList*/ global::Uno.UI.Xaml.BindingHelper.SetBindingXBindProvider(___b, this, ___ctx => ___ctx is global::Tutorial2.MainPage ___tctx ? (object)(___tctx.StatusList) : null, null ))
										);
										c17.SetBinding(
											global::Windows.UI.Xaml.Controls.ComboBox.SelectedItemProperty,
											new Windows.UI.Xaml.Data.Binding()
											{
												Mode = global::Windows.UI.Xaml.Data.BindingMode.TwoWay/* Windows.UI.Xaml.Data.BindingMode/Windows.UI.Xaml.Data.BindingMode, TwoWay, Bind/Mode */,
											}
												.BindingApply(___b =>  /*defaultBindModeOneTime Item.Status*/ global::Uno.UI.Xaml.BindingHelper.SetBindingXBindProvider(___b, this, ___ctx => ___ctx is global::Tutorial2.MainPage ___tctx ? (object)(___tctx.Item.Status) : null, (___ctx, __value) => { if(___ctx is global::Tutorial2.MainPage ___tctx) ___tctx.Item.Status = (Tutorial2.Models.IssueStatus)global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(Tutorial2.Models.IssueStatus), __value); } , new [] {"Item.Status"}))
										);
										var SelectionChanged_StatusPicker_SelectionChanged_That = (this as global::Uno.UI.DataBinding.IWeakReferenceProvider).WeakReference;
										/* second level */ c17.SelectionChanged += (StatusPicker_SelectionChanged_sender,StatusPicker_SelectionChanged_e) => (SelectionChanged_StatusPicker_SelectionChanged_That.Target as global::Tutorial2.MainPage)?.StatusPicker_SelectionChanged(StatusPicker_SelectionChanged_sender,StatusPicker_SelectionChanged_e);
										/* _isTopLevelDictionary:False */
										this._component_5 = c17;
										global::Uno.UI.FrameworkElementHelper.SetBaseUri(c17, "file:///C:/MySource/Tutorial2/Tutorial2/Tutorial2.Shared/MainPage.xaml");
										c17.CreationComplete();
									}
									))
									,
									new global::Windows.UI.Xaml.Controls.TextBlock
									{
										IsParsing = true,
										// Source ..\..\..\..\..\..\..\Tutorial2.Shared\MainPage.xaml (Line 61:18)
									}
									.MainPage_4ae8632034fa83762d4f119c617c899d_XamlApply((MainPage_4ae8632034fa83762d4f119c617c899dXamlApplyExtensions.XamlApplyHandler2)(c18 => 
									{
										c18.SetBinding(
											global::Windows.UI.Xaml.Controls.TextBlock.TextProperty,
											new Windows.UI.Xaml.Data.Binding()
											{
												Mode = global::Windows.UI.Xaml.Data.BindingMode.OneWay/* Windows.UI.Xaml.Data.BindingMode/Windows.UI.Xaml.Data.BindingMode, OneWay, Bind/Mode */,
											}
												.BindingApply(___b =>  /*defaultBindModeOneTime FormatDate("Started:", Item.StartedAt)*/ global::Uno.UI.Xaml.BindingHelper.SetBindingXBindProvider(___b, this, ___ctx => ___ctx is global::Tutorial2.MainPage ___tctx ? (object)(___tctx.FormatDate("Started:", ___tctx.Item.StartedAt)) : null, null , new [] {"Item.StartedAt"}))
										);
										/* _isTopLevelDictionary:False */
										this._component_6 = c18;
										global::Uno.UI.FrameworkElementHelper.SetBaseUri(c18, "file:///C:/MySource/Tutorial2/Tutorial2/Tutorial2.Shared/MainPage.xaml");
										c18.CreationComplete();
									}
									))
									,
									new global::Windows.UI.Xaml.Controls.TextBlock
									{
										IsParsing = true,
										// Source ..\..\..\..\..\..\..\Tutorial2.Shared\MainPage.xaml (Line 62:18)
									}
									.MainPage_4ae8632034fa83762d4f119c617c899d_XamlApply((MainPage_4ae8632034fa83762d4f119c617c899dXamlApplyExtensions.XamlApplyHandler2)(c19 => 
									{
										c19.SetBinding(
											global::Windows.UI.Xaml.Controls.TextBlock.TextProperty,
											new Windows.UI.Xaml.Data.Binding()
											{
												Mode = global::Windows.UI.Xaml.Data.BindingMode.OneWay/* Windows.UI.Xaml.Data.BindingMode/Windows.UI.Xaml.Data.BindingMode, OneWay, Bind/Mode */,
											}
												.BindingApply(___b =>  /*defaultBindModeOneTime FormatDate("Completed:", Item.CompletedAt)*/ global::Uno.UI.Xaml.BindingHelper.SetBindingXBindProvider(___b, this, ___ctx => ___ctx is global::Tutorial2.MainPage ___tctx ? (object)(___tctx.FormatDate("Completed:", ___tctx.Item.CompletedAt)) : null, null , new [] {"Item.CompletedAt"}))
										);
										/* _isTopLevelDictionary:False */
										this._component_7 = c19;
										global::Uno.UI.FrameworkElementHelper.SetBaseUri(c19, "file:///C:/MySource/Tutorial2/Tutorial2/Tutorial2.Shared/MainPage.xaml");
										c19.CreationComplete();
									}
									))
									,
								}
							}
							.MainPage_4ae8632034fa83762d4f119c617c899d_XamlApply((MainPage_4ae8632034fa83762d4f119c617c899dXamlApplyExtensions.XamlApplyHandler4)(c20 => 
							{
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c20, "file:///C:/MySource/Tutorial2/Tutorial2/Tutorial2.Shared/MainPage.xaml");
								c20.CreationComplete();
							}
							))
							,
						}
					}
					.MainPage_4ae8632034fa83762d4f119c617c899d_XamlApply((MainPage_4ae8632034fa83762d4f119c617c899dXamlApplyExtensions.XamlApplyHandler4)(c21 => 
					{
						global::Windows.UI.Xaml.Controls.Grid.SetRow(c21, 4/* int/, 4, Grid/Row */);
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c21, "file:///C:/MySource/Tutorial2/Tutorial2/Tutorial2.Shared/MainPage.xaml");
						c21.CreationComplete();
					}
					))
					,
					new global::Windows.UI.Xaml.Controls.TextBlock
					{
						IsParsing = true,
						Margin = new global::Windows.UI.Xaml.Thickness(10,0)/* Windows.UI.Xaml.Thickness/, 10,0, TextBlock/Margin */,
						// Source ..\..\..\..\..\..\..\Tutorial2.Shared\MainPage.xaml (Line 66:10)
					}
					.MainPage_4ae8632034fa83762d4f119c617c899d_XamlApply((MainPage_4ae8632034fa83762d4f119c617c899dXamlApplyExtensions.XamlApplyHandler2)(c22 => 
					{
						c22.SetBinding(
							global::Windows.UI.Xaml.Controls.TextBlock.TextProperty,
							new Windows.UI.Xaml.Data.Binding()
							{
								Mode = BindingMode.OneTime,
							}
								.BindingApply(___b =>  /*defaultBindModeOneTime FormatDate("Created:", Item.CreatedAt)*/ global::Uno.UI.Xaml.BindingHelper.SetBindingXBindProvider(___b, this, ___ctx => ___ctx is global::Tutorial2.MainPage ___tctx ? (object)(___tctx.FormatDate("Created:", ___tctx.Item.CreatedAt)) : null, null ))
						);
						global::Windows.UI.Xaml.Controls.Grid.SetRow(c22, 5/* int/, 5, Grid/Row */);
						/* _isTopLevelDictionary:False */
						this._component_8 = c22;
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c22, "file:///C:/MySource/Tutorial2/Tutorial2/Tutorial2.Shared/MainPage.xaml");
						c22.CreationComplete();
					}
					))
					,
				}
			}
			.MainPage_4ae8632034fa83762d4f119c617c899d_XamlApply((MainPage_4ae8632034fa83762d4f119c617c899dXamlApplyExtensions.XamlApplyHandler7)(c23 => 
			{
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c23, "file:///C:/MySource/Tutorial2/Tutorial2/Tutorial2.Shared/MainPage.xaml");
				c23.CreationComplete();
			}
			))
			;
			
			this
			.GenericApply((c24 => 
			{
				// Source C:\MySource\Tutorial2\Tutorial2\Tutorial2.Shared\MainPage.xaml (Line 1:2)
				
				// WARNING Property c24.base does not exist on {http://schemas.microsoft.com/winfx/2006/xaml/presentation}Page, the namespace is http://www.w3.org/XML/1998/namespace. This error was considered irrelevant by the XamlFileGenerator
			}
			))
			.GenericApply((c25 => 
			{
				// Class Tutorial2.MainPage
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c25, "file:///C:/MySource/Tutorial2/Tutorial2/Tutorial2.Shared/MainPage.xaml");
				c25.CreationComplete();
			}
			))
			;
			OnInitializeCompleted();

			Bindings = new MainPage_Bindings(this);
			Loading += delegate
			{
				Bindings.Update();
				Bindings.UpdateResources();
			}
			;
		}
		partial void OnInitializeCompleted();
		private global::Windows.UI.Xaml.Data.ElementNameSubject _IssueTypeIndicatorSubject = new global::Windows.UI.Xaml.Data.ElementNameSubject();
		private global::Windows.UI.Xaml.Controls.Canvas IssueTypeIndicator
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.Canvas)_IssueTypeIndicatorSubject.ElementInstance;
			}
			set
			{
				_IssueTypeIndicatorSubject.ElementInstance = value;
			}
		}
		private global::Windows.UI.Xaml.Data.ElementNameSubject _IssueTypeBoxSubject = new global::Windows.UI.Xaml.Data.ElementNameSubject();
		private global::Windows.UI.Xaml.Controls.ComboBox IssueTypeBox
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.ComboBox)_IssueTypeBoxSubject.ElementInstance;
			}
			set
			{
				_IssueTypeBoxSubject.ElementInstance = value;
			}
		}
		private global::Windows.UI.Xaml.Markup.ComponentHolder _component_0_Holder = new global::Windows.UI.Xaml.Markup.ComponentHolder(isWeak: true);
		private global::Windows.UI.Xaml.Controls.TextBlock _component_0
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.TextBlock)_component_0_Holder.Instance;
			}
			set
			{
				_component_0_Holder.Instance = value;
			}
		}
		private global::Windows.UI.Xaml.Markup.ComponentHolder _component_1_Holder = new global::Windows.UI.Xaml.Markup.ComponentHolder(isWeak: true);
		private global::Windows.UI.Xaml.Controls.ComboBox _component_1
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.ComboBox)_component_1_Holder.Instance;
			}
			set
			{
				_component_1_Holder.Instance = value;
			}
		}
		private global::Windows.UI.Xaml.Markup.ComponentHolder _component_2_Holder = new global::Windows.UI.Xaml.Markup.ComponentHolder(isWeak: true);
		private global::Windows.UI.Xaml.Controls.TextBox _component_2
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.TextBox)_component_2_Holder.Instance;
			}
			set
			{
				_component_2_Holder.Instance = value;
			}
		}
		private global::Windows.UI.Xaml.Markup.ComponentHolder _component_3_Holder = new global::Windows.UI.Xaml.Markup.ComponentHolder(isWeak: true);
		private global::Windows.UI.Xaml.Controls.TextBox _component_3
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.TextBox)_component_3_Holder.Instance;
			}
			set
			{
				_component_3_Holder.Instance = value;
			}
		}
		private global::Windows.UI.Xaml.Markup.ComponentHolder _component_4_Holder = new global::Windows.UI.Xaml.Markup.ComponentHolder(isWeak: true);
		private global::Windows.UI.Xaml.Controls.Slider _component_4
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.Slider)_component_4_Holder.Instance;
			}
			set
			{
				_component_4_Holder.Instance = value;
			}
		}
		private global::Windows.UI.Xaml.Markup.ComponentHolder _component_5_Holder = new global::Windows.UI.Xaml.Markup.ComponentHolder(isWeak: true);
		private global::Windows.UI.Xaml.Controls.ComboBox _component_5
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.ComboBox)_component_5_Holder.Instance;
			}
			set
			{
				_component_5_Holder.Instance = value;
			}
		}
		private global::Windows.UI.Xaml.Markup.ComponentHolder _component_6_Holder = new global::Windows.UI.Xaml.Markup.ComponentHolder(isWeak: true);
		private global::Windows.UI.Xaml.Controls.TextBlock _component_6
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.TextBlock)_component_6_Holder.Instance;
			}
			set
			{
				_component_6_Holder.Instance = value;
			}
		}
		private global::Windows.UI.Xaml.Markup.ComponentHolder _component_7_Holder = new global::Windows.UI.Xaml.Markup.ComponentHolder(isWeak: true);
		private global::Windows.UI.Xaml.Controls.TextBlock _component_7
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.TextBlock)_component_7_Holder.Instance;
			}
			set
			{
				_component_7_Holder.Instance = value;
			}
		}
		private global::Windows.UI.Xaml.Markup.ComponentHolder _component_8_Holder = new global::Windows.UI.Xaml.Markup.ComponentHolder(isWeak: true);
		private global::Windows.UI.Xaml.Controls.TextBlock _component_8
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.TextBlock)_component_8_Holder.Instance;
			}
			set
			{
				_component_8_Holder.Instance = value;
			}
		}
		private interface IMainPage_Bindings
		{
			void Initialize();
			void Update();
			void UpdateResources();
			void StopTracking();
		}
		#pragma warning disable 0169 //  Suppress unused field warning in case Bindings is not used.
		private IMainPage_Bindings Bindings;
		#pragma warning restore 0169
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		private class MainPage_Bindings : IMainPage_Bindings
		{
			#if UNO_HAS_UIELEMENT_IMPLICIT_PINNING
			private global::System.WeakReference _ownerReference;
			private MainPage Owner { get => (MainPage)_ownerReference?.Target; set => _ownerReference = new global::System.WeakReference(value); }
			#else
			private MainPage Owner { get; set; }
			#endif
			public MainPage_Bindings(MainPage owner)
			{
				Owner = owner;
			}
			void IMainPage_Bindings.Initialize()
			{
			}
			void IMainPage_Bindings.Update()
			{
				var owner = Owner;
				owner._component_0.ApplyXBind();
				owner._component_1.ApplyXBind();
				owner._component_2.ApplyXBind();
				owner._component_3.ApplyXBind();
				owner._component_4.ApplyXBind();
				owner._component_5.ApplyXBind();
				owner._component_6.ApplyXBind();
				owner._component_7.ApplyXBind();
				owner._component_8.ApplyXBind();
			}
			void IMainPage_Bindings.UpdateResources()
			{
				var owner = Owner;
				owner._component_0.UpdateResourceBindings();
				owner._component_1.UpdateResourceBindings();
				owner._component_2.UpdateResourceBindings();
				owner._component_3.UpdateResourceBindings();
				owner._component_4.UpdateResourceBindings();
				owner._component_5.UpdateResourceBindings();
				owner._component_6.UpdateResourceBindings();
				owner._component_7.UpdateResourceBindings();
				owner._component_8.UpdateResourceBindings();
			}
			void IMainPage_Bindings.StopTracking()
			{
			}
		}

	}
}
namespace Tutorial2.Droid
{
	static class MainPage_4ae8632034fa83762d4f119c617c899dXamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::Windows.UI.Xaml.Controls.RowDefinition instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.RowDefinition MainPage_4ae8632034fa83762d4f119c617c899d_XamlApply(this global::Windows.UI.Xaml.Controls.RowDefinition instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler1(global::Windows.UI.Xaml.Controls.Canvas instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.Canvas MainPage_4ae8632034fa83762d4f119c617c899d_XamlApply(this global::Windows.UI.Xaml.Controls.Canvas instance, XamlApplyHandler1 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler2(global::Windows.UI.Xaml.Controls.TextBlock instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.TextBlock MainPage_4ae8632034fa83762d4f119c617c899d_XamlApply(this global::Windows.UI.Xaml.Controls.TextBlock instance, XamlApplyHandler2 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler3(global::Windows.UI.Xaml.Controls.ComboBox instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.ComboBox MainPage_4ae8632034fa83762d4f119c617c899d_XamlApply(this global::Windows.UI.Xaml.Controls.ComboBox instance, XamlApplyHandler3 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler4(global::Windows.UI.Xaml.Controls.StackPanel instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.StackPanel MainPage_4ae8632034fa83762d4f119c617c899d_XamlApply(this global::Windows.UI.Xaml.Controls.StackPanel instance, XamlApplyHandler4 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler5(global::Windows.UI.Xaml.Controls.TextBox instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.TextBox MainPage_4ae8632034fa83762d4f119c617c899d_XamlApply(this global::Windows.UI.Xaml.Controls.TextBox instance, XamlApplyHandler5 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler6(global::Windows.UI.Xaml.Controls.Slider instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.Slider MainPage_4ae8632034fa83762d4f119c617c899d_XamlApply(this global::Windows.UI.Xaml.Controls.Slider instance, XamlApplyHandler6 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler7(global::Windows.UI.Xaml.Controls.Grid instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.Grid MainPage_4ae8632034fa83762d4f119c617c899d_XamlApply(this global::Windows.UI.Xaml.Controls.Grid instance, XamlApplyHandler7 handler)
		{
			handler(instance);
			return instance;
		}
	}
}
