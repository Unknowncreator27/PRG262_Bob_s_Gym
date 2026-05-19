namespace PRG262_Bob_s_Gym.Forms
{
    partial class FrmClasses
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
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.TxtClassName = new System.Windows.Forms.TextBox();
            this.LblClassName = new System.Windows.Forms.Label();
            this.TxtDesc = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.LblInstructor = new System.Windows.Forms.Label();
            this.TxtInstructor = new System.Windows.Forms.TextBox();
            this.LblSchedule = new System.Windows.Forms.Label();
            this.LblCapacity = new System.Windows.Forms.Label();
            this.numericCapacity = new System.Windows.Forms.NumericUpDown();
            this.TxtSchedule = new System.Windows.Forms.TextBox();
            this.numericDuration = new System.Windows.Forms.NumericUpDown();
            this.LblDuration = new System.Windows.Forms.Label();
            this.btnUpdateClass = new System.Windows.Forms.Button();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.DashHeaderPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDuration)).BeginInit();
            this.DashHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClasses
            // 
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Location = new System.Drawing.Point(283, 130);
            this.dgvClasses.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.RowHeadersWidth = 102;
            this.dgvClasses.RowTemplate.Height = 40;
            this.dgvClasses.Size = new System.Drawing.Size(405, 290);
            this.dgvClasses.TabIndex = 0;
            this.dgvClasses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasses_CellClick);
            // 
            // btnAddClass
            // 
            this.btnAddClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnAddClass.Location = new System.Drawing.Point(283, 439);
            this.btnAddClass.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(97, 29);
            this.btnAddClass.TabIndex = 1;
            this.btnAddClass.Text = "Add Class";
            this.btnAddClass.UseVisualStyleBackColor = false;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // TxtClassName
            // 
            this.TxtClassName.Location = new System.Drawing.Point(14, 162);
            this.TxtClassName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TxtClassName.Name = "TxtClassName";
            this.TxtClassName.Size = new System.Drawing.Size(154, 20);
            this.TxtClassName.TabIndex = 2;
            // 
            // LblClassName
            // 
            this.LblClassName.AutoSize = true;
            this.LblClassName.ForeColor = System.Drawing.Color.White;
            this.LblClassName.Location = new System.Drawing.Point(15, 140);
            this.LblClassName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblClassName.Name = "LblClassName";
            this.LblClassName.Size = new System.Drawing.Size(63, 13);
            this.LblClassName.TabIndex = 3;
            this.LblClassName.Text = "Class Name";
            // 
            // TxtDesc
            // 
            this.TxtDesc.AutoSize = true;
            this.TxtDesc.ForeColor = System.Drawing.Color.White;
            this.TxtDesc.Location = new System.Drawing.Point(15, 190);
            this.TxtDesc.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(60, 13);
            this.TxtDesc.TabIndex = 5;
            this.TxtDesc.Text = "Description";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(14, 212);
            this.TxtDescription.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(154, 20);
            this.TxtDescription.TabIndex = 4;
            // 
            // LblInstructor
            // 
            this.LblInstructor.AutoSize = true;
            this.LblInstructor.ForeColor = System.Drawing.Color.White;
            this.LblInstructor.Location = new System.Drawing.Point(15, 256);
            this.LblInstructor.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblInstructor.Name = "LblInstructor";
            this.LblInstructor.Size = new System.Drawing.Size(51, 13);
            this.LblInstructor.TabIndex = 7;
            this.LblInstructor.Text = "Instructor";
            // 
            // TxtInstructor
            // 
            this.TxtInstructor.Location = new System.Drawing.Point(14, 278);
            this.TxtInstructor.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TxtInstructor.Name = "TxtInstructor";
            this.TxtInstructor.Size = new System.Drawing.Size(154, 20);
            this.TxtInstructor.TabIndex = 6;
            // 
            // LblSchedule
            // 
            this.LblSchedule.AutoSize = true;
            this.LblSchedule.ForeColor = System.Drawing.Color.White;
            this.LblSchedule.Location = new System.Drawing.Point(15, 315);
            this.LblSchedule.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblSchedule.Name = "LblSchedule";
            this.LblSchedule.Size = new System.Drawing.Size(52, 13);
            this.LblSchedule.TabIndex = 9;
            this.LblSchedule.Text = "Schedule";
            // 
            // LblCapacity
            // 
            this.LblCapacity.AutoSize = true;
            this.LblCapacity.ForeColor = System.Drawing.Color.White;
            this.LblCapacity.Location = new System.Drawing.Point(15, 373);
            this.LblCapacity.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblCapacity.Name = "LblCapacity";
            this.LblCapacity.Size = new System.Drawing.Size(48, 13);
            this.LblCapacity.TabIndex = 11;
            this.LblCapacity.Text = "Capacity";
            // 
            // numericCapacity
            // 
            this.numericCapacity.Location = new System.Drawing.Point(14, 400);
            this.numericCapacity.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.numericCapacity.Name = "numericCapacity";
            this.numericCapacity.Size = new System.Drawing.Size(77, 20);
            this.numericCapacity.TabIndex = 12;
            // 
            // TxtSchedule
            // 
            this.TxtSchedule.Location = new System.Drawing.Point(14, 336);
            this.TxtSchedule.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TxtSchedule.Name = "TxtSchedule";
            this.TxtSchedule.Size = new System.Drawing.Size(154, 20);
            this.TxtSchedule.TabIndex = 8;
            // 
            // numericDuration
            // 
            this.numericDuration.Location = new System.Drawing.Point(11, 466);
            this.numericDuration.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.numericDuration.Name = "numericDuration";
            this.numericDuration.Size = new System.Drawing.Size(80, 20);
            this.numericDuration.TabIndex = 14;
            // 
            // LblDuration
            // 
            this.LblDuration.AutoSize = true;
            this.LblDuration.ForeColor = System.Drawing.Color.White;
            this.LblDuration.Location = new System.Drawing.Point(12, 439);
            this.LblDuration.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblDuration.Name = "LblDuration";
            this.LblDuration.Size = new System.Drawing.Size(47, 13);
            this.LblDuration.TabIndex = 13;
            this.LblDuration.Text = "Duration";
            // 
            // btnUpdateClass
            // 
            this.btnUpdateClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnUpdateClass.Location = new System.Drawing.Point(392, 439);
            this.btnUpdateClass.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.Size = new System.Drawing.Size(97, 29);
            this.btnUpdateClass.TabIndex = 15;
            this.btnUpdateClass.Text = "Update Class";
            this.btnUpdateClass.UseVisualStyleBackColor = false;
            this.btnUpdateClass.Click += new System.EventHandler(this.btnUpdateClass_Click);
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnDeleteClass.Location = new System.Drawing.Point(502, 439);
            this.btnDeleteClass.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(97, 29);
            this.btnDeleteClass.TabIndex = 16;
            this.btnDeleteClass.Text = "Delete Class";
            this.btnDeleteClass.UseVisualStyleBackColor = false;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            // 
            // DashHeaderPanel
            // 
            this.DashHeaderPanel.BackColor = System.Drawing.Color.Red;
            this.DashHeaderPanel.Controls.Add(this.label1);
            this.DashHeaderPanel.Location = new System.Drawing.Point(0, 1);
            this.DashHeaderPanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.DashHeaderPanel.Name = "DashHeaderPanel";
            this.DashHeaderPanel.Size = new System.Drawing.Size(733, 64);
            this.DashHeaderPanel.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Classes";
            // 
            // FrmClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(722, 502);
            this.Controls.Add(this.DashHeaderPanel);
            this.Controls.Add(this.btnDeleteClass);
            this.Controls.Add(this.btnUpdateClass);
            this.Controls.Add(this.numericDuration);
            this.Controls.Add(this.LblDuration);
            this.Controls.Add(this.numericCapacity);
            this.Controls.Add(this.LblCapacity);
            this.Controls.Add(this.LblSchedule);
            this.Controls.Add(this.TxtSchedule);
            this.Controls.Add(this.LblInstructor);
            this.Controls.Add(this.TxtInstructor);
            this.Controls.Add(this.TxtDesc);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.LblClassName);
            this.Controls.Add(this.TxtClassName);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.dgvClasses);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FrmClasses";
            this.Text = "FrmClasses";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDuration)).EndInit();
            this.DashHeaderPanel.ResumeLayout(false);
            this.DashHeaderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.TextBox TxtClassName;
        private System.Windows.Forms.Label LblClassName;
        private System.Windows.Forms.Label TxtDesc;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label LblInstructor;
        private System.Windows.Forms.TextBox TxtInstructor;
        private System.Windows.Forms.Label LblSchedule;
        private System.Windows.Forms.Label LblCapacity;
        private System.Windows.Forms.NumericUpDown numericCapacity;
        private System.Windows.Forms.TextBox TxtSchedule;
        private System.Windows.Forms.NumericUpDown numericDuration;
        private System.Windows.Forms.Label LblDuration;
        private System.Windows.Forms.Button btnUpdateClass;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.Panel DashHeaderPanel;
        private System.Windows.Forms.Label label1;
    }
}