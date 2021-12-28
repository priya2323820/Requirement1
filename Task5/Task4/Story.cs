using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement4
{
    class Story
    {
        private string name, authorName, genre;
        private int noOfChapters, noOfLikes, noOfReads;

        public Story(string name, string authorName, string genre, int noOfChapters, int noOfLikes, int noOfReads)
        {
            this.name = name;
            this.authorName = authorName;
            this.genre = genre;
            this.noOfChapters = noOfChapters;
            this.noOfLikes = noOfLikes;
            this.noOfReads = noOfReads;
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string AuthorName
        {
            set { authorName = value; }
            get { return authorName; }
        }
        public string Genre
        {
            set { genre = value; }
            get { return genre; }
        }
        public int NoOfChapter
        {
            set { noOfChapters = value; }
            get { return noOfChapters; }
        }

        public int NoOfLikes
        {
            set { noOfLikes = value; }
            get { return noOfLikes; }
        }

        public int NoOfReads
        {
            set { noOfReads = value; }
            get { return noOfReads; }
        }

        public override string ToString()
        {
            return string.Format(this.name + " " + " " + this.authorName + " " + this.genre
                + " " + this.noOfChapters + " " + this.noOfLikes + " " + this.noOfReads);
        }
    }
}
