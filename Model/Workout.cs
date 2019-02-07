using System;
using System.ComponentModel.DataAnnotations;

namespace Workout.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public  DateTimeOffset Date { get; set; }
        public long TimeInSeconds { get; set;}
    }
}