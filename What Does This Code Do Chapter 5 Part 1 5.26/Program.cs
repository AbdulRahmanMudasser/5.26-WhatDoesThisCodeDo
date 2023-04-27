class C5Q26
{
    static void Main(string[] args)
    {
        int row = 10;
        int column;

        while (row >= 1)
        {
            column = 1;

            while (column <= 10)
            {
                Console.Write(row % 2 == 1? "<" : ">");

                column++;
            }
            // end of inner loop

            --row;

            Console.WriteLine();
        }
        // end of outer loop
    }
}