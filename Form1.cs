﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace App_Blocker_Builder_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = ("By Skillax");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string[] str = new string[]
         {
               "@echo off",
               ":main",
               "taskkill /pid " + Process.Text,
               "goto:main",
               
         };

            using (StreamWriter sw = new StreamWriter("OutPut.bat"))
            {
                foreach (string s in str)
                {
                    sw.WriteLine(s);
                }
            }

            // Lire et afficher chaque ligne du fichier.
            string line = "";
            using (StreamReader sr = new StreamReader("OutPut.bat"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Text = ("RobloxPlayerBeta.exe");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Text = ("opera.exe");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Text = ("msedge.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Text = ("Calculator.exe");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Text = ("chrome.exe");
        }
    }
 
}
