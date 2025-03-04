using System.ComponentModel;

namespace Helpers.Enum
{
    public enum ProcessStatus
    {
        [Description("OPEN")]
        Open = 0,
        [Description("RUNNING")]
        Running = 1,
        [Description("OPEN")]
        Closed = 2,
        [Description("TASK CANCELLED")]
        Cancelled = 3,
        [Description("LAUNCHING")]
        Launching = 4
    }
}
