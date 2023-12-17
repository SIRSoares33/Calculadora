using Calculadora.Entities;

namespace Calculadora.MVP.Model.Main
{
    public class MainModel
    {
        public long CheckExpression(Calculation calculation, string operation) // Calculadora
        {
            switch(operation)
            {
                case "+":
                    return calculation.Sum();
                case "-":
                    return calculation.Subtraction();
                case "*":
                    return calculation.Multiplication();
            }
            return calculation.Division();
        }
    }
}