
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement5
{
    class NoOfReadsComparator : IComparer<Story>
    {
        public int Compare(Story x, Story y)
        {
            return x.NoOfReads.CompareTo(y.NoOfReads);
        }
    }
}
