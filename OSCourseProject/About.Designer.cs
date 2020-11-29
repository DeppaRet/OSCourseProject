namespace OSCourseProject
{
  partial class About
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
      this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
      this.gunaAnimateWindow1 = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
      this.Close = new Guna.UI.WinForms.GunaCircleButton();
      this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
      this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
      this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
      this.SuspendLayout();
      // 
      // gunaElipse1
      // 
      this.gunaElipse1.Radius = 20;
      this.gunaElipse1.TargetControl = this;
      // 
      // gunaAnimateWindow1
      // 
      this.gunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;
      this.gunaAnimateWindow1.Interval = 100;
      this.gunaAnimateWindow1.TargetControl = null;
      // 
      // Close
      // 
      this.Close.AnimationHoverSpeed = 0.07F;
      this.Close.AnimationSpeed = 0.03F;
      this.Close.BaseColor = System.Drawing.Color.Red;
      this.Close.BorderColor = System.Drawing.Color.Black;
      this.Close.DialogResult = System.Windows.Forms.DialogResult.None;
      this.Close.FocusedColor = System.Drawing.Color.Empty;
      this.Close.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.Close.ForeColor = System.Drawing.Color.White;
      this.Close.Image = null;
      this.Close.ImageSize = new System.Drawing.Size(52, 52);
      this.Close.Location = new System.Drawing.Point(413, 12);
      this.Close.Name = "Close";
      this.Close.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
      this.Close.OnHoverBorderColor = System.Drawing.Color.Black;
      this.Close.OnHoverForeColor = System.Drawing.Color.White;
      this.Close.OnHoverImage = null;
      this.Close.OnPressedColor = System.Drawing.Color.Black;
      this.Close.Size = new System.Drawing.Size(22, 22);
      this.Close.TabIndex = 0;
      this.Close.Text = "x";
      this.Close.Click += new System.EventHandler(this.Close_Click);
      // 
      // gunaDragControl1
      // 
      this.gunaDragControl1.TargetControl = this;
      // 
      // gunaLabel1
      // 
      this.gunaLabel1.AutoSize = true;
      this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.gunaLabel1.Location = new System.Drawing.Point(7, 37);
      this.gunaLabel1.Name = "gunaLabel1";
      this.gunaLabel1.Size = new System.Drawing.Size(428, 105);
      this.gunaLabel1.TabIndex = 1;
      this.gunaLabel1.Text = resources.GetString("gunaLabel1.Text");
      // 
      // gunaDragControl2
      // 
      this.gunaDragControl2.TargetControl = this.gunaLabel1;
      // 
      // About
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.NavajoWhite;
      this.ClientSize = new System.Drawing.Size(447, 163);
      this.Controls.Add(this.gunaLabel1);
      this.Controls.Add(this.Close);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "About";
      this.Text = "About";
      this.Load += new System.EventHandler(this.About_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Guna.UI.WinForms.GunaElipse gunaElipse1;
    private Guna.UI.WinForms.GunaAnimateWindow gunaAnimateWindow1;
    private Guna.UI.WinForms.GunaCircleButton Close;
    private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    private Guna.UI.WinForms.GunaLabel gunaLabel1;
    private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
  }
}