using Phonebook.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Models
{
    public class Contact
    {
        // [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        // [Required(ErrorMessage = "Поле должно быть установлено")]
        // [NonNumeric(ErrorMessage = "Не может начинаться с 1")]
        // [Display(Name = "Имя")]

        public int GroupId { get; set; }


        public string FirstName { get; set; }

        // [Required(ErrorMessage = "Поле должно быть установлено")]
        // [Display(Name = "Фамилия")]
        public string LastName { get; set; }
        // [Required(ErrorMessage = "Поле должно быть установлено")]
        //  [Display(Name = "Должность")]
        public string Position { get; set; }

        List<Phone> Phones = new List<Phone>();

    }
}
