namespace SolvaBlazorBoard.Entity
{
    public class File
    {
        // 파일이름, 파일경로, 파일크기, 파일유형
        public string? Id { get; set; }
        public string? Board_File_Id { get; set; }
        public string? Name { get; set; }  
        public string? Path { get; set; }
        public string? Size { get; set; }
        public string? Type { get; set; }
        public DateTime Date { get; set; }
    }
}
