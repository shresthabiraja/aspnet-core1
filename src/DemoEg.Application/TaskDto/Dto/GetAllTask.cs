using Abp.Application.Services.Dto;
using DemoEg.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoEg.TaskDto.Dto
{
    public class GetAllTasksInput : PagedAndSortedResultRequestDto
    {
        public TaskState? State { get; set; }
    }
}
