namespace HW_Additional_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhotoBookTest myBooks= new PhotoBookTest();
             
            Console.WriteLine(myBooks.myBookDefault.GetNumberPages());
            Console.WriteLine(myBooks.myBookCustom.GetNumberPages());
            Console.WriteLine(myBooks.myBigBook.GetNumberPages());
        }
    }
}