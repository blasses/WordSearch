﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WordSearchLibrary.Search
{
    public class SearchDiagDownLeftToRight : SearchString
    {
        public SearchDiagDownLeftToRight(int cols, int rows)
        {
            this.colSize = cols;
            this.rowsSize = rows;
        }
        public override bool CheckSearchLimits(int index, string searchValue, string toSearch)
        {
            int colunmPosition = (index / this.colSize) * this.colSize - index;
            int rowPosition = (index / this.rowsSize) * this.rowsSize;
            if (colunmPosition + searchValue.Length <= this.colSize)
            {
                return true;
            }
            else if (rowPosition + searchValue.Length <= rowsSize)
            {
                return true;
            }
            return false;
        }
        public override string SubStringGet(int index, int length, string toSearch)
        {
            string value = "";
            int limit = index + ((length - 1) * this.rowsSize);
            for (int i = index; i <= limit+1; i += (this.rowsSize + 1))
            {
                value += toSearch[i].ToString();
            }
            return value;
        }
    }
}