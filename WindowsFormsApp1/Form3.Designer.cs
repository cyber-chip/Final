namespace WindowsFormsApp1
{
    partial class Subjects
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label hrsLabel;
            System.Windows.Forms.Label deptLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subjects));
            this.label1 = new System.Windows.Forms.Label();
            this.bd1DataSet = new WindowsFormsApp1.bd1DataSet();
            this.subjects_KarimovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjects_KarimovTableAdapter = new WindowsFormsApp1.bd1DataSetTableAdapters.Subjects_KarimovTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.bd1DataSetTableAdapters.TableAdapterManager();
            this.subjects_KarimovBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.subjects_KarimovBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.hrsTextBox = new System.Windows.Forms.TextBox();
            this.deptTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            hrsLabel = new System.Windows.Forms.Label();
            deptLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_KarimovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_KarimovBindingNavigator)).BeginInit();
            this.subjects_KarimovBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(57, 145);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(57, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Название";
            // 
            // hrsLabel
            // 
            hrsLabel.AutoSize = true;
            hrsLabel.Location = new System.Drawing.Point(33, 225);
            hrsLabel.Name = "hrsLabel";
            hrsLabel.Size = new System.Drawing.Size(81, 13);
            hrsLabel.TabIndex = 4;
            hrsLabel.Text = "Обьем в часах";
            // 
            // deptLabel
            // 
            deptLabel.AutoSize = true;
            deptLabel.Location = new System.Drawing.Point(62, 331);
            deptLabel.Name = "deptLabel";
            deptLabel.Size = new System.Drawing.Size(52, 13);
            deptLabel.TabIndex = 6;
            deptLabel.Text = "Кафедра";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(116, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дисциплины";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bd1DataSet
            // 
            this.bd1DataSet.DataSetName = "bd1DataSet";
            this.bd1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjects_KarimovBindingSource
            // 
            this.subjects_KarimovBindingSource.DataMember = "Subjects_Karimov";
            this.subjects_KarimovBindingSource.DataSource = this.bd1DataSet;
            // 
            // subjects_KarimovTableAdapter
            // 
            this.subjects_KarimovTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.Subjects_KarimovTableAdapter = this.subjects_KarimovTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.bd1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Uspev_KarimovTableAdapter = null;
            // 
            // subjects_KarimovBindingNavigator
            // 
            this.subjects_KarimovBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.subjects_KarimovBindingNavigator.BindingSource = this.subjects_KarimovBindingSource;
            this.subjects_KarimovBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.subjects_KarimovBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.subjects_KarimovBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.subjects_KarimovBindingNavigatorSaveItem});
            this.subjects_KarimovBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.subjects_KarimovBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.subjects_KarimovBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.subjects_KarimovBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.subjects_KarimovBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.subjects_KarimovBindingNavigator.Name = "subjects_KarimovBindingNavigator";
            this.subjects_KarimovBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.subjects_KarimovBindingNavigator.Size = new System.Drawing.Size(300, 25);
            this.subjects_KarimovBindingNavigator.TabIndex = 1;
            this.subjects_KarimovBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // subjects_KarimovBindingNavigatorSaveItem
            // 
            this.subjects_KarimovBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.subjects_KarimovBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("subjects_KarimovBindingNavigatorSaveItem.Image")));
            this.subjects_KarimovBindingNavigatorSaveItem.Name = "subjects_KarimovBindingNavigatorSaveItem";
            this.subjects_KarimovBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.subjects_KarimovBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.subjects_KarimovBindingNavigatorSaveItem.Click += new System.EventHandler(this.subjects_KarimovBindingNavigatorSaveItem_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjects_KarimovBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(120, 145);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // hrsTextBox
            // 
            this.hrsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjects_KarimovBindingSource, "hrs", true));
            this.hrsTextBox.Location = new System.Drawing.Point(120, 225);
            this.hrsTextBox.Name = "hrsTextBox";
            this.hrsTextBox.Size = new System.Drawing.Size(100, 20);
            this.hrsTextBox.TabIndex = 5;
            // 
            // deptTextBox
            // 
            this.deptTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjects_KarimovBindingSource, "dept", true));
            this.deptTextBox.Location = new System.Drawing.Point(120, 324);
            this.deptTextBox.Name = "deptTextBox";
            this.deptTextBox.Size = new System.Drawing.Size(100, 20);
            this.deptTextBox.TabIndex = 7;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(deptLabel);
            this.Controls.Add(this.deptTextBox);
            this.Controls.Add(hrsLabel);
            this.Controls.Add(this.hrsTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.subjects_KarimovBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Subjects";
            this.Text = "Дисциплины";
            this.Load += new System.EventHandler(this.Subjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_KarimovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_KarimovBindingNavigator)).EndInit();
            this.subjects_KarimovBindingNavigator.ResumeLayout(false);
            this.subjects_KarimovBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private bd1DataSet bd1DataSet;
        private System.Windows.Forms.BindingSource subjects_KarimovBindingSource;
        private bd1DataSetTableAdapters.Subjects_KarimovTableAdapter subjects_KarimovTableAdapter;
        private bd1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator subjects_KarimovBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton subjects_KarimovBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox hrsTextBox;
        private System.Windows.Forms.TextBox deptTextBox;
    }
}