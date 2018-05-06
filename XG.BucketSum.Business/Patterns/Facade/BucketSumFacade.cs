using System;
using System.Collections.Generic;
using XG.BucketSum.Business.Operations;
using XG.BuketSum.Common.Helpers;
using XG.BuketSum.Common.Logs;

namespace XG.BucketSum.Business.Patterns.Facade
{
    public class BucketSumFacade : IBucketSumFacade
    {
        private readonly IFileManager fileManager;
        private readonly IOperationsBucketSum operationsBucketSum;

        public BucketSumFacade(IFileManager fileManager, IOperationsBucketSum operationsBucketSum)
        {
            this.fileManager = fileManager;
            this.operationsBucketSum = operationsBucketSum;
        }


        public  List<int> GetBucketSumConsol (string path)
        {
            List<string> lines = null;

            try
            {
                lines = this.fileManager.ReadFile(path);
            }
            catch (Exception exception)
            {
                Log.Default.Error("Se presento un error al obtener las lineas", exception);
            }

            return this.GetBucketSum(lines);
        }

        public List<int> GetBucketSumWeb(string data)
        {

            List<string> lines = new List<string>();

            String[] numbers = data.Trim().Split('\n');

            for (var i= 0; i< numbers.Length;i++) {
                lines.Add(numbers[i]);
            }

            return this.GetBucketSum(lines);
        }


        public List<int> GetBucketSum(List<string> lines)
        {
            bool isSuccess = false;
            List<int> output = new List<int>();         
            isSuccess = lines != null && lines.Count >= 0;

            if (isSuccess)
            {

                int testcases = int.Parse(lines[0]);

                Console.WriteLine("El texto introducido es: " + testcases);
                int r = 0;
                for (int i = 0; i < testcases; i++)
                {
                    String numsLine = lines[r + 1];
                    String[] numsLineParts = numsLine.Trim().Split(' ');
                    int dimensions = int.Parse(numsLineParts[0]);
                    int numOperations = int.Parse(numsLineParts[1]);
                    this.operationsBucketSum.setDimensions(dimensions);
                    r++;

                    for (int j = 0; j < numOperations; j++)
                    {
                        r++;
                        String line = lines[r];
                        String[] lineParts = line.Split(' ');
                        if (lineParts[0].Equals("UPDATE"))
                        {
                            this.operationsBucketSum.update(int.Parse(lineParts[1]) - 1, int.Parse(lineParts[2]) - 1, int.Parse(lineParts[3]) - 1, int.Parse(lineParts[4]));
                        }
                        if (lineParts[0].Equals("QUERY"))
                        {
                            var result = this.operationsBucketSum.query(int.Parse(lineParts[1]) - 1, int.Parse(lineParts[2]) - 1, int.Parse(lineParts[3]) - 1, int.Parse(lineParts[4]) - 1, int.Parse(lineParts[5]) - 1, int.Parse(lineParts[6]) - 1);
                            output.Add(result);
                        }
                    }
                }
            }

            return output;
        }
    }
}
