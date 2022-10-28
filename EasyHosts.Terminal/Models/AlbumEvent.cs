﻿using System.ComponentModel.DataAnnotations;

namespace EasyHosts.Terminal.Models
{
    public class AlbumEvent
    {
        [Key]
        public int Id { get; set; }
        public int EventId { get; set; }
        public virtual Event Event { get; set; }
        [MaxLength(100)]
        public string Picture { get; set; }
    }
}