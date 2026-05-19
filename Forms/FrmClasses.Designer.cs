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
            this.dgvClasses.Location = new System.Drawing.Point(754, 311);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.RowHeadersWidth = 102;
            this.dgvClasses.RowTemplate.Height = 40;
            this.dgvClasses.Size = new System.Drawing.Size(1081, 692);
            this.dgvClasses.TabIndex = 0;
            this.dgvClasses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasses_CellClick);
            // 
            // btnAddClass
            // 
            this.btnAddClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnAddClass.Location = new System.Drawing.Point(754, 1047);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(259, 69);
            this.btnAddClass.TabIndex = 1;
            this.btnAddClass.Text = "Add Class";
            this.btnAddClass.UseVisualStyleBackColor = false;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // TxtClassName
            // 
            this.TxtClassName.Location = new System.Drawing.Point(38, 386);
            this.TxtClassName.Name = "TxtClassName";
            this.TxtClassName.Size = new System.Drawing.Size(317, 38);
            this.TxtClassName.TabIndex = 2;
            // 
            // LblClassName
            // 
            this.LblClassName.AutoSize = true;
            this.LblClassName.ForeColor = System.Drawing.Color.White;
            this.LblClassName.Location = new System.Drawing.Point(41, 334);
            this.LblClassName.Name = "LblClassName";
            this.LblClassName.Size = new System.Drawing.Size(167, 32);
            this.LblClassName.TabIndex = 3;
            this.LblClassName.Text = "Class Name";
            // 
            // TxtDesc
            // 
            this.TxtDesc.AutoSize = true;
            this.TxtDesc.ForeColor = System.Drawing.Color.White;
            this.TxtDesc.Location = new System.Drawing.Point(41, 454);
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(157, 32);
            this.TxtDesc.TabIndex = 5;
            this.TxtDesc.Text = "Description";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(38, 506);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(404, 38);
            this.TxtDescription.TabIndex = 4;
            // 
            // LblInstructor
            // 
            this.LblInstructor.AutoSize = true;
            this.LblInstructor.ForeColor = System.Drawing.Color.White;
            this.LblInstructor.Location = new System.Drawing.Point(41, 611);
            this.LblInstructor.Name = "LblInstructor";
            this.LblInstructor.Size = new System.Drawing.Size(131, 32);
            this.LblInstructor.TabIndex = 7;
            this.LblInstructor.Text = "Instructor";
            // 
            // TxtInstructor
            // 
            this.TxtInstructor.Location = new System.Drawing.Point(38, 663);
            this.TxtInstructor.Name = "TxtInstructor";
            this.TxtInstructor.Size = new System.Drawing.Size(317, 38);
            this.TxtInstructor.TabIndex = 6;
            // 
            // LblSchedule
            // 
            this.LblSchedule.AutoSize = true;
            this.LblSchedule.ForeColor = System.Drawing.Color.White;
            this.LblSchedule.Location = new System.Drawing.Point(41, 750);
            this.LblSchedule.Name = "LblSchedule";
            this.LblSchedule.Size = new System.Drawing.Size(134, 32);
            this.LblSchedule.TabIndex = 9;
            this.LblSchedule.Text = "Schedule";
            // 
            // LblCapacity
            // 
            this.LblCapacity.AutoSize = true;
            this.LblCapacity.ForeColor = System.Drawing.Color.White;
            this.LblCapacity.Location = new System.Drawing.Point(41, 890);
            this.LblCapacity.Name = "LblCapacity";
            this.LblCapacity.Size = new System.Drawing.Size(125, 32);
            this.LblCapacity.TabIndex = 11;
            this.LblCapacity.Text = "Capacity";
            // 
            // numericCapacity
            // 
            this.numericCapacity.Location = new System.Drawing.Point(38, 955);
            this.numericCapacity.Name = "numericCapacity";
            this.numericCapacity.Size = new System.Drawing.Size(170, 38);
            this.numericCapacity.TabIndex = 12;
            // 
            // TxtSchedule
            // 
            this.TxtSchedule.Location = new System.Drawing.Point(38, 802);
            this.TxtSchedule.Name = "TxtSchedule";
            this.TxtSchedule.Size = new System.Drawing.Size(317, 38);
            this.TxtSchedule.TabIndex = 8;
            // 
            // numericDuration
            // 
            this.numericDuration.Location = new System.Drawing.Point(29, 1112);
            this.numericDuration.Name = "numericDuration";
            this.numericDuration.Size = new System.Drawing.Size(170, 38);
            this.numericDuration.TabIndex = 14;
            // 
            // LblDuration
            // 
            this.LblDuration.AutoSize = true;
            this.LblDuration.ForeColor = System.Drawing.Color.White;
            this.LblDuration.Location = new System.Drawing.Point(32, 1047);
            this.LblDuration.Name = "LblDuration";
            this.LblDuration.Size = new System.Drawing.Size(122, 32);
            this.LblDuration.TabIndex = 13;
            this.LblDuration.Text = "Duration";
            // 
            // btnUpdateClass
            // 
            this.btnUpdateClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnUpdateClass.Location = new System.Drawing.Point(1045, 1047);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.Size = new System.Drawing.Size(259, 69);
            this.btnUpdateClass.TabIndex = 15;
            this.btnUpdateClass.Text = "Update Class";
            this.btnUpdateClass.UseVisualStyleBackColor = false;
            this.btnUpdateClass.Click += new System.EventHandler(this.btnUpdateClass_Click);
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(16)))), ((int)(((byte)(46)))));
            this.btnDeleteClass.Location = new System.Drawing.Point(1339, 1047);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(259, 69);
            this.btnDeleteClass.TabIndex = 16;
            this.btnDeleteClass.Text = "Delete Class";
            this.btnDeleteClass.UseVisualStyleBackColor = false;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            // 
            // DashHeaderPanel
            // 
            this.DashHeaderPanel.BackColor = System.Drawing.Color.Red;
            this.DashHeaderPanel.Controls.Add(this.label1);
            this.DashHeaderPanel.Location = new System.Drawing.Point(-1, 3);
            this.DashHeaderPanel.Name = "DashHeaderPanel";
            this.DashHeaderPanel.Size = new System.Drawing.Size(1954, 152);
            this.DashHeaderPanel.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Classes";
            // 
            // FrmClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1940, 1205);
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