namespace SP_Lab4
{
  partial class Form1
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
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.opFileBt = new System.Windows.Forms.Button();
      this.calculateBt = new System.Windows.Forms.Button();
      this.createBt = new System.Windows.Forms.Button();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // opFileBt
      // 
      this.opFileBt.Location = new System.Drawing.Point(12, 387);
      this.opFileBt.Name = "opFileBt";
      this.opFileBt.Size = new System.Drawing.Size(133, 51);
      this.opFileBt.TabIndex = 0;
      this.opFileBt.Text = "Open File";
      this.opFileBt.UseVisualStyleBackColor = true;
      this.opFileBt.Click += new System.EventHandler(this.opFileBt_Click);
      // 
      // calculateBt
      // 
      this.calculateBt.Location = new System.Drawing.Point(168, 387);
      this.calculateBt.Name = "calculateBt";
      this.calculateBt.Size = new System.Drawing.Size(133, 51);
      this.calculateBt.TabIndex = 1;
      this.calculateBt.Text = "Calculate and Save";
      this.calculateBt.UseVisualStyleBackColor = true;
      this.calculateBt.Click += new System.EventHandler(this.calculateBt_Click);
      // 
      // createBt
      // 
      this.createBt.Location = new System.Drawing.Point(325, 387);
      this.createBt.Name = "createBt";
      this.createBt.Size = new System.Drawing.Size(133, 51);
      this.createBt.TabIndex = 2;
      this.createBt.Text = "Create File";
      this.createBt.UseVisualStyleBackColor = true;
      this.createBt.Click += new System.EventHandler(this.createBt_Click);
      // 
      // richTextBox1
      // 
      this.richTextBox1.Location = new System.Drawing.Point(12, 12);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(446, 357);
      this.richTextBox1.TabIndex = 3;
      this.richTextBox1.Text = "";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(469, 450);
      this.Controls.Add(this.richTextBox1);
      this.Controls.Add(this.createBt);
      this.Controls.Add(this.calculateBt);
      this.Controls.Add(this.opFileBt);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button calculateBt;
    private System.Windows.Forms.Button createBt;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.Button opFileBt;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;

    #endregion
  }
}

