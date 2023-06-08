using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Additional_5
{
    internal class PhotoBook
    {
        private int numPages;

        public PhotoBook()
        {
            this.numPages = 16;
        }

        public PhotoBook(int numPagesCustom)
        {
            if (numPagesCustom != 0)
                this.numPages = numPagesCustom;
            else
                this.numPages = 0;
        }
        public int GetNumberPages()
        {
            return this.numPages;
        }
    }
}
