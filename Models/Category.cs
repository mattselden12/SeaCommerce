using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeaCommerce.Models
{
    public class Category
    {
        public int CategoryId {get;set;}
        public string CategoryName {get;set;}
        public List<PlayerCategories> Players {get;set;}

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt {get;set;}
        
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt {get;set;}

        public Category(){
            Players = new List<PlayerCategories>();
        }

    }
}