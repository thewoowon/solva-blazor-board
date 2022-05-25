namespace SolvaBlazorBoard.Entity
{
    public class News
    {
        public string? Id { get; set; }
        public string? User { get; set; }
        public string? Title { get; set; }

        public string? Html { get; set; }

        public DateTime Date { get; set; }
    }
}
