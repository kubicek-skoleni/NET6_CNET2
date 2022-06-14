﻿using Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
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

        private void btnLoadFiles_Click(object sender, RoutedEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Wait;
            Stopwatch s = Stopwatch.StartNew();
            txbInfo.Text = "";
            var files = Directory.EnumerateFiles(@"C:\Users\StudentEN\source\repos\kubicek-skoleni\BigFiles","*.txt");

            foreach(var file in files)
            {
                var result = FreqAnalysis.FreqAnalysisFromFile(file);
                txbInfo.Text += result.Source + Environment.NewLine;

                foreach(var word in result.GetTop10())
                {
                    txbInfo.Text += $"{word.Key} : {word.Value} {Environment.NewLine}";
                }
            }

            s.Stop();
            txbInfo.Text += $"{Environment.NewLine}elapsed milliseconds:{s.ElapsedMilliseconds}";
            Mouse.OverrideCursor = null;
        }

        private async void btnParallel1_Click(object sender, RoutedEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Wait;
            Stopwatch s = Stopwatch.StartNew();
            txbInfo.Text = "";
            var files = Directory.EnumerateFiles(@"C:\Users\StudentEN\source\repos\kubicek-skoleni\BigFiles", "*.txt");

            IProgress<string> progress = new Progress<string>(message =>
            {
                txbInfo.Text += message;
            });

            await Parallel.ForEachAsync(files, async (file, cancellationToken) =>
            {
                var result = FreqAnalysis.FreqAnalysisFromFile(file);

                string message = "";
                message += result.Source + Environment.NewLine;

                foreach (var word in result.GetTop10())
                {
                    message += $"{word.Key} : {word.Value} {Environment.NewLine}";
                }

                progress.Report(message);
            });

            s.Stop();
            progress.Report($"{Environment.NewLine}elapsed milliseconds:{s.ElapsedMilliseconds}");
            Mouse.OverrideCursor = null;
        }
    }
}
