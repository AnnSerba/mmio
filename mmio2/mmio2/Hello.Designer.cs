namespace mmio2
{
    partial class Hello
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxМодиффицироныйСимплексМетод = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxФункцияЦели = new System.Windows.Forms.GroupBox();
            this.dataGridViewФункцияЦели = new System.Windows.Forms.DataGridView();
            this.Пусто = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Оптимум = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBoxОрганичения = new System.Windows.Forms.GroupBox();
            this.dataGridViewОграничения = new System.Windows.Forms.DataGridView();
            this.Знаки = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.СвободныеЧлены = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxRed = new System.Windows.Forms.GroupBox();
            this.buttonВыход = new System.Windows.Forms.Button();
            this.buttonРешить = new System.Windows.Forms.Button();
            this.buttonУдалитьПеременную = new System.Windows.Forms.Button();
            this.buttonУдалитьОграничение = new System.Windows.Forms.Button();
            this.buttonДобавитьПеременную = new System.Windows.Forms.Button();
            this.buttonДобавитьОграничение = new System.Windows.Forms.Button();
            this.groupBoxМодиффицироныйСимплексМетод.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxФункцияЦели.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewФункцияЦели)).BeginInit();
            this.groupBoxОрганичения.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewОграничения)).BeginInit();
            this.groupBoxRed.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxМодиффицироныйСимплексМетод
            // 
            this.groupBoxМодиффицироныйСимплексМетод.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxМодиффицироныйСимплексМетод.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxМодиффицироныйСимплексМетод.Location = new System.Drawing.Point(0, 0);
            this.groupBoxМодиффицироныйСимплексМетод.Name = "groupBoxМодиффицироныйСимплексМетод";
            this.groupBoxМодиффицироныйСимплексМетод.Size = new System.Drawing.Size(584, 357);
            this.groupBoxМодиффицироныйСимплексМетод.TabIndex = 0;
            this.groupBoxМодиффицироныйСимплексМетод.TabStop = false;
            this.groupBoxМодиффицироныйСимплексМетод.Text = "Модиффицированный симплекс метод";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.43172F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.56828F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxRed, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(578, 338);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBoxФункцияЦели, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxОрганичения, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.04502F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.95499F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(435, 332);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBoxФункцияЦели
            // 
            this.groupBoxФункцияЦели.Controls.Add(this.dataGridViewФункцияЦели);
            this.groupBoxФункцияЦели.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxФункцияЦели.Location = new System.Drawing.Point(3, 3);
            this.groupBoxФункцияЦели.Name = "groupBoxФункцияЦели";
            this.groupBoxФункцияЦели.Size = new System.Drawing.Size(429, 80);
            this.groupBoxФункцияЦели.TabIndex = 0;
            this.groupBoxФункцияЦели.TabStop = false;
            this.groupBoxФункцияЦели.Text = "Функция цели";
            // 
            // dataGridViewФункцияЦели
            // 
            this.dataGridViewФункцияЦели.AllowUserToAddRows = false;
            this.dataGridViewФункцияЦели.AllowUserToDeleteRows = false;
            this.dataGridViewФункцияЦели.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewФункцияЦели.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewФункцияЦели.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Пусто,
            this.Оптимум});
            this.dataGridViewФункцияЦели.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewФункцияЦели.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewФункцияЦели.Name = "dataGridViewФункцияЦели";
            this.dataGridViewФункцияЦели.RowHeadersVisible = false;
            this.dataGridViewФункцияЦели.Size = new System.Drawing.Size(423, 61);
            this.dataGridViewФункцияЦели.TabIndex = 0;
            // 
            // Пусто
            // 
            this.Пусто.HeaderText = "";
            this.Пусто.Name = "Пусто";
            // 
            // Оптимум
            // 
            this.Оптимум.HeaderText = "Оптимум";
            this.Оптимум.Name = "Оптимум";
            // 
            // groupBoxОрганичения
            // 
            this.groupBoxОрганичения.Controls.Add(this.dataGridViewОграничения);
            this.groupBoxОрганичения.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxОрганичения.Location = new System.Drawing.Point(3, 89);
            this.groupBoxОрганичения.Name = "groupBoxОрганичения";
            this.groupBoxОрганичения.Size = new System.Drawing.Size(429, 240);
            this.groupBoxОрганичения.TabIndex = 1;
            this.groupBoxОрганичения.TabStop = false;
            this.groupBoxОрганичения.Text = "Ограничния";
            // 
            // dataGridViewОграничения
            // 
            this.dataGridViewОграничения.AllowUserToAddRows = false;
            this.dataGridViewОграничения.AllowUserToDeleteRows = false;
            this.dataGridViewОграничения.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewОграничения.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewОграничения.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Знаки,
            this.СвободныеЧлены});
            this.dataGridViewОграничения.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewОграничения.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewОграничения.Name = "dataGridViewОграничения";
            this.dataGridViewОграничения.RowHeadersVisible = false;
            this.dataGridViewОграничения.Size = new System.Drawing.Size(423, 221);
            this.dataGridViewОграничения.TabIndex = 0;
            // 
            // Знаки
            // 
            this.Знаки.HeaderText = "Знаки";
            this.Знаки.Name = "Знаки";
            // 
            // СвободныеЧлены
            // 
            this.СвободныеЧлены.HeaderText = "B[i]";
            this.СвободныеЧлены.Name = "СвободныеЧлены";
            // 
            // groupBoxRed
            // 
            this.groupBoxRed.Controls.Add(this.buttonВыход);
            this.groupBoxRed.Controls.Add(this.buttonРешить);
            this.groupBoxRed.Controls.Add(this.buttonУдалитьПеременную);
            this.groupBoxRed.Controls.Add(this.buttonУдалитьОграничение);
            this.groupBoxRed.Controls.Add(this.buttonДобавитьПеременную);
            this.groupBoxRed.Controls.Add(this.buttonДобавитьОграничение);
            this.groupBoxRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRed.Location = new System.Drawing.Point(444, 3);
            this.groupBoxRed.Name = "groupBoxRed";
            this.groupBoxRed.Size = new System.Drawing.Size(131, 332);
            this.groupBoxRed.TabIndex = 1;
            this.groupBoxRed.TabStop = false;
            this.groupBoxRed.Text = "Редактирование";
            // 
            // buttonВыход
            // 
            this.buttonВыход.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonВыход.Location = new System.Drawing.Point(3, 295);
            this.buttonВыход.Name = "buttonВыход";
            this.buttonВыход.Size = new System.Drawing.Size(125, 34);
            this.buttonВыход.TabIndex = 5;
            this.buttonВыход.Text = "Выход";
            this.buttonВыход.UseVisualStyleBackColor = true;
            this.buttonВыход.Click += new System.EventHandler(this.buttonВыход_Click);
            // 
            // buttonРешить
            // 
            this.buttonРешить.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonРешить.Location = new System.Drawing.Point(3, 179);
            this.buttonРешить.Name = "buttonРешить";
            this.buttonРешить.Size = new System.Drawing.Size(125, 39);
            this.buttonРешить.TabIndex = 4;
            this.buttonРешить.Text = "Решить";
            this.buttonРешить.UseVisualStyleBackColor = true;
            this.buttonРешить.Click += new System.EventHandler(this.buttonРешить_Click);
            // 
            // buttonУдалитьПеременную
            // 
            this.buttonУдалитьПеременную.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonУдалитьПеременную.Location = new System.Drawing.Point(3, 136);
            this.buttonУдалитьПеременную.Name = "buttonУдалитьПеременную";
            this.buttonУдалитьПеременную.Size = new System.Drawing.Size(125, 43);
            this.buttonУдалитьПеременную.TabIndex = 3;
            this.buttonУдалитьПеременную.Text = "Удалить переменную";
            this.buttonУдалитьПеременную.UseVisualStyleBackColor = true;
            this.buttonУдалитьПеременную.Click += new System.EventHandler(this.buttonУдалитьПеременную_Click);
            // 
            // buttonУдалитьОграничение
            // 
            this.buttonУдалитьОграничение.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonУдалитьОграничение.Location = new System.Drawing.Point(3, 96);
            this.buttonУдалитьОграничение.Name = "buttonУдалитьОграничение";
            this.buttonУдалитьОграничение.Size = new System.Drawing.Size(125, 40);
            this.buttonУдалитьОграничение.TabIndex = 2;
            this.buttonУдалитьОграничение.Text = "Удалить ограничение";
            this.buttonУдалитьОграничение.UseVisualStyleBackColor = true;
            this.buttonУдалитьОграничение.Click += new System.EventHandler(this.buttonУдалитьСистему_Click);
            // 
            // buttonДобавитьПеременную
            // 
            this.buttonДобавитьПеременную.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonДобавитьПеременную.Location = new System.Drawing.Point(3, 56);
            this.buttonДобавитьПеременную.Name = "buttonДобавитьПеременную";
            this.buttonДобавитьПеременную.Size = new System.Drawing.Size(125, 40);
            this.buttonДобавитьПеременную.TabIndex = 1;
            this.buttonДобавитьПеременную.Text = "Добавить переменную";
            this.buttonДобавитьПеременную.UseVisualStyleBackColor = true;
            this.buttonДобавитьПеременную.Click += new System.EventHandler(this.buttonДобавитьПеременную_Click);
            // 
            // buttonДобавитьОграничение
            // 
            this.buttonДобавитьОграничение.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonДобавитьОграничение.Location = new System.Drawing.Point(3, 16);
            this.buttonДобавитьОграничение.Name = "buttonДобавитьОграничение";
            this.buttonДобавитьОграничение.Size = new System.Drawing.Size(125, 40);
            this.buttonДобавитьОграничение.TabIndex = 0;
            this.buttonДобавитьОграничение.Text = "Добавить ограничение";
            this.buttonДобавитьОграничение.UseVisualStyleBackColor = true;
            this.buttonДобавитьОграничение.Click += new System.EventHandler(this.buttonДобавитьСистему_Click);
            // 
            // Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 357);
            this.Controls.Add(this.groupBoxМодиффицироныйСимплексМетод);
            this.Name = "Hello";
            this.Text = "Form1";
            this.groupBoxМодиффицироныйСимплексМетод.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBoxФункцияЦели.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewФункцияЦели)).EndInit();
            this.groupBoxОрганичения.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewОграничения)).EndInit();
            this.groupBoxRed.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxМодиффицироныйСимплексМетод;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBoxФункцияЦели;
        private System.Windows.Forms.DataGridView dataGridViewФункцияЦели;
        private System.Windows.Forms.DataGridViewTextBoxColumn Пусто;
        private System.Windows.Forms.DataGridViewComboBoxColumn Оптимум;
        private System.Windows.Forms.GroupBox groupBoxОрганичения;
        private System.Windows.Forms.DataGridView dataGridViewОграничения;
        private System.Windows.Forms.DataGridViewComboBoxColumn Знаки;
        private System.Windows.Forms.DataGridViewTextBoxColumn СвободныеЧлены;
        private System.Windows.Forms.GroupBox groupBoxRed;
        private System.Windows.Forms.Button buttonВыход;
        private System.Windows.Forms.Button buttonРешить;
        private System.Windows.Forms.Button buttonУдалитьПеременную;
        private System.Windows.Forms.Button buttonУдалитьОграничение;
        private System.Windows.Forms.Button buttonДобавитьПеременную;
        private System.Windows.Forms.Button buttonДобавитьОграничение;
    }
}

