using System;
using System.Collections.Generic;

namespace SortList.Program
{
  class Program
  {
    static void Main(string[] args)
    {
      List<int> lists = new List<int>();
      lists.Add(4);
      lists.Add(1);
      lists.Add(3);
      lists.Add(2);
      lists.ListSortFunction();
    }
  }

  public static class ListSort
  {
    public static void ListSortFunction(this List<int> lists)
    {
      int temp;
      for (int i = 0; i < lists.Count; i++)
      {
        for (int j = 0; j < lists.Count; j++)
        {
          if (lists[i] < lists[j])
          {
            temp = lists[i];
            lists[i] = lists[j];
            lists[j] = temp;
          }
        }
      }
      foreach (int elem in lists)
      {
        Console.Write(elem + " ");
      }


    }
  }
}