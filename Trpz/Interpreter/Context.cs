using System.Collections.Generic;

namespace Trpz
{
    public class Context
    {
        public IExpression Evaluate(List<string> list)
        {
            int postion = list.Count-1;
            while (postion > 0)
            {
                if (list[postion] != "+")
                    postion--;
                else
                {
                    IExpression leftExpression = Evaluate(list.GetRange(0, postion));
                    IExpression rightExpression = new CommandExpression(list[postion+1]);
                    return new CommandConcatenation(leftExpression, rightExpression);
                }
            }
            return new CommandExpression(list[postion]);
        }
    }
}