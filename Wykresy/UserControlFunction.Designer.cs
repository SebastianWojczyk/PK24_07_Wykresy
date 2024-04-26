namespace Wykresy
{
    partial class UserControlFunction
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownC = new System.Windows.Forms.NumericUpDown();
            this.groupBoxFunction = new System.Windows.Forms.GroupBox();
            this.labelTrash = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).BeginInit();
            this.groupBoxFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(95, 44);
            this.numericUpDownB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownB.TabIndex = 0;
            this.numericUpDownB.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Location = new System.Drawing.Point(95, 18);
            this.numericUpDownA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownA.TabIndex = 0;
            this.numericUpDownA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownA.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // numericUpDownC
            // 
            this.numericUpDownC.Location = new System.Drawing.Point(95, 70);
            this.numericUpDownC.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownC.Name = "numericUpDownC";
            this.numericUpDownC.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownC.TabIndex = 1;
            this.numericUpDownC.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // groupBoxFunction
            // 
            this.groupBoxFunction.Controls.Add(this.labelTrash);
            this.groupBoxFunction.Controls.Add(this.label3);
            this.groupBoxFunction.Controls.Add(this.label2);
            this.groupBoxFunction.Controls.Add(this.label1);
            this.groupBoxFunction.Controls.Add(this.numericUpDownB);
            this.groupBoxFunction.Controls.Add(this.numericUpDownC);
            this.groupBoxFunction.Controls.Add(this.numericUpDownA);
            this.groupBoxFunction.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFunction.Name = "groupBoxFunction";
            this.groupBoxFunction.Size = new System.Drawing.Size(162, 102);
            this.groupBoxFunction.TabIndex = 2;
            this.groupBoxFunction.TabStop = false;
            this.groupBoxFunction.Text = "groupBox1";
            // 
            // labelTrash
            // 
            this.labelTrash.AutoSize = true;
            this.labelTrash.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTrash.ForeColor = System.Drawing.Color.Red;
            this.labelTrash.Location = new System.Drawing.Point(9, 61);
            this.labelTrash.Name = "labelTrash";
            this.labelTrash.Size = new System.Drawing.Size(39, 29);
            this.labelTrash.TabIndex = 5;
            this.labelTrash.Text = "🗑️";
            this.labelTrash.Click += new System.EventHandler(this.labelTrash_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "C=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "B=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "A=";
            // 
            // UserControlFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxFunction);
            this.Name = "UserControlFunction";
            this.Size = new System.Drawing.Size(170, 112);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).EndInit();
            this.groupBoxFunction.ResumeLayout(false);
            this.groupBoxFunction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.NumericUpDown numericUpDownC;
        private System.Windows.Forms.GroupBox groupBoxFunction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTrash;
    }
}
