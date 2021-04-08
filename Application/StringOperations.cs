using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Application
{
    public static class StringOperations
    {
        public static int LengthOfSubstring(string item, int numberOfOccurences)
        {
            int position = 0;
            int totalLength = 0;

            if (item.Substring(position).Contains(')'))
            {
                for (int i = 0; i < numberOfOccurences; i++)
                {
                    position = item.Substring(position).IndexOf(')') + 1;
                    totalLength += position;
                }

                return totalLength;
            }

            return -1;
        }

        public static string ParametrizeQuery(object query, string item)
        {
            var listofresults = new List<string>();
            foreach (string textToReplace in new string[3] { "where", "and", " or " })
            {
                int index = 0;
                int length = 0;
                while ((index = item.ToLower().IndexOf(textToReplace, index)) != -1)
                {

                    //set indexOfDeliminator to a random arbitrary large number 
                    int indexOfDeliminator = 100000;
                    int highestindex = 0;

                    foreach (var deliminator in new string[3] { "where", "and", " or " })
                    {
                        if (indexOfDeliminator > item.Substring(index + textToReplace.Length + 1).IndexOf(deliminator) 
                            && item.Substring(index + textToReplace.Length + 1).IndexOf(deliminator) != -1 )
                        {
                            indexOfDeliminator = item.ToLower().Substring(index + textToReplace.Length + 1).IndexOf(deliminator);
                            highestindex = item.ToLower().Substring(index + textToReplace.Length + 1).IndexOf(deliminator);
                        }
                    }

                    int numberOfOpeningParantheses = 0;
                    if (highestindex != 0)
                    {
                        //Console.WriteLine(item.Substring(index + textToReplace.Length + 1, indexOfDeliminator - 1));
                        numberOfOpeningParantheses = item.Substring(index + textToReplace.Length + 1, indexOfDeliminator - 1).Count(i => i == '(');
                    }
                    else
                    {
                        //Console.WriteLine(item.Substring(index + textToReplace.Length + 1, item.Substring(index + textToReplace.Length + 1).IndexOf(")") + 1));
                        numberOfOpeningParantheses = item.Substring(index + textToReplace.Length + 1, item.Substring(index + textToReplace.Length + 1).IndexOf(")") + 1).Count(i => i == '(');
                    }

                    length = LengthOfSubstring(item.Substring(index + textToReplace.Length + 1), numberOfOpeningParantheses);
                    //Console.WriteLine(length);

                    if (numberOfOpeningParantheses > 0 && item.Substring(index + textToReplace.Length + 1, length).Contains('$'))
                    {
                        string property = item.Substring(index + textToReplace.Length + 1, length).Substring(item.Substring(index + textToReplace.Length + 1, length).IndexOf('$') + 1).TrimEnd(' ', ')');

                        if (property.Contains("/"))
                        {
                            int pos = property.LastIndexOf("/") + 1;
                            property = property.Substring(pos, property.Length - pos);

                            if (property.Contains(" "))
                            {
                                int indexOfElement = property.IndexOf(" ");
                                property = property.Substring(0, indexOfElement);
                            }

                            if (property.Contains(")"))
                            {
                                int indexOfElement = property.IndexOf(")");
                                property = property.Substring(0, indexOfElement);
                            }
                        }

                        string value = GetValue(query, property);
                        //Console.WriteLine($"received value {value}");


                        if (value == "")
                        {
                            item = item.Replace(item.Substring(index + textToReplace.Length + 1, length), "1=1");
                        }
                        else
                        {
                            item = item.Replace(item.Substring(index + textToReplace.Length + 1, length).Substring(item.Substring(index + textToReplace.Length + 1, length).IndexOf('$')).TrimEnd(' ', ')'), $"'{value}'");
                        }
                    }
                    index++;
                    length = 0;
                }
            }
            Console.WriteLine(item);
            return item;
        }

        public static string GetValue(object elementname, string propertyToFind)
        {
            foreach (var child in elementname.GetType().GetProperties())
            {
                if (child.PropertyType.Name.Equals("List`1"))
                {
                    foreach (var item in elementname.GetType().GetProperty(child.Name).GetValue(elementname) as IList)
                    {
                        if (item.GetType().GetProperties().Where(a => a.Name == propertyToFind).Any())
                        {
                            return GetValue(item, propertyToFind);
                        }
                    }
                }
                else if (!child.PropertyType.Name.Equals("List`1") && child.Name == propertyToFind && child.GetValue(elementname) != null)
                {
                    return child.GetValue(elementname).ToString();
                }
            }

            return "";
        }
    }
}
