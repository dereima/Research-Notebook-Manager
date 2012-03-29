using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ResearchManagerNotebook
{
    class Category
    {
        private List<string> noteTitles = new List<string>();

        public string Title
        { get; set; }

        public string Comment
        { get; set; }

        public Color commentColor
        { get; set; }

        public Color titleColor
        { get; set; }

        /// <summary>
        /// makes notes mambers of this category
        /// the category can only have 10 member notes
        /// </summary>
        /// <param name="title"></param>
        public void addNote(string title)
        {
            if (noteTitles.Count < 10)
                noteTitles.Add(title);
            else
                throw new FullListException("The list has 10 items and is full. Please remove one and try again"
        }

        /// <summary>
        /// returns an array containing all the note titles that are members of this category
        /// </summary>
        /// <returns></returns>
        public string[] getNotes()
        { return noteTitles.ToArray(); }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Category()
        { }
    }
}
