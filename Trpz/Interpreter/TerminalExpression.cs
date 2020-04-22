namespace Trpz
{
    public class TerminalExpression : IExpression
    {
        private string Action { get; set; }
        public TerminalExpression(string action) => Action = action;
        public void Interpret(Context context)
        {
            throw new System.NotImplementedException();
        }
    }
}