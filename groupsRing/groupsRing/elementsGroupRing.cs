using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Windows.Forms;

namespace groupsRings
{
    class elementsGroupRing
    {
        public List<BigInteger> Numerator;
        public List<BigInteger> Denominator;
        public int power = 1;

        public elementsGroupRing()
        {
            Numerator = new List<BigInteger>();
            Denominator = new List<BigInteger>();
        }

        public elementsGroupRing(List<BigInteger> a, List<BigInteger> b)
        {
            Numerator = new List<BigInteger>(a);
            Denominator = new List<BigInteger>(b);
        }

        public void fillValues(int numCoef)
        {
            for (int i = 0; i < numCoef; i++)
            {
                int tmp = (int)Math.Round(Math.Log(numCoef, 3.0));
                BigInteger tmpDeg = BigInteger.Pow(3, tmp - 1);

                if (i == 0)
                {
                    Numerator.Insert(i, 1);
                    Denominator.Insert(i, 1);
                }
                else if (i == numCoef + 1 - tmpDeg || i == numCoef + 1 - 2 * tmpDeg)
                {
                    Numerator.Insert(i, -1);
                    Denominator.Insert(i, 3);
                }
                else if (i == 1)
                {
                    Numerator.Insert(i, 2);
                    Denominator.Insert(i, 3);
                }
                else
                {
                    Numerator.Insert(i, 0);
                    Denominator.Insert(i, 1);
                }
            }
        }

        public void fillUValues(int numCoef, int tmpi)
        {
            int tmp = (int)Math.Round(Math.Log(numCoef, 3.0));
            BigInteger tmpDeg = BigInteger.Pow(3, tmp - 1);

            for (int i = 0; i < numCoef; i++)
            {
                if (i == 0)
                {
                    Numerator.Insert(i, 1);
                    Denominator.Insert(i, 1);
                }
                else if (i == tmpi)
                {
                    Numerator.Insert(i, 2);
                    Denominator.Insert(i, 3);
                }
                else if ((i == tmpi + tmpDeg || i == tmpi + tmpDeg * 2) && tmpi < tmpDeg)
                {
                    Numerator.Insert(i, -1);
                    Denominator.Insert(i, 3);
                }
                else if ((i == tmpi - tmpDeg || i == tmpi + tmpDeg) && tmpi > tmpDeg)
                {
                    Numerator.Insert(i, -1);
                    Denominator.Insert(i, 3);
                }
                else
                {
                    Numerator.Insert(i, 0);
                    Denominator.Insert(i, 1);
                }
            }
        }

        public void outResult(ref TextBox resBox, Stopwatch time)
        {
            resBox.Text += Environment.NewLine;

            for (int i = 0; i < Numerator.Count; i++)
            {
                if (Denominator[i] == 1) resBox.Text += Numerator[i].ToString() + "  ";
                else resBox.Text += Numerator[i].ToString() + "/" + Denominator[i].ToString() + "  ";
            }
            resBox.Text += Environment.NewLine;
            resBox.Text += "Степень: " + power.ToString();
            resBox.Text += Environment.NewLine;
            TimeSpan ts = time.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            resBox.Text += "Потраченное время: " + elapsedTime;
        }

        public void outResultInFile(string fileName, Stopwatch time, int a, int b)
        {
            string path;
            if (fileName == "") path = Directory.GetCurrentDirectory() + " для " + Numerator.Count + ".txt";
            else path = Directory.GetCurrentDirectory() + "  " + fileName + ".txt";

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("\n");
                string tmp = "";
                if (a != 0 && b != 0) sw.WriteLine("U" + a + " * U" + b + "\n");
                else if (a != 0 && b == 0) sw.WriteLine("U" + a);
                for (int i = 0; i < Numerator.Count; i++)
                {
                    if (Denominator[i] == 1) tmp += Numerator[i].ToString() + "  ";
                    else tmp += Numerator[i].ToString() + "/" + Denominator[i].ToString() + "  ";
                }
                sw.WriteLine(tmp);
                sw.WriteLine("\n" + "Степень: " + power.ToString() + "\n");
                TimeSpan ts = time.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                sw.WriteLine("Потраченное время: " + elapsedTime + "\n");
            }
        }
    }
}
