using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REG_MARK_LIB
{
    public class Class
    {
        public string[] letters = { "А", "В", "Е", "К", "М", "Н", "О", "Р", "С", "Т", "У", "Х" };
        public bool CheckMark(string mark)
        {
            mark = mark.ToLower();
            Regex regex = new Regex("[а-б][0-9]{3}[а-б]{2}[0-9]{3}");
            Match match = regex.Match(mark);
            if(match.Success)
                return true;
            return false;
        }
        public string GetNextMarkAfter(string mark)
        {
            if (!CheckMark(mark))
                return "error";
            mark = mark.ToLower();
            Random rnd = new Random();
            string newnum = letters[rnd.Next(0, 12)];
            for (int i = 0; i < 3; i++)
            {
                newnum += rnd.Next(0, 9).ToString();
            }
            for (int i = 0; i < 2; i++)
            {
                newnum += letters[rnd.Next(0, 12)];
            }
            for (int i = 0; i < 3; i++)
            {
                newnum += mark[mark.Length - (3-i)];
            }
            newnum = newnum.ToLower();

            return newnum;
        }

        public string GetNextMarkAfterInRange(string prevMark, string rangeStart, string rangeEnd)
        {
            if (!CheckMark(prevMark))
                return "error";
            prevMark = prevMark.ToLower();
            int start = int.Parse(rangeStart.Substring(1, 3));
            int end = int.Parse(rangeEnd.Substring(1, 3));
            Random rnd = new Random();
            int newnum;
            if (end > start)
                newnum = rnd.Next(start, end);
            else
                newnum = rnd.Next(end,start);
            char[] mark = prevMark.ToCharArray();
            for (int i = 0; i < 3; i++)
            {
                mark[i + 1] = newnum.ToString()[i];
            }
            string str = new string(mark);
            return new string(mark);
        }
        public int GetCombinationsCountInRange(string mark1, string mark2)
        {
            //(10 ^ 3 - (start + end) * 11 ^ 3) + 10 ^ 3 - (start + end)
        }
    }
}
