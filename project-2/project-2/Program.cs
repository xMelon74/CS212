﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
/*
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
*/
using System.IO;

namespace project_2
{
    class Program
    {

         

        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\alexi\OneDrive - Calvin University\CS 212\prog2");
            string[] words = Regex.Split(input, @"\s+");
            Dictionary<string, List<string>> hashTable = hash(words)
        }

        static Dictionary<string, List<string>> hash(string[] words)
        { // adds an array of words to the hash table
            Dictionary<string, List<string>> hashTable = new Dictionary<string, List<string>>
            string prevWord = "";
            foreach (string word in words)
            {
                if (!hashTable.ContainsKey(prevWord))
                    hashTable.Add(prevWord, new List<string>);
                hashTable[prevWord].Add(word);

                prevWord = word;
            }
            return hashTable;
        }
    }
    /*
    /// Babble framework
    /// Starter code for CS212 Babble assignment
    public partial class MainWindow : Window
    {
        private string input;               // input file
        private string[] words;             // input file broken into array of words
        private int wordCount = 200;        // number of words to babble

        public MainWindow()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();
            ofd.FileName = "Sample"; // Default file name
            ofd.DefaultExt = ".txt"; // Default file extension
            ofd.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

            // Show open file dialog box
            if ((bool)ofd.ShowDialog())
            {
                //textBlock1.Text = "Loading file " + ofd.FileName + "\n";
                input = System.IO.File.ReadAllText(ofd.FileName);  // read file
                words = Regex.Split(input, @"\s+");       // split into array of words
            }
        }

        private void analyzeInput(int order)
        {
            if (order > 0)
            {
                MessageBox.Show("Analyzing at order: " + order);
            }
        }

        private void babbleButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < Math.Min(wordCount, words.Length); i++)
                textBlock1.Text += " " + words[i];
        }

        private void orderComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            analyzeInput(orderComboBox.SelectedIndex);
        }
    }
}
    */
}
