using System.ComponentModel;

namespace Helpers.Enum
{
    public enum ProcessStatus
    {
        [Description("Open")]
        Open = 0,
        [Description("Running")]
        Running = 1,
        [Description("Open")]
        Closed = 2,
        [Description("Task Cancelled")]
        Cancelled = 3,
        [Description("Launching")]
        Launching = 4
    }
}
