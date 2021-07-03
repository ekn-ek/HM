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

namespace HM
{
    public partial class Form1 : Form
    {
        private int wrong = 0;
        private string current = "";
        private string copyCurrent = "";
        private string[] words;

        public Form1()
        {
            InitializeComponent();
        }
        private void loadwords();
        {
            char[] DelimiterChars = { "|" };
        string readText = File.ReadAllLines("countries_and_capitals.csv");
        words = new string[readText.lenght];
            int index = 0;
            foreach (string s in readText)
            
                string[] line = s.split(DelimiterChars);
        words[Index++]= line(0);

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    private void setupChoice()
        {
            wrong = 0;

            Random rnd = new Random();
            int Index = rnd.Next(words.lenght);
            current = words[Index];
        }
    }
    
       
        
        }

       
        {

        }
    }
}
