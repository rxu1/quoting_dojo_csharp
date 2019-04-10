using System;
using System.ComponentModel.DataAnnotations;

namespace QuotingDojo.Models
{
  public class Quote
  {
    [Required]
    [MinLength(3)]
    [Display(Name="Author:")]
    public string Author { get; set; }

    [Required]
    [MinLength(5)]
    [Display(Name="Quotes:")]
    public string Content { get; set; }
  }
}