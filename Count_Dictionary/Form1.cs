﻿using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Count_Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            var Letters = new Dictionary<char, int>();
            string word = File.ReadAllText("try.txt");
            //txtInputWord.Text;
            //"if word is the word and bird is the word then word is the bird";
            // for each letter in the word
            foreach (char a in word)
            {
                //if there is no entry in the dictionary then add a new entry with 1 as the counter
                if (Letters.ContainsKey(a) == false)
                {
                    Letters.Add(a, 1);
                }
                else
                    // if its already in the dictionary increase the number (value) by one.
                {
                    //finds the key and adds 1 to the value, basically counts up
                    Letters[a]++;
                }
            }
            //loop through the dictionary and get out the key/value pairs
            foreach (KeyValuePair<char, int> pair in Letters)
            {
                lbxCountresult.Items.Add(pair.Key + " --> " + pair.Value);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbxCountresult.Items.Clear();
        }
    }
}
