using Abp.AutoMapper;
using DemoEg.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoEg.TaskDto.Dto
{
    [AutoMapTo(typeof(Task))]
    public class CreateTaskInput
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid? AssignedPersonId { get; set; }
    }
}
