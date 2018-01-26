namespace p5
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
            this.grpPerson = new System.Windows.Forms.GroupBox();
            this.txtBirthYr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.grpPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPerson
            // 
            this.grpPerson.Controls.Add(this.txtBirthYr);
            this.grpPerson.Controls.Add(this.label4);
            this.grpPerson.Controls.Add(this.txtGender);
            this.grpPerson.Controls.Add(this.label3);
            this.grpPerson.Controls.Add(this.txtAge);
            this.grpPerson.Controls.Add(this.label2);
            this.grpPerson.Controls.Add(this.txtName);
            this.grpPerson.Controls.Add(this.label1);
            this.grpPerson.Location = new System.Drawing.Point(16, 15);
            this.grpPerson.Margin = new System.Windows.Forms.Padding(4);
            this.grpPerson.Name = "grpPerson";
            this.grpPerson.Padding = new System.Windows.Forms.Padding(4);
            this.grpPerson.Size = new System.Drawing.Size(421, 204);
            this.grpPerson.TabIndex = 11;
            this.grpPerson.TabStop = false;
            this.grpPerson.Text = "Record : 0 / 0";
            // 
            // txtBirthYr
            // 
            this.txtBirthYr.Location = new System.Drawing.Point(147, 158);
            this.txtBirthYr.Margin = new System.Windows.Forms.Padding(4);
            this.txtBirthYr.Name = "txtBirthYr";
            this.txtBirthYr.Size = new System.Drawing.Size(260, 22);
            this.txtBirthYr.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Birth Year :";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(147, 117);
            this.txtGender.Margin = new System.Windows.Forms.Padding(4);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(260, 22);
            this.txtGender.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gender :";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(147, 70);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Name = "txtAge";
            this.txtAge.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAge.Size = new System.Drawing.Size(260, 22);
            this.txtAge.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Age :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(147, 23);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 22);
            this.txtName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name :";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(129, 249);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(63, 49);
            this.btnPrevious.TabIndex = 10;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(227, 249);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(63, 49);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(297, 249);
            this.btnLast.Margin = new System.Windows.Forms.Padding(4);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(63, 49);
            this.btnLast.TabIndex = 8;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(59, 249);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(63, 49);
            this.btnFirst.TabIndex = 7;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(35, 317);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            this.lblStatus.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Average Age of Males";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(470, 85);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(61, 17);
            this.lblAverage.TabIndex = 14;
            this.lblAverage.Text = "Average";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 364);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.grpPerson);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Prac5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPerson.ResumeLayout(false);
            this.grpPerson.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.GroupBox grpPerson;
  private System.Windows.Forms.TextBox txtGender;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.TextBox txtAge;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.TextBox txtName;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Button btnPrevious;
  private System.Windows.Forms.Button btnNext;
  private System.Windows.Forms.Button btnLast;
  private System.Windows.Forms.Button btnFirst;
  private System.Windows.Forms.TextBox txtBirthYr;
  private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAverage;
    }
}

