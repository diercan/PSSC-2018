using System;

namespace ProiectPSSC.Domain.Services.Entities
{
    public class LaptopEntity
    {
        public LaptopEntity(DateTime date, string creator)
        {
            CreatedDate = date;
            Creator = creator;
        }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Creator { get; set; }
    }
}
