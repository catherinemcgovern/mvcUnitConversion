using System;

namespace UConverter.Models
{
    public class ConverterViewModel
    {
        //send data down to view and get it back
        public decimal  ValueToConvert{get; set;}

        public string ConversionType {get; set;}
//we want to save what gets put into the form and pass it back to the controller

public decimal ConvertedValue {get; set;}

    }
}