
using Trpz.Commands;

namespace Trpz
{
    static class AutomationTool
    {
        static ICommand Command { get; set; }

        public static void SetAction(ICommand action) => Command = action;

        public static string ExecuteAction() => Command.Execute();
    }
}
