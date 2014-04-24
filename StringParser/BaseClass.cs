using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParserApplication
{
    public class BaseClass
    {
        /// <summary>
        /// ctor
        /// </summary>
        public BaseClass()
        {

        }
        private TimeSpan _ts = DateTime.Now.TimeOfDay;

        private string _errorString = string.Empty;

        public string ErrorString
        {
            get { return _errorString; }
            set { _errorString = value; }
        }

        public String RunTime()
        {
            return DateTime.Now.TimeOfDay.Subtract(_ts).ToString();
        }
        /// <summary>
        /// Make sure that the string is parseable using delimiters and the values are ints.
        /// </summary>
        /// <param name="stringOfNumbers"></param>
        /// <returns></returns>
        public bool CheckNumbers(string stringOfNumbers, out List<string> newList)
        {

            List<string> mylist = stringOfNumbers.Split(',').ToList();
            string[] stringArray = new string[mylist.Count];
            mylist.CopyTo(stringArray);
            foreach (string str in stringArray)
            {
                int i = int.MinValue;
                if (int.TryParse(str, out i) == false)
                {
                    if (str.Trim() == "")
                    {
                        mylist.Remove(str);
                    }
                    else
                    {
                        _errorString = "Value " + str.Trim() + " is not in correct integer form.";
                        newList = mylist;
                        return false;
                    }
                }
            }
            newList = mylist;
            return true;
        }

        /// <summary>
        /// Easiest way to solve this issue with .NET
        /// </summary>
        /// <param name="source"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public Sum RetrieveIndexOfTopSum(IEnumerable<int> source)
        {
            List<int> tempList = new List<int>(source);
            tempList.Sort();
            return new Sum(tempList[tempList.Count - 2], tempList[tempList.Count - 1]);
        }

        /// <summary>
        /// This is a method that does an exercise using a loop
        /// </summary>
        /// <param name="source"></param>
        /// <param name="mynumber"></param>
        /// <returns></returns>
        public void RetrieveIndexOfTopSum(IEnumerable<int> source, out Sum sum)
        {
            int keepTrack = int.MinValue;
            List<int> localCopy = source.ToList<int>();
            sum = new Sum(int.MinValue, int.MinValue);
            foreach (int i in source)
            {
                int currentSum = int.MinValue;
                foreach (int p in localCopy)
                {
                    if (i != p)
                    {
                        currentSum = i + p;
                        if (currentSum > keepTrack)
                        {
                            sum = new Sum(p, i);
                            keepTrack = currentSum;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="ts"></param>
        /// <returns></returns>
        public Sum RetrieveIndexOfTopSum(IEnumerable<int> source, IEnumerable<Sum> sums)
        {
            List<int> localCopy = source.ToList<int>();
            Sum sum = new Sum(int.MinValue, int.MinValue);
            sums =
                 from c in localCopy
                 from p in source
                 where c != p
                 select new Sum(c, p);
            sum = sums.OrderByDescending(t => t.Add()).First();
            return sum;
        }
    }
}
