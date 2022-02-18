
namespace BasicCalculator
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
            this.btnreset = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnentre = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnpunto = new System.Windows.Forms.Button();
            this.btnpor = new System.Windows.Forms.Button();
            this.btnmenos = new System.Windows.Forms.Button();
            this.btnmas = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.txtres = new System.Windows.Forms.TextBox();
            this.txtshow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnreset.Location = new System.Drawing.Point(15, 124);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(153, 50);
            this.btnreset.TabIndex = 3;
            this.btnreset.Text = "AC";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnborrar.Location = new System.Drawing.Point(177, 124);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 50);
            this.btnborrar.TabIndex = 4;
            this.btnborrar.Text = "DEL";
            this.btnborrar.UseVisualStyleBackColor = false;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnentre
            // 
            this.btnentre.BackColor = System.Drawing.SystemColors.Control;
            this.btnentre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentre.Location = new System.Drawing.Point(258, 124);
            this.btnentre.Name = "btnentre";
            this.btnentre.Size = new System.Drawing.Size(75, 50);
            this.btnentre.TabIndex = 5;
            this.btnentre.Text = "÷";
            this.btnentre.UseVisualStyleBackColor = false;
            this.btnentre.Click += new System.EventHandler(this.btnmas_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(15, 180);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 60);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(15, 246);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 60);
            this.btn4.TabIndex = 7;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(15, 312);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 60);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(96, 180);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 60);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(96, 246);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 60);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(96, 312);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 60);
            this.btn2.TabIndex = 12;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(15, 378);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 60);
            this.btn0.TabIndex = 13;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(177, 180);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 60);
            this.btn9.TabIndex = 14;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(177, 246);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 60);
            this.btn6.TabIndex = 15;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(177, 312);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 60);
            this.btn3.TabIndex = 16;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnpunto
            // 
            this.btnpunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpunto.Location = new System.Drawing.Point(96, 378);
            this.btnpunto.Name = "btnpunto";
            this.btnpunto.Size = new System.Drawing.Size(75, 60);
            this.btnpunto.TabIndex = 17;
            this.btnpunto.Text = ".";
            this.btnpunto.UseVisualStyleBackColor = true;
            this.btnpunto.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnpor
            // 
            this.btnpor.BackColor = System.Drawing.SystemColors.Control;
            this.btnpor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpor.Location = new System.Drawing.Point(258, 180);
            this.btnpor.Name = "btnpor";
            this.btnpor.Size = new System.Drawing.Size(75, 60);
            this.btnpor.TabIndex = 18;
            this.btnpor.Text = "×";
            this.btnpor.UseVisualStyleBackColor = false;
            this.btnpor.Click += new System.EventHandler(this.btnmas_Click);
            // 
            // btnmenos
            // 
            this.btnmenos.BackColor = System.Drawing.SystemColors.Control;
            this.btnmenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenos.Location = new System.Drawing.Point(258, 246);
            this.btnmenos.Name = "btnmenos";
            this.btnmenos.Size = new System.Drawing.Size(75, 60);
            this.btnmenos.TabIndex = 19;
            this.btnmenos.Text = "-";
            this.btnmenos.UseVisualStyleBackColor = false;
            this.btnmenos.Click += new System.EventHandler(this.btnmas_Click);
            // 
            // btnmas
            // 
            this.btnmas.BackColor = System.Drawing.SystemColors.Control;
            this.btnmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmas.Location = new System.Drawing.Point(258, 312);
            this.btnmas.Name = "btnmas";
            this.btnmas.Size = new System.Drawing.Size(75, 60);
            this.btnmas.TabIndex = 20;
            this.btnmas.Text = "+";
            this.btnmas.UseVisualStyleBackColor = false;
            this.btnmas.Click += new System.EventHandler(this.btnmas_Click);
            // 
            // btnigual
            // 
            this.btnigual.BackColor = System.Drawing.SystemColors.Control;
            this.btnigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnigual.Location = new System.Drawing.Point(177, 378);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(156, 60);
            this.btnigual.TabIndex = 21;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = false;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // txtres
            // 
            this.txtres.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtres.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtres.Location = new System.Drawing.Point(15, 50);
            this.txtres.Multiline = true;
            this.txtres.Name = "txtres";
            this.txtres.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtres.Size = new System.Drawing.Size(318, 54);
            this.txtres.TabIndex = 22;
            this.txtres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtshow
            // 
            this.txtshow.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtshow.Location = new System.Drawing.Point(15, 20);
            this.txtshow.Name = "txtshow";
            this.txtshow.Size = new System.Drawing.Size(318, 30);
            this.txtshow.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(346, 450);
            this.Controls.Add(this.txtshow);
            this.Controls.Add(this.txtres);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.btnmas);
            this.Controls.Add(this.btnmenos);
            this.Controls.Add(this.btnpor);
            this.Controls.Add(this.btnpunto);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnentre);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnreset);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnentre;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnpunto;
        private System.Windows.Forms.Button btnpor;
        private System.Windows.Forms.Button btnmenos;
        private System.Windows.Forms.Button btnmas;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.TextBox txtres;
        private System.Windows.Forms.Label txtshow;
    }
}

