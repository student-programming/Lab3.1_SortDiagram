using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1 
{
    class BubbleSorter
    {
        // объявление переменных
        private int _i;
        private int _j;
        // объявление массива
        private readonly int[] _numbers;

        // метод-конструктор класса
        public BubbleSorter(int[] numbers)
        {
            // переменная _numbers принимает данные numbers,
            // переданные из другого класса
            _numbers = numbers;
        }

        // метод пузырьковой сортировки по возрастанию
        public int[] Sort(CheckBox _chbInvers)
        {
           
                    if (_chbInvers.Checked == false)
            {
                    Array.Sort(_numbers, 0, _numbers.Length);
                }

            else
            
            {
                Array.Sort(_numbers, 0, _numbers.Length);
                Array.Reverse(_numbers);
            }
            // возврат отсортированных данных
            return _numbers;
        }
        
        // метод пошагового изменения массива: при каждом вызове
        // этого метода, меняется местами только одна пара чисел
        public int[] StepByStepSort()
        {
            bool exit = false;
            for (int i = _i; i < _numbers.Length; i++)
            {
                for (int j = _j; j < _numbers.Length - 1 -i; j++)
                {
                    if (_numbers[j] > _numbers[j + 1])
                    {
                        int temp = _numbers[j];
                        _numbers[j] = _numbers[j + 1];
                        _numbers[j + 1] = temp;
                        _i = i;
                        _j = j;
                        exit = true;
                    }
                    if (j >= _numbers.Length - 2 - i)
                        _i++;
                    if (exit)
                        break;
                }
                if (_i > i) _j = 0;
                if (exit)
                    break;
           }
            return _numbers;
        }
    }
}
