namespace groupsRings
{
    class matrixMultiplication
    {
        public int[,] matrDeg;
        private int numCoef;

        public matrixMultiplication(int NumCoef)
        {
            matrDeg = new int[NumCoef, NumCoef];
            numCoef = NumCoef;
        }

        public void findDegreeMultiplication()
        {
            int tmp = 0;

            for (int i = 0; i < numCoef; i++)
            {
                tmp = i;
                for (int j = 0; j < numCoef; j++)
                {
                    if (tmp == numCoef) tmp = 0;
                    matrDeg[i, j] = tmp++;
                }
            }
        }

        public int getElem(int a, int b)
        {
            return matrDeg[a, b];
        }
    }
}
