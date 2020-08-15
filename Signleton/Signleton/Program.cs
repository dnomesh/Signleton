using System;
using System.Threading.Tasks;

namespace Signleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(new ParallelOptions() { MaxDegreeOfParallelism = 2 },
                () => StudentDetails(),
                () => EmployeeDetails()
                );
        }

        private static void EmployeeDetails()
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("this is the second message");
        }

        private static void StudentDetails()
        {
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("this is the first message");
        }
    }
}
