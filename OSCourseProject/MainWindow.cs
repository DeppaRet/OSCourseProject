using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Calculations;
using Microsoft.Office.Interop.Excel;
using Point = System.Drawing.Point;


namespace OSCourseProject
{

  public partial class MainWindow : Form
  {
    private Point mouseOffset;
    private bool isMouseDown = false;
    string[] addreses = new string[100];
    bool[] visited = new bool[100];
    string[] files = new string[10];
    string A = " ", B = " ", C = " ", D = " ", E = " ", F = " ", G = " ", H = " ", I = " ", J = " ";
    private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
    {
      int xOffset;
      int yOffset;

      if (e.Button == MouseButtons.Left)
      {
        xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
        yOffset = -e.Y - SystemInformation.CaptionHeight -
                  SystemInformation.FrameBorderSize.Height;
        mouseOffset = new Point(xOffset, yOffset);
        isMouseDown = true;
      }
    }
    private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
    {
      if (isMouseDown)
      {
        Point mousePos = Control.MousePosition;
        mousePos.Offset(mouseOffset.X, mouseOffset.Y);
        Location = mousePos;
      }
    }

    private void Form1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        isMouseDown = false;
      }
    }
    public MainWindow()
    {
      InitializeComponent();
    }

    private void FileMenuClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void Export_Click(object sender, EventArgs e)
    {
      try
      {
        Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
        Workbook ExcelWorkBook;
        Worksheet ExcelWorkSheet;
        //Книга.
        ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
        //Таблица.
        ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet) ExcelWorkBook.Worksheets.get_Item(1);

        for (int i = 0; i < FileSystem.Rows.Count; i++)
        {
          for (int j = 0; j < FileSystem.ColumnCount; j++)
          {
            ExcelApp.Cells[i + 1, j + 1] = FileSystem.Rows[i].Cells[j].Value;
          }
        }

        //Вызываем нашу созданную эксельку.
        ExcelApp.Visible = true;
        ExcelApp.UserControl = true;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Что-то пошло не так.\nВозможно у вас нет Excel");
      }
    }

    private void Start_Click(object sender, EventArgs e)
    {
      Analyse.Enabled = true;
      Calc calc = new Calc();
      FileSystem.Rows.Clear();
      Output.Text = "";
      A = " ";
      B = " ";
      C = " ";
      D = " ";
      E = " ";
      F = " ";
      G = " ";
      H = " ";
      I = " ";
      J = " ";
      string start = Input.Text;
      for (int i = 0; i < 100; i++)
      {
        visited[i] = false;
      }
      string[] fileNames = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"};
      try
      {
        int countFiles = Convert.ToInt32(AmountOfFiles.Text);
      }
      catch (System.FormatException)
      {
        MessageBox.Show("Укажите количество файлов!");
        Analyse.Enabled = false;
        return;
      }

      try
      {
        var tmp = start.Split(' ');

        if (tmp.Length < 102)
        {
          int inputSize = tmp.Length;
          tmp[inputSize - 1] = "0";
          for (int i = 0; i < inputSize - 1; i++)
          {
            addreses[i] = tmp[i];
          }
        }
        else
        {
          MessageBox.Show("Входная строка была слишком длинная.\nМаксимальная длина 100.");
          return;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }

      for (int i = 0; i < 25; i++)
      {
        FileSystem.Rows.Add(i, addreses[i], i + 25, addreses[i + 25], i + 50, addreses[i + 50], i + 75,
          addreses[i + 75]);
      }


      try
      {
        for (int j = 0; j < Convert.ToInt32(AmountOfFiles.Text); j++)
        {
          switch (j)
          {
            case 0:
              Output.Text += calc.Result("A", AStart.Text, addreses, visited);
              files[j] = Output.Lines[0];
              break;
            case 1:
              Output.Text += calc.Result("B", BStart.Text, addreses, visited);
              files[j] = Output.Lines[1];
              break;
            case 2:
              Output.Text += calc.Result("C", CStart.Text, addreses, visited);
              files[j] = Output.Lines[2];
              break;
            case 3:
              Output.Text += calc.Result("D", DStart.Text, addreses, visited);
              files[j] = Output.Lines[3];
              break;
            case 4:
              Output.Text += calc.Result("E", EStart.Text, addreses, visited);
              files[j] = Output.Lines[4];
              break;
            case 5:
              Output.Text += calc.Result("F", FStart.Text, addreses, visited);
              files[j] = Output.Lines[5];
              break;
            case 6:
              Output.Text += calc.Result("G", GStart.Text, addreses, visited);
              files[j] = Output.Lines[6];
              break;
            case 7:
              Output.Text += calc.Result("H", HStart.Text, addreses, visited);
              files[j] = Output.Lines[7];
              break;
            case 8:
              Output.Text += calc.Result("I", IStart.Text, addreses, visited);
              files[j] = Output.Lines[8];
              break;
            case 9:
              Output.Text += calc.Result("J", JStart.Text, addreses, visited);
              files[j] = Output.Lines[9];
              break;
          }
        }

        for (int j = 0; j < 100; j++)
        {
          if (addreses[j] == "bad")
            visited[j] = true;
        }
        buildSystem();
      }
      catch (Exception ex)
      {
        Analyse.Enabled = false;
        MessageBox.Show(ex.Message);
      }
    }

    public void buildSystem()
    {

      for (int i = 0; i < 100; i++)
      {

        if (visited[i] == true)
        {
          if (i < 25)
          {
            FileSystem.Rows[i].Cells[1].Style.BackColor = Color.BlueViolet;
          }
          else if (i < 50)
          {
            FileSystem.Rows[i - 25].Cells[3].Style.BackColor = Color.BlueViolet;
          }
          else if (i < 75)
          {
            FileSystem.Rows[i - 50].Cells[5].Style.BackColor = Color.BlueViolet;
          }
          else if (i < 100)
          {
            FileSystem.Rows[i - 75].Cells[7].Style.BackColor = Color.BlueViolet;
          }
          //FileSystem.Update();           //обновление грида
          //Thread.Sleep(5);
        }
      }

      for (int i = 0; i < 100; i++)
      {
        if (visited[i] == false)
        {
          if (i < 25)
          {
            FileSystem.Rows[i].Cells[1].Style.BackColor = Color.LawnGreen;
          }
          else if (i < 50)
          {
            FileSystem.Rows[i - 25].Cells[3].Style.BackColor = Color.LawnGreen;
          }
          else if (i < 75)
          {
            FileSystem.Rows[i - 50].Cells[5].Style.BackColor = Color.LawnGreen;
          }
          else if (i < 100)
          {
            FileSystem.Rows[i - 75].Cells[7].Style.BackColor = Color.LawnGreen;
          }
          //FileSystem.Update();          //обновление грида
        }
        //Thread.Sleep(5);
      }

      for (int i = 0; i < 100; i++)
      {
        if (addreses[i] == "bad")
        {
          if (i < 25)
          {
            FileSystem.Rows[i].Cells[1].Style.BackColor = Color.OrangeRed;
          }
          else if (i < 50)
          {
            FileSystem.Rows[i - 25].Cells[3].Style.BackColor = Color.OrangeRed;
          }
          else if (i < 75)
          {
            FileSystem.Rows[i - 50].Cells[5].Style.BackColor = Color.OrangeRed;
          }
          else if (i < 100)
          {
            FileSystem.Rows[i - 75].Cells[7].Style.BackColor = Color.OrangeRed;
          }

          //FileSystem.Update();           //обновление грида
        }
      }
    }
    
    private void open_Click(object sender, EventArgs e) //игнорировать неправильный ввод
    {
      try
      {
        Start.Enabled = true;
        Analyse.Enabled = false;
        Input.Text = "";
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
          string filename = openFileDialog.FileName;
          string fileText = File.ReadAllText(filename);
          var tmp = fileText.Split(' ');
          int i = 0;
          while (tmp[i] != "A")
          {
            Input.Text += tmp[i] + " ";
            i++;
          }

          while (tmp[i] != "end")
          {
            if (tmp[i] == "A")
            {
              AStart.Text = tmp[i + 1];
            }
            else if (tmp[i] == "B")
            {
              BStart.Text = tmp[i + 1];
            }
            else if (tmp[i] == "C")
            {
              CStart.Text = tmp[i + 1];
            }
            else if (tmp[i] == "D")
            {
              DStart.Text = tmp[i + 1];
            }
            else if (tmp[i] == "E")
            {
              EStart.Text = tmp[i + 1];
            }
            else if (tmp[i] == "F")
            {
              FStart.Text = tmp[i + 1];
            }
            else if (tmp[i] == "G")
            {
              GStart.Text = tmp[i + 1];
            }
            else if (tmp[i] == "H")
            {
              HStart.Text = tmp[i + 1];
            }
            else if (tmp[i] == "I")
            {
              IStart.Text = tmp[i + 1];
            }
            else if (tmp[i] == "J")
            {
              JStart.Text = tmp[i + 1];
            }

            i++;
          }

          Input.Text += "end";
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Работа с введенными данными невозможна!\nПроверьте исходный файл!");
        Start.Enabled = false;
        return;
      }
    }

    private void Save_Click(object sender, EventArgs e)
    {
      var saveDialog = new SaveFileDialog
      {
        Title = "Сохранить как...",
        OverwritePrompt = true, //отображать ли предупреждение, если пользователь указывает имя уже существующего файла
        CheckPathExists = true, //отображать ли предупреждение, если пользователь указывает несуществующий путь
        Filter = "Файлы txt (*.txt)|*.txt", //список форматов файла, отображаемый в поле "Тип файла"
        ShowHelp = true  //отображается ли кнопка "Справка" в диалоговом окне
      };
      if (saveDialog.ShowDialog() == DialogResult.OK)
      {
        try
        {
          string tmp = "Результат работы программы:\n" + Output.Text;
          using (BinaryWriter writer = new BinaryWriter(File.Open(@saveDialog.FileName, FileMode.OpenOrCreate)))
          {
            writer.Write(tmp);
            MessageBox.Show("Файл сохранен успешно", "Успех", MessageBoxButtons.OK);
          }
        }
        catch
        {
          MessageBox.Show("Невозможно сохранить файл", "Ошибка",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void Analyse_Click(object sender, EventArgs e)
    {
      Analyse.Enabled = false;
      bool[] named = new bool[100];
      string[] E = new string[10];
      int fname = 1;
      int size = 10;
      int unnamedFiles = 10 - Convert.ToInt32(AmountOfFiles.Text);
      int namedFiles = 10 - unnamedFiles;
      int tmp = 1;

      for (int o = 0; o < 100; o++)
      {
        named[o] = false;
      }

      E = NotEmpty(visited, addreses, named); //поиск неименованных данных

      if (E[0] != "Empty")
      {
        Output.Text += ("Найдна неименованная часть данных. Записана под следующими именами.\n");
        for (int j = 0; j < size; j++)
        {
          if (E[j] != "Empty")
          {
            Output.Text += Convert.ToString(fname) + ": " + E[j] + "\n";
            fname++;
          }
          else
          {
            break;
          }
        }
         
        for (int i = 1; i <= unnamedFiles; i++)
        {
          files[namedFiles - 1 + tmp] = Output.Lines[Convert.ToInt32(AmountOfFiles.Text) + i];
          tmp++;
        }
      }
      else
      {
        Output.Text += ("Неименованные данные отсутствуют.\n");
      }

      IsEqual(files, addreses, visited); // поиск совпадений
      FileSystem.Rows.Clear();
      for (int i = 0; i < 25; i++)
      {
        FileSystem.Rows.Add(i, addreses[i], i + 25, addreses[i + 25], i + 50, addreses[i + 50], i + 75,
          addreses[i + 75]);
      }
      buildSystem();
    }

    public static string[] NotEmpty(bool[] visited, string[] addreses, bool[] named)
    {
      int i = 0, j = 0;
      string[] E = new string[10];
      for (int k = 0; k < 10; k++)
      {
        E[k] = "Empty";
      }
      do
      {
        var temp = i;
        if ((visited[i] == false) && (addreses[i] != "0"))
        {
          if (j < 9)
            E[j] = Convert.ToString(i);
          while ((addreses[temp] != "eof") && visited[temp] == false)
          {
            E[j] = E[j] + ' ' + addreses[temp];
            visited[temp] = true;
            temp = Convert.ToInt32(addreses[temp]);
          }
          if (addreses[temp] == "eof")
          {
            E[j] = E[j] + ' ' + "eof";
            visited[temp] = true;
            j++;
          }
        }
        i++;
      }
      while (i < 100);
      return E;
    }

    public void IsEqual(string[] files, string[] addreses, bool[] visited)
    {
      bool[] isFixed = new bool[10];
      for (int i = 0; i < 10; i++)
      {
        isFixed[i] = false;
      }

      try
      {
        Output.Text += "Найдены пересекающиеся файлы.\n";
        int temp = 0;
        for (int i = 0; i < 10; i++)
        {
          string[] tmp = files[i].Split(' ');
          int currentSize = tmp.Length;

          for (int j = 1 + temp; j < 10; j++)
          {
            for (int k = 1; k < currentSize - 1; k++) //не проверяем eof
            {
              string currentStatement = tmp[k];
              if (files[j].Contains(" " + currentStatement + " ") && isFixed[j] == false) //k-ый элемент на котором произошло совпадение находится в пеерв том файле, который сравниваем
              {
                string[] equalFile = files[j].Split(' '); //получаем совпавший файл 
                int equalSize = equalFile.Length;
                int firstIn = Array.IndexOf(equalFile,tmp[k]); //получаем индекс вхождения в файл (суть работы в том, чтобы в adresess[firstIn-1] заменить 
                Output.Text += "Новый путь к файлу " +" "; //ссылку на следующий файл заместо найденного вхождения на свободный
                for (int l = firstIn-1; l < equalSize; l++)
                {
                  int freeAddress = findFree();
                  if (l == equalSize - 2)
                  {
                    equalFile[l + 1] = "eof";
                    addreses[Convert.ToInt32(equalFile[l])] = "eof";
                    break;
                  }
                  equalFile[l+1] = Convert.ToString(freeAddress);
                  addreses[Convert.ToInt32(equalFile[l])] = Convert.ToString(freeAddress);
                }

                isFixed[j] = true;
                string findedPath ="";

                for (int b = 0; b < equalSize; b++)
                {
                  findedPath += equalFile[b] + " ";
                  Output.Text += equalFile[b] + " ";
                }

                files[j] = findedPath;
                Output.Text += "\n";
                break;
              }
            }
          }

          temp++;
        }

      }

      catch (Exception ex)
      {
        MessageBox.Show("Что-то пошло не так " + ex.Message);
      }
    }

    public int findFree()
    {
      int temp = 140;
      for (int i = 1; i < 100; i++)
      {
        if (visited[i] == false)
        {
          temp = i;
          visited[i] = true;
          return temp;
        }
        else
        {
          continue;
        }
      }
      return temp;
    }

   



    private void About_Click_1(object sender, EventArgs e)
    {
      About about = new About();
      about.Show();
    }

    private void close_Click_1(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
