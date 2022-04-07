using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace Advent_Of_Code_Day_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int increasingCount = 0;
        private List<int> sonarData = new List<int>();

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            using (StreamReader reader = new StreamReader("D:\\Users\\Benji\\source\\repos\\Advent of Code 2021\\Advent of Code Day 1\\Advent of Code Day 1\\Advant of code sonar input.txt"))
            {
                while (!reader.EndOfStream)
                {
                    sonarData.Add(Convert.ToInt32(reader.ReadLine()));
                }
            }
            int a = 0, b = 0;
            int i = 0;
            do
            {
                a = sonarData[i] + sonarData[i + 1] + sonarData[i + 2];
                b = sonarData[i + 1] + sonarData[i + 2] + sonarData[i + 3];
                if (a < b)
                {
                    increasingCount++;
                    
                }
                i++;
            } while (b != (sonarData[sonarData.Count - 1] + sonarData[sonarData.Count - 2] + sonarData[sonarData.Count - 3]));
            lblResult.Content = increasingCount.ToString();
        }
    }
}