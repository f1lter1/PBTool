// Decompiled with JetBrains decompiler
// Type: WindowsFormsApplication1.Form1
// Assembly: PBConfigEditorFinalVersion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FECF613A-B781-4A56-86B6-3D0456B5E18F
// Assembly location: E:\Projetos para RZBR\ragezoneBR.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
  public class Form1 : Form
  {
    private IContainer components = (IContainer) null;
    private TextBox textBox1;
    private TextBox textBox2;
    private Button button1;
    private Button button2;
    private Button button3;
    private Label label1;
    private Label label2;
    private LinkLabel linkLabel1;
    private LinkLabel linkLabel2;
    private byte[] buf;
    private Button button4;
    private Button button5;
    private string file;

    public Form1()
    {
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.textBox2 = new System.Windows.Forms.TextBox();
        this.button1 = new System.Windows.Forms.Button();
        this.button2 = new System.Windows.Forms.Button();
        this.button3 = new System.Windows.Forms.Button();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.linkLabel1 = new System.Windows.Forms.LinkLabel();
        this.linkLabel2 = new System.Windows.Forms.LinkLabel();
        this.button4 = new System.Windows.Forms.Button();
        this.button5 = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // textBox1
        // 
        this.textBox1.BackColor = System.Drawing.Color.Black;
        this.textBox1.ForeColor = System.Drawing.Color.Yellow;
        this.textBox1.Location = new System.Drawing.Point(12, 73);
        this.textBox1.Multiline = true;
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(673, 324);
        this.textBox1.TabIndex = 0;
        this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
        // 
        // textBox2
        // 
        this.textBox2.Location = new System.Drawing.Point(12, 37);
        this.textBox2.Name = "textBox2";
        this.textBox2.Size = new System.Drawing.Size(548, 20);
        this.textBox2.TabIndex = 1;
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(566, 36);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(119, 23);
        this.button1.TabIndex = 2;
        this.button1.Text = "Abrir .Sif";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // button2
        // 
        this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
        this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.button2.Location = new System.Drawing.Point(368, 34);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(317, 23);
        this.button2.TabIndex = 3;
        this.button2.Text = "1. descriptografar .sif";
        this.button2.UseVisualStyleBackColor = false;
        this.button2.Visible = false;
        this.button2.Click += new System.EventHandler(this.button2_Click);
        // 
        // button3
        // 
        this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
        this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.button3.Location = new System.Drawing.Point(368, 34);
        this.button3.Name = "button3";
        this.button3.Size = new System.Drawing.Size(317, 23);
        this.button3.TabIndex = 4;
        this.button3.Text = "2. Salvar";
        this.button3.UseVisualStyleBackColor = false;
        this.button3.Visible = false;
        this.button3.Click += new System.EventHandler(this.button3_Click);
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(12, 9);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(202, 13);
        this.label1.TabIndex = 5;
        this.label1.Text = "Selecione um .Sif file para descriptografar";
        this.label1.Click += new System.EventHandler(this.label1_Click);
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(9, 400);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(39, 13);
        this.label2.TabIndex = 6;
        this.label2.Text = "Forum:";
        this.label2.Click += new System.EventHandler(this.label2_Click);
        // 
        // linkLabel1
        // 
        this.linkLabel1.AutoSize = true;
        this.linkLabel1.Location = new System.Drawing.Point(44, 400);
        this.linkLabel1.Name = "linkLabel1";
        this.linkLabel1.Size = new System.Drawing.Size(79, 13);
        this.linkLabel1.TabIndex = 7;
        this.linkLabel1.TabStop = true;
        this.linkLabel1.Text = "[RageZoneBR]";
        this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
        // 
        // linkLabel2
        // 
        this.linkLabel2.AutoSize = true;
        this.linkLabel2.Location = new System.Drawing.Point(635, 400);
        this.linkLabel2.Name = "linkLabel2";
        this.linkLabel2.Size = new System.Drawing.Size(51, 13);
        this.linkLabel2.TabIndex = 8;
        this.linkLabel2.TabStop = true;
        this.linkLabel2.Text = "Skelleton";
        this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
        // 
        // button4
        // 
        this.button4.Location = new System.Drawing.Point(566, 7);
        this.button4.Name = "button4";
        this.button4.Size = new System.Drawing.Size(119, 23);
        this.button4.TabIndex = 9;
        this.button4.Text = "Templete Sif";
        this.button4.UseVisualStyleBackColor = true;
        this.button4.Click += new System.EventHandler(this.button4_Click);
        // 
        // button5
        // 
        this.button5.Location = new System.Drawing.Point(441, 7);
        this.button5.Name = "button5";
        this.button5.Size = new System.Drawing.Size(119, 23);
        this.button5.TabIndex = 10;
        this.button5.Text = "Limpar";
        this.button5.UseVisualStyleBackColor = true;
        this.button5.Click += new System.EventHandler(this.button5_Click);
        // 
        // Form1
        // 
        this.ClientSize = new System.Drawing.Size(695, 417);
        this.Controls.Add(this.button5);
        this.Controls.Add(this.button4);
        this.Controls.Add(this.linkLabel2);
        this.Controls.Add(this.linkLabel1);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.button3);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.textBox2);
        this.Controls.Add(this.textBox1);
        this.MaximizeBox = false;
        this.Name = "Form1";
        this.ShowIcon = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Tool Sifer";
        this.Load += new System.EventHandler(this.Form1_Load);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    private void button1_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.textBox2.Text = this.file = openFileDialog.FileName;
      this.buf = File.ReadAllBytes(openFileDialog.FileName);
      this.textBox1.Text = File.ReadAllText(openFileDialog.FileName);
      this.textBox2.Visible = false;
      this.button1.Visible = false;
      this.label1.Text = "o arquivo selecionado: " + openFileDialog.FileName;
      this.button2.Visible = true;
      this.buf = File.ReadAllBytes(openFileDialog.FileName);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      for (int a3 = 1; a3 <= 5; ++a3)
      {
        byte num = Form1.decrypt(this.buf, this.buf.Length, a3);
        Array.Resize<byte>(ref this.buf, this.buf.Length + 1);
        this.buf[this.buf.Length - 1] = num;
      }
      this.textBox1.Text = Encoding.GetEncoding(1251).GetString(this.buf);
      this.button3.Visible = true;
      this.label1.Text = "" + this.file + " Decodificado com sucesso !";
      this.button2.Visible = false;
    }

    public static byte decrypt(byte[] a1, int a2, int a3)
    {
      byte num1 = (byte) a2;
      byte num2 = (byte) a3;
      int num3 = a2 - 1;
      int num4 = 8 - a3;
      byte num5 = a1[a2 - 1];
      while (num3 >= 0)
      {
        num1 = (byte) ((num3 > 0 ? (int) a1[num3 - 1] : (int) num5) << num4 | (int) a1[num3--] >> (int) num2);
        a1[num3 + 1] = num1;
      }
      return num1;
    }

    public static int encrypt(byte[] a1, int a2, int a3)
    {
      int num1 = a3;
      byte[] numArray = a1;
      byte num2 = a1[0];
      int num3 = 8 - a3;
      int num4 = 0;
      int num5 = 8 - a3;
      if (a2 > 0)
      {
        while (true)
        {
          int num6 = num4 >= a2 - 1 ? (int) num2 : (int) numArray[num4 + 1];
          int num7 = (int) numArray[num4++] << num1;
          numArray[num4 - 1] = (byte) (num7 | num6 >> num3);
          if (num4 < a2)
          {
            int num8 = (int) (ushort) num3 & (int) byte.MaxValue;
            int num9 = (int) (ushort) num3 >> 8;
            num3 = num5 & (int) byte.MaxValue | (num9 & (int) byte.MaxValue) << 8;
          }
          else
            break;
        }
      }
      return num4;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.buf = Encoding.Default.GetBytes(this.textBox1.Text);
      for (int a3 = 1; a3 <= 5; ++a3)
      {
        Form1.encrypt(this.buf, this.buf.Length, a3);
        Array.Resize<byte>(ref this.buf, this.buf.Length - 1);
      }
      if (File.Exists(this.file))
        File.Delete(this.file);
      File.Create(this.file).Write(this.buf, 0, this.buf.Length);
      this.label1.Text = "O: " + this.file + " - criptografado com sucesso!";
      this.textBox1.Text = ".Sif Salvo com sucesso.";
      this.button3.Visible = false;
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start("http:\\ragezone.com.br");
    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Process.Start("http:\\migre.me/pHxUt");
    }

    internal void show()
    {
        throw new NotImplementedException();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button4_Click(object sender, EventArgs e)
    {
        this.textBox1.Text ="## ServerList" + 

"[Default]" +
"UseServerSet				= \"RUSSIAN_LIVE\"	; ServerList Set" +


"[RUSSIAN_LIVE]" +
"ServerCount				= 1" +
"ServerIp00				= \"127.0.0.1\"		; GameServer;###" +


"##Skelleton";
        //this.textBox1.Clear();
    }

    private void button5_Click(object sender, EventArgs e)
    {
        this.textBox1.Clear();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
