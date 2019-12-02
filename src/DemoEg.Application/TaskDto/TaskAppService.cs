using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using DemoEg.Model;
using DemoEg.TaskDto.Dto;
using DemoEg.Tasks.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoEg.Tasks
{
    public class TaskAppService : AsyncCrudAppService<Task, TasksDto>, ITaskAppService
    {
        public TaskAppService(IRepository<Task> repository) : base(repository)
        {
        }

      

    }
}
