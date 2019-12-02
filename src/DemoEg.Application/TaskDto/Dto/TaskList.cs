using Abp.AutoMapper;
using DemoEg.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoEg.TaskDto.Dto
{
    [AutoMapFrom(typeof(Task))]
    public class TaskList
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreationTime { get; set; }

        public TaskState State { get; set; }

        public Guid? AssignedPersonId { get; set; }

        public string AssignedPersonName { get; set; }
    }
}
