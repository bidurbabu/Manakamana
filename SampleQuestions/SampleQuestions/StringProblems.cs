using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuestions
{
   public class StringProblems
    {
        public string reverseWord(string word)
        {
            return reverse(word);
        }
        public string reverseSentence(string sentence)
        {
            string reversedSentence = reverse(sentence);
            char[] reveredArray = reversedSentence.ToCharArray();
            int startOfAWord = 0;
            int endOfAWord = 0;
            while (endOfAWord < sentence.Length)
            {
            while ((++endOfAWord<sentence.Length)&&(reveredArray[endOfAWord] != ' '));
            reverseAnArray(reveredArray,startOfAWord,--endOfAWord);
            while ((++endOfAWord<sentence.Length)&&(reveredArray[endOfAWord] == ' '));
            startOfAWord = endOfAWord;
            }
            return new string(reveredArray);
        }
       
        public string reverse(string inputString)
        {
            char[] stringArray = inputString.ToCharArray();
            int len = inputString.Length;
            int startIndex = 0;
            int endIndex = len - 1;
            char temp;
            while(endIndex>startIndex)
            {
                temp = stringArray[endIndex];
                stringArray[endIndex--] = stringArray[startIndex];
                stringArray[startIndex++] = temp;
            }
            return new String(stringArray);
        }
        public string largestPalindromeWithInWord(string word)
        {
            int lastIndex = word.Length-1;
            int len=word.Length;
            char[] arr=word.ToCharArray();
            for (int i = 0; i < len-1;i++ )
            {
                for (int j = 0; j <= i; j++)
                {
                    if(checkPalindrom(arr, j, lastIndex-(i-j)))
                    {
                        return new string(arr,j,len-i);
                    }

                }
            }
            return new string(arr,0,2);
        }
        public bool checkPalindrom(string word)
        {
            char[] arr = word.ToCharArray();
            return checkPalindrom(arr, 0, arr.Length - 1);
        }
        public bool checkPalindrom(char[] arr,int startIndex, int endIndex)
        {
            while(startIndex<endIndex)
            {
                if (arr[startIndex++] != arr[endIndex--]) return false;
            }
            return true;
        }
        private int horizentalDiff(char source,char destination)
        {
            return (destination - 'a') % 5 - (source - 'a') % 5;
        }
        private int verticalDiff(char source,char destination)
        {
            return (destination - 'a') / 5 - (source - 'a') / 5;
        }
        public void move(char source,char destination)
        {
            int ver = verticalDiff(source, destination);
            int hor = horizentalDiff(source, destination);
            while((ver!=0)&&(hor!=0))
            {
                if (hor < 0) { Console.WriteLine("Left"); hor++; }
                else { Console.WriteLine("Right"); hor--; }
                if (ver < 0) { Console.WriteLine("Up"); ver++; }
                else { Console.WriteLine("Down"); ver--; }

            }
            while (ver != 0)
            {
                if (ver < 0) { Console.WriteLine("Up"); ver++; }
                else { Console.WriteLine("Down"); ver--; }
            }
            while (hor != 0)
            {
                if (hor < 0) { Console.WriteLine("Left"); hor++; }
                else { Console.WriteLine("Right"); hor--; }
            }
            Console.WriteLine("I am there");

        }

       // given s string "1010101010" in base2 convert it into string with base4.not use extra space....
        public string baseTwoToBaseFour(string baseTwo)
        {
            char[] arr = baseTwo.ToCharArray();
            int fastIndex=arr.Length-1;
            int slowIndex=arr.Length-1;
            while(fastIndex>0)
            {
                char c = twoToFour(arr[fastIndex--], arr[fastIndex--]);
                arr[slowIndex--] = c;
            }
            if(fastIndex==0)
            {
                arr[slowIndex--] = twoToFour(arr[0],'0');
            }
            return new string(arr, ++slowIndex, arr.Length - slowIndex);
        }
        public char twoToFour(char c2,char c1)
        {
            if (c1 == '1' && c2 == '1') return '3';
            if (c1 == '1' && c2 == '0') return '2';
            if (c1 == '0' && c2 == '1') return '1';
            return '0';

        }
        public int isItInteger(string s)
        {
            int sum = 0;

            foreach(char c in s)
            {
                if (isInt(c) == -1) return -1;
                sum = sum * 10 + isInt(c);
            }
            return sum;
        }
        private int isInt(char c)
        {
            if ((c >= '0') && (c <= '9'))
                return c - '0';
            else return -1;

        }
        public string reverseWordsInSentence(string str)
        {
            if(str==null) return str;
            if (str.Length < 2) return str;
            char[] strArray = str.ToCharArray();
            int counter = 0;
            int wordStart = 0;
            int wordEnd = 0;
            while(counter<str.Length)
            {
                while ((counter<str.Length)&&strArray[counter] == ' ') { counter++; }
                wordStart = counter;
                while ((counter<str.Length)&&strArray[counter] != ' ') { counter++; }
                wordEnd = counter-1;
                if (wordStart - wordEnd > 1)
                {
                    reverseAnArray(strArray, wordStart, wordEnd);
                }
                counter++;
            }
            return new string(strArray);
        }
        private void reverseAnArray(char[] arr, int startIndex, int endIndex)
        {
            char temp;
            while (endIndex > startIndex)
            {
                temp = arr[endIndex];
                arr[endIndex--] = arr[startIndex];
                arr[startIndex++] = temp;
            }
        }
    }
}
