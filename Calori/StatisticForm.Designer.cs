namespace Calori
{
    partial class StatisticForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblLunch = new System.Windows.Forms.Label();
            this.lblSnack = new System.Windows.Forms.Label();
            this.lblDinner = new System.Windows.Forms.Label();
            this.lblBreakfast = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbMonthly = new System.Windows.Forms.RadioButton();
            this.rbWeekly = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lblDTotal = new System.Windows.Forms.Label();
            this.lblDUser = new System.Windows.Forms.Label();
            this.lblSTotal = new System.Windows.Forms.Label();
            this.lblSUser = new System.Windows.Forms.Label();
            this.lblLTotal = new System.Windows.Forms.Label();
            this.lblLUser = new System.Windows.Forms.Label();
            this.lblBTotal = new System.Windows.Forms.Label();
            this.lblBUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvFoodMeal = new System.Windows.Forms.DataGridView();
            this.cboMeals = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodMeal)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily Report";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalCalories);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblLunch);
            this.groupBox2.Controls.Add(this.lblSnack);
            this.groupBox2.Controls.Add(this.lblDinner);
            this.groupBox2.Controls.Add(this.lblBreakfast);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(0, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 204);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User";
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.AutoSize = true;
            this.lblTotalCalories.Location = new System.Drawing.Point(110, 168);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(36, 13);
            this.lblTotalCalories.TabIndex = 9;
            this.lblTotalCalories.Text = "0 kcal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Total Calories: ";
            // 
            // lblLunch
            // 
            this.lblLunch.AutoSize = true;
            this.lblLunch.Location = new System.Drawing.Point(74, 61);
            this.lblLunch.Name = "lblLunch";
            this.lblLunch.Size = new System.Drawing.Size(36, 13);
            this.lblLunch.TabIndex = 7;
            this.lblLunch.Text = "0 kcal";
            // 
            // lblSnack
            // 
            this.lblSnack.AutoSize = true;
            this.lblSnack.Location = new System.Drawing.Point(74, 91);
            this.lblSnack.Name = "lblSnack";
            this.lblSnack.Size = new System.Drawing.Size(36, 13);
            this.lblSnack.TabIndex = 6;
            this.lblSnack.Text = "0 kcal";
            // 
            // lblDinner
            // 
            this.lblDinner.AutoSize = true;
            this.lblDinner.Location = new System.Drawing.Point(74, 120);
            this.lblDinner.Name = "lblDinner";
            this.lblDinner.Size = new System.Drawing.Size(36, 13);
            this.lblDinner.TabIndex = 5;
            this.lblDinner.Text = "0 kcal";
            // 
            // lblBreakfast
            // 
            this.lblBreakfast.AutoSize = true;
            this.lblBreakfast.Location = new System.Drawing.Point(74, 34);
            this.lblBreakfast.Name = "lblBreakfast";
            this.lblBreakfast.Size = new System.Drawing.Size(36, 13);
            this.lblBreakfast.TabIndex = 4;
            this.lblBreakfast.Text = "0 kcal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Dinner";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lunch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Snack";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Breakfast";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbMonthly);
            this.groupBox3.Controls.Add(this.rbWeekly);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(180, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 402);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Benchmark Report";
            // 
            // rbMonthly
            // 
            this.rbMonthly.AutoSize = true;
            this.rbMonthly.Location = new System.Drawing.Point(174, 28);
            this.rbMonthly.Name = "rbMonthly";
            this.rbMonthly.Size = new System.Drawing.Size(62, 17);
            this.rbMonthly.TabIndex = 9;
            this.rbMonthly.TabStop = true;
            this.rbMonthly.Text = "Monthly";
            this.rbMonthly.UseVisualStyleBackColor = true;
            this.rbMonthly.Click += new System.EventHandler(this.rbMonthly_Click);
            // 
            // rbWeekly
            // 
            this.rbWeekly.AutoSize = true;
            this.rbWeekly.Location = new System.Drawing.Point(15, 28);
            this.rbWeekly.Name = "rbWeekly";
            this.rbWeekly.Size = new System.Drawing.Size(61, 17);
            this.rbWeekly.TabIndex = 8;
            this.rbWeekly.TabStop = true;
            this.rbWeekly.Text = "Weekly";
            this.rbWeekly.UseVisualStyleBackColor = true;
            this.rbWeekly.Click += new System.EventHandler(this.rbWeekly_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.lblDTotal);
            this.groupBox4.Controls.Add(this.lblDUser);
            this.groupBox4.Controls.Add(this.lblSTotal);
            this.groupBox4.Controls.Add(this.lblSUser);
            this.groupBox4.Controls.Add(this.lblLTotal);
            this.groupBox4.Controls.Add(this.lblLUser);
            this.groupBox4.Controls.Add(this.lblBTotal);
            this.groupBox4.Controls.Add(this.lblBUser);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(3, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(304, 351);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(168, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 16;
            this.label19.Text = "Average";
            // 
            // lblDTotal
            // 
            this.lblDTotal.AutoSize = true;
            this.lblDTotal.Location = new System.Drawing.Point(235, 276);
            this.lblDTotal.Name = "lblDTotal";
            this.lblDTotal.Size = new System.Drawing.Size(36, 13);
            this.lblDTotal.TabIndex = 15;
            this.lblDTotal.Text = "0 kcal";
            // 
            // lblDUser
            // 
            this.lblDUser.AutoSize = true;
            this.lblDUser.Location = new System.Drawing.Point(119, 276);
            this.lblDUser.Name = "lblDUser";
            this.lblDUser.Size = new System.Drawing.Size(36, 13);
            this.lblDUser.TabIndex = 14;
            this.lblDUser.Text = "0 kcal";
            // 
            // lblSTotal
            // 
            this.lblSTotal.AutoSize = true;
            this.lblSTotal.Location = new System.Drawing.Point(235, 201);
            this.lblSTotal.Name = "lblSTotal";
            this.lblSTotal.Size = new System.Drawing.Size(36, 13);
            this.lblSTotal.TabIndex = 13;
            this.lblSTotal.Text = "0 kcal";
            // 
            // lblSUser
            // 
            this.lblSUser.AutoSize = true;
            this.lblSUser.Location = new System.Drawing.Point(119, 201);
            this.lblSUser.Name = "lblSUser";
            this.lblSUser.Size = new System.Drawing.Size(36, 13);
            this.lblSUser.TabIndex = 12;
            this.lblSUser.Text = "0 kcal";
            // 
            // lblLTotal
            // 
            this.lblLTotal.AutoSize = true;
            this.lblLTotal.Location = new System.Drawing.Point(235, 132);
            this.lblLTotal.Name = "lblLTotal";
            this.lblLTotal.Size = new System.Drawing.Size(36, 13);
            this.lblLTotal.TabIndex = 11;
            this.lblLTotal.Text = "0 kcal";
            // 
            // lblLUser
            // 
            this.lblLUser.AutoSize = true;
            this.lblLUser.Location = new System.Drawing.Point(119, 132);
            this.lblLUser.Name = "lblLUser";
            this.lblLUser.Size = new System.Drawing.Size(36, 13);
            this.lblLUser.TabIndex = 10;
            this.lblLUser.Text = "0 kcal";
            // 
            // lblBTotal
            // 
            this.lblBTotal.AutoSize = true;
            this.lblBTotal.Location = new System.Drawing.Point(235, 64);
            this.lblBTotal.Name = "lblBTotal";
            this.lblBTotal.Size = new System.Drawing.Size(36, 13);
            this.lblBTotal.TabIndex = 9;
            this.lblBTotal.Text = "0 kcal";
            // 
            // lblBUser
            // 
            this.lblBUser.AutoSize = true;
            this.lblBUser.Location = new System.Drawing.Point(119, 64);
            this.lblBUser.Name = "lblBUser";
            this.lblBUser.Size = new System.Drawing.Size(36, 13);
            this.lblBUser.TabIndex = 8;
            this.lblBUser.Text = "0 kcal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dinner";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lunch";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Snack";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Breakfast";
            // 
            // dgvFoodMeal
            // 
            this.dgvFoodMeal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvFoodMeal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodMeal.Location = new System.Drawing.Point(0, 55);
            this.dgvFoodMeal.Name = "dgvFoodMeal";
            this.dgvFoodMeal.Size = new System.Drawing.Size(292, 347);
            this.dgvFoodMeal.TabIndex = 1;
            // 
            // cboMeals
            // 
            this.cboMeals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMeals.FormattingEnabled = true;
            this.cboMeals.Location = new System.Drawing.Point(87, 28);
            this.cboMeals.Name = "cboMeals";
            this.cboMeals.Size = new System.Drawing.Size(191, 21);
            this.cboMeals.TabIndex = 2;
            this.cboMeals.SelectedIndexChanged += new System.EventHandler(this.cboMeals_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.cboMeals);
            this.groupBox5.Controls.Add(this.dgvFoodMeal);
            this.groupBox5.Location = new System.Drawing.Point(494, 1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(292, 402);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Food Report";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Meal: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 178);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(787, 404);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "StatisticForm";
            this.Text = "Statistics";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodMeal)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblTotalCalories;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblLunch;
        private System.Windows.Forms.Label lblSnack;
        private System.Windows.Forms.Label lblDinner;
        private System.Windows.Forms.Label lblBreakfast;
        private System.Windows.Forms.DataGridView dgvFoodMeal;
        private System.Windows.Forms.ComboBox cboMeals;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbMonthly;
        private System.Windows.Forms.RadioButton rbWeekly;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblDTotal;
        private System.Windows.Forms.Label lblDUser;
        private System.Windows.Forms.Label lblSTotal;
        private System.Windows.Forms.Label lblSUser;
        private System.Windows.Forms.Label lblLTotal;
        private System.Windows.Forms.Label lblLUser;
        private System.Windows.Forms.Label lblBTotal;
        private System.Windows.Forms.Label lblBUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}