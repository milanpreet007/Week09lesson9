using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;
namespace AtomsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Atom> atoms = Atom.GetAtoms();
            WriteJson(atoms, "all.json");
            ReadJson("all.json");
        }
        static void WriteJson(List<Atom> atoms, string filename)
        {
            using (TextWriter writer = new StreamWriter(filename))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string output = serializer.Serialize(atoms);
                writer.Write(output);
            }
        }
        static void ReadJson(string filename)
        {
            using (TextReader reader = new StreamReader(filename))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();

                string input = reader.ReadToEnd();
                List<Atom> atoms = serializer.Deserialize<List<Atom>>(input);
                int count = 1;
                foreach (Atom atom in atoms)
                {
                    Console.WriteLine($"{count++,-2} - {atom}");
                }
            }
        } }
}
