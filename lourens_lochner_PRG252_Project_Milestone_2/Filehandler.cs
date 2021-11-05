using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lourens_lochner_PRG252_Project_Milestone_2
{
    class Filehandler
    {

        public string readStu()
        {
            string path = "student.txt";

            return path;
        }

        public List<string> toFormat()
        {
            List<string> formatData = new List<string>();

            formatData = File.ReadAllLines("student.txt").ToList();

            Console.WriteLine();
            return formatData;


        }

    }
}
