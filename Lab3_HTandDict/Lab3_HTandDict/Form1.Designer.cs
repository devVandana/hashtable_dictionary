namespace Lab3_HTandDict
{
    partial class Form1
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
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lbxDisplay = new System.Windows.Forms.ListBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblHashtable = new System.Windows.Forms.Label();
            this.Dictionary = new System.Windows.Forms.Label();
            this.btnHtAdd = new System.Windows.Forms.Button();
            this.btnHtRemove = new System.Windows.Forms.Button();
            this.btnHtDisplay = new System.Windows.Forms.Button();
            this.btnDictAdd = new System.Windows.Forms.Button();
            this.btnDictRemove = new System.Windows.Forms.Button();
            this.btnDictDisplay = new System.Windows.Forms.Button();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.lblErr = new System.Windows.Forms.Label();
            this.btnClr = new System.Windows.Forms.Button();
            this.btnVal = new System.Windows.Forms.Button();
            this.btnDClr = new System.Windows.Forms.Button();
            this.btnCkval = new System.Windows.Forms.Button();
            this.lblKva = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(98, 75);
            this.txtKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(155, 31);
            this.txtKey.TabIndex = 0;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(342, 75);
            this.txtValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(155, 31);
            this.txtValue.TabIndex = 1;
            // 
            // lbxDisplay
            // 
            this.lbxDisplay.FormattingEnabled = true;
            this.lbxDisplay.ItemHeight = 25;
            this.lbxDisplay.Location = new System.Drawing.Point(945, 75);
            this.lbxDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.lbxDisplay.Name = "lbxDisplay";
            this.lbxDisplay.Size = new System.Drawing.Size(244, 279);
            this.lbxDisplay.TabIndex = 2;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(98, 31);
            this.lblKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(40, 25);
            this.lblKey.TabIndex = 3;
            this.lblKey.Text = "Key";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(342, 31);
            this.lblValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(54, 25);
            this.lblValue.TabIndex = 4;
            this.lblValue.Text = "Value";
            // 
            // lblHashtable
            // 
            this.lblHashtable.AutoSize = true;
            this.lblHashtable.Location = new System.Drawing.Point(98, 215);
            this.lblHashtable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHashtable.Name = "lblHashtable";
            this.lblHashtable.Size = new System.Drawing.Size(91, 25);
            this.lblHashtable.TabIndex = 5;
            this.lblHashtable.Text = "Hashtable";
            // 
            // Dictionary
            // 
            this.Dictionary.AutoSize = true;
            this.Dictionary.Location = new System.Drawing.Point(98, 399);
            this.Dictionary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dictionary.Name = "Dictionary";
            this.Dictionary.Size = new System.Drawing.Size(92, 25);
            this.Dictionary.TabIndex = 6;
            this.Dictionary.Text = "Dictionary";
            // 
            // btnHtAdd
            // 
            this.btnHtAdd.Location = new System.Drawing.Point(44, 290);
            this.btnHtAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnHtAdd.Name = "btnHtAdd";
            this.btnHtAdd.Size = new System.Drawing.Size(118, 36);
            this.btnHtAdd.TabIndex = 7;
            this.btnHtAdd.Text = "Add";
            this.btnHtAdd.UseVisualStyleBackColor = true;
            this.btnHtAdd.Click += new System.EventHandler(this.btnHtAdd_Click);
            // 
            // btnHtRemove
            // 
            this.btnHtRemove.Location = new System.Drawing.Point(231, 290);
            this.btnHtRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnHtRemove.Name = "btnHtRemove";
            this.btnHtRemove.Size = new System.Drawing.Size(118, 36);
            this.btnHtRemove.TabIndex = 8;
            this.btnHtRemove.Text = "Remove";
            this.btnHtRemove.UseVisualStyleBackColor = true;
            this.btnHtRemove.Click += new System.EventHandler(this.btnHtRemove_Click);
            // 
            // btnHtDisplay
            // 
            this.btnHtDisplay.Location = new System.Drawing.Point(419, 290);
            this.btnHtDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.btnHtDisplay.Name = "btnHtDisplay";
            this.btnHtDisplay.Size = new System.Drawing.Size(118, 36);
            this.btnHtDisplay.TabIndex = 9;
            this.btnHtDisplay.Text = "Display";
            this.btnHtDisplay.UseVisualStyleBackColor = true;
            this.btnHtDisplay.Click += new System.EventHandler(this.btnHtDisplay_Click);
            // 
            // btnDictAdd
            // 
            this.btnDictAdd.Location = new System.Drawing.Point(44, 479);
            this.btnDictAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnDictAdd.Name = "btnDictAdd";
            this.btnDictAdd.Size = new System.Drawing.Size(118, 36);
            this.btnDictAdd.TabIndex = 10;
            this.btnDictAdd.Text = "Add";
            this.btnDictAdd.UseVisualStyleBackColor = true;
            this.btnDictAdd.Click += new System.EventHandler(this.btnDictAdd_Click);
            // 
            // btnDictRemove
            // 
            this.btnDictRemove.Location = new System.Drawing.Point(231, 479);
            this.btnDictRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnDictRemove.Name = "btnDictRemove";
            this.btnDictRemove.Size = new System.Drawing.Size(118, 36);
            this.btnDictRemove.TabIndex = 11;
            this.btnDictRemove.Text = "Remove";
            this.btnDictRemove.UseVisualStyleBackColor = true;
            this.btnDictRemove.Click += new System.EventHandler(this.btnDictRemove_Click);
            // 
            // btnDictDisplay
            // 
            this.btnDictDisplay.Location = new System.Drawing.Point(419, 479);
            this.btnDictDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.btnDictDisplay.Name = "btnDictDisplay";
            this.btnDictDisplay.Size = new System.Drawing.Size(118, 36);
            this.btnDictDisplay.TabIndex = 12;
            this.btnDictDisplay.Text = "Display";
            this.btnDictDisplay.UseVisualStyleBackColor = true;
            this.btnDictDisplay.Click += new System.EventHandler(this.btnDictDisplay_Click);
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(1012, 479);
            this.btnForm2.Margin = new System.Windows.Forms.Padding(4);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(118, 36);
            this.btnForm2.TabIndex = 13;
            this.btnForm2.Text = "Form 2";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.ForeColor = System.Drawing.Color.Crimson;
            this.lblErr.Location = new System.Drawing.Point(149, 140);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(0, 25);
            this.lblErr.TabIndex = 14;
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(600, 290);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(97, 36);
            this.btnClr.TabIndex = 15;
            this.btnClr.Text = "Clear";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // btnVal
            // 
            this.btnVal.Location = new System.Drawing.Point(765, 290);
            this.btnVal.Name = "btnVal";
            this.btnVal.Size = new System.Drawing.Size(97, 36);
            this.btnVal.TabIndex = 16;
            this.btnVal.Text = "Values";
            this.btnVal.UseVisualStyleBackColor = true;
            this.btnVal.Click += new System.EventHandler(this.btnVal_Click);
            // 
            // btnDClr
            // 
            this.btnDClr.Location = new System.Drawing.Point(600, 479);
            this.btnDClr.Name = "btnDClr";
            this.btnDClr.Size = new System.Drawing.Size(97, 36);
            this.btnDClr.TabIndex = 17;
            this.btnDClr.Text = "Clear";
            this.btnDClr.UseVisualStyleBackColor = true;
            this.btnDClr.Click += new System.EventHandler(this.btnDClr_Click);
            // 
            // btnCkval
            // 
            this.btnCkval.Location = new System.Drawing.Point(765, 479);
            this.btnCkval.Name = "btnCkval";
            this.btnCkval.Size = new System.Drawing.Size(116, 36);
            this.btnCkval.TabIndex = 18;
            this.btnCkval.Text = "Check Value";
            this.btnCkval.UseVisualStyleBackColor = true;
            this.btnCkval.Click += new System.EventHandler(this.btnCkval_Click);
            // 
            // lblKva
            // 
            this.lblKva.AutoSize = true;
            this.lblKva.Location = new System.Drawing.Point(780, 440);
            this.lblKva.Name = "lblKva";
            this.lblKva.Size = new System.Drawing.Size(0, 25);
            this.lblKva.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 562);
            this.Controls.Add(this.lblKva);
            this.Controls.Add(this.btnCkval);
            this.Controls.Add(this.btnDClr);
            this.Controls.Add(this.btnVal);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.lblErr);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.btnDictDisplay);
            this.Controls.Add(this.btnDictRemove);
            this.Controls.Add(this.btnDictAdd);
            this.Controls.Add(this.btnHtDisplay);
            this.Controls.Add(this.btnHtRemove);
            this.Controls.Add(this.btnHtAdd);
            this.Controls.Add(this.Dictionary);
            this.Controls.Add(this.lblHashtable);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lbxDisplay);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtKey);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtKey;
        private TextBox txtValue;
        private ListBox lbxDisplay;
        private Label lblKey;
        private Label lblValue;
        private Label lblHashtable;
        private Label Dictionary;
        private Button btnHtAdd;
        private Button btnHtRemove;
        private Button btnHtDisplay;
        private Button btnDictAdd;
        private Button btnDictRemove;
        private Button btnDictDisplay;
        private Button btnForm2;
        private Label lblErr;
        private Button btnClr;
        private Button btnVal;
        private Button btnDClr;
        private Button btnCkval;
        private Label lblKva;
    }
}