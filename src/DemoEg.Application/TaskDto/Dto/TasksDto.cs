using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Runtime.Validation;
using DemoEg.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DemoEg.Tasks.Dto
{
    [AutoMapFrom(typeof(Task))]
    public class TasksDto : AuditedEntityDto, ICustomValidate
    {
        [Required]
        public string Title { get; set; }

        
        public string Description { get; set; }
        public Guid? AssignedPersonId { get; set; }

        public void AddValidationErrors(CustomValidationContext context)
        {
            // repository access 
            // error populate
            throw new NotImplementedException();
        }
    }
}
