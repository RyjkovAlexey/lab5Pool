namespace lab5Pool
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pumpTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.currentPower = new System.Windows.Forms.Label();
            this.pump1 = new lab5Pool.Pump();
            this.pump5 = new lab5Pool.Pump();
            this.pump4 = new lab5Pool.Pump();
            this.pump3 = new lab5Pool.Pump();
            this.pump2 = new lab5Pool.Pump();
            this.filingPump = new lab5Pool.Pump();
            this.tableLayoutPanel1.SuspendLayout();
            this.pumpTable.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pumpTable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pumpTable
            // 
            this.pumpTable.ColumnCount = 5;
            this.pumpTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pumpTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pumpTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pumpTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pumpTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pumpTable.Controls.Add(this.pump1, 0, 0);
            this.pumpTable.Controls.Add(this.pump5, 4, 0);
            this.pumpTable.Controls.Add(this.pump4, 3, 0);
            this.pumpTable.Controls.Add(this.pump3, 2, 0);
            this.pumpTable.Controls.Add(this.pump2, 1, 0);
            this.pumpTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pumpTable.Location = new System.Drawing.Point(0, 0);
            this.pumpTable.Margin = new System.Windows.Forms.Padding(0);
            this.pumpTable.Name = "pumpTable";
            this.pumpTable.RowCount = 1;
            this.pumpTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pumpTable.Size = new System.Drawing.Size(800, 45);
            this.pumpTable.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.75F));
            this.tableLayoutPanel3.Controls.Add(this.trackBar1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 405);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(800, 45);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(0, 0);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(0);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(586, 45);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(0, 45);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar1.Maximum = 2000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(800, 360);
            this.progressBar1.Step = 20;
            this.progressBar1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.83178F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.16822F));
            this.tableLayoutPanel2.Controls.Add(this.currentPower, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.filingPump, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(586, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(214, 45);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // currentPower
            // 
            this.currentPower.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentPower.AutoSize = true;
            this.currentPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentPower.Location = new System.Drawing.Point(16, 12);
            this.currentPower.Name = "currentPower";
            this.currentPower.Size = new System.Drawing.Size(18, 20);
            this.currentPower.TabIndex = 0;
            this.currentPower.Text = "0";
            // 
            // pump1
            // 
            this.pump1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pump1.Location = new System.Drawing.Point(0, 0);
            this.pump1.Margin = new System.Windows.Forms.Padding(0);
            this.pump1.Mode = false;
            this.pump1.Name = "pump1";
            this.pump1.NamePump = "Насос 1";
            this.pump1.powerPump = 20;
            this.pump1.Size = new System.Drawing.Size(160, 45);
            this.pump1.TabIndex = 5;
            // 
            // pump5
            // 
            this.pump5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pump5.Location = new System.Drawing.Point(640, 0);
            this.pump5.Margin = new System.Windows.Forms.Padding(0);
            this.pump5.Mode = false;
            this.pump5.Name = "pump5";
            this.pump5.NamePump = "Насос 5";
            this.pump5.powerPump = 20;
            this.pump5.Size = new System.Drawing.Size(160, 45);
            this.pump5.TabIndex = 4;
            // 
            // pump4
            // 
            this.pump4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pump4.Location = new System.Drawing.Point(480, 0);
            this.pump4.Margin = new System.Windows.Forms.Padding(0);
            this.pump4.Mode = false;
            this.pump4.Name = "pump4";
            this.pump4.NamePump = "Насос 4";
            this.pump4.powerPump = 20;
            this.pump4.Size = new System.Drawing.Size(160, 45);
            this.pump4.TabIndex = 3;
            // 
            // pump3
            // 
            this.pump3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pump3.Location = new System.Drawing.Point(320, 0);
            this.pump3.Margin = new System.Windows.Forms.Padding(0);
            this.pump3.Mode = false;
            this.pump3.Name = "pump3";
            this.pump3.NamePump = "Насос 3";
            this.pump3.powerPump = 20;
            this.pump3.Size = new System.Drawing.Size(160, 45);
            this.pump3.TabIndex = 2;
            // 
            // pump2
            // 
            this.pump2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pump2.Location = new System.Drawing.Point(160, 0);
            this.pump2.Margin = new System.Windows.Forms.Padding(0);
            this.pump2.Mode = false;
            this.pump2.Name = "pump2";
            this.pump2.NamePump = "Насос 2";
            this.pump2.powerPump = 20;
            this.pump2.Size = new System.Drawing.Size(160, 45);
            this.pump2.TabIndex = 1;
            // 
            // filingPump
            // 
            this.filingPump.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filingPump.Location = new System.Drawing.Point(50, 0);
            this.filingPump.Margin = new System.Windows.Forms.Padding(0);
            this.filingPump.Mode = true;
            this.filingPump.Name = "filingPump";
            this.filingPump.NamePump = "Запустить заполнение";
            this.filingPump.powerPump = 0;
            this.filingPump.Size = new System.Drawing.Size(164, 45);
            this.filingPump.TabIndex = 1;
            this.filingPump.Click += new System.EventHandler(this.filingPump_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pumpTable.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel pumpTable;
        private Pump pump1;
        private Pump pump5;
        private Pump pump4;
        private Pump pump3;
        private Pump pump2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label currentPower;
        private Pump filingPump;
    }
}

