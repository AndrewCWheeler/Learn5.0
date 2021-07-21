using System;
using System.Collections.Generic;
using System.Linq;
namespace Learn.Models

{
    public class DivisionCard
    {
        public FractionCard Create(int level)
        {
            Random rand = new Random();
            int RL1Num = new RandomNumbers().LevelOneNum();
            int RL2Num = new RandomNumbers().LevelTwoNum();
            int RL3Num = new RandomNumbers().LevelThreeNum();

            FractionCard Card = new FractionCard();

            if (level == 1)
            {
                Card.Divisor = RL1Num;
                Card.Dividend = rand.Next(1, 8);

            } else if (level == 2)
            {
                Card.Divisor = RL2Num;
                Card.Dividend = rand.Next(1, 12);
            } else
            { 
                Card.Divisor = RL3Num;
                Card.Dividend = rand.Next(1, 16);
            }
            Card.Whole = Card.Dividend / Card.Divisor;
            Card.Modulus = Card.Dividend % Card.Divisor;

            if (Card.Dividend < Card.Divisor)
            {
                Card.Whole = null;
                Card.Answer = new Fraction(Card.Dividend, Card.Divisor);
            } else
            {
                if (Card.Modulus == 0)
                {
                    Card.Answer = null;
                } else
                {
                    Card.Answer = new Fraction(Card.Modulus, Card.Divisor);
                }
            }
            return Card;
        }
    }
}
