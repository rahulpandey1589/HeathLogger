using System;

namespace Data.Models
{
    public class BaseModel
    {
        public DateTime CreationDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public BaseModel()
        {
            CreationDate = DateTime.Now;
        }
    }
}