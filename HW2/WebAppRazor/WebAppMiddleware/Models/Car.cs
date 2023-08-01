namespace WebAppRazor
{
    public class Car
    {
        public string Name { get; set; }
        public string Engine { get; set; }
        public int Age { get; set; }

        public string GetID()
        {
            return DateTime.Now.Ticks.ToString();
        }
    }
}
