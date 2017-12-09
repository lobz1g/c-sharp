using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace groupsRings
{
    public partial class FormForCoefficients : Form
    {
        public FormForCoefficients()
        {
            InitializeComponent();
        }

        private void startDegreeBut_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            resultBox.Clear();
            int numCoef = int.Parse(valN.Text);

            Calculating calc = new Calculating();

            elementsGroupRing initialValues = new elementsGroupRing();
            initialValues.fillValues(numCoef);
            elementsGroupRing intermediateValues = new elementsGroupRing();
            intermediateValues.fillValues(numCoef);

            while (calc.check(intermediateValues, ref intermediateValues.power) == 0)
            {
                calc.multiplication(ref initialValues, ref intermediateValues, numCoef);
            }

            printResult(intermediateValues, stopWatch, 0, 0);
        }

        

        private void degreeU_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            resultBox.Clear();

            Calculating calc = new Calculating();
            int numCoef = int.Parse(valN.Text);
            int lastNum = calc.findLastNum(numCoef);

            matrixMultiplication matrDegree = new matrixMultiplication(numCoef);
            matrDegree.findDegreeMultiplication();

            for (int i = 1; i < lastNum; i++)
            {
                for (int j = i + 1; j < lastNum + 1; j++)
                {
                    if (i % 3 != 0 && j % 3 != 0)
                    {
                        elementsGroupRing u1 = new elementsGroupRing();
                        u1.fillUValues(numCoef, i);
                        elementsGroupRing u2 = new elementsGroupRing();
                        u2.fillUValues(numCoef, j);

                        calc.multiplication(ref u1, ref u2, numCoef);
                        u2.power = 1;
                        u1 = null;
                        u1 = new elementsGroupRing(u2.Numerator, u2.Denominator);

                        while (calc.check(u2, ref u2.power) == 0)
                        {
                            calc.multiplication(ref u1, ref u2, numCoef);
                        }

                        printResult(u2, stopWatch, i, j);
                    }
                }
            }
        }

        private void multiplicationU_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            resultBox.Clear();

            Calculating calc = new Calculating();
            int numCoef = int.Parse(valN.Text);
            int lastNum = calc.findLastNum(numCoef);

            matrixMultiplication matrDegree = new matrixMultiplication(numCoef);
            matrDegree.findDegreeMultiplication();


            for (int i = 1; i < lastNum + 1; i++)
            {
                if (i % 3 != 0)
                {
                    elementsGroupRing u1 = new elementsGroupRing();
                    u1.fillUValues(numCoef, i);
                    elementsGroupRing u2 = new elementsGroupRing(u1.Numerator, u1.Denominator);
                    u2.power = 0;

                    for (int k = 0; k < int.Parse(valDegree.Text); k++)
                    {
                        calc.multiplication(ref u1, ref u2, numCoef);
                    }

                    printResult(u1, stopWatch, i, 0);
                    printResult(u2, stopWatch, i, 0);
                }
            }
        }

        private void printResult(elementsGroupRing a, Stopwatch time, int i, int j)
        {
            if (outputScreen.Checked) a.outResult(ref resultBox, time);
            if (outputFile.Checked)
            {
                a.outResultInFile(fileName.Text, time, i, j);

                resultBox.Text += Environment.NewLine;
                resultBox.Text += "Запись в файл завершена!";
            }
        }
    }
}
