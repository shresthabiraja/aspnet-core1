using System.ComponentModel.DataAnnotations;

namespace DemoEg.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}