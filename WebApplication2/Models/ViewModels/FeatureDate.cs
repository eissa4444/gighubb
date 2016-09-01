using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GigHub.Models.ViewModels
{
    public class FeatureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isVAlid = DateTime.TryParseExact(Convert.ToString(value),
                "d mmm yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dateTime);
            return (isVAlid && dateTime > DateTime.Now);
        }

    }

}
