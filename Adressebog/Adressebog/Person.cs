using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.IO;

namespace Adressebog
{
    [Serializable()]
    public class Person
    {


        public static int Id = 0;
        public PersonState State;
        private string name = "";
        private string address = "";
        private string country = "";
        private int zipCode = 0;
        private int personId;

        public Person()
        {
            this.personId = ++Id;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }

        public string Adress
        {
            get { return address; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                   address = value;
                }
            }
        }

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    country = value;
                }
            }
        }

        public int PersonId
        {
            get
            {
                return personId;
            }
        }

        public int Zipcode
        {
            get
            {
                return zipCode;
            }
            set
            {
                this.zipCode = value;
            }
        }

        public void SaveMe(Person p)
        {
            //Person p = new Person();
            XmlSerializer ser = new XmlSerializer(typeof(Person));
            LoadConfig(p, ser);
        }

       public void LoadConfig(Person p, XmlSerializer ser)
        {
            try
            {
                if (File.Exists(@"C:\Users\freyb\Documents\GitHubVisualStudio\CPH_Business\Adressebog\Adressebog\records.xml"))
                {
                    FileStream fs = new FileStream(@"C:\Users\freyb\Documents\GitHubVisualStudio\CPH_Business\Adressebog\Adressebog\records.xml", FileMode.Append);
                    //p = (Person)ser.Deserialize(fs);
                    TextWriter tw = new StreamWriter(fs);
                    ser.Serialize(tw, p);
                    tw.Close();
                    fs.Close();

                }
                else
                {
                    Console.WriteLine("Could not find User Configuration File\n\nCreating new file...", "User Config Not Found");
                    FileStream fs = new FileStream(@"C:\Users\freyb\Documents\GitHubVisualStudio\CPH_Business\Adressebog\Adressebog\records.xml", FileMode.CreateNew);
                    TextWriter tw = new StreamWriter(fs);
                    ser.Serialize(tw, p);
                    tw.Close();
                    fs.Close();
                }
               // setupControlsFromConfig();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }

   public enum PersonState
    {
        friend,
        enemy,
        happy,
        sad,
        hungry,
        horny
    };

   
}
