using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Dodici {
    public sealed partial class TimeBar : UserControl {
        const double duration = 86400;

        public TimeBar() {
            this.InitializeComponent();
            Update();
        }

        private void Setup(object sender, Windows.UI.Xaml.RoutedEventArgs e) {
            Update();
        }

        public void Update() {
            Thickness targetMargin = TimelinePointer.Margin;
            double barWidth = TimelineBorder.ActualWidth;

            DateTime date = DateTime.Now;
            double currentTime = (date.Hour * 3600 + date.Minute * 60 + date.Second) / duration;

            targetMargin.Left += barWidth * currentTime;
            TimelinePointer.Margin = targetMargin;
        }
    }
}
