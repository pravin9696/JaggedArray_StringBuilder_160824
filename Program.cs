using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nsp1;

namespace nsp1
{
    //only classes, bastract class, interfaces
    class India
    {
        string[][] states;
        public India()
        {
            states = new string[3][];
            
        }
        public void addDistrict()
        {
            for (int i = 0; i < states.GetLength(0); i++)
            {
                Console.WriteLine("Enter District count ");
                int n = int.Parse(Console.ReadLine());
                states[i]=new string[n];
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Enter District name");
                    string dname=Console.ReadLine();
                    states[i][j] = dname;
                }
            }
        }
        public void showAllDistrict()
        {
            for (int i = 0; i < states.GetLength(0); i++)//total number of rows
            {
                for (int j = 0; j < states[i].GetLength(0); j++)
                {
                    Console.Write("\t" + states[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
namespace JaggedArray_StringBuilder_160824
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            ////jagged array
            ////It is multidiamentianal array in 
            ////rows are fix
            ////columns in each row is vary

            //// declaration
            ////row  column
            //int[][]arr1=new int[4]  [];
            //arr1[0] = new int[5];//column array create

            //arr1[1] = new int[3];
            //arr1[2] = new int[1];
            //arr1[3] = new int[5];

            //Console.WriteLine("##### "+arr1.Length);//total rows
            //Console.WriteLine("@@@@" + arr1[0].Length);//total columns row 0


            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    Console.WriteLine($"enter {i+1} row size");
            //    int s = int.Parse(Console.ReadLine());
            //    arr1[i]=new int[s];
            //}
            //Console.WriteLine("Length of each row is");
            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    int len = arr1[i].GetLength(0);
            //    Console.WriteLine($" Lenght of {i+1} row is {len}");
            //}

            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter {arr1[i].GetLength(0)} elements");
            //    for (int j = 0; j < arr1[i].GetLength(0); j++)
            //    {
            //        int n = int.Parse(Console.ReadLine());
            //        arr1[i][j] = n;
            //    }
            //}
            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{

            //    for (int j = 0; j < arr1[i].GetLength(0); j++)
            //    {
            //        if (arr1[i][j]%2==0)
            //        {
            //            Console.Write("\t" + arr1[i][j]);
            //        }

            //    }
            //    Console.WriteLine();
            //}
            #endregion

            //India obj = new India();
            //obj.addDistrict();
            //obj.showAllDistrict();
            //int[,,,] x = new int[5, 4,4,3];
            //int[][] y = new int[5][];

            //Console.WriteLine("rows ="+x.GetLength(0));
            //Console.WriteLine("columns =" + x.GetLength(1));
            //Console.WriteLine("3rd D length =" + x.GetLength(2));
            //Console.WriteLine("4th D length =" + x.GetLength(3));


            //////////////// string Builder/////////////////////
            ///
            StringBuilder sb=new StringBuilder();
            /*Console.WriteLine("capacity="+sb.Capacity);
            sb.Append("jsdkfjas");
            Console.WriteLine("capacity=" + sb.Capacity);
          
            Console.WriteLine(sb);
            */
            object[] date1 = { 16, 8,24 };
            sb.AppendFormat("date :{0}/{1}/{2}",date1);
            Console.WriteLine(sb);
            Console.ReadKey();
        }
    }
}
