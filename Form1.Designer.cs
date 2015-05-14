namespace Hw6
{
    partial class Form1
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
            this.cbox_ShapeSelect = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Para2 = new System.Windows.Forms.TextBox();
            this.txt_Para1 = new System.Windows.Forms.TextBox();
            this.lbl_Para2 = new System.Windows.Forms.Label();
            this.lbl_Para1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_MaterialSelect = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.txt_Display = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_AmountOfShape = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.grpCompare = new System.Windows.Forms.GroupBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.rdbDescent = new System.Windows.Forms.RadioButton();
            this.rdbAscent = new System.Windows.Forms.RadioButton();
            this.cboCompareType = new System.Windows.Forms.ComboBox();
            this.lblCompare = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpCompare.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbox_ShapeSelect
            // 
            this.cbox_ShapeSelect.FormattingEnabled = true;
            this.cbox_ShapeSelect.Items.AddRange(new object[] {
            "球",
            "正方體",
            "圓柱體",
            "金字塔"});
            this.cbox_ShapeSelect.Location = new System.Drawing.Point(106, 21);
            this.cbox_ShapeSelect.Name = "cbox_ShapeSelect";
            this.cbox_ShapeSelect.Size = new System.Drawing.Size(185, 20);
            this.cbox_ShapeSelect.TabIndex = 0;
            this.cbox_ShapeSelect.SelectedIndexChanged += new System.EventHandler(this.cbox_ShapeSelect_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Para2);
            this.groupBox1.Controls.Add(this.txt_Para1);
            this.groupBox1.Controls.Add(this.lbl_Para2);
            this.groupBox1.Controls.Add(this.lbl_Para1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbox_ShapeSelect);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 111);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "形狀設定";
            // 
            // txt_Para2
            // 
            this.txt_Para2.Location = new System.Drawing.Point(207, 65);
            this.txt_Para2.Name = "txt_Para2";
            this.txt_Para2.Size = new System.Drawing.Size(84, 22);
            this.txt_Para2.TabIndex = 5;
            this.txt_Para2.Text = "0";
            // 
            // txt_Para1
            // 
            this.txt_Para1.Location = new System.Drawing.Point(54, 65);
            this.txt_Para1.Name = "txt_Para1";
            this.txt_Para1.Size = new System.Drawing.Size(84, 22);
            this.txt_Para1.TabIndex = 4;
            this.txt_Para1.Text = "0";
            // 
            // lbl_Para2
            // 
            this.lbl_Para2.AutoSize = true;
            this.lbl_Para2.Location = new System.Drawing.Point(184, 68);
            this.lbl_Para2.Name = "lbl_Para2";
            this.lbl_Para2.Size = new System.Drawing.Size(17, 12);
            this.lbl_Para2.TabIndex = 3;
            this.lbl_Para2.Text = "高";
            // 
            // lbl_Para1
            // 
            this.lbl_Para1.AutoSize = true;
            this.lbl_Para1.Location = new System.Drawing.Point(19, 68);
            this.lbl_Para1.Name = "lbl_Para1";
            this.lbl_Para1.Size = new System.Drawing.Size(29, 12);
            this.lbl_Para1.TabIndex = 2;
            this.lbl_Para1.Text = "底邊";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "形狀類別";
            // 
            // cbox_MaterialSelect
            // 
            this.cbox_MaterialSelect.FormattingEnabled = true;
            this.cbox_MaterialSelect.Items.AddRange(new object[] {
            "鋁",
            "鐵",
            "鉛"});
            this.cbox_MaterialSelect.Location = new System.Drawing.Point(105, 21);
            this.cbox_MaterialSelect.Name = "cbox_MaterialSelect";
            this.cbox_MaterialSelect.Size = new System.Drawing.Size(185, 20);
            this.cbox_MaterialSelect.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbox_MaterialSelect);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 52);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "材質設定";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "材質類別";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(553, 13);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_Calculate.TabIndex = 4;
            this.btn_Calculate.Text = "計算";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // txt_Display
            // 
            this.txt_Display.Location = new System.Drawing.Point(553, 48);
            this.txt_Display.Multiline = true;
            this.txt_Display.Name = "txt_Display";
            this.txt_Display.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Display.Size = new System.Drawing.Size(374, 380);
            this.txt_Display.TabIndex = 5;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(6, 21);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "加入";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "數量";
            // 
            // txt_AmountOfShape
            // 
            this.txt_AmountOfShape.Location = new System.Drawing.Point(206, 21);
            this.txt_AmountOfShape.Name = "txt_AmountOfShape";
            this.txt_AmountOfShape.Size = new System.Drawing.Size(84, 22);
            this.txt_AmountOfShape.TabIndex = 8;
            this.txt_AmountOfShape.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Add);
            this.groupBox3.Controls.Add(this.txt_AmountOfShape);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(13, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 60);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "增加Shape";
            // 
            // txt_Message
            // 
            this.txt_Message.Location = new System.Drawing.Point(13, 282);
            this.txt_Message.Multiline = true;
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Message.Size = new System.Drawing.Size(296, 146);
            this.txt_Message.TabIndex = 10;
            // 
            // grpCompare
            // 
            this.grpCompare.Controls.Add(this.btnCompare);
            this.grpCompare.Controls.Add(this.rdbDescent);
            this.grpCompare.Controls.Add(this.rdbAscent);
            this.grpCompare.Controls.Add(this.cboCompareType);
            this.grpCompare.Controls.Add(this.lblCompare);
            this.grpCompare.Location = new System.Drawing.Point(335, 48);
            this.grpCompare.Name = "grpCompare";
            this.grpCompare.Size = new System.Drawing.Size(200, 100);
            this.grpCompare.TabIndex = 11;
            this.grpCompare.TabStop = false;
            this.grpCompare.Text = "排序";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(8, 69);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 5;
            this.btnCompare.Text = "確定";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // rdbDescent
            // 
            this.rdbDescent.AutoSize = true;
            this.rdbDescent.Location = new System.Drawing.Point(65, 47);
            this.rdbDescent.Name = "rdbDescent";
            this.rdbDescent.Size = new System.Drawing.Size(47, 16);
            this.rdbDescent.TabIndex = 3;
            this.rdbDescent.TabStop = true;
            this.rdbDescent.Text = "遞減";
            this.rdbDescent.UseVisualStyleBackColor = true;
            // 
            // rdbAscent
            // 
            this.rdbAscent.AutoSize = true;
            this.rdbAscent.Location = new System.Drawing.Point(8, 48);
            this.rdbAscent.Name = "rdbAscent";
            this.rdbAscent.Size = new System.Drawing.Size(47, 16);
            this.rdbAscent.TabIndex = 2;
            this.rdbAscent.TabStop = true;
            this.rdbAscent.Text = "遞增";
            this.rdbAscent.UseVisualStyleBackColor = true;
            // 
            // cboCompareType
            // 
            this.cboCompareType.FormattingEnabled = true;
            this.cboCompareType.Items.AddRange(new object[] {
            "Volume",
            "Weight"});
            this.cboCompareType.Location = new System.Drawing.Point(65, 21);
            this.cboCompareType.Name = "cboCompareType";
            this.cboCompareType.Size = new System.Drawing.Size(121, 20);
            this.cboCompareType.TabIndex = 1;
            // 
            // lblCompare
            // 
            this.lblCompare.AutoSize = true;
            this.lblCompare.Location = new System.Drawing.Point(6, 23);
            this.lblCompare.Name = "lblCompare";
            this.lblCompare.Size = new System.Drawing.Size(53, 12);
            this.lblCompare.TabIndex = 0;
            this.lblCompare.Text = "排序方式";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 440);
            this.Controls.Add(this.grpCompare);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txt_Display);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "103Quiz5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpCompare.ResumeLayout(false);
            this.grpCompare.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_ShapeSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_MaterialSelect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Para2;
        private System.Windows.Forms.TextBox txt_Para1;
        private System.Windows.Forms.Label lbl_Para2;
        private System.Windows.Forms.Label lbl_Para1;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.TextBox txt_Display;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_AmountOfShape;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.GroupBox grpCompare;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.RadioButton rdbDescent;
        private System.Windows.Forms.RadioButton rdbAscent;
        private System.Windows.Forms.ComboBox cboCompareType;
        private System.Windows.Forms.Label lblCompare;
    }
}

