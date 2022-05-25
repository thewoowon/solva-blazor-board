using System;
using System.Collections.Generic;

namespace SolvaBlazorBoard.Models
{
    public partial class TblAgoraNewsMaster
    {
        public string Id { get; set; } = null!;
        public string User { get; set; } = null!;
        public string? Title { get; set; }
        public string? Html { get; set; }
        public DateTime? Date { get; set; }
    }
}
