using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeaCommerce.Models
{
    public class Player
    {
        public int PlayerId {get;set;}
        public string PlayerName {get;set;}
        public int Price {get;set;}
        public string Description {get;set;}
        public string Country {get;set;}
        public string Team {get;set;}
        public string PlayerImage {get;set;}
        public List<PlayersOrdered> Orders {get;set;}
        public List<PlayerCategories> Categories {get;set;}

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt {get;set;}
        
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt {get;set;}

        public Player(){
            Orders = new List<PlayersOrdered>();
            Categories = new List<PlayerCategories>();
        }

    }
}