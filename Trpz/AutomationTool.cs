
using Trpz.Commands;

namespace Trpz
{
    class AutomationTool
    {
        ICommand Command { get; set; }

        public void SetAction(ICommand action) => Command = action;

        public void ExecuteAction() => Command.Execute();
    }
}
