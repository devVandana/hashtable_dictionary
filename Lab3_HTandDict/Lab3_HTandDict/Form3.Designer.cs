namespace Lab3_HTandDict
{
    partial class Form3
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
            this.btnform2 = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnIntersec = new System.Windows.Forms.Button();
            this.BtnUnion = new System.Windows.Forms.Button();
            this.btnSubset = new System.Windows.Forms.Button();
            this.btnSuper = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.ss1 = new System.Windows.Forms.ListBox();
            this.ss2 = new System.Windows.Forms.ListBox();
            this.BrnRem1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.btnRem2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnform2
            // 
            this.btnform2.Location = new System.Drawing.Point(863, 519);
            this.btnform2.Name = "btnform2";
            this.btnform2.Size = new System.Drawing.Size(125, 39);
            this.btnform2.TabIndex = 0;
            this.btnform2.Text = "Form 2";
            this.btnform2.UseVisualStyleBackColor = true;
            this.btnform2.Click += new System.EventHandler(this.btnform2_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(339, 91);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(114, 37);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(478, 91);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 37);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnIntersec
            // 
            this.btnIntersec.Location = new System.Drawing.Point(339, 145);
            this.btnIntersec.Name = "btnIntersec";
            this.btnIntersec.Size = new System.Drawing.Size(114, 38);
            this.btnIntersec.TabIndex = 3;
            this.btnIntersec.Text = "Intersection";
            this.btnIntersec.UseVisualStyleBackColor = true;
            this.btnIntersec.Click += new System.EventHandler(this.btnIntersec_Click);
            // 
            // BtnUnion
            // 
            this.BtnUnion.Location = new System.Drawing.Point(478, 149);
            this.BtnUnion.Name = "BtnUnion";
            this.BtnUnion.Size = new System.Drawing.Size(103, 34);
            this.BtnUnion.TabIndex = 4;
            this.BtnUnion.Text = "Union";
            this.BtnUnion.UseVisualStyleBackColor = true;
            this.BtnUnion.Click += new System.EventHandler(this.BtnUnion_Click);
            // 
            // btnSubset
            // 
            this.btnSubset.Location = new System.Drawing.Point(339, 206);
            this.btnSubset.Name = "btnSubset";
            this.btnSubset.Size = new System.Drawing.Size(114, 34);
            this.btnSubset.TabIndex = 5;
            this.btnSubset.Text = "Subset?";
            this.btnSubset.UseVisualStyleBackColor = true;
            this.btnSubset.Click += new System.EventHandler(this.btnSubset_Click);
            // 
            // btnSuper
            // 
            this.btnSuper.Location = new System.Drawing.Point(478, 206);
            this.btnSuper.Name = "btnSuper";
            this.btnSuper.Size = new System.Drawing.Size(103, 34);
            this.btnSuper.TabIndex = 6;
            this.btnSuper.Text = "SuperSet?";
            this.btnSuper.UseVisualStyleBackColor = true;
            this.btnSuper.Click += new System.EventHandler(this.btnSuper_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(435, 263);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(59, 25);
            this.lblresult.TabIndex = 7;
            this.lblresult.Text = "Result";
            // 
            // btnAdd1
            // 
            this.btnAdd1.Location = new System.Drawing.Point(145, 308);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(104, 35);
            this.btnAdd1.TabIndex = 8;
            this.btnAdd1.Text = "Add";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // ss1
            // 
            this.ss1.FormattingEnabled = true;
            this.ss1.ItemHeight = 25;
            this.ss1.Location = new System.Drawing.Point(107, 91);
            this.ss1.Name = "ss1";
            this.ss1.Size = new System.Drawing.Size(192, 179);
            this.ss1.TabIndex = 9;
            // 
            // ss2
            // 
            this.ss2.FormattingEnabled = true;
            this.ss2.ItemHeight = 25;
            this.ss2.Location = new System.Drawing.Point(754, 91);
            this.ss2.Name = "ss2";
            this.ss2.Size = new System.Drawing.Size(192, 179);
            this.ss2.TabIndex = 10;
            // 
            // BrnRem1
            // 
            this.BrnRem1.Location = new System.Drawing.Point(283, 308);
            this.BrnRem1.Name = "BrnRem1";
            this.BrnRem1.Size = new System.Drawing.Size(97, 35);
            this.BrnRem1.TabIndex = 11;
            this.BrnRem1.Text = "Remove";
            this.BrnRem1.UseVisualStyleBackColor = true;
            this.BrnRem1.Click += new System.EventHandler(this.BrnRem1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(417, 310);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 31);
            this.textBox1.TabIndex = 12;
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(624, 309);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(96, 33);
            this.btnAdd2.TabIndex = 13;
            this.btnAdd2.Text = "Add";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // btnRem2
            // 
            this.btnRem2.Location = new System.Drawing.Point(754, 308);
            this.btnRem2.Name = "btnRem2";
            this.btnRem2.Size = new System.Drawing.Size(94, 33);
            this.btnRem2.TabIndex = 14;
            this.btnRem2.Text = "Remove";
            this.btnRem2.UseVisualStyleBackColor = true;
            this.btnRem2.Click += new System.EventHandler(this.btnRem2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 578);
            this.Controls.Add(this.btnRem2);
            this.Controls.Add(this.btnAdd2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BrnRem1);
            this.Controls.Add(this.ss2);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btnSuper);
            this.Controls.Add(this.btnSubset);
            this.Controls.Add(this.BtnUnion);
            this.Controls.Add(this.btnIntersec);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnform2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnform2;
        private Button btnDisplay;
        private Button btnClear;
        private Button btnIntersec;
        private Button BtnUnion;
        private Button btnSubset;
        private Button btnSuper;
        private Label lblresult;
        private Button btnAdd1;
        private ListBox ss1;
        private ListBox ss2;
        private Button BrnRem1;
        private TextBox textBox1;
        private Button btnAdd2;
        private Button btnRem2;
    }
}