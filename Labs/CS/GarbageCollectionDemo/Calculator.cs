using System;

namespace GarbageCollectionDemo
{
    class Calculator : IDisposable
    {
        private bool disposed = false;
        public Calculator()
        {
            Console.WriteLine("Calculator being created");
        }
        public int Divide(int first, int second)
        {
            return first / second;
        }

        public void Dispose()
        {
            //Console.WriteLine("In dispose method, Calculator being disposed.");
            if (!this.disposed)
            {
                Console.WriteLine("Calculator being disposed");
            }
            this.disposed = true;
            GC.SuppressFinalize(this);
        }
        ~Calculator()
        {
            Console.WriteLine("Calculator being finalized");
            Dispose();
        }
    }
}
