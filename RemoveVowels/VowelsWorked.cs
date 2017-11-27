using System;
using System.Linq;

namespace VowelWork
{
    class VowelsWorked
    {
        char[] vowels = { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u' };
        string workString;

        /* Alternative to above...
         * 
         *string sVowels =  "AaEeIiOoUu"
         * char[] vowels  = vowels.ToCharArray();
         * 
        */

        char[] charWorkString;          
        bool containsVowels;

        //int _ACount, aCount, _ECount, eCount, _ICount, iCount, _OCount, oCount, _UCount, uCount, totalNumberOfVowels;

        int aCount, eCount, iCount, oCount, uCount, totalNumberOfVowels;

        public int NumberOfA { get { return aCount; } }
        public int NumberOfE { get { return eCount; } }
        public int NumberOfI { get { return iCount; } }
        public int NumberOfO { get { return oCount; } }
        public int NumberOfU { get { return uCount; } }
        public int TotalNumberOfVowels { get { return totalNumberOfVowels; } }
        public bool ContainsVowels { get { return containsVowels; } }

        public VowelsWorked()
        {
            containsVowels = false;
            workString = "";
            charWorkString = workString.ToCharArray();
        }

        public VowelsWorked(string text)
        {
            workString = text;
            containsVowels = DoesStringContainVowels(text);
            charWorkString = text.ToCharArray();
            CountVowelsByType(text);
            StringWithVowelsRemoved(text);
        }  
        
        public string StringWithVowelsRemoved(string text)
        {
            string result;

            char[] temp = new char[text.Length];
            int counter = 0;
            
            foreach (char c in text)
            {                
                switch (c)
                {
                    case 'a':                        
                        break;
                    case 'A':
                        
                        break;
                    case 'E':
                        
                        break;
                    case 'e':
                        
                        break;
                    case 'I':
                        
                        break;
                    case 'i':
                        
                        break;
                    case 'o':
                        
                        break;
                    case 'O':
                        
                        break;
                    case 'U':
                       
                        break;
                    case 'u':
                        
                        break;
                    default:
                        counter += 1;
                        temp[counter] = c;
                        break;
                }
            }

            result = String.Concat(temp);
            return result;
        }

        public bool DoesStringContainVowels(string text)
        {
            workString = text;
            bool result = false;

            if (workString.IndexOfAny(vowels)!=-1)
            {
                result = true;
            }

            return result;
        }

        public int[] CountVowelsByType(string text)
        {
            aCount = 0; eCount = 0; iCount = 0; oCount = 0; uCount = 0;
            workString = text;
            charWorkString = text.ToCharArray();

            foreach (char c in charWorkString)
            {
                switch (c)
                {
                    case 'a':
                        aCount += 1;
                        break;
                    case 'A':
                        aCount += 1;
                        break;
                    case 'E':
                        eCount += 1;
                        break;
                    case 'e':
                        eCount += 1;
                        break;
                    case 'I':
                        iCount += 1;
                        break;
                    case 'i':
                        iCount += 1;
                        break;
                    case 'o':
                        oCount += 1;
                        break;
                    case 'O':
                        oCount += 1;
                        break;
                    case 'U':
                        uCount += 1;
                        break;
                    case 'u':
                        uCount += 1;
                        break;
                    default:
                        break;
                }                       
            }

            int[] result = { aCount, eCount, iCount, oCount, uCount };
            totalNumberOfVowels = result.Sum();

            return result;
        }

        public int NumberOfVowels (string text = "")
        {
            int result = 0;
            char[] charArray = { };
            if (text !="")
            {
                workString = text;
            }
            

            return result;
        }

        private char[] StringToChar(string text = "")
        {
            char[] result = { };

            if (text != "")
            {
                workString = text;
            }

            int i = 0;
            foreach(char c in workString)
            {
                result[i] = c;
                i++;                
            }

            return result;
        }        
    }
}
