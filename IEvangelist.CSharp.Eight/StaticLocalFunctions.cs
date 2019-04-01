namespace IEvangelist.CSharp.Eight
{
    class StaticLocalFunctions
    {
        static void Main()
        {
            // Implicitly captured variables in the method scope
            ClassicCapture();

            // Now we can explicitly prevent that
            NonCapturing();
        }

        internal static int ClassicCapture()
        {
            int y;
            LocalFunction();

            return y;

            // Note, assignmet of y here...
            // it's captured in the scope of the local function
            void LocalFunction() => y = 19;
        }

        internal static int NonCapturing()
        {
            int y = 5,
                x = 7;

            return Add(x, y);

            // If either "y" or "x" are referenced in Add
            // CS8421: "A static local function can't contain a reference to ..."
            static int Add(int left, int right) => left + right;
        }
    }
}