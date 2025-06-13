namespace RomanNumerals;

public class RomanNumerals
{
    //Primeiro codigo
    
    // public string Convert(int number)
    // {
    //     if (number == 2)
    //         return "II";
    //     
    //     return "I";
    // }
    
    //refatoração 1 
    
    // public string Convert(int number)
    // {
    //     if (number == 5)
    //         return "V";
    //     
    //     if (number == 4)
    //         return "IV";  
    //    
    //     
    //     var result = "";
    //     
    //     for (int i = 0; i < number; i++)
    //     {
    //         result += "I";
    //     }
    //     
    //     return result;
    // }
    
    //refatoração 2
    
        // public string Convert(int number)
        // {
        //     var result = "";
        //
        //     if (number >= 10)
        //     {
        //         result += "X";
        //         number -= 10;
        //     }
        //     
        //     if (number == 9)
        //     {
        //         result += "IX";
        //         number -= 9;
        //     }
        //    
        //     if (number >= 5)
        //     {
        //         result += "V";
        //         number -= 5;
        //     }
        //     else if (number == 4)
        //     {
        //         result += "IV";
        //         number -= 4;
        //     }
        //
        //    
        //     for (int i = 0; i < number; i++)
        //     {
        //         result += "I";
        //     }
        //
        //     return result;
        // }
        
        //refatoração 3 - final
        
        public string Convert(int number)
        {
            var result = "";
            
            while (number >= 1000)
            {
                result += "M";
                number -= 1000;
            }
            if (number >= 900)
            {
                result += "CM";
                number -= 900;
            }
            
            while (number >= 500)
            {
                result += "D";
                number -= 500;
            }
            
            if (number >= 400)
            {
                result += "CD";
                number -= 400;
            }
            
            while (number >= 100)
            {
                result += "C";
                number -= 100;
            }
            
            if (number >= 90)
            {
                result += "XC";
                number -= 90;
            }
            
            while (number >= 50)
            {
                result += "L";
                number -= 50;
            }
            
            if (number >= 40)
            {
                result += "XL";
                number -= 40;
            }
            
            while (number >= 10)
            {
                result += "X";
                number -= 10;
            }
            if (number >= 9)
            {
                result += "IX";
                number -= 9;
            }
            
            // 5 e 4
            while (number >= 5)
            {
                result += "V";
                number -= 5;
            }
            if (number >= 4)
            {
                result += "IV";
                number -= 4;
            }
            
            while (number >= 1)
            {
                result += "I";
                number -= 1;
            }
            
            return result;
        }
        
}
