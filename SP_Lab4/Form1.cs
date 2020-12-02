using System;
using System.IO;
using System.Windows.Forms;

namespace SP_Lab4
{
  
  public partial class Form1 : Form
  {
    string openedPath = null;
    public Form1()
    {
      InitializeComponent();
    }

    private void opFileBt_Click(object sender, EventArgs e)
    {
      if(openFileDialog1.ShowDialog() == DialogResult.OK)
          openedPath = openFileDialog1.FileName;
      if (openedPath != null)
      {
        StreamReader sr = new StreamReader(openedPath);
        richTextBox1.Text = sr.ReadLine();
        sr.Dispose();
      }
      else
        MessageBox.Show("File didn't chose!");
    }

    private void calculateBt_Click(object sender, EventArgs e)
    {
      if (openedPath != null)
      {
        saveFileDialog1.Filter = "out files (*.out) | *.out";
        saveFileDialog1.FileName = "";
        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        {
          int result = SeriesFinder.GetCountOfSeries(openedPath, saveFileDialog1.FileName);
          MessageBox.Show($"Done! Writen: {result}");
        }
      }
      else
        MessageBox.Show("File didn't chose!");
    }

    private void createBt_Click(object sender, EventArgs e)
    {
      saveFileDialog1.Filter = "txt files (*.txt) | *.txt";
      if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        SeriesFinder.CreateAndFill(saveFileDialog1.FileName);
    }
  }
}
