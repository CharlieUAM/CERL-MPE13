﻿namespace registro
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbprodct = new System.Windows.Forms.TextBox();
            this.tbprice = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.DGVnumbers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVnumbers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "precio";
            // 
            // tbprodct
            // 
            this.tbprodct.Location = new System.Drawing.Point(360, 49);
            this.tbprodct.Name = "tbprodct";
            this.tbprodct.Size = new System.Drawing.Size(100, 20);
            this.tbprodct.TabIndex = 2;
            // 
            // tbprice
            // 
            this.tbprice.Location = new System.Drawing.Point(337, 122);
            this.tbprice.Name = "tbprice";
            this.tbprice.Size = new System.Drawing.Size(149, 20);
            this.tbprice.TabIndex = 3;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(544, 89);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // DGVnumbers
            // 
            this.DGVnumbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVnumbers.Location = new System.Drawing.Point(49, 49);
            this.DGVnumbers.Name = "DGVnumbers";
            this.DGVnumbers.Size = new System.Drawing.Size(240, 239);
            this.DGVnumbers.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVnumbers);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.tbprice);
            this.Controls.Add(this.tbprodct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Regsitro";
            ((System.ComponentModel.ISupportInitialize)(this.DGVnumbers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbprodct;
        private System.Windows.Forms.TextBox tbprice;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView DGVnumbers;
    }
}

