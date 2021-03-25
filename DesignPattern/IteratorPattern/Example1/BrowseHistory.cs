using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.IteratorPattern.Example1
{
    public class BrowseHistory
    {
        //private List<string> urls = new List<string>();
        private string[] urls = new string[10];
        private int index;

        //public void Push(string url)
        //{
        //    urls.Add(url);
        //}

        //public string Pop()
        //{
        //    var lastIndex = urls.Count - 1;
        //    var lastUrl = urls[lastIndex];
        //    urls.RemoveAt(lastIndex);

        //    return lastUrl;
        //}

        public void Push(string url)
        {
            urls[index++] = url;
        }

        public string Pop()
        {
            return urls[--index];
        }

        public IIterator<string> CreateIterator()
        {
            //return new ListIterator(this);
            return new ArrayIterator(this);
        }

        //public class ListIterator : IIterator<string>
        //{
        //    private BrowseHistory history;
        //    private int index;

        //    public ListIterator(BrowseHistory history)
        //    {
        //        this.history = history;
        //    }

        //    public string Current()
        //    {
        //        return history.urls[index];
        //    }

        //    public bool HasNext()
        //    {
        //        return (index < history.urls.Count); //Because ListIterator is inside BrowseHistory, it can see BrowseHistory's private members.
        //    }

        //    public void Next()
        //    {
        //        index++;
        //    }
        //}

        public class ArrayIterator : IIterator<string>
        {
            private BrowseHistory history;
            private int index;

            public ArrayIterator(BrowseHistory history)
            {
                this.history = history;
            }

            public string Current()
            {
                return history.urls[index];
            }

            public bool HasNext()
            {
                return index < history.urls.Length; //Because ListIterator is inside BrowseHistory, it can see BrowseHistory's private members.
            }

            public void Next()
            {
                index++;
            }
        }
    }
}
