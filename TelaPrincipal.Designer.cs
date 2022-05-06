
namespace MaioresValoresEntreTrês
{
    partial class TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.lblValor3 = new System.Windows.Forms.Label();
            this.numUpD1 = new System.Windows.Forms.NumericUpDown();
            this.numUpD2 = new System.Windows.Forms.NumericUpDown();
            this.numUpD3 = new System.Windows.Forms.NumericUpDown();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpD3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValor1.Location = new System.Drawing.Point(97, 158);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(55, 17);
            this.lblValor1.TabIndex = 0;
            this.lblValor1.Text = "Valor 1:";
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValor2.Location = new System.Drawing.Point(97, 202);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(55, 17);
            this.lblValor2.TabIndex = 1;
            this.lblValor2.Text = "Valor 2:";
            // 
            // lblValor3
            // 
            this.lblValor3.AutoSize = true;
            this.lblValor3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValor3.Location = new System.Drawing.Point(97, 245);
            this.lblValor3.Name = "lblValor3";
            this.lblValor3.Size = new System.Drawing.Size(55, 17);
            this.lblValor3.TabIndex = 2;
            this.lblValor3.Text = "Valor 3:";
            // 
            // numUpD1
            // 
            this.numUpD1.Location = new System.Drawing.Point(203, 158);
            this.numUpD1.Name = "numUpD1";
            this.numUpD1.Size = new System.Drawing.Size(120, 23);
            this.numUpD1.TabIndex = 3;
            // 
            // numUpD2
            // 
            this.numUpD2.Location = new System.Drawing.Point(203, 202);
            this.numUpD2.Name = "numUpD2";
            this.numUpD2.Size = new System.Drawing.Size(120, 23);
            this.numUpD2.TabIndex = 4;
            // 
            // numUpD3
            // 
            this.numUpD3.Location = new System.Drawing.Point(203, 245);
            this.numUpD3.Name = "numUpD3";
            this.numUpD3.Size = new System.Drawing.Size(120, 23);
            this.numUpD3.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Humnst777 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(82, 71);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(260, 32);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Digite Três Valores";
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(169, 294);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(75, 23);
            this.btnCalculo.TabIndex = 7;
            this.btnCalculo.Text = "Calcular";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(127, 345);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(159, 73);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.numUpD3);
            this.Controls.Add(this.numUpD2);
            this.Controls.Add(this.numUpD1);
            this.Controls.Add(this.lblValor3);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.lblValor1);
            this.Name = "TelaPrincipal";
            this.Text = "Sistema de Exibir Maior Valor entre três numeros";
            ((System.ComponentModel.ISupportInitialize)(this.numUpD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpD3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Label lblValor3;
        private System.Windows.Forms.NumericUpDown numUpD1;
        private System.Windows.Forms.NumericUpDown numUpD2;
        private System.Windows.Forms.NumericUpDown numUpD3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Label lblResultado;
    }
}

