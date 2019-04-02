namespace Domain
{
    public class GlobalSettings
    {
        private static int _intputBoxSize;

        public static int InputBoxSize
        {
            get { return _intputBoxSize; }
            set { _intputBoxSize = value; }
        }

        private static int _textAreaSize;

        public static int TextAreaSize
        {
            get { return _textAreaSize; }
            set { _textAreaSize = value; }
        }
    }
}