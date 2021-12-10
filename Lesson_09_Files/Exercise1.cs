using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Lesson_09_Files
{
    public static class Exercise1
    {
        public static void ProcessAllCalculations(string workingFolder)
        {
            var calculationLines = ReadInputFile(workingFolder);

            var calculationResults = Calculate(calculationLines);

            ExportResult(calculationResults, workingFolder);
        }

        private static void ExportResult(StringBuilder calculationResults, string workingFolder)
        {
            string outputFile = Path.Combine(workingFolder, "MathCalc", "output.txt");

            File.WriteAllText(outputFile, calculationResults.ToString());
        }

        private static StringBuilder Calculate(string[] calculationLines)
        {
            StringBuilder calculationResults = new StringBuilder();

            foreach (var line in calculationLines)
            {
                var data = line.Split(" ");

                NumberFormatInfo numberFormatInfo = new NumberFormatInfo();
                numberFormatInfo.NumberDecimalSeparator = ".";

                double operand1 = double.Parse(data[0], numberFormatInfo);
                double operand2 = double.Parse(data[2], numberFormatInfo);

                string operation = data[1].Trim();

                double? result = null;

                switch (operation)
                {
                    case "+":
                        result = operand1 + operand2;
                        break;

                    case "-":
                        result = operand1 - operand2;
                        break;

                    case "*":
                        result = operand1 * operand2;
                        break;

                    case "/":
                        if (operand2 != 0)
                        {
                            result = operand1 / operand2;
                        }
                        break;
                }

                if (result != null)
                {
                    calculationResults.AppendLine(result.Value.ToString(numberFormatInfo));
                }
                else
                {
                    calculationResults.AppendLine("Error");
                }
            }

            return calculationResults;
        }

        private static string[] ReadInputFile(string workingFolder)
        {
            string inputFile = Path.Combine(workingFolder, "MathCalc", "input.txt");

            string[] calculationLines = File.ReadAllLines(inputFile);
            return calculationLines;
        }
    }
}