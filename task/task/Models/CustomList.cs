using System;
using System.Collections.Generic;
using System.Text;

namespace task.Models
{
    class CustomList<T> 
    {
        private T[] _list;
        public CustomList()
        {
            _list = new T[0];
        }
        public CustomList(params T[] nums)
        {
            _list = new T[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                _list[i] = nums[i];
            }
        }
        public void Add (T input)
        {
            Array.Resize(ref _list, _list.Length + 1);
            _list[_list.Length - 1] = input;
        }
        public void Show()
        {
            foreach (var item in _list)
            {
                Console.WriteLine(item);
            }
        }              
    }
}
