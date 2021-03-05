using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }

        public SuccessDataResult(T data) : base(data, true)
        {

        }

        //data döndürülmek istenmiyorsa default hali verilerek kullanılır.
        public SuccessDataResult(string message) : base(default, true, message)
        {

        }

        // geriye hiçbir şey döndürmek istenmezse -> sadece başarılı olduğunu belirtmek için.
        public SuccessDataResult() : base(default, true)
        {

        }
    }
}
