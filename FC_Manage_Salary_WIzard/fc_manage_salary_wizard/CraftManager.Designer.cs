namespace FC_Manage_Salary_WIzard {
  partial class CraftManager {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CraftManager));
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripButton_CraftAdd = new System.Windows.Forms.ToolStripButton();
      this.toolStripButton_CraftRemove = new System.Windows.Forms.ToolStripButton();
      this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
      this.treeView_Crafts = new System.Windows.Forms.TreeView();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage_DayYong = new System.Windows.Forms.TabPage();
      this.tabPage_HourInDay = new System.Windows.Forms.TabPage();
      this.tabPage_IllDayPrice = new System.Windows.Forms.TabPage();
      this.tabPage_HourPrice = new System.Windows.Forms.TabPage();
      this.tabPage_NightHourPrice = new System.Windows.Forms.TabPage();
      this.tabPage_Main = new System.Windows.Forms.TabPage();
      this.dataGridView_HourPrice = new System.Windows.Forms.DataGridView();
      this.dataGridView_NightHourPrice = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.textBox_CraftName = new System.Windows.Forms.TextBox();
      this.checkBox_Productivity = new System.Windows.Forms.CheckBox();
      this.dataGridView_DayYong = new System.Windows.Forms.DataGridView();
      this.dataGridView_HourInDay = new System.Windows.Forms.DataGridView();
      this.dataGridView_IllDayPrice = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage_DayYong.SuspendLayout();
      this.tabPage_HourInDay.SuspendLayout();
      this.tabPage_IllDayPrice.SuspendLayout();
      this.tabPage_HourPrice.SuspendLayout();
      this.tabPage_NightHourPrice.SuspendLayout();
      this.tabPage_Main.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HourPrice)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NightHourPrice)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DayYong)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HourInDay)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_IllDayPrice)).BeginInit();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
      this.splitContainer1.Panel1.Controls.Add(this.treeView_Crafts);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
      this.splitContainer1.Size = new System.Drawing.Size(626, 195);
      this.splitContainer1.SplitterDistance = 186;
      this.splitContainer1.TabIndex = 0;
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_CraftAdd,
            this.toolStripButton_CraftRemove,
            this.toolStripButton1});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(186, 25);
      this.toolStrip1.TabIndex = 1;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // toolStripButton_CraftAdd
      // 
      this.toolStripButton_CraftAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton_CraftAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_CraftAdd.Image")));
      this.toolStripButton_CraftAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton_CraftAdd.Name = "toolStripButton_CraftAdd";
      this.toolStripButton_CraftAdd.Size = new System.Drawing.Size(23, 22);
      this.toolStripButton_CraftAdd.Text = "toolStripButton1";
      this.toolStripButton_CraftAdd.ToolTipText = "Добавить должность";
      // 
      // toolStripButton_CraftRemove
      // 
      this.toolStripButton_CraftRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton_CraftRemove.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_CraftRemove.Image")));
      this.toolStripButton_CraftRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton_CraftRemove.Name = "toolStripButton_CraftRemove";
      this.toolStripButton_CraftRemove.Size = new System.Drawing.Size(23, 22);
      this.toolStripButton_CraftRemove.Text = "toolStripButton1";
      this.toolStripButton_CraftRemove.ToolTipText = "Удалить должность";
      // 
      // toolStripButton1
      // 
      this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
      this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton1.Name = "toolStripButton1";
      this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
      this.toolStripButton1.Text = "toolStripButton_Save";
      this.toolStripButton1.ToolTipText = "Сохранить";
      // 
      // treeView_Crafts
      // 
      this.treeView_Crafts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.treeView_Crafts.Location = new System.Drawing.Point(0, 28);
      this.treeView_Crafts.Name = "treeView_Crafts";
      this.treeView_Crafts.Size = new System.Drawing.Size(186, 167);
      this.treeView_Crafts.TabIndex = 0;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage_Main);
      this.tabControl1.Controls.Add(this.tabPage_DayYong);
      this.tabControl1.Controls.Add(this.tabPage_HourInDay);
      this.tabControl1.Controls.Add(this.tabPage_IllDayPrice);
      this.tabControl1.Controls.Add(this.tabPage_HourPrice);
      this.tabControl1.Controls.Add(this.tabPage_NightHourPrice);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.HotTrack = true;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Multiline = true;
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(436, 195);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPage_DayYong
      // 
      this.tabPage_DayYong.Controls.Add(this.dataGridView_DayYong);
      this.tabPage_DayYong.Location = new System.Drawing.Point(4, 40);
      this.tabPage_DayYong.Name = "tabPage_DayYong";
      this.tabPage_DayYong.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage_DayYong.Size = new System.Drawing.Size(428, 151);
      this.tabPage_DayYong.TabIndex = 0;
      this.tabPage_DayYong.Text = "Испытательный срок";
      this.tabPage_DayYong.UseVisualStyleBackColor = true;
      // 
      // tabPage_HourInDay
      // 
      this.tabPage_HourInDay.Controls.Add(this.dataGridView_HourInDay);
      this.tabPage_HourInDay.Location = new System.Drawing.Point(4, 40);
      this.tabPage_HourInDay.Name = "tabPage_HourInDay";
      this.tabPage_HourInDay.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage_HourInDay.Size = new System.Drawing.Size(428, 151);
      this.tabPage_HourInDay.TabIndex = 1;
      this.tabPage_HourInDay.Text = "Часов в смену";
      this.tabPage_HourInDay.UseVisualStyleBackColor = true;
      // 
      // tabPage_IllDayPrice
      // 
      this.tabPage_IllDayPrice.Controls.Add(this.dataGridView_IllDayPrice);
      this.tabPage_IllDayPrice.Location = new System.Drawing.Point(4, 40);
      this.tabPage_IllDayPrice.Name = "tabPage_IllDayPrice";
      this.tabPage_IllDayPrice.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage_IllDayPrice.Size = new System.Drawing.Size(428, 151);
      this.tabPage_IllDayPrice.TabIndex = 2;
      this.tabPage_IllDayPrice.Text = "Оплата больничного";
      this.tabPage_IllDayPrice.UseVisualStyleBackColor = true;
      // 
      // tabPage_HourPrice
      // 
      this.tabPage_HourPrice.Controls.Add(this.dataGridView_HourPrice);
      this.tabPage_HourPrice.Location = new System.Drawing.Point(4, 40);
      this.tabPage_HourPrice.Name = "tabPage_HourPrice";
      this.tabPage_HourPrice.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage_HourPrice.Size = new System.Drawing.Size(428, 151);
      this.tabPage_HourPrice.TabIndex = 3;
      this.tabPage_HourPrice.Text = "Стоимость часа";
      this.tabPage_HourPrice.UseVisualStyleBackColor = true;
      // 
      // tabPage_NightHourPrice
      // 
      this.tabPage_NightHourPrice.Controls.Add(this.dataGridView_NightHourPrice);
      this.tabPage_NightHourPrice.Location = new System.Drawing.Point(4, 40);
      this.tabPage_NightHourPrice.Name = "tabPage_NightHourPrice";
      this.tabPage_NightHourPrice.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage_NightHourPrice.Size = new System.Drawing.Size(428, 151);
      this.tabPage_NightHourPrice.TabIndex = 4;
      this.tabPage_NightHourPrice.Text = "Стоимость ночного часа";
      this.tabPage_NightHourPrice.UseVisualStyleBackColor = true;
      // 
      // tabPage_Main
      // 
      this.tabPage_Main.Controls.Add(this.checkBox_Productivity);
      this.tabPage_Main.Controls.Add(this.textBox_CraftName);
      this.tabPage_Main.Controls.Add(this.label1);
      this.tabPage_Main.Location = new System.Drawing.Point(4, 40);
      this.tabPage_Main.Name = "tabPage_Main";
      this.tabPage_Main.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage_Main.Size = new System.Drawing.Size(428, 151);
      this.tabPage_Main.TabIndex = 5;
      this.tabPage_Main.Text = "Основные";
      this.tabPage_Main.UseVisualStyleBackColor = true;
      // 
      // dataGridView_HourPrice
      // 
      this.dataGridView_HourPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_HourPrice.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView_HourPrice.Location = new System.Drawing.Point(3, 3);
      this.dataGridView_HourPrice.Name = "dataGridView_HourPrice";
      this.dataGridView_HourPrice.Size = new System.Drawing.Size(422, 145);
      this.dataGridView_HourPrice.TabIndex = 0;
      // 
      // dataGridView_NightHourPrice
      // 
      this.dataGridView_NightHourPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_NightHourPrice.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView_NightHourPrice.Location = new System.Drawing.Point(3, 3);
      this.dataGridView_NightHourPrice.Name = "dataGridView_NightHourPrice";
      this.dataGridView_NightHourPrice.Size = new System.Drawing.Size(422, 145);
      this.dataGridView_NightHourPrice.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(83, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Наименование";
      // 
      // textBox_CraftName
      // 
      this.textBox_CraftName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox_CraftName.Location = new System.Drawing.Point(3, 37);
      this.textBox_CraftName.Multiline = true;
      this.textBox_CraftName.Name = "textBox_CraftName";
      this.textBox_CraftName.Size = new System.Drawing.Size(425, 50);
      this.textBox_CraftName.TabIndex = 1;
      // 
      // checkBox_Productivity
      // 
      this.checkBox_Productivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.checkBox_Productivity.AutoSize = true;
      this.checkBox_Productivity.Location = new System.Drawing.Point(297, 11);
      this.checkBox_Productivity.Name = "checkBox_Productivity";
      this.checkBox_Productivity.Size = new System.Drawing.Size(123, 17);
      this.checkBox_Productivity.TabIndex = 2;
      this.checkBox_Productivity.Text = "Производственная";
      this.checkBox_Productivity.UseVisualStyleBackColor = true;
      // 
      // dataGridView_DayYong
      // 
      this.dataGridView_DayYong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_DayYong.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView_DayYong.Location = new System.Drawing.Point(3, 3);
      this.dataGridView_DayYong.Name = "dataGridView_DayYong";
      this.dataGridView_DayYong.Size = new System.Drawing.Size(422, 145);
      this.dataGridView_DayYong.TabIndex = 0;
      // 
      // dataGridView_HourInDay
      // 
      this.dataGridView_HourInDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_HourInDay.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView_HourInDay.Location = new System.Drawing.Point(3, 3);
      this.dataGridView_HourInDay.Name = "dataGridView_HourInDay";
      this.dataGridView_HourInDay.Size = new System.Drawing.Size(422, 145);
      this.dataGridView_HourInDay.TabIndex = 0;
      // 
      // dataGridView_IllDayPrice
      // 
      this.dataGridView_IllDayPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_IllDayPrice.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView_IllDayPrice.Location = new System.Drawing.Point(3, 3);
      this.dataGridView_IllDayPrice.Name = "dataGridView_IllDayPrice";
      this.dataGridView_IllDayPrice.Size = new System.Drawing.Size(422, 145);
      this.dataGridView_IllDayPrice.TabIndex = 0;
      // 
      // CraftManager
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(626, 195);
      this.Controls.Add(this.splitContainer1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MinimumSize = new System.Drawing.Size(642, 233);
      this.Name = "CraftManager";
      this.Text = "Управление должностями";
      this.Load += new System.EventHandler(this.CraftManager_Load);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabPage_DayYong.ResumeLayout(false);
      this.tabPage_HourInDay.ResumeLayout(false);
      this.tabPage_IllDayPrice.ResumeLayout(false);
      this.tabPage_HourPrice.ResumeLayout(false);
      this.tabPage_NightHourPrice.ResumeLayout(false);
      this.tabPage_Main.ResumeLayout(false);
      this.tabPage_Main.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HourPrice)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NightHourPrice)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DayYong)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HourInDay)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_IllDayPrice)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton toolStripButton_CraftAdd;
    private System.Windows.Forms.ToolStripButton toolStripButton_CraftRemove;
    private System.Windows.Forms.TreeView treeView_Crafts;
    private System.Windows.Forms.ToolStripButton toolStripButton1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage_Main;
    private System.Windows.Forms.TabPage tabPage_DayYong;
    private System.Windows.Forms.TabPage tabPage_HourInDay;
    private System.Windows.Forms.TabPage tabPage_IllDayPrice;
    private System.Windows.Forms.TabPage tabPage_HourPrice;
    private System.Windows.Forms.TabPage tabPage_NightHourPrice;
    private System.Windows.Forms.CheckBox checkBox_Productivity;
    private System.Windows.Forms.TextBox textBox_CraftName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView dataGridView_DayYong;
    private System.Windows.Forms.DataGridView dataGridView_HourInDay;
    private System.Windows.Forms.DataGridView dataGridView_IllDayPrice;
    private System.Windows.Forms.DataGridView dataGridView_HourPrice;
    private System.Windows.Forms.DataGridView dataGridView_NightHourPrice;
  }
}