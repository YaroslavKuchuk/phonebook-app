using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhoneBook.Attributes
{
    public class NonNumericAttribute:ValidationAttribute
    {
        private string name;
        public string Name { get { return name; }  private set { name = value; } }
       
        public delegate bool Validator(string value);

        public enum Validation
        {
            All,
            Numbers,
            Cyrilic
        }

        private Dictionary<Validation, Validator> _validators =
            new Dictionary<Validation, Validator>();
        

        public override bool IsValid(object value)
        {
            if (value is string strValue)                
            {
                if(!string.IsNullOrEmpty(value.ToString()))
                {                 
                    if(NumberCyrilicValidator(strValue) && NumberValidator(strValue) && CyrilicValidator(strValue))                   
                        return true;                    
                }
               
            }          

            return false;
        }

        public NonNumericAttribute()
        {
            _validators.Add(
               Validation.All,
               new Validator(NumberCyrilicValidator)
               );

            _validators.Add(
                Validation.Numbers,
                new Validator(NumberValidator)
                );

            _validators.Add(
               Validation.Cyrilic,
               new Validator(CyrilicValidator)
               );
                       
        }

        public bool NumberValidator (string value)
        {
            char[] numbers = new char[] { '0', '1','2', '3','4','5','6','7','8','9'};

            return !numbers.Contains(value[0]);
        }

        public bool CyrilicValidator (string value)
        {
            char[] letters = new char[] {'ё', 'ъ','ь'};

            return !letters.Contains(value[0]);
        }

        public bool NumberCyrilicValidator(string value)
        {
            return CyrilicValidator(value) && NumberValidator(value);
        }

       
       
    }
}