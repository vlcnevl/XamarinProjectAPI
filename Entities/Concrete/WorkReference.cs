using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class WorkReference:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int WorkId { get; set; }
    }
}
