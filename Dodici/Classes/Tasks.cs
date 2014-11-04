using System;
using System.Collections.Generic;
using Windows.UI;

namespace Dodici.Classes {
    /// <summary>
    /// Category of activities that can take places
    /// </summary>
    class TaskType {
        public string name = "Unnamed";
        public Color color = Colors.White;
    }

    /// <summary>
    /// Denotes an activity that took place
    /// </summary>
    class TaskPeriod {
        public TaskType type = null;
        public DateTime start = DateTime.Today;
        public DateTime end = DateTime.Now;
        public TimeSpan duration { get { return end - start; } }
    }

    /// <summary>
    /// Contains all activities that happened in the same day
    /// </summary>
    class TaskDay {
        public DateTime day = DateTime.Today;
        public List<TaskPeriod> tasks = new List<TaskPeriod>();
    }

    /// <summary>
    /// Collection of tasks separated per day
    /// </summary>
    class TaskCalendar {
        public Dictionary<DateTime, TaskDay> dates = new Dictionary<DateTime,TaskDay>();
    }
}
