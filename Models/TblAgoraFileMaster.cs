using System;
using System.Collections.Generic;

namespace SolvaBlazorBoard.Models
{
    public partial class TblAgoraFileMaster
    {
        public string Id { get; set; } = null!;
        public string BoardFileId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Path { get; set; } = null!;
        public string? Size { get; set; }
        public string? Type { get; set; }
        public DateTime? Date { get; set; }
    }
}
