using System;
namespace Learn.Models
{
    public class MultiplicationCard
    {
        public FractionCard Create(int level, int id)
        {
            Random rand = new Random();
            int RL1Num = new RandomNumbers().LevelOneNum();
            int RL2Num = new RandomNumbers().LevelTwoNum();

            FractionCard Card = new FractionCard();
            Card.Id = id;

            if (level == 1)
            {
                Card.Dividend = rand.Next(1, 6);
                Card.Divisor = RL1Num;
                Card.DividendTwo = rand.Next(1, 6);
                Card.DivisorTwo = RL1Num;

            }
            else if (level == 2)
            {
                Card.Dividend = rand.Next(1, 10);
                Card.Divisor = RL1Num;
                Card.DividendTwo = rand.Next(1, 10);
                Card.DivisorTwo = RL1Num;

            }
            else
            {
                Card.Dividend = rand.Next(1, 10);
                Card.Divisor = RL2Num;
                Card.DividendTwo = rand.Next(1, 10);
                Card.DivisorTwo = RL2Num;
            }
            
            // Combine first and second fraction and assign to values "first" and "second"
            Fraction first = new Fraction(Card.Dividend, Card.Divisor);
            Fraction second = new Fraction(Card.DividendTwo, Card.DivisorTwo);

            // Create variables to contain whole number reductions of each fraction
            Card.Whole = Card.Dividend / Card.Divisor;
            Card.WholeTwo = Card.DividendTwo / Card.DivisorTwo;
            Card.AnswerDividend = Card.Dividend * Card.DividendTwo;
            Card.AnswerDivisor = Card.Divisor * Card.DivisorTwo;
            Card.Modulus = Card.Dividend % Card.Divisor;
            Card.ModulusTwo = Card.DividendTwo % Card.DivisorTwo;

            Card.Answer = new Fraction(first * second);
            var frac = new Fraction(Card.Answer);
            Card.Answer = frac;
            Card.DecimalDividend = (decimal)frac.Numerator;
            Card.DecimalDivisor = (decimal)frac.Denominator;
            //Cards[j].AnswerDividend = (int)frac.Numerator;
            //Cards[j].AnswerDivisor = (int)frac.Denominator;
            Card.AnswerWhole = Card.AnswerDividend / Card.AnswerDivisor;
            Card.AnswerModulus = Card.AnswerDividend % Card.AnswerDivisor;
            // Format the fractions to be multiplied:
            if (Card.Modulus == 0)
            {
                Card.First = Card.Dividend.ToString() + "/" + Card.Divisor.ToString();
            }
            else
            {
                Card.First = new Fraction(Card.Dividend, Card.Divisor);
            }
            if (Card.ModulusTwo == 0)
            {
                Card.Second = Card.DividendTwo.ToString() + "/" + Card.DivisorTwo.ToString();
            }
            else
            {
                Card.Second = new Fraction(Card.DividendTwo, Card.DivisorTwo);
            }
            // Format the Cards[j].Answer to display as a whole number over 1 and Cards[j].AnswerTwo as a reduced fraction: 
            if (Card.AnswerDividend < Card.AnswerDivisor)
            {
                Card.AnswerWhole = null;
                Card.AnswerTwo = new Fraction(Card.AnswerDividend, Card.AnswerDivisor);
            }
            else
            {
                if (Card.AnswerModulus == 0)
                {
                    Card.Answer = Card.Answer.ToString() + "/1";
                    Card.AnswerTwo = null;
                }
                else
                {
                    Card.AnswerTwo = new Fraction(Card.AnswerModulus, Card.AnswerDivisor);
                }
            }
            // Calculate the decimal answer if the AnswerDivisor is not == 0.
            if (Card.AnswerDivisor != 0)
            {
                Card.AnswerDecimal = Decimal.Round((Card.DecimalDividend / Card.DecimalDivisor), 3);
            }
            else
            {
                Card.AnswerDecimal = Card.DecimalDividend / 1;
            }
        
            return Card;
        }
    }
}
