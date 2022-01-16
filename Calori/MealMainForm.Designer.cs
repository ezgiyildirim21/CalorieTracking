namespace Calori
{
    partial class MealMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealMainForm));
            this.dgvMeals = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.mcMealDate = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeals)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMeals
            // 
            this.dgvMeals.AllowUserToAddRows = false;
            this.dgvMeals.AllowUserToDeleteRows = false;
            this.dgvMeals.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvMeals.Location = new System.Drawing.Point(2, 186);
            this.dgvMeals.Name = "dgvMeals";
            this.dgvMeals.ReadOnly = true;
            this.dgvMeals.Size = new System.Drawing.Size(545, 355);
            this.dgvMeals.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Calorie";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Amount";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Porsion";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Meal Name";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Id";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAddMeal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddMeal.BackgroundImage")));
            this.btnAddMeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddMeal.Location = new System.Drawing.Point(12, 12);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(110, 104);
            this.btnAddMeal.TabIndex = 1;
            this.btnAddMeal.Text = "Add Meal";
            this.btnAddMeal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddMeal.UseVisualStyleBackColor = false;
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStatistic.BackgroundImage")));
            this.btnStatistic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStatistic.Location = new System.Drawing.Point(426, 12);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(110, 104);
            this.btnStatistic.TabIndex = 2;
            this.btnStatistic.Text = "Statistics";
            this.btnStatistic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // mcMealDate
            // 
            this.mcMealDate.Location = new System.Drawing.Point(151, 12);
            this.mcMealDate.Name = "mcMealDate";
            this.mcMealDate.TabIndex = 4;
            this.mcMealDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcMealDate_DateChanged);
            // 
            // MealMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(548, 547);
            this.Controls.Add(this.mcMealDate);
            this.Controls.Add(this.btnStatistic);
            this.Controls.Add(this.btnAddMeal);
            this.Controls.Add(this.dgvMeals);
            this.Name = "MealMainForm";
            this.Text = "Meal Main";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMeals;
        private System.Windows.Forms.Button btnAddMeal;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.MonthCalendar mcMealDate;
    }
}