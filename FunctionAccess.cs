using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform__with_database_
{
    internal class FunctionAccess
    {
        private static FunctionAccess instance = new FunctionAccess();
        private static readonly object padlock = new object();
        static FunctionAccess()
        {
        }

        private FunctionAccess()
        {
        }

        public static FunctionAccess Instance
        {
            get
            {
                return instance;

            }
        }

    }
}