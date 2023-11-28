using CRUD_Operations.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operations.Models.Concrate
{
    public class Category : BaseItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
