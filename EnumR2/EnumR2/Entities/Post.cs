using System;
using System.Collections.Generic;
using System.Text;


namespace EnumR2.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Like { get; set; }
        public List<Comment> Comment { get; set; } = new List<Comment>();

        public Post()
        {

        }

        public Post(DateTime moment, string title, string content, int like)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Like = like;

        }
        public void AddComment(Comment comment)
        {
            Comment.Add(comment);

        }

        public void RemoveComment(Comment comment)
        {
            Comment.Remove(comment);

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Like);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.Append("Comments: ");

            foreach(Comment c in Comment){
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
