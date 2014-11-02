using System;
using Windows.UI.Xaml.Controls;

namespace Dodici {
    public sealed partial class TimeTold : UserControl {
        static string[] numbers = { "midnight", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "noon" };
        const string oclock = "{0} o'clock";
        const string quarterpast = "quarter past {0}";
        const string quarterto = "quarter to {0}";
        const string halfpast = "half past {0}";
        const string minutespast = "{1} minutes past {0}";
        const string minutesto = "{1} minutes to {0}";

        public TimeTold() {
            this.InitializeComponent();
            Update();
        }

        private void Setup(object sender, Windows.UI.Xaml.RoutedEventArgs e) {
            Update();
        }

        public void Update() {
            ToldText.Text = TellDate(DateTime.Now);
        }

        private string TellDate(DateTime date) {
            // O'clock
            if (date.Minute < 5) {
                return string.Format(oclock, NominalHour(date.Hour));
            }

            // Quarters
            if (date.Minute < 20 && date.Minute >= 15) {
                return string.Format(quarterpast, NominalHour(date.Hour));
            }
            if (date.Minute < 35 && date.Minute >= 30) {
                return string.Format(halfpast, NominalHour(date.Hour));
            }
            if (date.Minute < 50 && date.Minute >= 45) {
                return string.Format(quarterto, NominalHour(date.Hour+1));
            }

            // Past / To
            if (date.Minute < 30) {
                return string.Format(minutespast, NominalHour(date.Hour), date.Minute);
            } else {
                return string.Format(minutesto, NominalHour(date.Hour+1), 60-date.Minute);
            }
        }

        private string NominalHour(int hour) {
            if (hour < 13) return numbers[hour];
            else if (hour > 23) return numbers[0];
            else return numbers[hour - 12];
        }
    }
}
