namespace _5
{
  partial class Form_CopyResult
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
      this.textBox_Enter = new System.Windows.Forms.TextBox();
      this.textBox_Result = new System.Windows.Forms.TextBox();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.button_OpenFile = new System.Windows.Forms.Button();
      this.comboBox2 = new System.Windows.Forms.ComboBox();
      this.button1 = new System.Windows.Forms.Button();
      this.textBox_Raktas = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // textBox_Enter
      // 
      this.textBox_Enter.Location = new System.Drawing.Point(13, 13);
      this.textBox_Enter.Multiline = true;
      this.textBox_Enter.Name = "textBox_Enter";
      this.textBox_Enter.Size = new System.Drawing.Size(278, 252);
      this.textBox_Enter.TabIndex = 0;
      this.textBox_Enter.TextChanged += new System.EventHandler(this.textBox_Enter_TextChanged);
      // 
      // textBox_Result
      // 
      this.textBox_Result.Location = new System.Drawing.Point(297, 12);
      this.textBox_Result.Multiline = true;
      this.textBox_Result.Name = "textBox_Result";
      this.textBox_Result.ReadOnly = true;
      this.textBox_Result.Size = new System.Drawing.Size(278, 252);
      this.textBox_Result.TabIndex = 1;
      // 
      // comboBox1
      // 
      this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "13",
            "12",
            "11",
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1"});
      this.comboBox1.Location = new System.Drawing.Point(532, 270);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(43, 21);
      this.comboBox1.TabIndex = 2;
      this.comboBox1.Text = "13";
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      this.comboBox1.EnabledChanged += new System.EventHandler(this.comboBox1_EnabledChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(493, 273);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(33, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "ROT";
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.DefaultExt = "txt";
      this.openFileDialog1.FileName = "openFileDialog1";
      this.openFileDialog1.Filter = "Text files (*.txt)|*.txt";
      // 
      // button_OpenFile
      // 
      this.button_OpenFile.Location = new System.Drawing.Point(13, 275);
      this.button_OpenFile.Name = "button_OpenFile";
      this.button_OpenFile.Size = new System.Drawing.Size(75, 23);
      this.button_OpenFile.TabIndex = 4;
      this.button_OpenFile.Text = "Koduoti faila";
      this.button_OpenFile.UseVisualStyleBackColor = true;
      this.button_OpenFile.Click += new System.EventHandler(this.button_OpenFile_Click);
      // 
      // comboBox2
      // 
      this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Items.AddRange(new object[] {
            "Koduoti",
            "Dekoduoti"});
      this.comboBox2.Location = new System.Drawing.Point(405, 270);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new System.Drawing.Size(82, 21);
      this.comboBox2.TabIndex = 5;
      this.comboBox2.Text = "Koduoti";
      this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(94, 275);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(89, 23);
      this.button1.TabIndex = 6;
      this.button1.Text = "Uzkrauti raktą";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // textBox_Raktas
      // 
      this.textBox_Raktas.Location = new System.Drawing.Point(13, 335);
      this.textBox_Raktas.Multiline = true;
      this.textBox_Raktas.Name = "textBox_Raktas";
      this.textBox_Raktas.Size = new System.Drawing.Size(562, 145);
      this.textBox_Raktas.TabIndex = 7;
      this.textBox_Raktas.TextChanged += new System.EventHandler(this.textBox_Raktas_TextChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(251, 307);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(78, 25);
      this.label2.TabIndex = 8;
      this.label2.Text = "Raktas";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(297, 268);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(102, 23);
      this.button2.TabIndex = 9;
      this.button2.Text = "Kopijuoti rezultatą";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // Form_CopyResult
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(591, 492);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBox_Raktas);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.comboBox2);
      this.Controls.Add(this.button_OpenFile);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.textBox_Result);
      this.Controls.Add(this.textBox_Enter);
      this.Name = "Form_CopyResult";
      this.Text = "ROT it";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox_Enter;
    private System.Windows.Forms.TextBox textBox_Result;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.Button button_OpenFile;
    private System.Windows.Forms.ComboBox comboBox2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox_Raktas;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button2;
  }
}

