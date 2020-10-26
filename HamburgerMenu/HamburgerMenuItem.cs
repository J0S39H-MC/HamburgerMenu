using Prism.Interactivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace HamburgerMenu
{
    public class HamburgerMenuItem : ListBoxItem, ICommandSource
    {
        static HamburgerMenuItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HamburgerMenuItem), new FrameworkPropertyMetadata(typeof(HamburgerMenuItem)));
        }
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(HamburgerMenuItem), new PropertyMetadata(String.Empty));


        public object Icon
        {
            get { return (object)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(nameof(Icon), typeof(object), typeof(HamburgerMenuItem), new PropertyMetadata(null));


        public Button Button
        {
            get { return (Button)GetValue(ButtonProperty); }
            set { SetValue(ButtonProperty, value); }
        }
        public static readonly DependencyProperty ButtonProperty = DependencyProperty.Register(nameof(Button), typeof(object), typeof(HamburgerMenuItem), new PropertyMetadata(null));

        public Brush SelectionIndicatorColor
        {
            get { return (Brush)GetValue(SelectionIndicatorColorProperty); }
            set { SetValue(SelectionIndicatorColorProperty, value); }
        }

        public static readonly DependencyProperty SelectionIndicatorColorProperty =
            DependencyProperty.Register("SelectionIndicatorColor", typeof(Brush), typeof(HamburgerMenuItem), new PropertyMetadata(Brushes.Blue));

        public bool IsMenuItemChecked
        {
            get { return (bool)GetValue(IsMenuItemCheckedProperty); }
            set { SetValue(IsMenuItemCheckedProperty, value); }
        }

        public static readonly DependencyProperty IsMenuItemCheckedProperty =
            DependencyProperty.Register(nameof(IsMenuItemChecked), typeof(bool), typeof(HamburgerMenuItem), new PropertyMetadata(false));

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register("Command", typeof(ICommand), typeof(HamburgerMenuItem), new UIPropertyMetadata(null));

        public object CommandParameter
        {
            get { return (object)GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CommandParameter.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CommandParameterProperty =
            DependencyProperty.Register("CommandParameter", typeof(object), typeof(HamburgerMenuItem), new UIPropertyMetadata(null));

        public IInputElement CommandTarget
        {
            get { return (IInputElement)GetValue(CommandTargetProperty); }
            set { SetValue(CommandTargetProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CommandTarget.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CommandTargetProperty =
            DependencyProperty.Register("CommandTarget", typeof(IInputElement), typeof(HamburgerMenuItem), new UIPropertyMetadata(null));
    }
}
