namespace MathClass
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnLog1 = new System.Windows.Forms.Button();
            this.btnCopyFirst = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnAbs = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExp);
            this.groupBox1.Controls.Add(this.btnLog1);
            this.groupBox1.Controls.Add(this.btnCopyFirst);
            this.groupBox1.Controls.Add(this.btnLog);
            this.groupBox1.Controls.Add(this.btnPow);
            this.groupBox1.Controls.Add(this.btnSqrt);
            this.groupBox1.Controls.Add(this.btnSign);
            this.groupBox1.Controls.Add(this.btnCos);
            this.groupBox1.Controls.Add(this.btnTan);
            this.groupBox1.Controls.Add(this.btnSin);
            this.groupBox1.Controls.Add(this.btnAbs);
            this.groupBox1.Controls.Add(this.btnMax);
            this.groupBox1.Controls.Add(this.btnMin);
            this.groupBox1.Controls.Add(this.btnC);
            this.groupBox1.Location = new System.Drawing.Point(372, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnExp
            // 
            this.btnExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExp.Location = new System.Drawing.Point(15, 179);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(57, 37);
            this.btnExp.TabIndex = 12;
            this.btnExp.Text = "Exp";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnLog1
            // 
            this.btnLog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLog1.Location = new System.Drawing.Point(237, 136);
            this.btnLog1.Name = "btnLog1";
            this.btnLog1.Size = new System.Drawing.Size(57, 37);
            this.btnLog1.TabIndex = 12;
            this.btnLog1.Text = "Log1";
            this.btnLog1.UseVisualStyleBackColor = true;
            this.btnLog1.Click += new System.EventHandler(this.btnLog1_Click);
            // 
            // btnCopyFirst
            // 
            this.btnCopyFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCopyFirst.Location = new System.Drawing.Point(125, 180);
            this.btnCopyFirst.Name = "btnCopyFirst";
            this.btnCopyFirst.Size = new System.Drawing.Size(169, 37);
            this.btnCopyFirst.TabIndex = 12;
            this.btnCopyFirst.Text = "Copy First Number";
            this.btnCopyFirst.UseVisualStyleBackColor = true;
            this.btnCopyFirst.Click += new System.EventHandler(this.btnCopyFirst_Click);
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLog.Location = new System.Drawing.Point(163, 136);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(57, 37);
            this.btnLog.TabIndex = 12;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnPow
            // 
            this.btnPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPow.Location = new System.Drawing.Point(15, 136);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(57, 37);
            this.btnPow.TabIndex = 12;
            this.btnPow.Text = "Pow";
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.btnPow_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSqrt.Location = new System.Drawing.Point(88, 136);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(57, 37);
            this.btnSqrt.TabIndex = 12;
            this.btnSqrt.Text = "Sqrt";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnSign
            // 
            this.btnSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSign.Location = new System.Drawing.Point(15, 91);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(57, 37);
            this.btnSign.TabIndex = 11;
            this.btnSign.Text = "Sign";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnCos
            // 
            this.btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCos.Location = new System.Drawing.Point(163, 91);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(57, 37);
            this.btnCos.TabIndex = 10;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnTan
            // 
            this.btnTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTan.Location = new System.Drawing.Point(237, 91);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(57, 37);
            this.btnTan.TabIndex = 9;
            this.btnTan.Text = "Tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnSin
            // 
            this.btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSin.Location = new System.Drawing.Point(88, 91);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(57, 37);
            this.btnSin.TabIndex = 8;
            this.btnSin.Text = "Sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnAbs
            // 
            this.btnAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAbs.Location = new System.Drawing.Point(237, 48);
            this.btnAbs.Name = "btnAbs";
            this.btnAbs.Size = new System.Drawing.Size(57, 37);
            this.btnAbs.TabIndex = 7;
            this.btnAbs.Text = "Abs";
            this.btnAbs.UseVisualStyleBackColor = true;
            this.btnAbs.Click += new System.EventHandler(this.btnAbs_Click);
            // 
            // btnMax
            // 
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMax.Location = new System.Drawing.Point(163, 48);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(57, 37);
            this.btnMax.TabIndex = 6;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMin.Location = new System.Drawing.Point(88, 48);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(57, 37);
            this.btnMin.TabIndex = 5;
            this.btnMin.Text = "Min";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnC.Location = new System.Drawing.Point(15, 48);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(57, 37);
            this.btnC.TabIndex = 4;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirstNumber.Location = new System.Drawing.Point(211, 95);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(129, 30);
            this.txtFirstNumber.TabIndex = 1;
            this.txtFirstNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstNumber_KeyPress);
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSecondNumber.Location = new System.Drawing.Point(211, 151);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(129, 30);
            this.txtSecondNumber.TabIndex = 2;
            this.txtSecondNumber.TextChanged += new System.EventHandler(this.txtSecondNumber_TextChanged);
            this.txtSecondNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecondNumber_keyPress);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtResult.Location = new System.Drawing.Point(211, 239);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(129, 30);
            this.txtResult.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Second Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(53, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSecondNumber);
            this.Controls.Add(this.txtFirstNumber);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnLog1;
        private System.Windows.Forms.Button btnCopyFirst;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnAbs;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnC;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

