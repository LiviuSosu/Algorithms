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
            string[] words = ChopString(alpfabet);

            foreach (string result in words)
            {
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
            }

            EncodingChart();
        }

        public Dictionary<int, string> EncodingChart()
        {
           // Coding();

            list1.Sort();
            list2.Sort();
            list3.Sort();
            list4.Sort();
            list5.Sort();
            list6.Sort();
            list7.Sort();
            list8.Sort();
            list9.Sort();
            list10.Sort();
            list11.Sort();
            list12.Sort();
            list13.Sort();
            list14.Sort();
            list15.Sort();
            list16.Sort();
            list17.Sort();
            list18.Sort();
            list19.Sort();
            list20.Sort();
            list21.Sort();
            list22.Sort();
            list23.Sort();
            list24.Sort();
            list25.Sort();
            list26.Sort();
            list27.Sort();

            Dictionary<int, string> result = new Dictionary<int, string>();
            int key = 1;
            foreach (string code in list1)
            {
                result.Add(key, code);
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

            foreach (string code in list4)
            {
                result.Add(key, code);
                key++;
            }

            foreach (string code in list5)
            {
                result.Add(key, code);
                key++;
            }

            foreach (string code in list6)
            {
                result.Add(key, code);
                key++;
            }


            foreach (string code in list7)
            {
                result.Add(key, code);
                key++;
            }


            foreach (string code in list8)
            {
                result.Add(key, code);
                key++;
            }


            foreach (string code in list9)
            {
                result.Add(key, code);
                key++;
            }

            foreach (string code in list10)
            {
                result.Add(key, code);
                key++;
            }

            foreach (string code in list11)
            {
                result.Add(key, code);
                key++;
            }

            foreach (string code in list12)
            {
                result.Add(key, code);
                key++;
            }

            foreach (string code in list13)
            {
                result.Add(key, code);
                key++;
            }

            foreach (string code in list14)
            {
                result.Add(key, code);
                key++;
            }

            foreach (string code in list15)
            {
                result.Add(key, code);
                key++;
            }

            foreach (string code in list16)
            {
                result.Add(key, code);
                key++;
            }

            foreach (string code in list17)
            {
                result.Add(key, code);
                key++;
            }


            foreach (string code in list18)
            {
                result.Add(key, code);
                key++;
            }

            foreach (string code in list19)
            {
                result.Add(key, code);
                key++;
            }

            foreach (string code in list20)
            {
                result.Add(key, code);
                key++;
            }

            foreach (string code in list21)
            {
                result.Add(key, code);
                key++;
            }

            foreach (string code in list22)
            {
                result.Add(key, code);
                key++;
            }

            foreach (string code in list23)
            {
                result.Add(key, code);
                key++;
            }

            foreach (string code in list24)
            {
                result.Add(key, code);
                key++;
            }

            foreach (string code in list25)
            {
                result.Add(key, code);
                key++;
            }

            foreach (string code in list26)
            {
                result.Add(key, code);
                key++;
            }

            foreach (string code in list27)
            {
                result.Add(key, code);
                key++;
            }

            //var test = result[83681];
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
