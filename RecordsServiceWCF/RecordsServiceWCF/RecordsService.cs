using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RecordsServiceWCF
{

    public class RecordsService : IRecordsService
    {

        static private int xAge;

        public int getAge()
        {
            return xAge;
        }

        public int ageCalc(string birthDate)
        {
            string[] date = birthDate.Split('/');
            int age = 2023 - Convert.ToInt32(date[2]);
            return age;
        }

        public bool checkName(string name)
        {

            bool found = false;
            Dictionary<string, string> records = new Dictionary<string, string>();

            try
            {

                StreamReader read = new StreamReader("C:\\Users\\Good User\\Desktop\\Name_Date_DB.csv");
                read.ReadLine();
                while (read.Peek() != -1)
                {
                    string[] row = read.ReadLine().Split(',');
                    records.Add(row[0] + " " + row[1], row[2]);
                }

                if (records.ContainsKey(name))
                {
                    xAge = ageCalc(records[name]);
                    found = true;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return found;
        }
    }
}
