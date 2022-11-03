namespace WindowsFormsApp1
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            System.Windows.Forms.Label no_zkLabel;
            System.Windows.Forms.Label famLabel;
            System.Windows.Forms.Label imLabel;
            System.Windows.Forms.Label otLabel;
            System.Windows.Forms.Label specLabel;
            System.Windows.Forms.Label kursLabel;
            System.Windows.Forms.Label grLabel;
            System.Windows.Forms.Label data_rLabel;
            System.Windows.Forms.Label biogrLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.bd1DataSet = new WindowsFormsApp1.bd1DataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new WindowsFormsApp1.bd1DataSetTableAdapters.StudentsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.bd1DataSetTableAdapters.TableAdapterManager();
            this.studentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.studentsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.no_zkTextBox = new System.Windows.Forms.TextBox();
            this.famTextBox = new System.Windows.Forms.TextBox();
            this.imTextBox = new System.Windows.Forms.TextBox();
            this.otTextBox = new System.Windows.Forms.TextBox();
            this.specTextBox = new System.Windows.Forms.TextBox();
            this.kursTextBox = new System.Windows.Forms.TextBox();
            this.grTextBox = new System.Windows.Forms.TextBox();
            this.data_rDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.biogrTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            no_zkLabel = new System.Windows.Forms.Label();
            famLabel = new System.Windows.Forms.Label();
            imLabel = new System.Windows.Forms.Label();
            otLabel = new System.Windows.Forms.Label();
            specLabel = new System.Windows.Forms.Label();
            kursLabel = new System.Windows.Forms.Label();
            grLabel = new System.Windows.Forms.Label();
            data_rLabel = new System.Windows.Forms.Label();
            biogrLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingNavigator)).BeginInit();
            this.studentsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(102, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Студенты";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bd1DataSet
            // 
            this.bd1DataSet.DataSetName = "bd1DataSet";
            this.bd1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.bd1DataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.Subjects_KarimovTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.bd1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Uspev_KarimovTableAdapter = null;
            // 
            // studentsBindingNavigator
            // 
            this.studentsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentsBindingNavigator.BindingSource = this.studentsBindingSource;
            this.studentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.studentsBindingNavigatorSaveItem});
            this.studentsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentsBindingNavigator.Name = "studentsBindingNavigator";
            this.studentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentsBindingNavigator.Size = new System.Drawing.Size(360, 25);
            this.studentsBindingNavigator.TabIndex = 1;
            this.studentsBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // studentsBindingNavigatorSaveItem
            // 
            this.studentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentsBindingNavigatorSaveItem.Image")));
            this.studentsBindingNavigatorSaveItem.Name = "studentsBindingNavigatorSaveItem";
            this.studentsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.studentsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.studentsBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentsBindingNavigatorSaveItem_Click);
            // 
            // no_zkLabel
            // 
            no_zkLabel.AutoSize = true;
            no_zkLabel.Location = new System.Drawing.Point(43, 114);
            no_zkLabel.Name = "no_zkLabel";
            no_zkLabel.Size = new System.Drawing.Size(58, 13);
            no_zkLabel.TabIndex = 2;
            no_zkLabel.Text = "Номер ЗК";
            no_zkLabel.Click += new System.EventHandler(this.no_zkLabel_Click);
            // 
            // no_zkTextBox
            // 
            this.no_zkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "no_zk", true));
            this.no_zkTextBox.Location = new System.Drawing.Point(106, 111);
            this.no_zkTextBox.Name = "no_zkTextBox";
            this.no_zkTextBox.Size = new System.Drawing.Size(100, 20);
            this.no_zkTextBox.TabIndex = 3;
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Location = new System.Drawing.Point(45, 167);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(56, 13);
            famLabel.TabIndex = 4;
            famLabel.Text = "Фамилия";
            // 
            // famTextBox
            // 
            this.famTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "fam", true));
            this.famTextBox.Location = new System.Drawing.Point(106, 164);
            this.famTextBox.Name = "famTextBox";
            this.famTextBox.Size = new System.Drawing.Size(100, 20);
            this.famTextBox.TabIndex = 5;
            // 
            // imLabel
            // 
            imLabel.AutoSize = true;
            imLabel.Location = new System.Drawing.Point(71, 223);
            imLabel.Name = "imLabel";
            imLabel.Size = new System.Drawing.Size(29, 13);
            imLabel.TabIndex = 6;
            imLabel.Text = "Имя";
            // 
            // imTextBox
            // 
            this.imTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "im", true));
            this.imTextBox.Location = new System.Drawing.Point(106, 223);
            this.imTextBox.Name = "imTextBox";
            this.imTextBox.Size = new System.Drawing.Size(100, 20);
            this.imTextBox.TabIndex = 7;
            // 
            // otLabel
            // 
            otLabel.AutoSize = true;
            otLabel.Location = new System.Drawing.Point(47, 288);
            otLabel.Name = "otLabel";
            otLabel.Size = new System.Drawing.Size(54, 13);
            otLabel.TabIndex = 8;
            otLabel.Text = "Отчество";
            // 
            // otTextBox
            // 
            this.otTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "ot", true));
            this.otTextBox.Location = new System.Drawing.Point(107, 285);
            this.otTextBox.Name = "otTextBox";
            this.otTextBox.Size = new System.Drawing.Size(100, 20);
            this.otTextBox.TabIndex = 9;
            // 
            // specLabel
            // 
            specLabel.AutoSize = true;
            specLabel.Location = new System.Drawing.Point(16, 353);
            specLabel.Name = "specLabel";
            specLabel.Size = new System.Drawing.Size(85, 13);
            specLabel.TabIndex = 10;
            specLabel.Text = "Специальность";
            // 
            // specTextBox
            // 
            this.specTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "spec", true));
            this.specTextBox.Location = new System.Drawing.Point(106, 350);
            this.specTextBox.Name = "specTextBox";
            this.specTextBox.Size = new System.Drawing.Size(100, 20);
            this.specTextBox.TabIndex = 11;
            // 
            // kursLabel
            // 
            kursLabel.AutoSize = true;
            kursLabel.Location = new System.Drawing.Point(71, 417);
            kursLabel.Name = "kursLabel";
            kursLabel.Size = new System.Drawing.Size(31, 13);
            kursLabel.TabIndex = 12;
            kursLabel.Text = "Курс";
            // 
            // kursTextBox
            // 
            this.kursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "kurs", true));
            this.kursTextBox.Location = new System.Drawing.Point(107, 414);
            this.kursTextBox.Name = "kursTextBox";
            this.kursTextBox.Size = new System.Drawing.Size(100, 20);
            this.kursTextBox.TabIndex = 13;
            // 
            // grLabel
            // 
            grLabel.AutoSize = true;
            grLabel.Location = new System.Drawing.Point(58, 470);
            grLabel.Name = "grLabel";
            grLabel.Size = new System.Drawing.Size(42, 13);
            grLabel.TabIndex = 14;
            grLabel.Text = "Группа";
            // 
            // grTextBox
            // 
            this.grTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "gr", true));
            this.grTextBox.Location = new System.Drawing.Point(107, 470);
            this.grTextBox.Name = "grTextBox";
            this.grTextBox.Size = new System.Drawing.Size(100, 20);
            this.grTextBox.TabIndex = 15;
            // 
            // data_rLabel
            // 
            data_rLabel.AutoSize = true;
            data_rLabel.Location = new System.Drawing.Point(63, 542);
            data_rLabel.Name = "data_rLabel";
            data_rLabel.Size = new System.Drawing.Size(33, 13);
            data_rLabel.TabIndex = 16;
            data_rLabel.Text = "Дата";
            // 
            // data_rDateTimePicker
            // 
            this.data_rDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentsBindingSource, "data_r", true));
            this.data_rDateTimePicker.Location = new System.Drawing.Point(106, 538);
            this.data_rDateTimePicker.Name = "data_rDateTimePicker";
            this.data_rDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_rDateTimePicker.TabIndex = 17;
            // 
            // biogrLabel
            // 
            biogrLabel.AutoSize = true;
            biogrLabel.Location = new System.Drawing.Point(39, 604);
            biogrLabel.Name = "biogrLabel";
            biogrLabel.Size = new System.Drawing.Size(63, 13);
            biogrLabel.TabIndex = 18;
            biogrLabel.Text = "Биография";
            // 
            // biogrTextBox
            // 
            this.biogrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "biogr", true));
            this.biogrTextBox.Location = new System.Drawing.Point(107, 601);
            this.biogrTextBox.Name = "biogrTextBox";
            this.biogrTextBox.Size = new System.Drawing.Size(100, 20);
            this.biogrTextBox.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 663);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Список студентов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 710);
            this.Controls.Add(this.button1);
            this.Controls.Add(biogrLabel);
            this.Controls.Add(this.biogrTextBox);
            this.Controls.Add(data_rLabel);
            this.Controls.Add(this.data_rDateTimePicker);
            this.Controls.Add(grLabel);
            this.Controls.Add(this.grTextBox);
            this.Controls.Add(kursLabel);
            this.Controls.Add(this.kursTextBox);
            this.Controls.Add(specLabel);
            this.Controls.Add(this.specTextBox);
            this.Controls.Add(otLabel);
            this.Controls.Add(this.otTextBox);
            this.Controls.Add(imLabel);
            this.Controls.Add(this.imTextBox);
            this.Controls.Add(famLabel);
            this.Controls.Add(this.famTextBox);
            this.Controls.Add(no_zkLabel);
            this.Controls.Add(this.no_zkTextBox);
            this.Controls.Add(this.studentsBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Students";
            this.Text = " Студенты_Каримов";
            this.Load += new System.EventHandler(this.Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingNavigator)).EndInit();
            this.studentsBindingNavigator.ResumeLayout(false);
            this.studentsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private bd1DataSet bd1DataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private bd1DataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private bd1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton studentsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox no_zkTextBox;
        private System.Windows.Forms.TextBox famTextBox;
        private System.Windows.Forms.TextBox imTextBox;
        private System.Windows.Forms.TextBox otTextBox;
        private System.Windows.Forms.TextBox specTextBox;
        private System.Windows.Forms.TextBox kursTextBox;
        private System.Windows.Forms.TextBox grTextBox;
        private System.Windows.Forms.DateTimePicker data_rDateTimePicker;
        private System.Windows.Forms.TextBox biogrTextBox;
        private System.Windows.Forms.Button button1;
    }
}