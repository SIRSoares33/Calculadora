namespace Calculadora.Entities;
public class Calculation
{
    #region Attributes
    private readonly long[] Numbers;
    #endregion
    
    #region Constructor
    public Calculation(long[] numbers)
    {
        if (numbers[0] == null || numbers[1] == null)
            throw new Exception("Digite dois n�meros para realizar a opera��o");

       Numbers = numbers;
    }
    #endregion

    #region Methods
    public long Sum            () => Numbers[0] + Numbers[1];
    public long Subtraction    () => Numbers[0] - Numbers[1];
    public long Multiplication () => Numbers[0] * Numbers[1];
    public long Division       () => Numbers[0] / Numbers[1];
    #endregion
}
