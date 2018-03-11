using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCTravelReviewApp.Models
{
    public class Review
    { //properties and changing some display names:
        [Key]
        public int ReviewID { get; set; }

        [Display(Name = "Business Name")]
        public string BusinessName { get; set; }

        [Display(Name = "Would you recommend it?")]
        public bool WouldRecommend { get; set; }

        [Display(Name = "Star Rating (1-5)")]
        public int StarRating { get; set; }

        public string Comments { get; set; }

        public string Location { get; set; }

        //foreign key and navegation property
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }






    }
}