using System;
using System.Collections.Generic;
using Windows.UI;

namespace Dodici.Classes {
    class TaskType {
        public string name;
        public Color color;
    }

    class TaskPeriod {
        public TaskType type;
        public DateTime start;
        public DateTime end;
        public TimeSpan duration { get { return end - start; } }
    }

    class TaskDay {
        public DateTime day;
        public List<TaskPeriod> tasks;
    }

    class TaskCalendar {
        public Dictionary<DateTime, TaskDay> dates;
    }
}
