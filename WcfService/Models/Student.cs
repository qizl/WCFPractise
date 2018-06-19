using System;

namespace WcfService.Models
{
    public class Student
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public SexEnum Sex { get; set; }
        public DateTime Birthday { get; set; }

        public enum SexEnum
        {
            Boy = 0,
            Girl
        }
    }
}