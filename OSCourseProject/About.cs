using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSCourseProject
{
  public partial class About : Form
  {

    private Point mouseOffset;
    private bool isMouseDown = false;

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
    public About()
    {
      InitializeComponent();
    }

    private void Close_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void About_Load(object sender, EventArgs e)
    {

    }
  }
}
