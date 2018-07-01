using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Encoding
{
    class Encoding
    {
        private string alpfabet = "abcdefghijklmnopqrstuvwxyz";
        List<string> list1 = new List<string>();
        List<string> list2 = new List<string>();
        List<string> list3 = new List<string>();
        List<string> list4 = new List<string>();
        List<string> list5 = new List<string>();
        List<string> list6 = new List<string>();
        List<string> list7 = new List<string>();
        List<string> list8 = new List<string>();
        List<string> list9 = new List<string>();
        List<string> list10 = new List<string>();
        List<string> list11 = new List<string>();
        List<string> list12 = new List<string>();
        List<string> list13 = new List<string>();
        List<string> list14 = new List<string>();
        List<string> list15 = new List<string>();
        List<string> list16 = new List<string>();
        List<string> list17 = new List<string>();
        List<string> list18 = new List<string>();
        List<string> list19 = new List<string>();
        List<string> list20 = new List<string>();
        List<string> list21 = new List<string>();
        List<string> list22 = new List<string>();
        List<string> list23 = new List<string>();
        List<string> list24 = new List<string>();
        List<string> list25 = new List<string>();
        List<string> list26 = new List<string>();
        List<string> list27 = new List<string>();

        public void Coding()
        {
            int k = 0;
            for (int i=0; i < alpfabet.Length; i++)
            {
                for (int j = i; j < alpfabet.Length; j++)
                {
                    string result = alpfabet.Substring(i,j-k+1);
                    switch (result.Length)
                    {
                        case 1:
                            list1.Add(result);
                            break;
                        case 2:
                            list2.Add(result);
                            break;
                        case 3:
                            list3.Add(result);
                            break;
                        case 4:
                            list4.Add(result);
                            break;
                        case 5:
                            list5.Add(result);
                            break;
                        case 6:
                            list6.Add(result);
                            break;
                        case 7:
                            list7.Add(result);
                            break;
                        case 8:
                            list8.Add(result);
                            break;
                        case 9:
                            list9.Add(result);
                            break;
                        case 10:
                            list10.Add(result);
                            break;
                        case 11:
                            list11.Add(result);
                            break;
                        case 12:
                            list12.Add(result);
                            break;
                        case 13:
                            list13.Add(result);
                            break;
                        case 14:
                            list14.Add(result);
                            break;
                        case 15:
                            list15.Add(result);
                            break;
                        case 16:
                            list16.Add(result);
                            break;
                        case 17:
                            list17.Add(result);
                            break;
                        case 18:
                            list18.Add(result);
                            break;
                        case 19:
                            list19.Add(result);
                            break;
                        case 20:
                            list20.Add(result);
                            break;
                        case 21:
                            list21.Add(result);
                            break;
                        case 22:
                            list22.Add(result);
                            break;
                        case 23:
                            list23.Add(result);
                            break;
                        case 24:
                            list24.Add(result);
                            break;
                        case 25:
                            list25.Add(result);
                            break;
                        case 26:
                            list26.Add(result);
                            break;
                        case 27:
                            list27.Add(result);
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine(result);
                }
                k++;
            }
        }

        public Dictionary<int, string> EncodingChart()
        {
            Coding();

            list1.Sort();
            list2.Sort();

            Dictionary<int, string> result = new Dictionary<int,string>();
            int key = 1;
            foreach(string code in list1)
            {
                result.Add(key,code);
                key++;
            }

            foreach (string code in list2)
            {
                result.Add(key, code);
                key++;
            }

            foreach (string code in list3)
            {
                result.Add(key, code);
                key++;
            }

            return result;
        }

        public string[]/*string*/ ChopString(string str)
        {
            //int middlePosition = desiredLength;
            //int lastPosition = alpfabet.Length-
            //throw new NotImplementedException();

            List<string> output = new List<string>();
            // Working buffer to build new sub-strings
            char[] buffer = new char[str.Length];

            Combination2Recurse(str.ToCharArray(), 0, buffer, 0, output);

            return output.ToArray();
        }

        public static void Combination2Recurse(char[] input, int inputPos, char[] buffer, int bufferPos, List<string> output)
        {
            if (inputPos >= input.Length)
            {
                // Add only non-empty strings
                if (bufferPos > 0)
                    output.Add(new string(buffer, 0, bufferPos));

                return;
            }

            // Recurse 2 times - one time without adding current input char, one time with.
            Combination2Recurse(input, inputPos + 1, buffer, bufferPos, output);

            buffer[bufferPos] = input[inputPos];
            Combination2Recurse(input, inputPos + 1, buffer, bufferPos + 1, output);
        }
    }
}
