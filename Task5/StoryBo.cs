using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement5
{
    class StoryBo
    {

        public static Story createStory(String detail)
        {
            string[] s = detail.Split(",");

            Story story = new Story(s[0], s[1], s[2], Convert.ToInt32(s[3]), Convert.ToInt32(s[4]), Convert.ToInt32(s[5]));

            return story;

        }
    }
}

