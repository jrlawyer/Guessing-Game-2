using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GuessingGame2.Models
{
    public class GameModel
    {
        [Display(Name = "Enter Your Name")]
        [Required(ErrorMessage = "Please enter your name.")]
        [MinLength(2, ErrorMessage = "Name is too short.")]
        [MaxLength(20, ErrorMessage = "Name is too long")]
        public string PlayerName
        { get; set; }

        [Display(Name = "What's Your Guess")]
        [Required(ErrorMessage = "Please take a guess.")]
        [Range(RangeMin, RangeMax, ErrorMessage = "Please pick a number between 1 and 10." )]
        public int Guess
        { get; set; }

        /*create constants for rangemin and rangemax.
       */
        public const int RangeMin = 1;
        public const int RangeMax = 10;
        
        public override string ToString()
        {
            return $"{PlayerName}, ({Guess})";
        }
    }
}


//public class GameModel
//[Display(Name = "Please enter your name.")]
//public string PlayerName
//{ get; set; }

//[Display(Name = "Please enter a guess.")]
//public string Guess
//{ get; set; }

//public override string ToString()
//{
//    return $"{PlayerName}, ({Guess})";
//}

