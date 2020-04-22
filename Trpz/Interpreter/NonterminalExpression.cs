namespace Trpz
{
    public class NonterminalExpression : IExpression
    {
        private IExpression LeftExpression { get; set; }
        private IExpression RightExpression { get; set; }

        public NonterminalExpression(IExpression left, IExpression right)
        {
            LeftExpression = left;
            RightExpression = right;
        }

        public void Interpret(Context context)
        {
            throw new System.NotImplementedException();
        }
    }
}