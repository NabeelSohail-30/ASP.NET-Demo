namespace BasicCalculator.Model
{
    interface ICalculator
    {
        float Difference(float num1, float num2);
        float Divide(float num1, float num2);
        float Product(float num1, float num2);
        float Sum(float num1, float num2);
    }
}