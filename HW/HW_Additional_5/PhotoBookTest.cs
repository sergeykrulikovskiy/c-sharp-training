using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Additional_5
{
    internal class PhotoBookTest
    {
        public PhotoBook myBookDefault = new PhotoBook();
        public PhotoBook myBookCustom = new PhotoBook(24);

        public BigPhotoBook myBigBook = new BigPhotoBook(64);

    }
}
