using System;

namespace Grades
{
    public class NameChangedEventsArgs : EventArgs
    {
        public string ExistingName { get; set; }
        public string NewName { get; set; }
    }
}