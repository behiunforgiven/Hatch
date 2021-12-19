using System.ComponentModel.DataAnnotations;

namespace Hatch.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}