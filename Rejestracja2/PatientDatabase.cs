using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rejestracja2
{
    public static class PatientDatabase
    {
        private static readonly string filePath = "patients.txt";

        public static List<Patient> LoadPatients()
        {
            List<Patient> patients = new List<Patient>();

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            foreach (string line in File.ReadAllLines(filePath))
            {
                string[] data = line.Split(';');

                if (data.Length == 5)
                {
                    patients.Add(new Patient(data[0], data[1], data[2], data[3], data[4]));
                }
            }

            return patients;
        }

        public static void SavePatients(List<Patient> patients)
        {
            List<string> lines = new List<string>();

            foreach (Patient patient in patients)
            {
                lines.Add($"{patient.FirstName};{patient.LastName};{patient.Pesel};{patient.PhoneNumber};{patient.Address}");
            }

            File.WriteAllLines(filePath, lines);
        }
    }
}