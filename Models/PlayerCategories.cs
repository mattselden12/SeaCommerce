using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeaCommerce.Models
{
    public class PlayerCategories
    {
        public string PlayerCategoriesId {get;set;}

        public int PlayerId {get;set;}
        public Player Player {get;set;}
        public int CategoryId {get;set;}
        public Category Category {get;set;}

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt {get;set;}
        
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt {get;set;}
    }
}