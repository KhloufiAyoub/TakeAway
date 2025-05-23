﻿using System.ComponentModel.DataAnnotations;

namespace TakeAway.Models
{
    public class Service
    {
        private int id;
        private TimeSpan startTime;
        private TimeSpan endTime;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        [Required(ErrorMessage = "Start time is required.")]
        [DataType(DataType.Time)]
        [Display(Name = "Start Time")]
        public TimeSpan StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }


        [Required(ErrorMessage = "End time is required.")]
        [DataType(DataType.Time)]
        [Display(Name = "End Time")]
        public TimeSpan EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }


        public Service(int id, TimeSpan startTime, TimeSpan endTime)
        {
            Id = id;
            StartTime = startTime;
            EndTime = endTime;
        }


        public Service() { }


        public override string ToString()
        {
            string start = $"{startTime.Hours:D2}:{startTime.Minutes:D2}";
            string end = $"{endTime.Hours:D2}:{endTime.Minutes:D2}";
            return $"{start} - {end}";
        }
    }
}
