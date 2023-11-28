using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operations.Models.Abstract
{
    public enum Status { Active = 1, Modified = 2, Passive = 3 }

    public abstract class BaseItem
    {
        private DateTime _cratedDate = DateTime.Now;
        private Status _status = Status.Active; 

        public int Id { get; set; }
        public DateTime CreatedDate { get => _cratedDate; set => _cratedDate = value; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public Status Status { get => _status; set => _status = value; }
    }
}
