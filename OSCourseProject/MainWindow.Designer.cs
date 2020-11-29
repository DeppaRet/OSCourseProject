namespace OSCourseProject
{
  partial class MainWindow
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
      this.label1 = new System.Windows.Forms.Label();
      this.AmountOfFiles = new System.Windows.Forms.ComboBox();
      this.Input = new System.Windows.Forms.RichTextBox();
      this.Start = new System.Windows.Forms.Button();
      this.FileSystem = new System.Windows.Forms.DataGridView();
      this.first25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.first25Link = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.second25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.second25Link = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.third25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.third25Link = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fourth25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fourth25Link = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.open = new System.Windows.Forms.Button();
      this.AStart = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.BStart = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.CStart = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.DStart = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.EStart = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.FStart = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.GStart = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.HStart = new System.Windows.Forms.TextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.IStart = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.JStart = new System.Windows.Forms.TextBox();
      this.label13 = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.Output = new System.Windows.Forms.RichTextBox();
      this.Save = new System.Windows.Forms.Button();
      this.Analyse = new System.Windows.Forms.Button();
      this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
      this.close = new Guna.UI.WinForms.GunaCircleButton();
      this.About = new Guna.UI.WinForms.GunaCircleButton();
      this.Export = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.FileSystem)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Location = new System.Drawing.Point(16, 35);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(269, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Укажите количество известных файлов в системе:";
      // 
      // AmountOfFiles
      // 
      this.AmountOfFiles.FormattingEnabled = true;
      this.AmountOfFiles.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
      this.AmountOfFiles.Location = new System.Drawing.Point(288, 32);
      this.AmountOfFiles.Name = "AmountOfFiles";
      this.AmountOfFiles.Size = new System.Drawing.Size(54, 21);
      this.AmountOfFiles.TabIndex = 2;
      // 
      // Input
      // 
      this.Input.Location = new System.Drawing.Point(19, 61);
      this.Input.Name = "Input";
      this.Input.Size = new System.Drawing.Size(389, 135);
      this.Input.TabIndex = 3;
      this.Input.Text = "";
      // 
      // Start
      // 
      this.Start.Location = new System.Drawing.Point(416, 32);
      this.Start.Name = "Start";
      this.Start.Size = new System.Drawing.Size(73, 22);
      this.Start.TabIndex = 4;
      this.Start.Text = "Построить";
      this.Start.UseVisualStyleBackColor = true;
      this.Start.Click += new System.EventHandler(this.Start_Click);
      // 
      // FileSystem
      // 
      this.FileSystem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.FileSystem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.FileSystem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.first25,
            this.first25Link,
            this.second25,
            this.second25Link,
            this.third25,
            this.third25Link,
            this.fourth25,
            this.fourth25Link});
      this.FileSystem.Location = new System.Drawing.Point(418, 60);
      this.FileSystem.Name = "FileSystem";
      this.FileSystem.Size = new System.Drawing.Size(447, 476);
      this.FileSystem.TabIndex = 6;
      // 
      // first25
      // 
      dataGridViewCellStyle5.BackColor = System.Drawing.Color.PeachPuff;
      this.first25.DefaultCellStyle = dataGridViewCellStyle5;
      this.first25.HeaderText = "№";
      this.first25.Name = "first25";
      // 
      // first25Link
      // 
      this.first25Link.HeaderText = "Ссылка";
      this.first25Link.Name = "first25Link";
      // 
      // second25
      // 
      dataGridViewCellStyle6.BackColor = System.Drawing.Color.PeachPuff;
      this.second25.DefaultCellStyle = dataGridViewCellStyle6;
      this.second25.HeaderText = "№";
      this.second25.Name = "second25";
      // 
      // second25Link
      // 
      this.second25Link.HeaderText = "Ссылка";
      this.second25Link.Name = "second25Link";
      // 
      // third25
      // 
      dataGridViewCellStyle7.BackColor = System.Drawing.Color.PeachPuff;
      this.third25.DefaultCellStyle = dataGridViewCellStyle7;
      this.third25.HeaderText = "№";
      this.third25.Name = "third25";
      // 
      // third25Link
      // 
      this.third25Link.HeaderText = "Ссылка";
      this.third25Link.Name = "third25Link";
      // 
      // fourth25
      // 
      dataGridViewCellStyle8.BackColor = System.Drawing.Color.PeachPuff;
      this.fourth25.DefaultCellStyle = dataGridViewCellStyle8;
      this.fourth25.HeaderText = "№";
      this.fourth25.Name = "fourth25";
      // 
      // fourth25Link
      // 
      this.fourth25Link.HeaderText = "Ссылка";
      this.fourth25Link.Name = "fourth25Link";
      // 
      // open
      // 
      this.open.Location = new System.Drawing.Point(348, 32);
      this.open.Name = "open";
      this.open.Size = new System.Drawing.Size(60, 23);
      this.open.TabIndex = 8;
      this.open.Text = "Открыть";
      this.open.UseVisualStyleBackColor = true;
      this.open.Click += new System.EventHandler(this.open_Click);
      // 
      // AStart
      // 
      this.AStart.Enabled = false;
      this.AStart.Location = new System.Drawing.Point(41, 264);
      this.AStart.Name = "AStart";
      this.AStart.Size = new System.Drawing.Size(31, 20);
      this.AStart.TabIndex = 9;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.Location = new System.Drawing.Point(18, 267);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(17, 13);
      this.label2.TabIndex = 10;
      this.label2.Text = "A:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.BackColor = System.Drawing.Color.Transparent;
      this.label3.Location = new System.Drawing.Point(18, 248);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(134, 13);
      this.label3.TabIndex = 11;
      this.label3.Text = "Укажите начало файлов:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.BackColor = System.Drawing.Color.Transparent;
      this.label4.Location = new System.Drawing.Point(77, 267);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(17, 13);
      this.label4.TabIndex = 13;
      this.label4.Text = "B:";
      // 
      // BStart
      // 
      this.BStart.Enabled = false;
      this.BStart.Location = new System.Drawing.Point(100, 264);
      this.BStart.Name = "BStart";
      this.BStart.Size = new System.Drawing.Size(31, 20);
      this.BStart.TabIndex = 12;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.BackColor = System.Drawing.Color.Transparent;
      this.label5.Location = new System.Drawing.Point(141, 267);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(17, 13);
      this.label5.TabIndex = 15;
      this.label5.Text = "C:";
      // 
      // CStart
      // 
      this.CStart.Enabled = false;
      this.CStart.Location = new System.Drawing.Point(164, 264);
      this.CStart.Name = "CStart";
      this.CStart.Size = new System.Drawing.Size(31, 20);
      this.CStart.TabIndex = 14;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.BackColor = System.Drawing.Color.Transparent;
      this.label6.Location = new System.Drawing.Point(203, 267);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(18, 13);
      this.label6.TabIndex = 17;
      this.label6.Text = "D:";
      // 
      // DStart
      // 
      this.DStart.Enabled = false;
      this.DStart.Location = new System.Drawing.Point(226, 264);
      this.DStart.Name = "DStart";
      this.DStart.Size = new System.Drawing.Size(31, 20);
      this.DStart.TabIndex = 16;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.BackColor = System.Drawing.Color.Transparent;
      this.label7.Location = new System.Drawing.Point(265, 267);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(17, 13);
      this.label7.TabIndex = 19;
      this.label7.Text = "E:";
      // 
      // EStart
      // 
      this.EStart.Enabled = false;
      this.EStart.Location = new System.Drawing.Point(288, 264);
      this.EStart.Name = "EStart";
      this.EStart.Size = new System.Drawing.Size(31, 20);
      this.EStart.TabIndex = 18;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.BackColor = System.Drawing.Color.Transparent;
      this.label8.Location = new System.Drawing.Point(18, 293);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(16, 13);
      this.label8.TabIndex = 21;
      this.label8.Text = "F:";
      // 
      // FStart
      // 
      this.FStart.Enabled = false;
      this.FStart.Location = new System.Drawing.Point(41, 290);
      this.FStart.Name = "FStart";
      this.FStart.Size = new System.Drawing.Size(31, 20);
      this.FStart.TabIndex = 20;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.BackColor = System.Drawing.Color.Transparent;
      this.label9.Location = new System.Drawing.Point(77, 293);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(18, 13);
      this.label9.TabIndex = 23;
      this.label9.Text = "G:";
      // 
      // GStart
      // 
      this.GStart.Enabled = false;
      this.GStart.Location = new System.Drawing.Point(100, 290);
      this.GStart.Name = "GStart";
      this.GStart.Size = new System.Drawing.Size(31, 20);
      this.GStart.TabIndex = 22;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.BackColor = System.Drawing.Color.Transparent;
      this.label10.Location = new System.Drawing.Point(141, 293);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(18, 13);
      this.label10.TabIndex = 25;
      this.label10.Text = "H:";
      // 
      // HStart
      // 
      this.HStart.Enabled = false;
      this.HStart.Location = new System.Drawing.Point(164, 290);
      this.HStart.Name = "HStart";
      this.HStart.Size = new System.Drawing.Size(31, 20);
      this.HStart.TabIndex = 24;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.BackColor = System.Drawing.Color.Transparent;
      this.label11.Location = new System.Drawing.Point(203, 293);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(13, 13);
      this.label11.TabIndex = 27;
      this.label11.Text = "I:";
      // 
      // IStart
      // 
      this.IStart.Enabled = false;
      this.IStart.Location = new System.Drawing.Point(226, 290);
      this.IStart.Name = "IStart";
      this.IStart.Size = new System.Drawing.Size(31, 20);
      this.IStart.TabIndex = 26;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.BackColor = System.Drawing.Color.Transparent;
      this.label12.Location = new System.Drawing.Point(265, 293);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(15, 13);
      this.label12.TabIndex = 29;
      this.label12.Text = "J:";
      // 
      // JStart
      // 
      this.JStart.Enabled = false;
      this.JStart.Location = new System.Drawing.Point(288, 290);
      this.JStart.Name = "JStart";
      this.JStart.Size = new System.Drawing.Size(31, 20);
      this.JStart.TabIndex = 28;
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.BackColor = System.Drawing.Color.Transparent;
      this.label13.Location = new System.Drawing.Point(16, 212);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(288, 26);
      this.label13.TabIndex = 30;
      this.label13.Text = "В исходном файле первым указывается файл А. \r\nВ конце файла указывается специальн" +
    "ая метка \"end\".\r\n";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.BackColor = System.Drawing.Color.Transparent;
      this.label14.Location = new System.Drawing.Point(20, 324);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(62, 13);
      this.label14.TabIndex = 31;
      this.label14.Text = "Результат:";
      // 
      // Output
      // 
      this.Output.Location = new System.Drawing.Point(23, 340);
      this.Output.Name = "Output";
      this.Output.Size = new System.Drawing.Size(389, 171);
      this.Output.TabIndex = 32;
      this.Output.Text = "";
      // 
      // Save
      // 
      this.Save.Location = new System.Drawing.Point(337, 517);
      this.Save.Name = "Save";
      this.Save.Size = new System.Drawing.Size(75, 20);
      this.Save.TabIndex = 33;
      this.Save.Text = "Сохранить";
      this.Save.UseVisualStyleBackColor = true;
      this.Save.Click += new System.EventHandler(this.Save_Click);
      // 
      // Analyse
      // 
      this.Analyse.Enabled = false;
      this.Analyse.Location = new System.Drawing.Point(333, 290);
      this.Analyse.Name = "Analyse";
      this.Analyse.Size = new System.Drawing.Size(75, 22);
      this.Analyse.TabIndex = 34;
      this.Analyse.Text = "Анализ";
      this.Analyse.UseVisualStyleBackColor = true;
      this.Analyse.Click += new System.EventHandler(this.Analyse_Click);
      // 
      // gunaElipse1
      // 
      this.gunaElipse1.Radius = 80;
      this.gunaElipse1.TargetControl = this;
      // 
      // close
      // 
      this.close.Animated = true;
      this.close.AnimationHoverSpeed = 0.07F;
      this.close.AnimationSpeed = 0.03F;
      this.close.BaseColor = System.Drawing.Color.Red;
      this.close.BorderColor = System.Drawing.Color.Black;
      this.close.DialogResult = System.Windows.Forms.DialogResult.None;
      this.close.FocusedColor = System.Drawing.Color.Empty;
      this.close.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.close.ForeColor = System.Drawing.Color.White;
      this.close.Image = null;
      this.close.ImageSize = new System.Drawing.Size(52, 52);
      this.close.Location = new System.Drawing.Point(843, 12);
      this.close.Name = "close";
      this.close.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
      this.close.OnHoverBorderColor = System.Drawing.Color.Black;
      this.close.OnHoverForeColor = System.Drawing.Color.White;
      this.close.OnHoverImage = null;
      this.close.OnPressedColor = System.Drawing.Color.Black;
      this.close.Size = new System.Drawing.Size(22, 22);
      this.close.TabIndex = 36;
      this.close.Text = "x";
      this.close.Click += new System.EventHandler(this.close_Click_1);
      // 
      // About
      // 
      this.About.AnimationHoverSpeed = 0.07F;
      this.About.AnimationSpeed = 0.03F;
      this.About.BaseColor = System.Drawing.Color.Yellow;
      this.About.BorderColor = System.Drawing.Color.Black;
      this.About.DialogResult = System.Windows.Forms.DialogResult.None;
      this.About.FocusedColor = System.Drawing.Color.Empty;
      this.About.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.About.ForeColor = System.Drawing.Color.Black;
      this.About.Image = null;
      this.About.ImageSize = new System.Drawing.Size(52, 52);
      this.About.Location = new System.Drawing.Point(815, 12);
      this.About.Name = "About";
      this.About.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
      this.About.OnHoverBorderColor = System.Drawing.Color.Black;
      this.About.OnHoverForeColor = System.Drawing.Color.White;
      this.About.OnHoverImage = null;
      this.About.OnPressedColor = System.Drawing.Color.Black;
      this.About.Size = new System.Drawing.Size(22, 22);
      this.About.TabIndex = 37;
      this.About.Text = "?";
      this.About.Click += new System.EventHandler(this.About_Click_1);
      // 
      // Export
      // 
      this.Export.Location = new System.Drawing.Point(694, 32);
      this.Export.Name = "Export";
      this.Export.Size = new System.Drawing.Size(75, 21);
      this.Export.TabIndex = 38;
      this.Export.Text = "Экспорт";
      this.Export.UseVisualStyleBackColor = true;
      this.Export.Click += new System.EventHandler(this.Export_Click);
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.NavajoWhite;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.ClientSize = new System.Drawing.Size(906, 564);
      this.Controls.Add(this.Export);
      this.Controls.Add(this.About);
      this.Controls.Add(this.close);
      this.Controls.Add(this.Analyse);
      this.Controls.Add(this.Save);
      this.Controls.Add(this.Output);
      this.Controls.Add(this.label14);
      this.Controls.Add(this.label13);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.JStart);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.IStart);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.HStart);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.GStart);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.FStart);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.EStart);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.DStart);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.CStart);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.BStart);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.AStart);
      this.Controls.Add(this.open);
      this.Controls.Add(this.FileSystem);
      this.Controls.Add(this.Start);
      this.Controls.Add(this.Input);
      this.Controls.Add(this.AmountOfFiles);
      this.Controls.Add(this.label1);
      this.DoubleBuffered = true;
      this.ForeColor = System.Drawing.SystemColors.ControlText;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "MainWindow";
      this.Text = "MainWindow";
      this.TransparencyKey = System.Drawing.Color.Maroon;
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
      this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
      this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
      ((System.ComponentModel.ISupportInitialize)(this.FileSystem)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox AmountOfFiles;
    private System.Windows.Forms.RichTextBox Input;
    private System.Windows.Forms.Button Start;
    private System.Windows.Forms.DataGridView FileSystem;
    private System.Windows.Forms.Button open;
    private System.Windows.Forms.TextBox AStart;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox BStart;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox CStart;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox DStart;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox EStart;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox FStart;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox GStart;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox HStart;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox IStart;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.TextBox JStart;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.RichTextBox Output;
    private System.Windows.Forms.Button Save;
    private System.Windows.Forms.Button Analyse;
    private System.Windows.Forms.DataGridViewTextBoxColumn first25;
    private System.Windows.Forms.DataGridViewTextBoxColumn first25Link;
    private System.Windows.Forms.DataGridViewTextBoxColumn second25;
    private System.Windows.Forms.DataGridViewTextBoxColumn second25Link;
    private System.Windows.Forms.DataGridViewTextBoxColumn third25;
    private System.Windows.Forms.DataGridViewTextBoxColumn third25Link;
    private System.Windows.Forms.DataGridViewTextBoxColumn fourth25;
    private System.Windows.Forms.DataGridViewTextBoxColumn fourth25Link;
    private Guna.UI.WinForms.GunaElipse gunaElipse1;
    private Guna.UI.WinForms.GunaCircleButton About;
    private Guna.UI.WinForms.GunaCircleButton close;
    private System.Windows.Forms.Button Export;
  }
}

