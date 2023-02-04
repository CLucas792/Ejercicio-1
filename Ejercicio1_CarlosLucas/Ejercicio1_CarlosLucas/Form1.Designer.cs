namespace Ejercicio1_CarlosLucas
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
            this.components = new System.ComponentModel.Container();
            this.Ingreselabel = new System.Windows.Forms.Label();
            this.NumerotextBox = new System.Windows.Forms.TextBox();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Informacionlabel = new System.Windows.Forms.Label();
            this.Parlabel = new System.Windows.Forms.Label();
            this.Positivolabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ingreselabel
            // 
            this.Ingreselabel.AutoSize = true;
            this.Ingreselabel.Location = new System.Drawing.Point(12, 33);
            this.Ingreselabel.Name = "Ingreselabel";
            this.Ingreselabel.Size = new System.Drawing.Size(143, 16);
            this.Ingreselabel.TabIndex = 0;
            this.Ingreselabel.Text = "Ingrese un valor entero";
            // 
            // NumerotextBox
            // 
            this.NumerotextBox.Location = new System.Drawing.Point(162, 33);
            this.NumerotextBox.Name = "NumerotextBox";
            this.NumerotextBox.Size = new System.Drawing.Size(132, 22);
            this.NumerotextBox.TabIndex = 1;
            this.NumerotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumerotextBox_KeyPress);
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Location = new System.Drawing.Point(15, 61);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(373, 42);
            this.Calcularbutton.TabIndex = 2;
            this.Calcularbutton.Text = "Determinar características del numero";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Característica 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Característica 2:";
            // 
            // Informacionlabel
            // 
            this.Informacionlabel.AutoSize = true;
            this.Informacionlabel.Location = new System.Drawing.Point(22, 116);
            this.Informacionlabel.Name = "Informacionlabel";
            this.Informacionlabel.Size = new System.Drawing.Size(232, 16);
            this.Informacionlabel.TabIndex = 5;
            this.Informacionlabel.Text = "                                                                           ";
            // 
            // Parlabel
            // 
            this.Parlabel.AutoSize = true;
            this.Parlabel.Location = new System.Drawing.Point(136, 156);
            this.Parlabel.Name = "Parlabel";
            this.Parlabel.Size = new System.Drawing.Size(58, 16);
            this.Parlabel.TabIndex = 6;
            this.Parlabel.Text = "                 ";
            // 
            // Positivolabel
            // 
            this.Positivolabel.AutoSize = true;
            this.Positivolabel.Location = new System.Drawing.Point(139, 196);
            this.Positivolabel.Name = "Positivolabel";
            this.Positivolabel.Size = new System.Drawing.Size(73, 16);
            this.Positivolabel.TabIndex = 7;
            this.Positivolabel.Text = "                      ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 300);
            this.Controls.Add(this.Positivolabel);
            this.Controls.Add(this.Parlabel);
            this.Controls.Add(this.Informacionlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.NumerotextBox);
            this.Controls.Add(this.Ingreselabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Ejercicio 1 - Carlos R Lucas";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ingreselabel;
        private System.Windows.Forms.TextBox NumerotextBox;
        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Informacionlabel;
        private System.Windows.Forms.Label Parlabel;
        private System.Windows.Forms.Label Positivolabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

