using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDB
{
    public partial class Form1 : Form
    {
        private BST t = new BST();
        private List<Movie> MovieList = new List<Movie>();

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFile_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = @"Text Files|*.txt|All Files|*.*",
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                File_Label.Text = $@"Current File: {ofd.FileName}";
                ProcessFile(ofd.FileName);
            }
        }

        private void ProcessFile(string fileName)
        {
            int i = 0;
            using (StreamReader sr = new StreamReader(File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read)))
            {
                StringBuilder block = new StringBuilder();
                while (sr.EndOfStream == false)
                {
                    string line = sr.ReadLine();
                    if (line != "")
                    {
                        if (block.Length == 0)
                        {
                            block.Append(line);
                        }
                        else
                        {
                            block.Append('|' + line);
                        }
                    }
                    else
                    {
                        if(block.Length != 0)
                        {
                            InsertMovieToTree(block.ToString());
                            i++;
                        }
                        block.Clear();
                    }
                }
                if (block.Length != 0)
                {
                    InsertMovieToTree(block.ToString());
                    i++;
                }
            }

            textBox1.WriteLine(t.InOrderTitles());
            MoviesInFile_Label.Text += i;
            MoviesInTree_Label.Text += t.Count;
        }

        private void InsertMovieToTree(string movieBlock)
        {
            string[] block = movieBlock.Split('|');
            string title = block.First();
            int i = title.IndexOf("(");
            int j = title.IndexOf(")");

            string year = title.Substring(i+1, j - i - 1);
            int y = int.Parse(year);
            string betterTitle = title.Remove(i);
            string[] x = block.Skip(1).ToArray();

            Movie m = new Movie()
            {
                Title = betterTitle.Trim(),
                Year = y,
                Actors = x
            };
            MovieList.Add(m);
            t.Add(m);
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            if (Search_TextBox.Text != string.Empty)
            {
                Movie m = t.GetMovieByTitle(Search_TextBox.Text);
                if (m != null)
                {
                    Output_TextBox.WriteLine(m.ToString());
                }
            }
        }
    }

    public static class Extension
    {
        public static void WriteLine(this TextBox tb, string value)
        {
            tb.SelectionStart = tb.TextLength;
            tb.SelectedText = value + Environment.NewLine;
        }
    }

    public class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string[] Actors { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Title: {Title}{Environment.NewLine}Year: {Year}{Environment.NewLine}Actors:{Environment.NewLine}");
            int i = 0;
            foreach (string actor in Actors)
            {
                sb.Append(i++ == Actors.Length - 1 ? $"\t{actor}" : $"\t{actor}{Environment.NewLine}");
            }

            return sb.ToString();
        }
    }

    public class BST
    {
        public int Count { get; set; }
        private class Node
        {
            internal Node Left;
            internal Node Right;
            internal string Value;
            internal Movie m;

            public Node(Movie m)
            {
                Value = m.Title;
                Right = null;
                this.m = m;
            }
        }

        private Node Root;

        public bool Add(Movie m)
        {
            if (Root == null)
            {
                Root = new Node(m);
                Count++;
                return true;
            }
            else
            {
                return Add(Root, m);
            }
        }

        private bool Add(Node current, Movie m)
        {
            if (current == null)
            {
                throw new Exception();
            }

            switch (string.Compare(m.Title, current.Value))
            {
                case -1:
                    if (current.Left == null)
                    {
                        current.Left = new Node(m);
                        Count++;
                        return true;
                    }
                    else
                    {
                        return Add(current.Left, m);
                    }
                case 1:
                    if (current.Right == null)
                    {
                        current.Right = new Node(m);
                        Count++;
                        return true;
                    }
                    else
                    {
                        return Add(current.Right, m);
                    }
                default:
                    return false;
            }
        }

        public int ExpensiveCount()
        {
            return Root == null ? 0 : ExpensiveCount(Root);
        }

        private int ExpensiveCount(Node current)
        {
            if (current == null)
            {
                return 0;
            }

            return ExpensiveCount(current.Left) + 1 + ExpensiveCount(current.Right);
        }

        public string InOrderYears()
        {
            return InOrderYears(Root);
        }

        private string InOrderYears(Node current)
        {

            if (current == null)
            {
                return string.Empty;
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(InOrderYears(current.Left));
            sb.Append($"{current.m.Year}, ");
            sb.Append(InOrderYears(current.Right));
            return sb.ToString();
        }

        public string InOrderTitles()
        {
            return InOrderTitles(Root);
        }

        private string InOrderTitles(Node current)
        {
            if (current == null)
            {
                return string.Empty;
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(InOrderTitles(current.Left));
            sb.Append($"{current.Value}{Environment.NewLine}");
            sb.Append(InOrderTitles(current.Right));
            return sb.ToString();
        }

        public Movie GetMovieByTitle(string title)
        {
            return Root == null ? null : GetMovieByTitle(Root, title);
        }

        private Movie GetMovieByTitle(Node current, string title)
        {
            if (current == null)
            {
                return null;
            }
            if (current.Value == title)
            {
                return current.m;
            }

            switch (string.Compare(title, current.Value))
            {
                case -1: return GetMovieByTitle(current.Left, title);
                case 1: return GetMovieByTitle(current.Right, title);
                default: return null;
            }
        }

        public bool Remove()
        {
            throw new NotImplementedException();
        }
    }
}
