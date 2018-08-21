using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeaCommerce.Models
{
    public class Order
    {
        public int OrderId {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string Address {get;set;}
        public string City {get;set;}
        public string State {get;set;}
        public int Zipcode {get;set;}
        public List<PlayersOrdered> Players {get;set;}

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt {get;set;}
        
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt {get;set;}

        public Order(){
            Players = new List<PlayersOrdered>();
        }
    }
}