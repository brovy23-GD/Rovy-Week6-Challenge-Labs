# Rovy Week 6 Challenge Labs
Rotate Matrix 90 Degrees Clockwise (Optimal In‑Place Algorithm)

This project rotates an n × n matrix (square matrix) 90 degrees clockwise using the fastest possible algorithm with O(n²) time and O(1) space.

What the program does:
Takes a matrix like:
1 2 3
4 5 6
7 8 9

And rotates it to:
7 4 1
8 5 2
9 6 3

How it works:
Step 1: Transpose the matrix (swap across diagonal)
1 4 7
2 5 8
3 6 9

Step 2: Reverse each row
7 4 1
8 5 2
9 6 3

Time Complexity:
Transpose: O(n²)
Reverse rows: O(n²)
Total: O(n²)
Space: O(1)

Example Outputs:
3×3:
Original:
1 2 3
4 5 6
7 8 9

Rotated:
7 4 1
8 5 2
9 6 3

4×4:
Original:
5  1  9 11
2  4  8 10
13  3  6  7
15 14 12 16

Rotated:
15 13  2  5
14  3  4  1
12  6  8  9
16  7 10 11

Whiteboard Explanation:
1. Rotate in-place, no new matrix.
2. Transpose.
3. Reverse each row.
4. O(n²) time, O(1) space.

Folder Structure:
Program.cs
README.md
.gitignore
LICENSE
docs/
screenshots/
.github/

Status:
Project complete and fully documented.
