using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class GenericClass<T> where T: new()
    {
        //Bu generic class'ın instance'ı yaradılanda parametr kimi ötürülən classın parmaetrsiz bir constructoru olmalidir. 
    }
}
