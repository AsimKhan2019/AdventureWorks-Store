using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdWrksConsoleTest
{
    public class ByteToIntMapConverter : ITypeConverter<byte, int>
    {
        public int Convert(ResolutionContext context)
        {
            return System.Convert.ToInt32((byte)context.SourceValue);
        }
    }
}
