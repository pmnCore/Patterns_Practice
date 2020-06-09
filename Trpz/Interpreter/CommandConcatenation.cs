using System.Runtime.Remoting.Messaging;

namespace Trpz
{
    public class CommandConcatenation : IExpression
    {
        private IExpression LeftExpression { get; set; }
        private IExpression RightExpression { get; set; }

        public CommandConcatenation(IExpression left, IExpression right)
        {
            LeftExpression = left;
            RightExpression = right;
        }

        public string Interpret() => LeftExpression.Interpret() +"\n"+ RightExpression.Interpret();

    }
}