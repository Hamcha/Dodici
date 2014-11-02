using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Dodici {
    public sealed partial class TaskBar : UserControl {
        public static DependencyProperty TitleProperty = DependencyProperty.Register("Title",
            typeof(string), typeof(TaskBar), new PropertyMetadata(""));
        public static DependencyProperty ProgressProperty = DependencyProperty.Register("Progress",
            typeof(double), typeof(TaskBar), new PropertyMetadata(0));

        public string Title {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value);  }
        }
        public double Progress {
            get { return (double)GetValue(ProgressProperty); }
            set { SetValue(ProgressProperty, value); }
        }

        private Brush BackgroundColor {
            get {
                Brush foreground = Foreground;
                foreground.Opacity = 0.5;
                return foreground;
            }
        }

        public TaskBar() {
            this.InitializeComponent();
        }
    }
}
