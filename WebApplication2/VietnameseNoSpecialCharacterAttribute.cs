using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApplication2
{
    public class VietnameseNoSpecialCharacterAttribute: RegularExpressionAttribute
    {

        public VietnameseNoSpecialCharacterAttribute() : base(@"^[\p{L} ]+$")
        {
            ErrorMessage = "Vui lòng chỉ nhập ký tự tiếng Việt và không chứa số hoặc ký tự đặc biệt";
        }

    }
}