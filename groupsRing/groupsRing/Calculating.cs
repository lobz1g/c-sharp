using System;
using System.Collections.Generic;
using System.Numerics;

namespace groupsRings
{
    class Calculating
    {
        public void multiplication(ref elementsGroupRing a, ref elementsGroupRing b, int numCoef)
        {
            matrixMultiplication matrDegree = new matrixMultiplication(numCoef);
            matrDegree.findDegreeMultiplication();

            b.power++;
            List<List<BigInteger>> tmpNum = new List<List<BigInteger>>();
            List<List<BigInteger>> tmpDen = new List<List<BigInteger>>();

            for (int i = 0; i < a.Numerator.Count; i++)
            {
                tmpNum.Add(new List<BigInteger>());
                tmpDen.Add(new List<BigInteger>());
            }

            for (int i = 0; i < a.Numerator.Count; i++)
            {
                for (int j = 0; j < a.Numerator.Count; j++)
                {
                    for (int k = 0; k < a.Numerator.Count; k++)
                    {
                        if (matrDegree.getElem(j, k) == i)
                        {
                            tmpNum[i].Insert(j, b.Numerator[j] * a.Numerator[k]);
                            tmpDen[i].Insert(j, b.Denominator[j] * a.Denominator[k]);
                        }
                    }
                }
            }

            for (int i = 0; i < a.Numerator.Count; i++)
            {
                BigInteger leastCommonDivisor;

                b.Numerator[i] = tmpNum[i][0];
                b.Denominator[i] = tmpDen[i][0];

                for (int j = 1; j < a.Numerator.Count; j++)
                {
                    if (b.Denominator[i] == tmpDen[i][j]) b.Numerator[i] += tmpNum[i][j];
                    else
                    {
                        leastCommonDivisor = b.Denominator[i] * tmpDen[i][j];
                        b.Numerator[i] = leastCommonDivisor / b.Denominator[i] * b.Numerator[i] + leastCommonDivisor / tmpDen[i][j] * tmpNum[i][j];
                        b.Denominator[i] = leastCommonDivisor;
                    }
                }

                leastCommonDivisor = BigInteger.GreatestCommonDivisor(b.Numerator[i], b.Denominator[i]);

                if (leastCommonDivisor < 0) leastCommonDivisor = -leastCommonDivisor;
                b.Numerator[i] /= leastCommonDivisor;
                b.Denominator[i] /= leastCommonDivisor;
            }

            tmpDen.Clear();
            tmpNum.Clear();
        }

        public int findLastNum(int numCoef)
        {
            int tmp = (int)Math.Round(Math.Log(numCoef, 3.0));
            BigInteger tmpDeg = BigInteger.Pow(3, tmp - 1) - 1;

            BigInteger count = 1;
            for (int i = 1; ; i++)
            {
                if (count != tmpDeg && i % 3 != 0) count++;
                else if (count == tmpDeg) return i;
            }
        }

        public int check(elementsGroupRing a, ref int power)
        {
            for (int i = 0; i < a.Numerator.Count; i++)
            {
                if (hasFractionalPart(a.Numerator[i], a.Denominator[i])) return 0;
            }
            
            return 1;
        }

        private bool hasFractionalPart(BigInteger a, BigInteger b)
        {
            return BigInteger.Remainder(a, b) > 0;
        }
    }
}
