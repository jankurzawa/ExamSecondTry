using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSecondTry.Data.Entities
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Review { get; set; }
        public double Length { get; set; }
        public Movie()
        {
            Id = Guid.NewGuid();
        }
        public Movie(string title, string direcotr, string review, double length)
        {
            Id = Guid.NewGuid();
            Title = title;
            Director = direcotr;
            Review = review;
            Length = length;
        }
    }
}
