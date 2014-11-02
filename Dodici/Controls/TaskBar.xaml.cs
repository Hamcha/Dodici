using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Dodici {
    public sealed partial class TaskBar : UserControl {
        public static DependencyProperty TitleProperty = DependencyProperty.Register("Title",
            typeof(string), typeof(TaskBar), new PropertyMetadata(false));
        public static DependencyProperty ProgressProperty = DependencyProperty.Register("Progress",
            typeof(int), typeof(TaskBar), new PropertyMetadata(false));

        public string Title {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value);  }
        }
        public int Progress {
            get { return (int)GetValue(ProgressProperty); }
            set { SetValue(ProgressProperty, value); }
        }

        public TaskBar() {
            this.InitializeComponent();
        }
    }
}
