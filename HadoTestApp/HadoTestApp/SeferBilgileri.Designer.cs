
namespace HadoTestApp
{
    partial class SeferBilgileri
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.doIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seabusnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seabusaktifgunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seabusaktifsaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seabushatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tseferinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dotobusbaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dotobusbaseDataSet = new HadoTestApp.dotobusbaseDataSet();
            this.t_seferinfoTableAdapter = new HadoTestApp.dotobusbaseDataSetTableAdapters.t_seferinfoTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tseferinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotobusbaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotobusbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(119, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deniz Otobüsleri Sefer Bilgileri";
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(107)))), ((int)(((byte)(101)))));
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doIDDataGridViewTextBoxColumn,
            this.seabusnameDataGridViewTextBoxColumn,
            this.seabusaktifgunDataGridViewTextBoxColumn,
            this.seabusaktifsaatDataGridViewTextBoxColumn,
            this.seabushatDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.tseferinfoBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(126, 107);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(929, 461);
            this.dataGridView5.TabIndex = 3;
            // 
            // doIDDataGridViewTextBoxColumn
            // 
            this.doIDDataGridViewTextBoxColumn.DataPropertyName = "doID";
            this.doIDDataGridViewTextBoxColumn.HeaderText = "doID";
            this.doIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doIDDataGridViewTextBoxColumn.Name = "doIDDataGridViewTextBoxColumn";
            this.doIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.doIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // seabusnameDataGridViewTextBoxColumn
            // 
            this.seabusnameDataGridViewTextBoxColumn.DataPropertyName = "seabusname";
            this.seabusnameDataGridViewTextBoxColumn.HeaderText = "seabusname";
            this.seabusnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seabusnameDataGridViewTextBoxColumn.Name = "seabusnameDataGridViewTextBoxColumn";
            this.seabusnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // seabusaktifgunDataGridViewTextBoxColumn
            // 
            this.seabusaktifgunDataGridViewTextBoxColumn.DataPropertyName = "seabusaktifgun";
            this.seabusaktifgunDataGridViewTextBoxColumn.HeaderText = "seabusaktifgun";
            this.seabusaktifgunDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seabusaktifgunDataGridViewTextBoxColumn.Name = "seabusaktifgunDataGridViewTextBoxColumn";
            this.seabusaktifgunDataGridViewTextBoxColumn.Width = 125;
            // 
            // seabusaktifsaatDataGridViewTextBoxColumn
            // 
            this.seabusaktifsaatDataGridViewTextBoxColumn.DataPropertyName = "seabusaktifsaat";
            this.seabusaktifsaatDataGridViewTextBoxColumn.HeaderText = "seabusaktifsaat";
            this.seabusaktifsaatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seabusaktifsaatDataGridViewTextBoxColumn.Name = "seabusaktifsaatDataGridViewTextBoxColumn";
            this.seabusaktifsaatDataGridViewTextBoxColumn.Width = 125;
            // 
            // seabushatDataGridViewTextBoxColumn
            // 
            this.seabushatDataGridViewTextBoxColumn.DataPropertyName = "seabushat";
            this.seabushatDataGridViewTextBoxColumn.HeaderText = "seabushat";
            this.seabushatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seabushatDataGridViewTextBoxColumn.Name = "seabushatDataGridViewTextBoxColumn";
            this.seabushatDataGridViewTextBoxColumn.Width = 125;
            // 
            // tseferinfoBindingSource
            // 
            this.tseferinfoBindingSource.DataMember = "t_seferinfo";
            this.tseferinfoBindingSource.DataSource = this.dotobusbaseDataSetBindingSource;
            // 
            // dotobusbaseDataSetBindingSource
            // 
            this.dotobusbaseDataSetBindingSource.DataSource = this.dotobusbaseDataSet;
            this.dotobusbaseDataSetBindingSource.Position = 0;
            // 
            // dotobusbaseDataSet
            // 
            this.dotobusbaseDataSet.DataSetName = "dotobusbaseDataSet";
            this.dotobusbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_seferinfoTableAdapter
            // 
            this.t_seferinfoTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.tseferinfoBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.CountItemFormat = "index {0}";
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(472, 571);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(256, 27);
            this.bindingNavigator1.TabIndex = 4;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(67, 24);
            this.bindingNavigatorCountItem.Text = "index {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::HadoTestApp.Properties.Resources.DOTOBUS__9_;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::HadoTestApp.Properties.Resources.DOTOBUS__13_;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = global::HadoTestApp.Properties.Resources.DOTOBUS__12_;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::HadoTestApp.Properties.Resources.DOTOBUS__11_;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(-1, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 54);
            this.button4.TabIndex = 12;
            this.button4.Text = "<---";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SeferBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HadoTestApp.Properties.Resources.dotobus__2_;
            this.ClientSize = new System.Drawing.Size(1190, 651);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SeferBilgileri";
            this.Text = "Deniz Otobüsü Sefer Bilgileri";
            this.Load += new System.EventHandler(this.SeferBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tseferinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotobusbaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotobusbaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.BindingSource dotobusbaseDataSetBindingSource;
        private dotobusbaseDataSet dotobusbaseDataSet;
        private System.Windows.Forms.BindingSource tseferinfoBindingSource;
        private dotobusbaseDataSetTableAdapters.t_seferinfoTableAdapter t_seferinfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn doIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seabusnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seabusaktifgunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seabusaktifsaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seabushatDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button button4;
    }
}