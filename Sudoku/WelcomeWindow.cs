﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Configuration;

namespace Sudoku
{
    public partial class WelcomeWindow : Form
    {
        private GameControl gameControl;

        private string file;
        private string path;

        public WelcomeWindow()
        {
            file = "..\\..\\data\\" + ConfigurationManager.AppSettings["fileName"];
            path = AppDomain.CurrentDomain.BaseDirectory;

            InitializeComponent();

            // Create our GameControl here
            GameControl gc = new GameControl();
            gameControl = gc;
        }

        private int numOfSolvedGrids()
        {
            string fileName = path + "" + file;
            const int BufferSize = 128;
            using (var fileStream = File.OpenRead(fileName))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                string line;
                int numOfLines = 0;
                while ((line = streamReader.ReadLine()) != null)
                {
                    numOfLines++;
                }
                return numOfLines;
            }
        }

        private List<int> getPuzzle(int position)
        {
            List<int> result = new List<int>();
            char[] delimitChars = { ',' };
            string fileName = path + "" + file;
            const int BufferSize = 128;
            using (var fileStream = File.OpenRead(fileName))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                string line;
                int numOfLines = 1;
                // Iterate over lines until we reach our position in text file
                while ((line = streamReader.ReadLine()) != null && numOfLines != position)
                {
                    numOfLines++;
                }
                string[] splitLine = line.Split(delimitChars);
                for (int i = 0; i < splitLine.Length; i++)
                {
                    result.Add(int.Parse(splitLine[i]));
                }
                return result;
            }
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            // Seleccionamos el sudoku a mostrar
            Random rnd = new Random();
            int puzzlePick = rnd.Next(1, numOfSolvedGrids() + 1);
            SudokuGrid sudokuGrid = new SudokuGrid(getPuzzle(puzzlePick));
            PlayWindow pw = new PlayWindow(gameControl, sudokuGrid, 0);
            pw.FormClosed += (s, args) => Close();
            Hide();
            pw.Show();
        }

        private void leaderboardButton_Click(object sender, EventArgs e)
        {
            Leaderboard lb = new Leaderboard(this);
            lb.Show();
            Hide();
        }

        private void generatePuzzleButton_Click(object sender, EventArgs e)
        {
            progressBar.Maximum = 100;
            progressBar.Step = 3;
            progressBar.Value = 0;

            Thread t = new Thread(doWork);
            t.IsBackground = true;
            t.Name = "En proceso...";
            t.Start();
        }

        delegate void SetTextCallback(string text);

        private void setTotalLettersGuessedText(string text)
        {
            string labelToFind = "cpuWordLabel";
            Control[] controls = Controls.Find(labelToFind, true);
            if (controls.Length == 1)
            {
                Label lab = controls[0] as Label;
                if (lab.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(setTotalLettersGuessedText);
                    Invoke(d, new object[] { text });
                }
                else
                {
                    lab.Text = text;
                }
            }
        }

        delegate void PerformProgress();

        public void updateProgressBar()
        {
            if (progressBar.InvokeRequired)
            {
                PerformProgress d = new PerformProgress(updateProgressBar);
                Invoke(d, new object[] { });
            }
            else
            {
                progressBar.PerformStep();
            }
        }

        public void completeProgressBar()
        {
            if (progressBar.InvokeRequired)
            {
                PerformProgress d = new PerformProgress(completeProgressBar);
                Invoke(d, new object[] { });
            }
            else
            {
                progressBar.Value = 100;
            }
        }

        delegate void PerformProgressStatus(string text);

        public void updateProgressLabel(string text)
        {
            if (statusLabel.InvokeRequired)
            {
                PerformProgressStatus d = new PerformProgressStatus(updateProgressLabel);
                Invoke(d, new object[] { text });
            }
            else
            {
                statusLabel.Text = "Estado: " + text;
            }
        }

        private void doWork(object state)
        {
            SudokuGrid sg = new SudokuGrid(path, file);
            updateProgressLabel("Trabajando...");
            sg.setUpPlacementOrders();
            updateProgressBar();
            for (int i = 0; i < 9; i++)
                sg.doInitialPlacementFill(i);

            updateProgressBar();
            sg.populate(this);
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            // Seleccionamos el sudoku a mostrar
            Random rnd = new Random();
            int puzzlePick = rnd.Next(1, numOfSolvedGrids() + 1);
            SudokuGrid sudokuGrid = new SudokuGrid(getPuzzle(puzzlePick));
            PlayWindow pw = new PlayWindow(gameControl, sudokuGrid, 1);
            pw.FormClosed += (s, args) => Close();
            Hide();
            pw.Show();
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            // Seleccionamos el sudoku a mostrar
            Random rnd = new Random();
            int puzzlePick = rnd.Next(1, numOfSolvedGrids() + 1);
            SudokuGrid sudokuGrid = new SudokuGrid(getPuzzle(puzzlePick));
            PlayWindow pw = new PlayWindow(gameControl, sudokuGrid, 2);
            pw.FormClosed += (s, args) => Close();
            Hide();
            pw.Show();
        }
    }
}
