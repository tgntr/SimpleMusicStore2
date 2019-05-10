﻿using System.ComponentModel.DataAnnotations;

namespace SimpleMusicStore.Entities
{
    public class RecordOrder
    {
        public RecordOrder()
        {
            Quantity = 1;
        }
        [Required]
        public int RecordId { get; set; }
        public Record Record { get; set; }

        [Required]
        public int OrderId { get; set; }
        public Order Order { get; set; }
        
        public int Quantity { get; set; }
    }
}