using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SampleConsole.Sample2.Case1
{
    public static class ListUtil
    {
        // Difference list (This is like `Except` function)
        public static IEnumerable<T> Ignore<T>(IEnumerable<T> targetList, IEnumerable<T> ignoreList)
        {
            var ignoreSet = new HashSet<T>(ignoreList);
            return targetList.Where(x => !ignoreSet.Contains(x));
        }

        // Swap elements at index1 and index2
        public static IEnumerable<T> Swap<T>(IEnumerable<T> targetList, int index1, int index2)
        {
            if (index1 == index2) return targetList;

            var element1 = targetList.ElementAt(index1);
            var element2 = targetList.ElementAt(index2);

            return targetList.Select((element, index) =>
            {
                if (index == index1) return element2;
                if (index == index2) return element1;
                return element;
            }).ToList();
        }
    }
}
