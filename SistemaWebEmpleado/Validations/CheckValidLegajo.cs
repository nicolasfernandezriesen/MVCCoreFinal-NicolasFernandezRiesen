using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebEmpleado.Validations
{
    public class CheckValidLegajo : ValidationAttribute
    {
        public CheckValidLegajo() 
        {
            ErrorMessage = ("El Legajo debe comenzar con dos letras AA y 5 numeros");
        }

        public override bool IsValid(object value)
        {
            string legajo = value.ToString();

            if (legajo.Substring(0,2) == "AA" && legajo.Replace("AA", "").Length == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
