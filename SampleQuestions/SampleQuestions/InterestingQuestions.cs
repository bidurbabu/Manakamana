using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuestions
{
    public class InterestingQuestions
    {
        int totalSum = 0;
        int totalMultipication = 0;
        int lessNumber = 0;

        public int oddCountIntegerInArray(int[] arr)
        {
         int x=arr[0];
         for(int i=1;i<arr.Length;i++)
         {
             x^=arr[i];
         }
            return x;
        }
        public int productWithAddition(int x,int y)
        {
            int xn = 0;
            int yn = 0;
            if(x<0){xn = 1;x = 0-x;}
            if (y < 0) { yn = 1; y = 0 - y; }
            int tn=xn^yn;
            if(x<y)
                return productWithAddition(y,x);
            totalSum=0;
            totalMultipication=0;
            lessNumber = y;
            int currentAddition=x;
            int currentMultiplier=1;
            productWithAdditionRecursion(currentAddition, currentMultiplier);
            return tn==0?totalSum:0-totalSum;

        }
        private void productWithAdditionRecursion(int currentAddition,int currentMultiplier)
        {
            if(currentMultiplier>lessNumber)
            {
                return;
            }
            productWithAdditionRecursion(currentAddition << 1, currentMultiplier << 1);
            if((totalMultipication+currentMultiplier)<=lessNumber)
            {
                totalSum = totalSum + currentAddition;
                totalMultipication = totalMultipication + currentMultiplier;
            }
        }
    }
}
