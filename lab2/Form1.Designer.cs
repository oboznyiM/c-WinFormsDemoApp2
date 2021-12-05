namespace lab2
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
            this.cmb_name = new System.Windows.Forms.ComboBox();
            this.cmb_gender = new System.Windows.Forms.ComboBox();
            this.cmb_department = new System.Windows.Forms.ComboBox();
            this.cmb_age = new System.Windows.Forms.ComboBox();
            this.btn_sax = new System.Windows.Forms.RadioButton();
            this.btn_linq = new System.Windows.Forms.RadioButton();
            this.btn_dom = new System.Windows.Forms.RadioButton();
            this.btn_search = new System.Windows.Forms.Button();
            this.box_result = new System.Windows.Forms.RichTextBox();
            this.transform = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_name
            // 
            this.cmb_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_name.FormattingEnabled = true;
            this.cmb_name.Location = new System.Drawing.Point(77, 42);
            this.cmb_name.Name = "cmb_name";
            this.cmb_name.Size = new System.Drawing.Size(151, 28);
            this.cmb_name.TabIndex = 0;
            this.cmb_name.SelectedIndexChanged += new System.EventHandler(this.cmb_name_SelectedIndexChanged);
            // 
            // cmb_gender
            // 
            this.cmb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_gender.FormattingEnabled = true;
            this.cmb_gender.Location = new System.Drawing.Point(77, 247);
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.Size = new System.Drawing.Size(151, 28);
            this.cmb_gender.TabIndex = 1;
            // 
            // cmb_department
            // 
            this.cmb_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_department.FormattingEnabled = true;
            this.cmb_department.Location = new System.Drawing.Point(77, 108);
            this.cmb_department.Name = "cmb_department";
            this.cmb_department.Size = new System.Drawing.Size(151, 28);
            this.cmb_department.TabIndex = 2;
            // 
            // cmb_age
            // 
            this.cmb_age.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_age.FormattingEnabled = true;
            this.cmb_age.Location = new System.Drawing.Point(77, 179);
            this.cmb_age.Name = "cmb_age";
            this.cmb_age.Size = new System.Drawing.Size(151, 28);
            this.cmb_age.TabIndex = 3;
            // 
            // btn_sax
            // 
            this.btn_sax.AutoSize = true;
            this.btn_sax.Location = new System.Drawing.Point(32, 293);
            this.btn_sax.Name = "btn_sax";
            this.btn_sax.Size = new System.Drawing.Size(57, 24);
            this.btn_sax.TabIndex = 8;
            this.btn_sax.TabStop = true;
            this.btn_sax.Text = "SAX";
            this.btn_sax.UseVisualStyleBackColor = true;
            // 
            // btn_linq
            // 
            this.btn_linq.AutoSize = true;
            this.btn_linq.Location = new System.Drawing.Point(181, 293);
            this.btn_linq.Name = "btn_linq";
            this.btn_linq.Size = new System.Drawing.Size(114, 24);
            this.btn_linq.TabIndex = 9;
            this.btn_linq.TabStop = true;
            this.btn_linq.Text = "LINQ to XML";
            this.btn_linq.UseVisualStyleBackColor = true;
            this.btn_linq.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btn_dom
            // 
            this.btn_dom.AutoSize = true;
            this.btn_dom.Location = new System.Drawing.Point(110, 293);
            this.btn_dom.Name = "btn_dom";
            this.btn_dom.Size = new System.Drawing.Size(65, 24);
            this.btn_dom.TabIndex = 10;
            this.btn_dom.TabStop = true;
            this.btn_dom.Text = "DOM";
            this.btn_dom.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(32, 339);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(346, 40);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Пошук";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // box_result
            // 
            this.box_result.Location = new System.Drawing.Point(411, 42);
            this.box_result.Name = "box_result";
            this.box_result.Size = new System.Drawing.Size(333, 365);
            this.box_result.TabIndex = 12;
            this.box_result.Text = "";
            this.box_result.TextChanged += new System.EventHandler(this.box_result_TextChanged);
            // 
            // transform
            // 
            this.transform.Location = new System.Drawing.Point(32, 398);
            this.transform.Name = "transform";
            this.transform.Size = new System.Drawing.Size(346, 40);
            this.transform.TabIndex = 13;
            this.transform.Text = "Перетворити";
            this.transform.UseVisualStyleBackColor = true;
            this.transform.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ім\'я";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Стать";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Вік";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Факультет";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transform);
            this.Controls.Add(this.box_result);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_dom);
            this.Controls.Add(this.btn_linq);
            this.Controls.Add(this.btn_sax);
            this.Controls.Add(this.cmb_age);
            this.Controls.Add(this.cmb_department);
            this.Controls.Add(this.cmb_gender);
            this.Controls.Add(this.cmb_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmb_name;
        private ComboBox cmb_gender;
        private ComboBox cmb_department;
        private ComboBox cmb_age;
        private RadioButton btn_sax;
        private RadioButton btn_linq;
        private RadioButton btn_dom;
        private Button btn_search;
        private RichTextBox box_result;
        private Button transform;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}