using System;
using System.Collections.Generic;

namespace SolvaBlazorBoard.Models
{
    public partial class TblAgoraTagMaster
    {
        public string Id { get; set; } = null!;
        public string BoardTagId { get; set; } = null!;
        public string? Name { get; set; }
        public DateTime? Date { get; set; }
    }
}
