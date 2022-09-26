using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Data;
using System.IO;
using Microsoft.Win32;

namespace LibMas
{
    public class Masssiv
    {
        /// <summary>
        /// Функция для создания одномерного массива и заполнения его случайными числами
        /// </summary>
        /// <param name="m">Нижний предел для генерации случайных чисел</param>
        /// <param name="n">Верхний предел для генерации случайных чисел</param>
        /// <param name="count">Размер одномерного массива</param>
        /// <returns>Одномерный заполненный массив</returns>
        public static int[] Zapol(int m, int n, int count)
        {
            int[] mas = new int[count];
            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(m, n);
            }
            return mas;
        }
        /// <summary>
        /// Функция для очистки массива и возвращения пустого массива
        /// </summary>
        /// <param name="mas">Передаваемый массив со значениями</param>
        /// <returns>Пустой массив без значений</returns>
        public static int[] Clear(int[] mas)
        {
            mas = null;
            return mas;
        }
        /// <summary>
        /// Функция для очистки массива(матрицы) и возвращения пустого массива
        /// </summary>
        /// <param name="mas">Передаваемый массив(матрица) со значениями</param>
        /// <returns>Пустой массив(матрица) без значений</returns>
        public static int[,] Clear(int[,] mas)
        {
            mas = null;
            return mas;
        }
        /// <summary>
        /// Функция для сохранения массива в выбранный\созданный файл в корневой системе Windows 
        /// </summary>
        /// <param name="mas">Передаваемый массив со значениями</param>
        public static void SaveMassiv(int[] mas)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = ".txt";
            save.Filter = "Все файлы (*.*) | *.* | Текстовые файлы | *.txt";
            save.FilterIndex = 2;
            save.Title = "Сохранение таблицы";

            if (save.ShowDialog() == true)
            {
                StreamWriter file = new StreamWriter(save.FileName);
                file.WriteLine(mas.Length);
                for (int i = 0; i < mas.Length; i++)
                {
                    file.WriteLine(mas[i]);
                }
                file.Close();
            }
        }
        /// <summary>
        /// Функция для открытия и передачи записанных значений из файла,открытого из корневой системы Windows в переданный массив
        /// </summary>
        /// <param name="mas">Массив для получения из него значений и записи новых</param>
        public static void OpenMassiv(ref int[] mas)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.DefaultExt = ".txt";
            open.Filter = "Все файлы (*.*) | *.* | Текстовые файлы | *.txt";
            open.FilterIndex = 2;
            open.Title = "Открытие таблицы";
            if (open.ShowDialog() == true)
            {
                StreamReader file = new StreamReader(open.FileName);
                int len = Convert.ToInt32(file.ReadLine());
                mas = new int[len];
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = Convert.ToInt32(file.ReadLine());
                }
                file.Close();
            }
        }
        /// <summary>
        /// Функция для создания матрицы и заполнения её случайными числами
        /// </summary>
        /// <param name="i">Кол-во строк в создаваемой матрице</param>
        /// <param name="j">Кол-во столбцов в создаваемой матрице</param>
        /// <param name="max">Верхний предел для генерации случайных чисел,нужных для заполнения матрицы</param>
        /// <returns>Заполненная матрица с определенным кол-вом строк и столбцов</returns>
        public static int[,] DVZapol(int i,int j,int max)
        {
            int[,] mas = new int[i, j];
            Random rnd = new Random();
            for (i = 0; i< mas.GetLength(0);i++)
                for (j= 0; j< mas.GetLength(1);j++)
                    mas[i,j] = rnd.Next(max);
            return mas;
        }
        /// <summary>
        /// Функция для записи матрицы со значениями в созданный\существующий текстовый файл,в корневой системе Windows
        /// </summary>
        /// <param name="mas">Передаваемая матрица со значениями</param>
        public static void DVSaveMassiv(int[,] mas)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = ".txt";
            save.Filter = "Все файлы (*.*) | *.* | Текстовые файлы | *.txt";
            save.FilterIndex = 2;
            save.Title = "Сохранение таблицы";

            if (save.ShowDialog() == true)
            {
                StreamWriter file = new StreamWriter(save.FileName);
                file.WriteLine(mas.GetLength(0));
                file.WriteLine(mas.GetLength(1));
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        file.WriteLine(mas[i,j]);
                    }
                }
                file.Close();
            }
        }
        /// <summary>
        /// Функция для записи в передаваемую матрицу новых значений из открытого уже существующего файла из корневой системы Windows
        /// </summary>
        /// <param name="mas">Матрица со значениями для записи в неё новых значений</param>
        public static void DVOpenMassiv(ref int[,] mas)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.DefaultExt = ".txt";
            open.Filter = "Все файлы (*.*) | *.* | Текстовые файлы | *.txt";
            open.FilterIndex = 2;
            open.Title = "Открытие таблицы";
            if (open.ShowDialog() == true)
            {
                StreamReader file = new StreamReader(open.FileName);
                int rows = Convert.ToInt32(file.ReadLine());
                int columns = Convert.ToInt32(file.ReadLine());
                mas = new int[rows,columns];
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        mas[i, j] = Convert.ToInt32(file.ReadLine());
                    }
                }
                file.Close();
            }
        }
    }

    public static class VisualArray
    {
        //Метод для одномерного массива
        public static DataTable ToDataTable<T>(this T[] arr)
        {
            var res = new DataTable();
            for (int i = 0; i < arr.Length; i++)
            {
                res.Columns.Add("col" + (i + 1), typeof(T));
            }
            var row = res.NewRow();
            for (int i = 0; i < arr.Length; i++)
            {
                row[i] = arr[i];
            }
            res.Rows.Add(row);
            return res;
        }

        //Метод для двухмерного массива
        public static DataTable ToDataTable<T>(this T[,] matrix)
        {
            var res = new DataTable();
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                res.Columns.Add("col" + (i + 1), typeof(T));
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var row = res.NewRow();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    row[j] = matrix[i, j];
                }

                res.Rows.Add(row);
            }

            return res;
        }
    }
}
