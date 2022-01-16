namespace Calori
{
    partial class SelectMealForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectMealForm));
            this.cboSelectMeal = new System.Windows.Forms.ComboBox();
            this.btnSelectAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboSelectMeal
            // 
            this.cboSelectMeal.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cboSelectMeal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectMeal.FormattingEnabled = true;
            this.cboSelectMeal.Location = new System.Drawing.Point(12, 110);
            this.cboSelectMeal.Name = "cboSelectMeal";
            this.cboSelectMeal.Size = new System.Drawing.Size(221, 21);
            this.cboSelectMeal.TabIndex = 0;
            // 
            // btnSelectAdd
            // 
            this.btnSelectAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelectAdd.Location = new System.Drawing.Point(158, 137);
            this.btnSelectAdd.Name = "btnSelectAdd";
            this.btnSelectAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAdd.TabIndex = 1;
            this.btnSelectAdd.Text = "SELECT";
            this.btnSelectAdd.UseVisualStyleBackColor = true;
            this.btnSelectAdd.Click += new System.EventHandler(this.btnSelectAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Select";
            // 
            // SelectMealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(245, 172);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectAdd);
            this.Controls.Add(this.cboSelectMeal);
            this.Name = "SelectMealForm";
            this.Text = "Select Meal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSelectMeal;
        private System.Windows.Forms.Button btnSelectAdd;
        private System.Windows.Forms.Label label1;
    }
}