namespace WindowsFormsApp1
{
    partial class Uspev
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
            System.Windows.Forms.Label studentLabel;
            System.Windows.Forms.Label predmetLabel;
            System.Windows.Forms.Label ocenkaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uspev));
            this.label1 = new System.Windows.Forms.Label();
            this.bd1DataSet = new WindowsFormsApp1.bd1DataSet();
            this.uspev_KarimovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspev_KarimovTableAdapter = new WindowsFormsApp1.bd1DataSetTableAdapters.Uspev_KarimovTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.bd1DataSetTableAdapters.TableAdapterManager();
            this.uspev_KarimovBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.uspev_KarimovBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.studentTextBox = new System.Windows.Forms.TextBox();
            this.predmetTextBox = new System.Windows.Forms.TextBox();
            this.ocenkaTextBox = new System.Windows.Forms.TextBox();
            studentLabel = new System.Windows.Forms.Label();
            predmetLabel = new System.Windows.Forms.Label();
            ocenkaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspev_KarimovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspev_KarimovBindingNavigator)).BeginInit();
            this.uspev_KarimovBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentLabel
            // 
            studentLabel.AutoSize = true;
            studentLabel.Location = new System.Drawing.Point(93, 127);
            studentLabel.Name = "studentLabel";
            studentLabel.Size = new System.Drawing.Size(47, 13);
            studentLabel.TabIndex = 2;
            studentLabel.Text = "Студент";
            // 
            // predmetLabel
            // 
            predmetLabel.AutoSize = true;
            predmetLabel.Location = new System.Drawing.Point(70, 212);
            predmetLabel.Name = "predmetLabel";
            predmetLabel.Size = new System.Drawing.Size(70, 13);
            predmetLabel.TabIndex = 4;
            predmetLabel.Text = "Дисциплина";
            // 
            // ocenkaLabel
            // 
            ocenkaLabel.AutoSize = true;
            ocenkaLabel.Location = new System.Drawing.Point(92, 325);
            ocenkaLabel.Name = "ocenkaLabel";
            ocenkaLabel.Size = new System.Drawing.Size(45, 13);
            ocenkaLabel.TabIndex = 6;
            ocenkaLabel.Text = "Оценка";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(140, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Успеваемость";
            // 
            // bd1DataSet
            // 
            this.bd1DataSet.DataSetName = "bd1DataSet";
            this.bd1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspev_KarimovBindingSource
            // 
            this.uspev_KarimovBindingSource.DataMember = "Uspev_Karimov";
            this.uspev_KarimovBindingSource.DataSource = this.bd1DataSet;
            // 
            // uspev_KarimovTableAdapter
            // 
            this.uspev_KarimovTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.Subjects_KarimovTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.bd1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Uspev_KarimovTableAdapter = this.uspev_KarimovTableAdapter;
            // 
            // uspev_KarimovBindingNavigator
            // 
            this.uspev_KarimovBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uspev_KarimovBindingNavigator.BindingSource = this.uspev_KarimovBindingSource;
            this.uspev_KarimovBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uspev_KarimovBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uspev_KarimovBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.uspev_KarimovBindingNavigatorSaveItem});
            this.uspev_KarimovBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uspev_KarimovBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uspev_KarimovBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uspev_KarimovBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uspev_KarimovBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uspev_KarimovBindingNavigator.Name = "uspev_KarimovBindingNavigator";
            this.uspev_KarimovBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uspev_KarimovBindingNavigator.Size = new System.Drawing.Size(372, 25);
            this.uspev_KarimovBindingNavigator.TabIndex = 1;
            this.uspev_KarimovBindingNavigator.Text = "bindingNavigator1";
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
            // uspev_KarimovBindingNavigatorSaveItem
            // 
            this.uspev_KarimovBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uspev_KarimovBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uspev_KarimovBindingNavigatorSaveItem.Image")));
            this.uspev_KarimovBindingNavigatorSaveItem.Name = "uspev_KarimovBindingNavigatorSaveItem";
            this.uspev_KarimovBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.uspev_KarimovBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.uspev_KarimovBindingNavigatorSaveItem.Click += new System.EventHandler(this.uspev_KarimovBindingNavigatorSaveItem_Click);
            // 
            // studentTextBox
            // 
            this.studentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspev_KarimovBindingSource, "student", true));
            this.studentTextBox.Location = new System.Drawing.Point(144, 124);
            this.studentTextBox.Name = "studentTextBox";
            this.studentTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentTextBox.TabIndex = 3;
            // 
            // predmetTextBox
            // 
            this.predmetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspev_KarimovBindingSource, "predmet", true));
            this.predmetTextBox.Location = new System.Drawing.Point(144, 205);
            this.predmetTextBox.Name = "predmetTextBox";
            this.predmetTextBox.Size = new System.Drawing.Size(100, 20);
            this.predmetTextBox.TabIndex = 5;
            // 
            // ocenkaTextBox
            // 
            this.ocenkaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspev_KarimovBindingSource, "ocenka", true));
            this.ocenkaTextBox.Location = new System.Drawing.Point(144, 322);
            this.ocenkaTextBox.Name = "ocenkaTextBox";
            this.ocenkaTextBox.Size = new System.Drawing.Size(100, 20);
            this.ocenkaTextBox.TabIndex = 7;
            // 
            // Uspev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 450);
            this.Controls.Add(ocenkaLabel);
            this.Controls.Add(this.ocenkaTextBox);
            this.Controls.Add(predmetLabel);
            this.Controls.Add(this.predmetTextBox);
            this.Controls.Add(studentLabel);
            this.Controls.Add(this.studentTextBox);
            this.Controls.Add(this.uspev_KarimovBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Uspev";
            this.Text = "Успеваемость";
            this.Load += new System.EventHandler(this.Uspev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspev_KarimovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspev_KarimovBindingNavigator)).EndInit();
            this.uspev_KarimovBindingNavigator.ResumeLayout(false);
            this.uspev_KarimovBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private bd1DataSet bd1DataSet;
        private System.Windows.Forms.BindingSource uspev_KarimovBindingSource;
        private bd1DataSetTableAdapters.Uspev_KarimovTableAdapter uspev_KarimovTableAdapter;
        private bd1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uspev_KarimovBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton uspev_KarimovBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox studentTextBox;
        private System.Windows.Forms.TextBox predmetTextBox;
        private System.Windows.Forms.TextBox ocenkaTextBox;
    }
}