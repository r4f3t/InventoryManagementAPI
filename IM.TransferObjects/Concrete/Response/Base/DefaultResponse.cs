using System;
using System.Collections.Generic;
using System.Text;

namespace IM.TransferObjects.Concrete.Response.Base
{
   public class DefaultResponse<T>
    {
        public bool HasResult { get; set; }
        public string ResultText { get; set; }
        public T Result { get; set; }
    }
}
