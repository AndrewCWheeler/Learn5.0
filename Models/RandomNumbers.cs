using System;
using System.Collections.Generic;
using System.Linq;
namespace Learn.Models
{
    public class RandomNumbers
    {
        public int LevelOneNum()
        {
            var exclude = new HashSet<int>() { 7 };
            var range = Enumerable.Range(1, 8).Where(i => !exclude.Contains(i));
            Random rand = new Random();
            int index = rand.Next(0, 7 - exclude.Count);
            return range.ElementAt(index);
        }
        public int LevelTwoNum()
        {
            var exclude = new HashSet<int>() { 7, 11 };
            var range = Enumerable.Range(1, 12).Where(i => !exclude.Contains(i));
            Random rand = new Random();
            int index = rand.Next(0, 11 - exclude.Count);
            return range.ElementAt(index);
        }
        public int LevelThreeNum()
        {
            var exclude = new HashSet<int>() { 7, 11, 13, };
            var range = Enumerable.Range(1, 16).Where(i => !exclude.Contains(i));
            Random rand = new Random();
            int index = rand.Next(0, 15 - exclude.Count);
            return range.ElementAt(index);
        }
    }
}
