namespace SolvaBlazorBoard.Entity
{
    public class Board
    {
        
        // 게시판에 내용을 등록 시 항목
        // -> 헤더, 메인, 푸터
        // -> 제목, 위지윅, 파일첨부, 태그, 일자
        public string? Id { get; set; }
        public string? User { get; set; }
        public string? Title { get; set; }
        public string? Html { get; set; }
        public DateTime Date { get; set; }
    }
}
