using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3ElementsFinder;
public class ElementsFinder
{
    public void FindElementsForSum(List<uint> list, ulong sum, out int start, out int end)
    {
        start = 0;
        end = 0;

        if (list == null || list.Count < 2)
        {
            throw new ArgumentException("List must contain at least two elements.");
        }

        // we stop at the last group with at least 2 elements
        for (start = 0; start < list.Count - 1; start++)
        {
            ulong currentSum = 0;
            end = start + 1;

            while (true)
            {
                if (end > list.Count)
                {
                    start = 0;
                    end = 0;
                    return;
                }

                currentSum += list[end - 1];

                if (currentSum == sum)
                    return;

                if (currentSum > sum)
                    break;

                end++;
            }
        }

        //if not found
        start = 0;
        end = 0;
    }
}
