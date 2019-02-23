using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace PhoneBook.Attributes
{
    public class ReverseAttribute:ValidationAttribute
    {
        private string name;

        public string Name { get { return name; } private set {  name = value; } }
        public ReverseAttribute()
        {

        }
        public override bool IsValid(object value)
        {

            if (value is string str)
            {
                if (!string.IsNullOrEmpty(value.ToString()))
                {
                    if (ReverseMethod(str))
                        return true;
                }
            }
            return false;
        }

        public bool ReverseMethod(string value)
        {
            char[] array = value.ToCharArray();
            for (int i = 0; i < value.Length; i++)
            {
                array[i] = value[value.Length - i -1];
            }

            char[] numbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            return !numbers.Contains(array[0]);
        }
    }
}