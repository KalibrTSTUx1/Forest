using ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    internal class entryPoint
    {
        private int amTree;
        public int[] row;
        private int[] column;
        public int ansRow;
        public int ansColumn;
        public string path;
        public int n;
        
        Forest forest = new Forest();
        public int getNumber()
        {
            amTree = forest.Number(path);
            if (amTree == -1)
                return 0;
            return amTree;
        }
        public List<int> getEmpty(int[] ansRow)
        {
            return forest.FoundEmpty(ansRow);
        }
        
        
        public void main()
        {
            
            row = forest.ReadMassPart(path, 0);
            column = forest.ReadMassPart(path, 1);
            int[] errArr = { -1 };
            if (row == errArr || column == errArr)
                return;
            forest.SortArrays(row, column);
            forest.FoundAnswer(n, row, column, out ansRow, out ansColumn);
        }
    }
}
