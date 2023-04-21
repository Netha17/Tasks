using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    
        public class File
    {
        public string Name
        {
            get;
            set;
        }

        public File(string name) { this.Name = name; }
    }

    /// <summary>
    /// File Handler class which
    /// implements IDisposable
    /// interface
    /// </summary>
    public class FileHandler : IDisposable
    {
        // unmanaged object
        private File fileObject = null;

        // managed object
        private static int TotalFiles = 0;

        // boolean variable to ensure dispose
        // method executes only once
        private bool disposedValue;

        // Constructor
        public FileHandler(string fileName)
        {
            if (fileObject == null)
            {
                TotalFiles++;
                fileObject = new File(fileName);
            }
        }

        // Gets called by the below dispose method
        // resource cleaning happens here
        protected virtual void Dispose(bool disposing)
        {
            // check if already disposed
            if (!disposedValue)
            {
                if (disposing)
                {
                    // free managed objects here
                    TotalFiles = 0;
                }

                // free unmanaged objects here
                Console.WriteLine("The {0} has been disposed",
                                  fileObject.Name);
                fileObject = null;

                // set the bool value to true
                disposedValue = true;
            }
        }

        // The consumer object can call
        // the below dispose method
        public void Dispose()
        {
            // Invoke the above virtual
            // dispose(bool disposing) method
            Dispose(disposing: true);

            // Notify the garbage collector
            // about the cleaning event
            GC.SuppressFinalize(this);
        }

        // Get the details of the file object
        public void GetFileDetails()
        {
            Console.WriteLine(
                "{0} file has been successfully created.",
                fileObject.Name);
        }

        // Destructors should have the following
        // invocation in order to dispose
        // unmanaged objects at the end
        ~FileHandler() { Dispose(disposing: false); }
    }
    internal class disposable
    {
        public static void Main()
        {


            Console.WriteLine(
                "Explicit calling of dispose method - ");
            Console.WriteLine("");

            FileHandler filehandler = new FileHandler("Demo1");
            filehandler.GetFileDetails();
            // manual calling
            filehandler.Dispose();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(
                "Implicit calling using 'Using' keyword - ");
            Console.WriteLine("");
            using (FileHandler fileHandler2
                  = new FileHandler("Demo2"))
            {
                fileHandler2.GetFileDetails();
                // The dispose method is called automatically
                // by the using keyword at the end of scope
            }
            Console.ReadLine();
        }
}
}
