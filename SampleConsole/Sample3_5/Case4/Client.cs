using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample3_5.Case4
{
    public class Client
    {
        public Container Container { get; }

        public Client(Container container)
        {
            Container = container;
        }

        public void MainProcess()
        {
            var result = Container.Execute(TargetProcess, new Param("Foo"));

            Console.WriteLine($"result.Status={result.Status}");

            try
            {
                Container.Execute(TargetProcessExeption, new Param("bar"));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ex.Message={ex.Message}");
            }
        }

        private Result TargetProcess(TransactionInfo info, Param param)
        {
            Console.WriteLine($"TargetProcess. ConnectionString={info.ConnectionString}, param.Name={param.Name}");

            return new Result("Success");
        }

        private Result TargetProcessExeption(TransactionInfo info, Param param)
        {
            Console.WriteLine($"TargetProcess. ConnectionString={info.ConnectionString}, param.Name={param.Name}");

            throw new Exception("Custom Error");
        }

        private class Param
        {
            public string Name { get; }

            public Param(string name)
            {
                Name = name;
            }
        }

        private class Result
        {
            public string Status { get; }

            public Result(string status)
            {
                Status = status;
            }
        }
    }
}
