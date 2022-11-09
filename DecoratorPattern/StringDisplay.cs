namespace DecoratorPattern
{
    public class StringDisplay : Display
    {
        public string _str;
        public StringDisplay(string str)
        {
            _str = str;
        }
        public override int GetColumns()
        {
            return _str.Length;
        }

        public override int GetRows()
        {
            return 1;
        }

        public override string GetRowText(int row)
        {
            if (row == 0)
            {
                return _str;
            }
            else
            {
                return null;
            }
        }
    }
}
