using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample3_5.Case4
{
    public class Container
    {
        public U Execute<T, U>(Func<TransactionInfo, T, U> proc, T param)
        {
            // Start transaction
            var info = StartTransaction();

            try
            {
                // Execute target process
                var result = proc(info, param);

                // End transaction
                CommitTransaction(info);

                // Return result of target process
                return result;
            }
            catch (Exception)
            {
                // Rollback Transaction
                RollbackTransaction(info);

                // Throw an exception as it is
                throw;
            }
        }

        public T Execute<T>(Func<TransactionInfo, T> proc)
        {
            // Start transaction
            var info = StartTransaction();

            try
            {
                // Execute target process
                var result = proc(info);

                // End transaction
                CommitTransaction(info);

                // Return result of target process
                return result;
            }
            catch (Exception)
            {
                // Rollback Transaction
                RollbackTransaction(info);

                // Throw an exception as it is
                throw;
            }
        }

        public void Execute<T>(Action<TransactionInfo, T> proc, T param)
        {
            // Start transaction
            var info = StartTransaction();

            try
            {
                // Execute target process
                proc(info, param);

                // End transaction
                CommitTransaction(info);
            }
            catch (Exception)
            {
                // Rollback Transaction
                RollbackTransaction(info);

                // Throw an exception as it is
                throw;
            }
        }

        public void Execute<T>(Action<TransactionInfo> proc)
        {
            // Start transaction
            var info = StartTransaction();

            try
            {
                // Execute target process
                proc(info);

                // End transaction
                CommitTransaction(info);
            }
            catch (Exception)
            {
                // Rollback Transaction
                RollbackTransaction(info);

                // Throw an exception as it is
                throw;
            }
        }

        private TransactionInfo StartTransaction()
        {
            Console.WriteLine("StartTransaction");

            return new TransactionInfo("**********");
        }

        private void CommitTransaction(TransactionInfo info)
        {
            Console.WriteLine("CommitTransaction");
        }

        private void RollbackTransaction(TransactionInfo info)
        {
            Console.WriteLine("RollbackTransaction");
        }
    }
}
