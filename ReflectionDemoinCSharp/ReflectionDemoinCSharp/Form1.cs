using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace ReflectionDemoinCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDiscoverTypeInformation_Click(object sender, EventArgs e)
        {
            string TypeName = TxtbxTableName.Text;
            Type T = Type.GetType(TypeName);
            LstMethods.Items.Clear();
            LstProperties.Items.Clear();
            LstConstructors.Items.Clear();
            if (T != null)
            {
                MethodInfo[] Methods = T.GetMethods();
                if (Methods.Any())
                {
                    foreach (MethodInfo Method in Methods)
                    {
                        LstMethods.Items.Add(Method.Name);
                    }
                }
                else
                {
                    LstMethods.Items.Add("No Methods in this class");
                }

                PropertyInfo[] Properties = T.GetProperties();
                if (Properties.Any())
                {
                    foreach (PropertyInfo Property in Properties)
                    {
                        LstProperties.Items.Add(Property.Name);
                    }
                }
                else
                {
                    LstProperties.Items.Add("No Properties in this class");
                }

                ConstructorInfo[] Constructors = T.GetConstructors();
                if (Constructors.Any())
                {
                    foreach (ConstructorInfo Constructor in Constructors)
                    {
                        LstConstructors.Items.Add(Constructor.ToString());
                    }
                }
                else
                {
                    LstConstructors.Items.Add("No Constructors in this class");
                }
            }
            else
            {
                LstMethods.Items.Add("Must me a class to list Methods");
                LstProperties.Items.Add("Must me a class to list Properties");
                LstConstructors.Items.Add("Must me a class to list Constructors");
            }
        }
    }
}
