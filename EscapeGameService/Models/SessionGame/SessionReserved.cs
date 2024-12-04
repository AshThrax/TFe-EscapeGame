﻿namespace EscapeGameService.Models
{
    public class SessionReserved
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public int SessionGameId { get; set; }
        public SessionGame? SessionGame { get; set; }
        public bool Iscancel { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime Updatedate { get; set; }
    }
}