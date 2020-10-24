namespace Calculadora_Comp_Lib
{
    partial class Cal_Comp
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
            this.cal_Comp1 = new Cal_Comp.Cal_Comp();
            this.SuspendLayout();
            // 
            // cal_Comp1
            // 
            this.cal_Comp1.Location = new System.Drawing.Point(-7, -9);
            this.cal_Comp1.Name = "cal_Comp1";
            this.cal_Comp1.Size = new System.Drawing.Size(318, 392);
            this.cal_Comp1.TabIndex = 0;
            // 
            // Cal_Comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 380);
            this.Controls.Add(this.cal_Comp1);
            this.Name = "Cal_Comp";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Cal_Comp.Cal_Comp cal_Comp1;
    }
}

