using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace StudentGradeCalc
{
  internal static class Program
  {
    [STAThread]
    static void Main()
    {
      while (true)
      {
        string inP = Interaction.InputBox("Input the amount of students", "Students", "");
        int? NumStudents = null;
        if (int.TryParse(inP, out var pNum))
        { 
          
          break; 
        }
        MessageBox.Show("Invalid Input");
      }
      for (int i = 0; i < numSt; i++) { }
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1());
    }
  }
}
