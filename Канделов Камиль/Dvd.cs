namespace LibraryApp
{
    public class Dvd : LibraryItem
    {
        public override string Search()
        {
            return $"DVD \"{Title}\" — нашёлся";
        }
    }
}