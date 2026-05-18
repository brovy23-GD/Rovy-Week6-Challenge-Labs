using System; 

namespace Rovy_Week_6_Challenge_Labs 
{
    internal class Program // Main class where the program runs
    {   // time complexity: O(n^2) because we have nested loops that go through the matrix
        // space complexity: O(1) because we are rotating the matrix in place without using extra space
        static void Main(string[] args) // First method that runs when the program starts
        {
            Console.WriteLine("---- Week 6 Challenge: Rotate Matrix 90 Degrees Clockwise ----\n");
            // This prints a title so the user knows what the program is doing


           
            // EXAMPLE 1: 3x3 MATRIX
         

            // Creating our first matrix (3 rows, 3 columns)
            // Each row is an array, and all rows together form the matrix
            var matrix1 = new[]
            {
                new[] {1, 2, 3}, // Row 1
                new[] {4, 5, 6}, // Row 2
                new[] {7, 8, 9}  // Row 3
            };

            Console.WriteLine("---- Original 3x3 Matrix ----"); // Label for the user
            PrintMatrix(matrix1); // Print the matrix before rotation

            Rotate(matrix1); // Rotate the matrix 90 degrees clockwise

            Console.WriteLine("---- Rotated 3x3 Matrix ----"); // Label for the rotated version
            PrintMatrix(matrix1); // Print the rotated matrix



          
            // EXAMPLE 2: 4x4 MATRIX
          

            // Creating a larger 4x4 matrix
            var matrix2 = new[]
            {
                new[] {5, 1, 9, 11},   // Row 1 
                new[] {2, 4, 8, 10},   // Row 2
                new[] {13, 3, 6, 7},   // Row 3
                new[] {15, 14, 12, 16} // Row 4
            };

            Console.WriteLine("---- Original 4x4 Matrix ----"); // Label for the user
            PrintMatrix(matrix2); // Print the matrix before rotation

            Rotate(matrix2); // Rotate the 4x4 matrix

            Console.WriteLine("---- Rotated 4x4 Matrix ----"); // Label for the rotated version
            PrintMatrix(matrix2); // Print the rotated matrix

            Console.WriteLine("---- DONE ----"); // End message
        }



      
        // ROTATE METHOD
      
        // This method rotates ANY n x n matrix 90 degrees clockwise.
        // It does NOT create a new matrix — it changes the original one.
        // We do this in TWO steps:
        //
        // STEP 1: Transpose the matrix (swap across diagonal)
        // STEP 2: Reverse each row (flip horizontally)
       
        public static void Rotate(int[][] matrix)
        {
            var n = matrix.Length; // n is the number of rows/columns in the square matrix


           
            // STEP 1: TRANSPOSE THE MATRIX
           
            // Transposing means swapping elements across the diagonal.
            // Example: swap (0,1) with (1,0)
            // We only swap when j > i so we don't undo our own swaps.
            for (var i = 0; i < n; i++) // Loop through each row diagonally
            {
                for (var j = i + 1; j < n; j++) // Loop through columns ABOVE the diagonal
                {
                    var temp = matrix[i][j];      // swap top-right element into temp
                    matrix[i][j] = matrix[j][i];  // swap top-right with bottom-left
                    matrix[j][i] = temp;          // swap bottom-left with temp (original top-right)
                }
            }


          
            // STEP 2: REVERSE EACH ROW
 
            // After transposing, the matrix is NOT rotated yet.
            // We must reverse each row to complete the rotation.
            for (var i = 0; i < n; i++) // Loop through each row
            {
                Array.Reverse(matrix[i]); // Reverse the row in-place (built-in C# method)
            }
        }



        // PRINT MATRIX METHOD
       
        public static void PrintMatrix(int[][] matrix)
        {
            for (var i = 0; i < matrix.Length; i++) // Loop through each row
            {
                for (var j = 0; j < matrix[i].Length; j++) // Loop through each column in the row
                {
                    Console.Write(matrix[i][j] + " "); // Print each number with a space
                }
                Console.WriteLine(); // Move to the next line after each row
            }
            Console.WriteLine(); // Extra blank line for spacing
        }
    }
}
