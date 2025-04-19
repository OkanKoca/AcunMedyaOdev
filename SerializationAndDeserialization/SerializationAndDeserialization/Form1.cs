using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SerializationAndDeserialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee
                {
                    Name = textBoxAd.Text,
                    Phone = textBoxTelefon.Text,
                    DateOfBirth = dateTimePickerDogumTarihi.Value,
                    Department = textBoxDepartman.Text,
                    Salary = Convert.ToInt32(textBoxMaas.Text)
                };
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
                FileStream fileStream = new FileStream("employee.xml", FileMode.Create, FileAccess.Write, FileShare.None);
                using (fileStream)
                {
                    xmlSerializer.Serialize(fileStream, emp);
                    textBoxAd.Text = "";
                    textBoxTelefon.Text = "";
                    dateTimePickerDogumTarihi.Value = DateTime.Now;
                    textBoxDepartman.Text = "";
                    textBoxMaas.Text = "";
                    MessageBox.Show("Employee data saved successfully.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while saving the employee data.");   
            }
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
                FileStream fileStream = new FileStream("employee.xml", FileMode.Open, FileAccess.Read, FileShare.None);

                using (fileStream)
                {
                    emp = xmlSerializer.Deserialize(fileStream) as Employee;
                    textBoxAd.Text = emp.Name;
                    textBoxTelefon.Text = emp.Phone;
                    dateTimePickerDogumTarihi.Value = emp.DateOfBirth;
                    textBoxDepartman.Text = emp.Department;
                    textBoxMaas.Text = emp.Salary.ToString();
                    MessageBox.Show("Employee data loaded successfully.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while loading the employee data.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee
                {
                    Name = textBoxAd.Text,
                    Phone = textBoxTelefon.Text,
                    DateOfBirth = dateTimePickerDogumTarihi.Value,
                    Department = textBoxDepartman.Text,
                    Salary = Convert.ToInt32(textBoxMaas.Text)
                };

                JsonWriter jsonWriter = new JsonTextWriter(new StreamWriter("employee.json"));
                JsonSerializer jsonSerializer = new JsonSerializer();

                jsonSerializer.Serialize(jsonWriter, emp);

                jsonWriter.Close();

                textBoxAd.Text = "";
                textBoxTelefon.Text = "";
                dateTimePickerDogumTarihi.Value = DateTime.Now;
                textBoxDepartman.Text = "";
                textBoxMaas.Text = "";

                MessageBox.Show("Employee data saved successfully in JSON format.");
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while saving the employee data in JSON format.");    
            }
        }

        private void btnJsonDeserialize_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();

                JsonReader jsonReader = new JsonTextReader(new StreamReader("employee.json"));
                JsonSerializer jsonSerializer = new JsonSerializer();

                emp = jsonSerializer.Deserialize<Employee>(jsonReader);

                jsonReader.Close();

                textBoxAd.Text = emp.Name;
                textBoxTelefon.Text = emp.Phone;
                dateTimePickerDogumTarihi.Value = emp.DateOfBirth;
                textBoxDepartman.Text = emp.Department;
                textBoxMaas.Text = emp.Salary.ToString();
                
                MessageBox.Show("Employee data loaded successfully from JSON format.");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
