namespace INFOSiSView
{
    partial class frmCoursesManager
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblRequisite = new System.Windows.Forms.Label();
            this.lblSyllabus = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAddSyllabus = new System.Windows.Forms.Button();
            this.btnAddRequisite = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCourseType = new System.Windows.Forms.Label();
            this.cmbCourseType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Id,
            this.Description});
            this.dataGridView.Location = new System.Drawing.Point(67, 239);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(628, 222);
            this.dataGridView.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(97, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(101, 49);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(43, 13);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Código:";
            // 
            // lblRequisite
            // 
            this.lblRequisite.AutoSize = true;
            this.lblRequisite.Location = new System.Drawing.Point(90, 153);
            this.lblRequisite.Name = "lblRequisite";
            this.lblRequisite.Size = new System.Drawing.Size(54, 13);
            this.lblRequisite.TabIndex = 3;
            this.lblRequisite.Text = "Requisito:";
            // 
            // lblSyllabus
            // 
            this.lblSyllabus.AutoSize = true;
            this.lblSyllabus.Location = new System.Drawing.Point(103, 179);
            this.lblSyllabus.Name = "lblSyllabus";
            this.lblSyllabus.Size = new System.Drawing.Size(41, 13);
            this.lblSyllabus.TabIndex = 4;
            this.lblSyllabus.Text = "Sílabo:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(78, 75);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(66, 13);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Descripción:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(296, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(150, 72);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(296, 72);
            this.txtDescription.TabIndex = 7;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(150, 46);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(296, 20);
            this.txtId.TabIndex = 8;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(610, 20);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 20);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(610, 72);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(85, 20);
            this.btnDisable.TabIndex = 10;
            this.btnDisable.Text = "Deshabilitar";
            this.btnDisable.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(610, 46);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(85, 20);
            this.btnModify.TabIndex = 11;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnAddSyllabus
            // 
            this.btnAddSyllabus.Location = new System.Drawing.Point(150, 175);
            this.btnAddSyllabus.Name = "btnAddSyllabus";
            this.btnAddSyllabus.Size = new System.Drawing.Size(139, 20);
            this.btnAddSyllabus.TabIndex = 12;
            this.btnAddSyllabus.Text = "Agregar Sílabo";
            this.btnAddSyllabus.UseVisualStyleBackColor = true;
            // 
            // btnAddRequisite
            // 
            this.btnAddRequisite.Location = new System.Drawing.Point(150, 149);
            this.btnAddRequisite.Name = "btnAddRequisite";
            this.btnAddRequisite.Size = new System.Drawing.Size(139, 20);
            this.btnAddRequisite.TabIndex = 13;
            this.btnAddRequisite.Text = "Agregar Requisito";
            this.btnAddRequisite.UseVisualStyleBackColor = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Nombre";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 200;
            // 
            // Id
            // 
            this.Id.HeaderText = "Código";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Descripción";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 300;
            // 
            // lblCourseType
            // 
            this.lblCourseType.AutoSize = true;
            this.lblCourseType.Location = new System.Drawing.Point(69, 205);
            this.lblCourseType.Name = "lblCourseType";
            this.lblCourseType.Size = new System.Drawing.Size(75, 13);
            this.lblCourseType.TabIndex = 14;
            this.lblCourseType.Text = "Tipo de curso:";
            // 
            // cmbCourseType
            // 
            this.cmbCourseType.FormattingEnabled = true;
            this.cmbCourseType.Location = new System.Drawing.Point(150, 202);
            this.cmbCourseType.Name = "cmbCourseType";
            this.cmbCourseType.Size = new System.Drawing.Size(137, 21);
            this.cmbCourseType.TabIndex = 15;
            // 
            // frmCoursesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 513);
            this.Controls.Add(this.cmbCourseType);
            this.Controls.Add(this.lblCourseType);
            this.Controls.Add(this.btnAddRequisite);
            this.Controls.Add(this.btnAddSyllabus);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblSyllabus);
            this.Controls.Add(this.lblRequisite);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dataGridView);
            this.Name = "frmCoursesManager";
            this.Text = "Gestión de Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblRequisite;
        private System.Windows.Forms.Label lblSyllabus;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAddSyllabus;
        private System.Windows.Forms.Button btnAddRequisite;
        private System.Windows.Forms.Label lblCourseType;
        private System.Windows.Forms.ComboBox cmbCourseType;
    }
}