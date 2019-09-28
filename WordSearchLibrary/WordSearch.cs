﻿using System;
using System.Text;

namespace WordSearchLibrary
{
    public class WordSearch
    {
        private string[] stringUseToSeach = { "BOB", "FRED", "RICH", "JOHN", "TED","DAN"};
        private string stringToSearch = "RBOBWG" +
                                        "IBDERF" +
                                        "CBOBWN" +
                                        "HBDBWH" +
                                        "AEOAWO" +
                                        "TBOBNJ";
        private readonly int rows = 6;
        private readonly int cols = 6;

        public bool ColumnsRowsEqual(int rows, int cols)
        {
            return true;
        }
        public string GenerateForwardOutput(string stringUsedToSearch, string stringSearched)
        {
            int offset = GetSearchStringIndex(stringUsedToSearch, stringSearched);
            string   coordinates = CalculateForwardCorrdinates(offset, stringUsedToSearch.Length);

            return stringUsedToSearch + ": " + coordinates;
        }

        public string GenerateReverseOutput(string stringUsedToSearch, string stringSearched)
        {
            string reverseString = ReveseOrderOfString(stringUsedToSearch);
            int offset = GetSearchStringIndex(reverseString, stringSearched);
            string coordinates = CalculateReveseCorrdinates(offset, stringUsedToSearch.Length);
            return stringUsedToSearch + ": " + coordinates;

        }
        public string GenerateDownOutPut(string stringUsedToSearch, string stringSearched)
        {
            return "";
        }
        public string GenerateUpOutput(string stringUsedToSearch, string stringSearched)
        {
            return "";
        }
        public string GenerateDiagDownOutPut(string stringUsedToSearch, string stringSearched)
        {
            return "";
        }
        //public string GenerateDiagUPOutput(string stringUsedToSearch, string stringSearched)
        //{
        //    return "";
        //}
        public string CalculateDiagDownCorrdinates(int Offset, int lengthToSearch)
        {
            return "";
        }
        public string CalculateDiagUpCorrdinates(int Offset, int lengthToSearch)
        {
            return "";
        }
        public string CalculateUpCorrdinates(int Offset, int lengthToSearch)
        {
            int row = (Offset / cols);
            int col = 0;
            if (Offset >= cols)
            {
                col = Offset - row * cols;
            }
            else
            {
                col = Offset;
            }
            string coordinates = "";
            for (int i = 0; i < lengthToSearch; i++)
            {
                if (i != 0)
                {
                    coordinates += ",";
                }
                coordinates += "(" + (col).ToString() + "," + (row - i).ToString() + ")";
            }
            return coordinates;
        }
        public string CalculateDownCorrdinates(int Offset, int lengthToSearch)
        {
            int row = (Offset / cols);
            int col = 0;
            if (Offset >= cols)
            {
                col = Offset - row * cols;
            }
            else
            {
                col = Offset;
            }
            string coordinates = "";
            for (int i = 0; i < lengthToSearch; i++)
            {
                if (i != 0)
                {
                    coordinates += ",";
                }
                coordinates += "(" + (col).ToString() + "," + (i + row).ToString() + ")";
            }
            return coordinates;
        }
        public string CalculateReveseCorrdinates(int Offset, int lengthToSearch)
        {
            int row = (Offset / cols);
            int col = 0;
            if (Offset >= cols)
            {
                col = Offset - row * cols;
            }
            else
            {
                col = Offset;
            }
            string coordinates = "";
            for (int i = lengthToSearch-1; 0 <= i; i--)
            {
                if (i != lengthToSearch-1)
                {
                    coordinates += ",";
                }
                coordinates += "(" + (i + col).ToString() + "," + row.ToString() + ")";
            }
            return coordinates;
        }
        public string CalculateForwardCorrdinates(int Offset, int lengthToSearch)
        {
            int row = (Offset / cols);
            int col = 0;
            if (Offset >= cols)
            {
                col = Offset - row * cols;
            }
            else
            {
                col = Offset;
            }
            string coordinates = "";
            for(int i=0; i < lengthToSearch;i++)
            {
                if (i != 0)
                {
                    coordinates += ",";
                }
                coordinates += "(" + (i + col).ToString() + "," + row.ToString() + ")";
            }
            return coordinates;
        }
        public int GetSearchStringIndex(string stringUsedToSearch, string stringSearched)
        {
            for (int  i=0; i < stringSearched.Length; i++)
            {
                int index = FindCharOffSet(i, stringUsedToSearch[0], stringSearched);
                string results = stringSearched.Substring(index, stringUsedToSearch.Length);
                if (ForwardSearchStringsMatch(stringUsedToSearch, results)){
                    return index;
                }
                i = i + index;
            }
            return -1;

        }
        public string ReveseOrderOfString(string stringUsedToSearch)
        {
            string reverseString = "";
            for(int i= stringUsedToSearch.Length-1; 0 <= i; i--)
            {
                reverseString += stringUsedToSearch[i];
            }
            return reverseString;
        }
        public int FindCharOffSet(int offset,char charUsedToSearch, string stringSearched)
        {
            int index = stringSearched.IndexOf(charUsedToSearch, offset);
            return index;
        }
        public bool ForwardSearchStringsMatch(string stringUsedToSearch, string stringSearched)
        {
            if (stringUsedToSearch == stringSearched)
            {
                return true;
            }

            return false;
        }   
    }
}
