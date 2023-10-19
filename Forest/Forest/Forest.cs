using System;
using System.Data.Common;
using System.Dynamic;

namespace ClassLib//misha loh
{
    public class Forest
    {
        /// <summary>
        /// Функция, которая сортирует первый и второй столбец, ряд и столбец
        /// </summary>
        /// <param name="rows">Массив с рядами</param>
        /// <param name="columns">Массив со столбцами</param>
        public void SortArrays(int[] rows, int[] columns)
        {
            int n = rows.Length;
            int cand_row, cand_column;
            int j = 0;
            for (int i = 1; i < n; i++)
            {
                cand_row = rows[i]; 
                cand_column = columns[i];
                j = i - 1;
                while ((j >= 0) && ((cand_row > rows[j]) || (cand_row == rows[j] && cand_column < columns[j])))
                {
                    rows[j + 1] = rows[j]; columns[j + 1] = columns[j];
                    j--;
                }
                rows[j + 1] = cand_row; columns[j + 1] = cand_column;
            }
        }
        /// <summary>
        /// Функция, которая находит ответ
        /// </summary>
        /// <param name="N">Количество данных деревьев</param>
        /// <param name="rows">Массив Рядов</param>
        /// <param name="columns">Массив Столбцов</param>
        /// <param name="row">Строка с ответом</param>
        /// <param name="col">Столбец с ответом</param>
        public void FoundAnswer(int N, int[] rows, int[] columns, out int row, out int col)
        {
            bool found = false;
            int k = 0;
            int n = rows.Length;
            row = 0; col = 0;
            while (k + 1 < n && !found)
            {
                if (rows[k] == rows[k + 1])
                {
                    if (columns[k + 1] - columns[k] > N)
                    {
                        row = rows[k]; col = columns[k] + 1;
                        found = true;
                    }
                }
                k++;
            }
        }
        /// <summary>
        /// Считывает N деревьев с первой строки файла
        /// </summary>
        /// <param name="file">Адрес файла</param>
        /// <returns>N деревьев</returns>
        public int Number(string file)
        {
            StreamReader F;
            int number;
            try
            {
                F = new StreamReader(file);
                number = int.Parse(F.ReadLine());
            } catch (Exception)
            {
                return -1;
            }
            return number;
        }
        /// <summary>
        /// Считывает массив со строками деревьев
        /// </summary>
        /// <param name="file">Адрес файла</param>
        /// <param name="n">Позиция в строке исходного файла</param>
        /// <returns>Массив с числами на заданной позиции в исходном файле</returns>
        public int[] ReadMassPart(string file, int n)
        {
            StreamReader File = new StreamReader(file);
            int number = Number(file);
            File.ReadLine();
            int[] mesto = new int[number];
            for (int i = 0; i < number; ++i)
            {
                try
                {
                    string s = File.ReadLine();
                    string[] buf = s.Split(' ');
                    mesto[i] = int.Parse(buf[n]);
                } catch (Exception)
                {
                    int[] errArr = { -1 };
                    return errArr;
                }
            }
            return mesto;
        }
        /// <summary>
        /// Ищет ряды без деревьев
        /// </summary>
        /// <returns></returns>
        /// <param name="rowsArr">Массив рядов</param>
        public List<int> FoundEmpty(int[] rowsArr)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < rowsArr.Length - 1; i++)
            {
                int tempDiff = rowsArr[i] - rowsArr[i + 1];
                if (tempDiff > 1)
                {
                    for (int j = rowsArr[i] - 1; j > rowsArr[i + 1]; j--)
                    {
                        res.Add(j);
                    }
                }
            }
            return res;
        }


    }
}