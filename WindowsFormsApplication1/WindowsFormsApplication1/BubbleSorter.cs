using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class BubbleSorter
    {
    private int _i;
    private int _j;

    private readonly int[] _numbers;
    public BubbleSorter(int[] numbers)
    {
        _numbers = numbers;
    }
    
    public int[] Sort(CheckBox _chbinvers)
    {
        if (_chbinvers.Checked == false)
        {
            Array.Sort(_numbers, 0, _numbers.Length);
        }
        else
        {
            Array.Sort(_numbers, 0, _numbers.Length);
            Array.Reverse(_numbers);
        }
        return _numbers;
    }






   public int[] StepByStep()
    {
            bool exit = false;
            for (int i = _i; i < _numbers.Length; i++)
            {
                for (int j = _j; j < _numbers.Length - 1 - i; j++)
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
