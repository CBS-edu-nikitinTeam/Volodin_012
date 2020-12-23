using System;

namespace Exercise3
{
    public class Book : IShowable
    {
        private readonly Title _title = new Title();
        private readonly Author _author = new Author();
        private readonly Content _content = new Content();

        public Book(string title, string author, string content)
        {
            this._title.Name = title;
            this._author.Name = author;
            this._content.Name = content;
        }

        public void Show()
        {
            _title.Show();
            _author.Show();
            _content.Show();
        }
    }
}