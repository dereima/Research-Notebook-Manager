using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ResearchManagerNotebook
{
    class Note
    {
        private List<string> categoryTitles = new List<string>();

        public string Title
        { get; set; }

        public string Comment
        { get; set; }

        public Color commentColor
        { get; set; }

        public Color titleColor
        { get; set; }

        /// <summary>
        /// makes this note a member of the category title passed in
        /// the note can only be a member of 5 catagories
        /// </summary>
        /// <param name="title"></param>
        public void addCategory(string title)
        {
            if (categoryTitles.Count < 5)
                categoryTitles.Add(title);
            else
                throw new FullListException("The list has 5 items and is full. Please remove one and try again");
        }

        /// <summary>
        /// returns an array containing all the category titles this note is a member of
        /// </summary>
        /// <returns></returns>
        public string[] getCategories()
        { return categoryTitles.ToArray(); }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Note()
        { }
    }
}
