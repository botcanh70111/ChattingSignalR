﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model
{
    public class Message : DateTimeGeneric
    {
        public Message()
        {
            Users = new HashSet<User>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid WithDestinationId { get; set; }
        public string Messages { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
