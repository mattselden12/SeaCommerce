using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeaCommerce.Models
{
    public class PlayersOrdered
    {
        public string PlayersOrderedId {get;set;}

        public int PlayerId {get;set;}
        public Player Player {get;set;}
        public int OrderId {get;set;}
        public Order Order {get;set;}

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt {get;set;}
        
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt {get;set;}
    }
}