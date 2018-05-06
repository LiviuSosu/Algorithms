using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.XII
{
    public class Numbers
    {
        public string GetNumber(int n)
        {
            List<int> arr = new List<int>() { 3,4,5,6,7,8,9,10,11,12,13,14,15,16};
            string result = "1 2";
            string _result = "";
            double _count = Math.Pow(2,n);
            int count = (int)_count;
            int sw = 1;
            int _sw = 0;
            //for (int i = 3; i < count; i++)
            //{
            //    for (int j = 0; j < sw; j++)
            //    {
            //        _result += (i).ToString() + " ";
            //    }
            //    result = _result + result;
            //    _result = "";

            //    for (int j = 0; j < sw; j++)
            //    {
            //        _result += " " + (i + sw).ToString();
            //    }
            //    result = result + _result;
            //    _result = "";
            //    sw++;

            //}
            for(int i = 0; i < n; i++)
            {
                
            }

            return result;
        }
    }
}
