using PsscProject.Helpers.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Generic
{
    public class PlainText:ValueObject
    {
        [Required]
        private string _text;
        public string Text { get { return _text; } }

        public PlainText(string text)
        {
            if (string.IsNullOrEmpty(text)) throw new ArgumentNullException("input cannot be null or empty");

            _text = text;
        }

    }
}
