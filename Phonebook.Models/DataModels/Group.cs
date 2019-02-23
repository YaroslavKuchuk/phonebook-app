using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Phonebook.Models.DataModels
{
    public class Group
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        //[NonNumeric(ErrorMessage = "Не может начинаться с 1")]
        public string Name { get; set; }
    }
}
