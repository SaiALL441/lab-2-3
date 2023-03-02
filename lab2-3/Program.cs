using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace lab2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TextFieldParser tfp = new TextFieldParser(@"D:\2 курс"))
            {
                tfp.TextFieldType = FieldType.Delimited;
                tfp.SetDelimiters(",");

                while (!tfp.EndOfData)
                {
                    string[] fields = tfp.ReadFields();
                }
            }
        }
    }
}
