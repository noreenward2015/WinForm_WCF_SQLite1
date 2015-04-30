namespace MyCar
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
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAns = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRest = new System.Windows.Forms.TextBox();
            this.btnRest = new System.Windows.Forms.Button();
            this.picCC = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMakeDB = new System.Windows.Forms.TextBox();
            this.txtModelDB = new System.Windows.Forms.TextBox();
            this.txtYearDB = new System.Windows.Forms.TextBox();
            this.txtIDDB = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtShowCarById = new System.Windows.Forms.TextBox();
            this.dgCar = new System.Windows.Forms.DataGridView();
            this.btnGetCar = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(101, 57);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(0, 13);
            this.lblModel.TabIndex = 0;
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(101, 13);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(0, 13);
            this.lblMake.TabIndex = 1;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(101, 109);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(0, 13);
            this.lblYear.TabIndex = 2;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(18, 31);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(37, 20);
            this.txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(86, 31);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(35, 20);
            this.txtNum2.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(42, 80);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAns.Location = new System.Drawing.Point(176, 58);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(0, 19);
            this.lblAns.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Make:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Year:";
            // 
            // txtRest
            // 
            this.txtRest.Location = new System.Drawing.Point(189, 23);
            this.txtRest.Name = "txtRest";
            this.txtRest.Size = new System.Drawing.Size(258, 20);
            this.txtRest.TabIndex = 10;
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(489, 113);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(109, 41);
            this.btnRest.TabIndex = 11;
            this.btnRest.Text = "Get";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // picCC
            // 
            this.picCC.Location = new System.Drawing.Point(74, 62);
            this.picCC.Name = "picCC";
            this.picCC.Size = new System.Drawing.Size(338, 145);
            this.picCC.TabIndex = 0;
            this.picCC.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "This uses a service reference to CarService1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(394, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "This uses a service reference to mathsService";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(196, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(373, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "This calls RestService using the URLs as defined in the API ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblYear);
            this.groupBox1.Controls.Add(this.lblMake);
            this.groupBox1.Controls.Add(this.lblModel);
            this.groupBox1.Location = new System.Drawing.Point(54, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 141);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAns);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtNum2);
            this.groupBox2.Controls.Add(this.txtNum1);
            this.groupBox2.Location = new System.Drawing.Point(418, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 135);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picCC);
            this.groupBox3.Controls.Add(this.btnRest);
            this.groupBox3.Controls.Add(this.txtRest);
            this.groupBox3.Location = new System.Drawing.Point(44, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(658, 218);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // txtMakeDB
            // 
            this.txtMakeDB.Location = new System.Drawing.Point(20, 65);
            this.txtMakeDB.Name = "txtMakeDB";
            this.txtMakeDB.Size = new System.Drawing.Size(100, 20);
            this.txtMakeDB.TabIndex = 18;
            // 
            // txtModelDB
            // 
            this.txtModelDB.Location = new System.Drawing.Point(20, 107);
            this.txtModelDB.Name = "txtModelDB";
            this.txtModelDB.Size = new System.Drawing.Size(100, 20);
            this.txtModelDB.TabIndex = 23;
            // 
            // txtYearDB
            // 
            this.txtYearDB.Location = new System.Drawing.Point(20, 149);
            this.txtYearDB.Name = "txtYearDB";
            this.txtYearDB.Size = new System.Drawing.Size(100, 20);
            this.txtYearDB.TabIndex = 20;
            // 
            // txtIDDB
            // 
            this.txtIDDB.Location = new System.Drawing.Point(20, 29);
            this.txtIDDB.Name = "txtIDDB";
            this.txtIDDB.Size = new System.Drawing.Size(100, 20);
            this.txtIDDB.TabIndex = 21;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(35, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.txtIDDB);
            this.groupBox4.Controls.Add(this.txtYearDB);
            this.groupBox4.Controls.Add(this.txtModelDB);
            this.groupBox4.Controls.Add(this.txtMakeDB);
            this.groupBox4.Location = new System.Drawing.Point(789, 41);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(140, 232);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(747, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "This saves directly into a SQLite database";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(747, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "This returns a car from database using Id entered";
            // 
            // txtShowCarById
            // 
            this.txtShowCarById.Location = new System.Drawing.Point(779, 348);
            this.txtShowCarById.Name = "txtShowCarById";
            this.txtShowCarById.Size = new System.Drawing.Size(120, 20);
            this.txtShowCarById.TabIndex = 28;
            // 
            // dgCar
            // 
            this.dgCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCar.Location = new System.Drawing.Point(790, 411);
            this.dgCar.Name = "dgCar";
            this.dgCar.Size = new System.Drawing.Size(240, 150);
            this.dgCar.TabIndex = 29;
            // 
            // btnGetCar
            // 
            this.btnGetCar.Location = new System.Drawing.Point(941, 354);
            this.btnGetCar.Name = "btnGetCar";
            this.btnGetCar.Size = new System.Drawing.Size(72, 40);
            this.btnGetCar.TabIndex = 30;
            this.btnGetCar.Text = "button1";
            this.btnGetCar.UseVisualStyleBackColor = true;
            this.btnGetCar.Click += new System.EventHandler(this.btnGetCar_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(750, 390);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(35, 13);
            this.lblTest.TabIndex = 31;
            this.lblTest.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1118, 588);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.btnGetCar);
            this.Controls.Add(this.dgCar);
            this.Controls.Add(this.txtShowCarById);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Random app calling on 3 services";
            ((System.ComponentModel.ISupportInitialize)(this.picCC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRest;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.PictureBox picCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMakeDB;
        private System.Windows.Forms.TextBox txtModelDB;
        private System.Windows.Forms.TextBox txtYearDB;
        private System.Windows.Forms.TextBox txtIDDB;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtShowCarById;
        private System.Windows.Forms.DataGridView dgCar;
        private System.Windows.Forms.Button btnGetCar;
        private System.Windows.Forms.Label lblTest;
    }
}

