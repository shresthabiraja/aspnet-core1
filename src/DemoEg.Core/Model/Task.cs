using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoEg.Model
{
    public class Task : FullAuditedEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

      

        public TaskState State { get; set; }

        public Person AssignedPerson { get; set; }
        public Guid? AssignedPersonId { get; set; }

        public Task()
        {
            CreationTime = Clock.Now;
            State = TaskState.Open;
        }
    }
}