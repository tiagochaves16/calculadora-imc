
namespace Projeto_Calculadora_IMC
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.MaskedTextBox();
            this.txtA = new System.Windows.Forms.MaskedTextBox();
            this.txtInfoP = new System.Windows.Forms.Label();
            this.txtInfoA = new System.Windows.Forms.Label();
            this.btmLimpa = new System.Windows.Forms.Button();
            this.lblResul = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.p4 = new System.Windows.Forms.PictureBox();
            this.p5 = new System.Windows.Forms.PictureBox();
            this.p6 = new System.Windows.Forms.PictureBox();
            this.pb = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalc.Location = new System.Drawing.Point(46, 136);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(295, 46);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(38, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Peso";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(238, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Altura";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtP
            // 
            this.txtP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP.Location = new System.Drawing.Point(43, 77);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(100, 38);
            this.txtP.TabIndex = 7;
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(238, 77);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 38);
            this.txtA.TabIndex = 8;
            // 
            // txtInfoP
            // 
            this.txtInfoP.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtInfoP.Location = new System.Drawing.Point(238, 53);
            this.txtInfoP.Name = "txtInfoP";
            this.txtInfoP.Size = new System.Drawing.Size(100, 21);
            this.txtInfoP.TabIndex = 9;
            this.txtInfoP.Text = "(ex: 1,70)";
            this.txtInfoP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInfoA
            // 
            this.txtInfoA.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoA.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtInfoA.Location = new System.Drawing.Point(43, 50);
            this.txtInfoA.Name = "txtInfoA";
            this.txtInfoA.Size = new System.Drawing.Size(100, 21);
            this.txtInfoA.TabIndex = 10;
            this.txtInfoA.Text = "(ex:  69,2)";
            this.txtInfoA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btmLimpa
            // 
            this.btmLimpa.BackColor = System.Drawing.Color.OrangeRed;
            this.btmLimpa.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmLimpa.ForeColor = System.Drawing.Color.White;
            this.btmLimpa.Location = new System.Drawing.Point(41, 191);
            this.btmLimpa.Name = "btmLimpa";
            this.btmLimpa.Size = new System.Drawing.Size(102, 46);
            this.btmLimpa.TabIndex = 11;
            this.btmLimpa.Text = "Limpar";
            this.btmLimpa.UseVisualStyleBackColor = false;
            this.btmLimpa.Click += new System.EventHandler(this.btmLimpa_Click);
            // 
            // lblResul
            // 
            this.lblResul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResul.Location = new System.Drawing.Point(43, 255);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(295, 90);
            this.lblResul.TabIndex = 17;
            this.lblResul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p1
            // 
            this.p1.Image = ((System.Drawing.Image)(resources.GetObject("p1.Image")));
            this.p1.Location = new System.Drawing.Point(471, 12);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(76, 297);
            this.p1.TabIndex = 19;
            this.p1.TabStop = false;
            // 
            // p2
            // 
            this.p2.Image = ((System.Drawing.Image)(resources.GetObject("p2.Image")));
            this.p2.Location = new System.Drawing.Point(471, 12);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(74, 297);
            this.p2.TabIndex = 20;
            this.p2.TabStop = false;
            // 
            // p3
            // 
            this.p3.Image = ((System.Drawing.Image)(resources.GetObject("p3.Image")));
            this.p3.Location = new System.Drawing.Point(473, 12);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(74, 297);
            this.p3.TabIndex = 21;
            this.p3.TabStop = false;
            // 
            // p4
            // 
            this.p4.Image = ((System.Drawing.Image)(resources.GetObject("p4.Image")));
            this.p4.Location = new System.Drawing.Point(465, 12);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(82, 297);
            this.p4.TabIndex = 22;
            this.p4.TabStop = false;
            // 
            // p5
            // 
            this.p5.Image = ((System.Drawing.Image)(resources.GetObject("p5.Image")));
            this.p5.Location = new System.Drawing.Point(465, 12);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(92, 297);
            this.p5.TabIndex = 23;
            this.p5.TabStop = false;
            // 
            // p6
            // 
            this.p6.Image = ((System.Drawing.Image)(resources.GetObject("p6.Image")));
            this.p6.Location = new System.Drawing.Point(465, 12);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(119, 305);
            this.p6.TabIndex = 24;
            this.p6.TabStop = false;
            // 
            // pb
            // 
            this.pb.Image = ((System.Drawing.Image)(resources.GetObject("pb.Image")));
            this.pb.Location = new System.Drawing.Point(427, 12);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(199, 330);
            this.pb.TabIndex = 25;
            this.pb.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnFechar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(236, 191);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(102, 46);
            this.btnFechar.TabIndex = 26;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(655, 370);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.p6);
            this.Controls.Add(this.p5);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.lblResul);
            this.Controls.Add(this.btmLimpa);
            this.Controls.Add(this.txtInfoA);
            this.Controls.Add(this.txtInfoP);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora de IMC";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtP;
        private System.Windows.Forms.MaskedTextBox txtA;
        private System.Windows.Forms.Label txtInfoP;
        private System.Windows.Forms.Label txtInfoA;
        private System.Windows.Forms.Button btmLimpa;
        private System.Windows.Forms.Label lblResul;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.PictureBox p4;
        private System.Windows.Forms.PictureBox p5;
        private System.Windows.Forms.PictureBox p6;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Button btnFechar;
    }
}

