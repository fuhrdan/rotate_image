void rotate(int** matrix, int matrixSize, int* matrixColSize) {
    for(int x = 0; x < matrixSize; x++)
    {
        const int half = matrixSize - 1 - x;
        for(int y = x; y < half; y++)
        {
            const int offset = y - x;
            const int top = matrix[x][y];
            matrix[x][y] = matrix[half - offset][x];
            matrix[half - offset][x] = matrix[half][half - offset];
            matrix[half][half - offset] = matrix[y][half];
            matrix[y][half] = top;
        }
    }
}