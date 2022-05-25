using System;
using System.Collections.Generic;

namespace SolvaBlazorBoard.Models
{
    public partial class TblAgoraChatMaster
    {
        public string Id { get; set; } = null!;
        public string User { get; set; } = null!;
        public string? Content { get; set; }
        public DateTime? Date { get; set; }
    }
}
