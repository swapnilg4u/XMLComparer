using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using NUnit.Framework;
using NetBike.XmlUnit.NUnitAdapter;

namespace XMLComparer
{
    
    public partial class Form1 : Form
    {
        OpenFileDialog op1 = new OpenFileDialog();
        OpenFileDialog op2 = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            

            op1.Multiselect = false;
            op1.Title = "Browse XML Files";
            op1.ShowDialog();
            op1.Filter = "allfiles|*.xml";
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog op1 = new OpenFileDialog();

        //    op1.Multiselect = false;
        //    op1.Title = "Browse XML Files";
        //    op1.ShowDialog();

        //    op1.Filter = "allfiles|*.xml";
        //    XmlDocument doc = new XmlDocument();


        //    doc.Load(op1.FileName);
        //    StringWriter sw = new StringWriter();
        //    XmlTextWriter tx = new XmlTextWriter(sw);
        //    doc.WriteTo(tx);

        //    textBox1.Text = sw.ToString();
        //    label1.Text = op1.FileName;
        //    label1.AutoEllipsis = true;

        //}

        private void button3_Click(object sender, EventArgs e)
        {
            XmlTextReader reader1 = null;
            XmlTextReader reader2 = null;

            try
            {
                reader1 = new XmlTextReader(op1.FileName);
                reader1.WhitespaceHandling = WhitespaceHandling.None;
                
                reader2 = new XmlTextReader(op2.FileName);
                reader2.WhitespaceHandling = WhitespaceHandling.None;

            }
        }

        //private void button3_Click(object sender, EventArgs e)
        //{

        //    //if (String.Equals(textBox1.Text, textBox2.Text))
        //    //{
        //    //    label3.Text = "Both are Same";
        //    //    label3.ForeColor = Color.Green;
        //    //}
        //    //else
        //    //{
        //    //    label3.Text = "Both are Different";
        //    //    label3.ForeColor = Color.Red;

        //    //}
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            
            op2.Multiselect = false;
            op2.ShowDialog();
            op2.Filter = "allfiles|*.xml";
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog op2 = new OpenFileDialog();

        //    op2.Multiselect = false;

        //    op2.ShowDialog();

        //    op2.Filter = "allfiles|*.xml";
        //    XmlDocument doc2 = new XmlDocument();


        //    doc2.Load(op2.FileName);
        //    StringWriter sw2 = new StringWriter();
        //    XmlTextWriter tx2 = new XmlTextWriter(sw2);
        //    doc2.WriteTo(tx2);

        //    textBox2.Text = sw2.ToString();
        //    label2.Text = op2.FileName;
        //    label2.AutoEllipsis = true;
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}