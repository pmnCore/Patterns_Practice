using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trpz
{
    public class Context
    {
        public IExpression Evaluate(string command)
        {
            List<string> splittedCommand = new List<string>(command.Split(' ').ToList());
            int position = splittedCommand.Count() - 1;
            while (position > 0)
            {
                if (splittedCommand[position] != "+")
                    position--;
                else
                {
                    IExpression leftExpression = Evaluate(ConvertToCommandString(splittedCommand.GetRange(0, position)));
                    IExpression rightExpression = new CommandExpression
                        (ConvertToCommandString(splittedCommand.GetRange(position+1, splittedCommand.Count-(position+1))));
                    return new CommandConcatenation(leftExpression, rightExpression);
                }
            }
            return new CommandExpression(ConvertToCommandString(splittedCommand.GetRange(0, splittedCommand.Count)));
        }

        string ConvertToCommandString(List<string> splittedCommand)
        {
            string result = "";
            for (int i = 0; i < splittedCommand.Count; i++)
            {
                result += splittedCommand[i];
                if (i != splittedCommand.Count - 1)
                {
                    result += ' ';
                }
            }

            return result;
        }
    }
}