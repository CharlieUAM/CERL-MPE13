﻿namespace metodo_de_burbuja
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbarray = new System.Windows.Forms.ListBox();
            this.TBNsort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ingrese un numero";
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(314, 25);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(186, 20);
            this.tbNumber.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(520, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbarray
            // 
            this.lbarray.FormattingEnabled = true;
            this.lbarray.Location = new System.Drawing.Point(314, 95);
            this.lbarray.Name = "lbarray";
            this.lbarray.Size = new System.Drawing.Size(186, 134);
            this.lbarray.TabIndex = 3;
            // 
            // TBNsort
            // 
            this.TBNsort.Location = new System.Drawing.Point(520, 132);
            this.TBNsort.Name = "TBNsort";
            this.TBNsort.Size = new System.Drawing.Size(75, 23);
            this.TBNsort.TabIndex = 4;
            this.TBNsort.Text = "Ordenar";
            this.TBNsort.UseVisualStyleBackColor = true;
            this.TBNsort.Click += new System.EventHandler(this.TBNsort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBNsort);
            this.Controls.Add(this.lbarray);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "metodo de burbuja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbarray;
        private System.Windows.Forms.Button TBNsort;
    }
}

