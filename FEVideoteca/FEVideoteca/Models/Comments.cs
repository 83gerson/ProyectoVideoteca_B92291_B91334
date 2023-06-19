namespace FEVideoteca.Models
{
    public class Comments
    {
        public int CommentId { get; set; }
        public string Comment { get; set; }
        public int? MovieSeriesId { get; set; }
        public string UserName { get; set; }


        public Comments()
        {
            CommentId = 0;
            Comment= String.Empty;
            MovieSeriesId = 0;
            UserName = String.Empty;
        }
    }
}
