namespace RevisaoCsharp.LearningMaterial
{
    public class variables
    {
        public void Main()
        {
            //Beginning... Variables
            /*
             * Integers: short for less digits and long for longer digits
			 * Insert 'u' (unsigned) in front to double the range of positives
			 * Insert '?' (unknown) in back to accept nullable
             */
            ushort? shortVar = 10000;
            uint intVar = 1000000000;
            ulong longVar = 1000000000000000000;
            //String
            string strVar = "hi";
            char charVar = 'F';
            //Special ones: numbers with decimal and byte specifications
            double doubleVar = 1.1;
            float floatVar = 1.1f;
            decimal decimalVar = 1.2m;
            byte byteVar = 25;
            //bool variable
            bool boolVar = true;

            Console.WriteLine($"My variables: " +
                    $"{intVar}, {strVar}, {doubleVar}, " +
                    $"{floatVar}, {byteVar}, {decimalVar}, {shortVar}, {longVar}, " +
                    $"{boolVar}, {charVar}"
                );

            /*-------------------------------------------------------------*/
            //Constants
            const string ITEM_NAME = "sword";
            Console.WriteLine(ITEM_NAME);
        }
    }
}
