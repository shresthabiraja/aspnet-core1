using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoEg.Model
{
   public  class Person :FullAuditedEntity
    {
        public string Name { get; set; }
    }
}
