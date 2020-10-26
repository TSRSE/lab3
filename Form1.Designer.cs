namespace lab3_stack_queue_deck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьВсеПоляToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.шаблонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.готовыйПример1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.готовыйПример2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l_stack_chosen = new System.Windows.Forms.Label();
            this.tb_stack_edit = new System.Windows.Forms.TextBox();
            this.tb_stack_add = new System.Windows.Forms.TextBox();
            this.b_stack_edit = new System.Windows.Forms.Button();
            this.b_stack_delete = new System.Windows.Forms.Button();
            this.b_stack_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.list_stack = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.l_queue_chosen_el = new System.Windows.Forms.Label();
            this.tb_queue_edit = new System.Windows.Forms.TextBox();
            this.tb_queue_add = new System.Windows.Forms.TextBox();
            this.b_queue_edit = new System.Windows.Forms.Button();
            this.b_queue_remove = new System.Windows.Forms.Button();
            this.b_queue_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.list_queue = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gb_last_el = new System.Windows.Forms.GroupBox();
            this.tb_deck_edit_sec = new System.Windows.Forms.TextBox();
            this.tb_deck_add_sec = new System.Windows.Forms.TextBox();
            this.b_deck_edit_sec = new System.Windows.Forms.Button();
            this.b_deck_delet_sec = new System.Windows.Forms.Button();
            this.b_deck_add_sec = new System.Windows.Forms.Button();
            this.gb_first_el = new System.Windows.Forms.GroupBox();
            this.tb_deck_edit_frt = new System.Windows.Forms.TextBox();
            this.tb_deck_add_frt = new System.Windows.Forms.TextBox();
            this.b_deck_edit_frt = new System.Windows.Forms.Button();
            this.b_deck_delet_frt = new System.Windows.Forms.Button();
            this.b_deck_add_frt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.list_deck = new System.Windows.Forms.ListBox();
            this.l_el_f = new System.Windows.Forms.Label();
            this.l_el_s = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.gb_last_el.SuspendLayout();
            this.gb_first_el.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 467);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(505, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(120, 17);
            this.toolStripStatusLabel1.Text = "Элементов в стеке: 0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(137, 17);
            this.toolStripStatusLabel2.Text = "Элементов в очереди: 0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(115, 17);
            this.toolStripStatusLabel3.Text = "Элементов в деке: 0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(505, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьВсеПоляToolStripMenuItem1,
            this.шаблонToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.файлToolStripMenuItem.Text = "Программа";
            // 
            // очиститьВсеПоляToolStripMenuItem1
            // 
            this.очиститьВсеПоляToolStripMenuItem1.Name = "очиститьВсеПоляToolStripMenuItem1";
            this.очиститьВсеПоляToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.очиститьВсеПоляToolStripMenuItem1.Text = "Очистить все поля";
            this.очиститьВсеПоляToolStripMenuItem1.Click += new System.EventHandler(this.очиститьВсеПоляToolStripMenuItem1_Click);
            // 
            // шаблонToolStripMenuItem
            // 
            this.шаблонToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.готовыйПример1ToolStripMenuItem,
            this.готовыйПример2ToolStripMenuItem});
            this.шаблонToolStripMenuItem.Name = "шаблонToolStripMenuItem";
            this.шаблонToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.шаблонToolStripMenuItem.Text = "Шаблон";
            // 
            // готовыйПример1ToolStripMenuItem
            // 
            this.готовыйПример1ToolStripMenuItem.Name = "готовыйПример1ToolStripMenuItem";
            this.готовыйПример1ToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.готовыйПример1ToolStripMenuItem.Text = "Готовый пример 1";
            this.готовыйПример1ToolStripMenuItem.Click += new System.EventHandler(this.готовыйПример1ToolStripMenuItem_Click);
            // 
            // готовыйПример2ToolStripMenuItem
            // 
            this.готовыйПример2ToolStripMenuItem.Name = "готовыйПример2ToolStripMenuItem";
            this.готовыйПример2ToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.готовыйПример2ToolStripMenuItem.Text = "Готовый пример 2";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(504, 437);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.list_stack);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(496, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Стек";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_stack_chosen);
            this.groupBox1.Controls.Add(this.tb_stack_edit);
            this.groupBox1.Controls.Add(this.tb_stack_add);
            this.groupBox1.Controls.Add(this.b_stack_edit);
            this.groupBox1.Controls.Add(this.b_stack_delete);
            this.groupBox1.Controls.Add(this.b_stack_add);
            this.groupBox1.Location = new System.Drawing.Point(6, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 184);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление элементом";
            // 
            // l_stack_chosen
            // 
            this.l_stack_chosen.AutoSize = true;
            this.l_stack_chosen.Location = new System.Drawing.Point(6, 142);
            this.l_stack_chosen.Name = "l_stack_chosen";
            this.l_stack_chosen.Size = new System.Drawing.Size(84, 13);
            this.l_stack_chosen.TabIndex = 14;
            this.l_stack_chosen.Text = "Нет элементов";
            // 
            // tb_stack_edit
            // 
            this.tb_stack_edit.Enabled = false;
            this.tb_stack_edit.Location = new System.Drawing.Point(104, 67);
            this.tb_stack_edit.Name = "tb_stack_edit";
            this.tb_stack_edit.Size = new System.Drawing.Size(111, 20);
            this.tb_stack_edit.TabIndex = 5;
            // 
            // tb_stack_add
            // 
            this.tb_stack_add.Location = new System.Drawing.Point(104, 27);
            this.tb_stack_add.Name = "tb_stack_add";
            this.tb_stack_add.Size = new System.Drawing.Size(111, 20);
            this.tb_stack_add.TabIndex = 4;
            // 
            // b_stack_edit
            // 
            this.b_stack_edit.Enabled = false;
            this.b_stack_edit.Location = new System.Drawing.Point(6, 59);
            this.b_stack_edit.Name = "b_stack_edit";
            this.b_stack_edit.Size = new System.Drawing.Size(92, 34);
            this.b_stack_edit.TabIndex = 1;
            this.b_stack_edit.Text = "Изменить";
            this.b_stack_edit.UseVisualStyleBackColor = true;
            this.b_stack_edit.Click += new System.EventHandler(this.b_stack_edit_Click);
            // 
            // b_stack_delete
            // 
            this.b_stack_delete.Enabled = false;
            this.b_stack_delete.Location = new System.Drawing.Point(6, 99);
            this.b_stack_delete.Name = "b_stack_delete";
            this.b_stack_delete.Size = new System.Drawing.Size(209, 34);
            this.b_stack_delete.TabIndex = 2;
            this.b_stack_delete.Text = "Удалить";
            this.b_stack_delete.UseVisualStyleBackColor = true;
            this.b_stack_delete.Click += new System.EventHandler(this.b_stack_delete_Click);
            // 
            // b_stack_add
            // 
            this.b_stack_add.Location = new System.Drawing.Point(6, 19);
            this.b_stack_add.Name = "b_stack_add";
            this.b_stack_add.Size = new System.Drawing.Size(92, 34);
            this.b_stack_add.TabIndex = 0;
            this.b_stack_add.Text = "Добавить";
            this.b_stack_add.UseVisualStyleBackColor = true;
            this.b_stack_add.Click += new System.EventHandler(this.b_stack_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(248, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Стек";
            // 
            // list_stack
            // 
            this.list_stack.FormattingEnabled = true;
            this.list_stack.Location = new System.Drawing.Point(252, 38);
            this.list_stack.Name = "list_stack";
            this.list_stack.Size = new System.Drawing.Size(209, 277);
            this.list_stack.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.list_queue);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(496, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Очередь";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.l_queue_chosen_el);
            this.groupBox2.Controls.Add(this.tb_queue_edit);
            this.groupBox2.Controls.Add(this.tb_queue_add);
            this.groupBox2.Controls.Add(this.b_queue_edit);
            this.groupBox2.Controls.Add(this.b_queue_remove);
            this.groupBox2.Controls.Add(this.b_queue_add);
            this.groupBox2.Location = new System.Drawing.Point(6, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 184);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление элементом";
            // 
            // l_queue_chosen_el
            // 
            this.l_queue_chosen_el.AutoSize = true;
            this.l_queue_chosen_el.Location = new System.Drawing.Point(6, 142);
            this.l_queue_chosen_el.Name = "l_queue_chosen_el";
            this.l_queue_chosen_el.Size = new System.Drawing.Size(84, 13);
            this.l_queue_chosen_el.TabIndex = 13;
            this.l_queue_chosen_el.Text = "Нет элементов\r\n";
            // 
            // tb_queue_edit
            // 
            this.tb_queue_edit.Enabled = false;
            this.tb_queue_edit.Location = new System.Drawing.Point(104, 67);
            this.tb_queue_edit.Name = "tb_queue_edit";
            this.tb_queue_edit.Size = new System.Drawing.Size(111, 20);
            this.tb_queue_edit.TabIndex = 12;
            // 
            // tb_queue_add
            // 
            this.tb_queue_add.Location = new System.Drawing.Point(104, 27);
            this.tb_queue_add.Name = "tb_queue_add";
            this.tb_queue_add.Size = new System.Drawing.Size(111, 20);
            this.tb_queue_add.TabIndex = 11;
            // 
            // b_queue_edit
            // 
            this.b_queue_edit.Enabled = false;
            this.b_queue_edit.Location = new System.Drawing.Point(6, 59);
            this.b_queue_edit.Name = "b_queue_edit";
            this.b_queue_edit.Size = new System.Drawing.Size(92, 34);
            this.b_queue_edit.TabIndex = 8;
            this.b_queue_edit.Text = "Изменить";
            this.b_queue_edit.UseVisualStyleBackColor = true;
            this.b_queue_edit.Click += new System.EventHandler(this.b_queue_edit_Click);
            // 
            // b_queue_remove
            // 
            this.b_queue_remove.Enabled = false;
            this.b_queue_remove.Location = new System.Drawing.Point(6, 99);
            this.b_queue_remove.Name = "b_queue_remove";
            this.b_queue_remove.Size = new System.Drawing.Size(209, 34);
            this.b_queue_remove.TabIndex = 9;
            this.b_queue_remove.Text = "Удалить";
            this.b_queue_remove.UseVisualStyleBackColor = true;
            this.b_queue_remove.Click += new System.EventHandler(this.b_queue_remove_Click);
            // 
            // b_queue_add
            // 
            this.b_queue_add.Location = new System.Drawing.Point(6, 19);
            this.b_queue_add.Name = "b_queue_add";
            this.b_queue_add.Size = new System.Drawing.Size(92, 34);
            this.b_queue_add.TabIndex = 7;
            this.b_queue_add.Text = "Добавить";
            this.b_queue_add.UseVisualStyleBackColor = true;
            this.b_queue_add.Click += new System.EventHandler(this.b_queue_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(248, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Очередь";
            // 
            // list_queue
            // 
            this.list_queue.FormattingEnabled = true;
            this.list_queue.Location = new System.Drawing.Point(252, 38);
            this.list_queue.Name = "list_queue";
            this.list_queue.Size = new System.Drawing.Size(209, 277);
            this.list_queue.TabIndex = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gb_last_el);
            this.tabPage3.Controls.Add(this.gb_first_el);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.list_deck);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(496, 411);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Дек";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gb_last_el
            // 
            this.gb_last_el.Controls.Add(this.l_el_s);
            this.gb_last_el.Controls.Add(this.tb_deck_edit_sec);
            this.gb_last_el.Controls.Add(this.tb_deck_add_sec);
            this.gb_last_el.Controls.Add(this.b_deck_edit_sec);
            this.gb_last_el.Controls.Add(this.b_deck_delet_sec);
            this.gb_last_el.Controls.Add(this.b_deck_add_sec);
            this.gb_last_el.Location = new System.Drawing.Point(3, 215);
            this.gb_last_el.Name = "gb_last_el";
            this.gb_last_el.Size = new System.Drawing.Size(221, 184);
            this.gb_last_el.TabIndex = 22;
            this.gb_last_el.TabStop = false;
            this.gb_last_el.Text = "Управление ПОСЛЕДНИМ элементом";
            // 
            // tb_deck_edit_sec
            // 
            this.tb_deck_edit_sec.Location = new System.Drawing.Point(104, 67);
            this.tb_deck_edit_sec.Name = "tb_deck_edit_sec";
            this.tb_deck_edit_sec.Size = new System.Drawing.Size(111, 20);
            this.tb_deck_edit_sec.TabIndex = 19;
            // 
            // tb_deck_add_sec
            // 
            this.tb_deck_add_sec.Location = new System.Drawing.Point(104, 27);
            this.tb_deck_add_sec.Name = "tb_deck_add_sec";
            this.tb_deck_add_sec.Size = new System.Drawing.Size(111, 20);
            this.tb_deck_add_sec.TabIndex = 18;
            // 
            // b_deck_edit_sec
            // 
            this.b_deck_edit_sec.Enabled = false;
            this.b_deck_edit_sec.Location = new System.Drawing.Point(6, 59);
            this.b_deck_edit_sec.Name = "b_deck_edit_sec";
            this.b_deck_edit_sec.Size = new System.Drawing.Size(92, 34);
            this.b_deck_edit_sec.TabIndex = 15;
            this.b_deck_edit_sec.Text = "Изменить";
            this.b_deck_edit_sec.UseVisualStyleBackColor = true;
            this.b_deck_edit_sec.Click += new System.EventHandler(this.b_deck_edit_sec_Click);
            // 
            // b_deck_delet_sec
            // 
            this.b_deck_delet_sec.Enabled = false;
            this.b_deck_delet_sec.Location = new System.Drawing.Point(6, 99);
            this.b_deck_delet_sec.Name = "b_deck_delet_sec";
            this.b_deck_delet_sec.Size = new System.Drawing.Size(209, 34);
            this.b_deck_delet_sec.TabIndex = 16;
            this.b_deck_delet_sec.Text = "Удалить";
            this.b_deck_delet_sec.UseVisualStyleBackColor = true;
            this.b_deck_delet_sec.Click += new System.EventHandler(this.b_deck_delet_sec_Click);
            // 
            // b_deck_add_sec
            // 
            this.b_deck_add_sec.Location = new System.Drawing.Point(6, 19);
            this.b_deck_add_sec.Name = "b_deck_add_sec";
            this.b_deck_add_sec.Size = new System.Drawing.Size(92, 34);
            this.b_deck_add_sec.TabIndex = 14;
            this.b_deck_add_sec.Text = "Добавить";
            this.b_deck_add_sec.UseVisualStyleBackColor = true;
            this.b_deck_add_sec.Click += new System.EventHandler(this.b_deck_add_sec_Click);
            // 
            // gb_first_el
            // 
            this.gb_first_el.Controls.Add(this.l_el_f);
            this.gb_first_el.Controls.Add(this.tb_deck_edit_frt);
            this.gb_first_el.Controls.Add(this.tb_deck_add_frt);
            this.gb_first_el.Controls.Add(this.b_deck_edit_frt);
            this.gb_first_el.Controls.Add(this.b_deck_delet_frt);
            this.gb_first_el.Controls.Add(this.b_deck_add_frt);
            this.gb_first_el.Location = new System.Drawing.Point(6, 15);
            this.gb_first_el.Name = "gb_first_el";
            this.gb_first_el.Size = new System.Drawing.Size(221, 184);
            this.gb_first_el.TabIndex = 21;
            this.gb_first_el.TabStop = false;
            this.gb_first_el.Text = "Управление ПЕРВЫМ элементом";
            // 
            // tb_deck_edit_frt
            // 
            this.tb_deck_edit_frt.Enabled = false;
            this.tb_deck_edit_frt.Location = new System.Drawing.Point(104, 67);
            this.tb_deck_edit_frt.Name = "tb_deck_edit_frt";
            this.tb_deck_edit_frt.Size = new System.Drawing.Size(111, 20);
            this.tb_deck_edit_frt.TabIndex = 19;
            // 
            // tb_deck_add_frt
            // 
            this.tb_deck_add_frt.Location = new System.Drawing.Point(104, 27);
            this.tb_deck_add_frt.Name = "tb_deck_add_frt";
            this.tb_deck_add_frt.Size = new System.Drawing.Size(111, 20);
            this.tb_deck_add_frt.TabIndex = 18;
            // 
            // b_deck_edit_frt
            // 
            this.b_deck_edit_frt.Enabled = false;
            this.b_deck_edit_frt.Location = new System.Drawing.Point(6, 59);
            this.b_deck_edit_frt.Name = "b_deck_edit_frt";
            this.b_deck_edit_frt.Size = new System.Drawing.Size(92, 34);
            this.b_deck_edit_frt.TabIndex = 15;
            this.b_deck_edit_frt.Text = "Изменить";
            this.b_deck_edit_frt.UseVisualStyleBackColor = true;
            this.b_deck_edit_frt.Click += new System.EventHandler(this.b_deck_edit_frt_Click);
            // 
            // b_deck_delet_frt
            // 
            this.b_deck_delet_frt.Enabled = false;
            this.b_deck_delet_frt.Location = new System.Drawing.Point(6, 99);
            this.b_deck_delet_frt.Name = "b_deck_delet_frt";
            this.b_deck_delet_frt.Size = new System.Drawing.Size(209, 34);
            this.b_deck_delet_frt.TabIndex = 16;
            this.b_deck_delet_frt.Text = "Удалить";
            this.b_deck_delet_frt.UseVisualStyleBackColor = true;
            this.b_deck_delet_frt.Click += new System.EventHandler(this.b_deck_delet_frt_Click);
            // 
            // b_deck_add_frt
            // 
            this.b_deck_add_frt.Location = new System.Drawing.Point(6, 19);
            this.b_deck_add_frt.Name = "b_deck_add_frt";
            this.b_deck_add_frt.Size = new System.Drawing.Size(92, 34);
            this.b_deck_add_frt.TabIndex = 14;
            this.b_deck_add_frt.Text = "Добавить";
            this.b_deck_add_frt.UseVisualStyleBackColor = true;
            this.b_deck_add_frt.Click += new System.EventHandler(this.b_deck_add_frt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(248, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Дек";
            // 
            // list_deck
            // 
            this.list_deck.FormattingEnabled = true;
            this.list_deck.Location = new System.Drawing.Point(252, 38);
            this.list_deck.Name = "list_deck";
            this.list_deck.Size = new System.Drawing.Size(209, 355);
            this.list_deck.TabIndex = 17;
            // 
            // l_el_f
            // 
            this.l_el_f.AutoSize = true;
            this.l_el_f.Location = new System.Drawing.Point(6, 142);
            this.l_el_f.Name = "l_el_f";
            this.l_el_f.Size = new System.Drawing.Size(84, 13);
            this.l_el_f.TabIndex = 20;
            this.l_el_f.Text = "Нет элементов";
            // 
            // l_el_s
            // 
            this.l_el_s.AutoSize = true;
            this.l_el_s.Location = new System.Drawing.Point(6, 145);
            this.l_el_s.Name = "l_el_s";
            this.l_el_s.Size = new System.Drawing.Size(84, 13);
            this.l_el_s.TabIndex = 21;
            this.l_el_s.Text = "Нет элементов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 489);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Лабораторная работа 3 | Удалых Максим Антонович | БПИ20-9";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.gb_last_el.ResumeLayout(false);
            this.gb_last_el.PerformLayout();
            this.gb_first_el.ResumeLayout(false);
            this.gb_first_el.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шаблонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem готовыйПример1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem готовыйПример2ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button b_stack_add;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button b_stack_delete;
        private System.Windows.Forms.ListBox list_stack;
        private System.Windows.Forms.Button b_stack_edit;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.TextBox tb_stack_edit;
        private System.Windows.Forms.TextBox tb_stack_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_queue_edit;
        private System.Windows.Forms.TextBox tb_queue_add;
        private System.Windows.Forms.Button b_queue_edit;
        private System.Windows.Forms.ListBox list_queue;
        private System.Windows.Forms.Button b_queue_remove;
        private System.Windows.Forms.Button b_queue_add;
        private System.Windows.Forms.GroupBox gb_first_el;
        private System.Windows.Forms.TextBox tb_deck_edit_frt;
        private System.Windows.Forms.TextBox tb_deck_add_frt;
        private System.Windows.Forms.Button b_deck_edit_frt;
        private System.Windows.Forms.Button b_deck_delet_frt;
        private System.Windows.Forms.Button b_deck_add_frt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox list_deck;
        private System.Windows.Forms.GroupBox gb_last_el;
        private System.Windows.Forms.TextBox tb_deck_edit_sec;
        private System.Windows.Forms.TextBox tb_deck_add_sec;
        private System.Windows.Forms.Button b_deck_edit_sec;
        private System.Windows.Forms.Button b_deck_delet_sec;
        private System.Windows.Forms.Button b_deck_add_sec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label l_queue_chosen_el;
        private System.Windows.Forms.Label l_stack_chosen;
        private System.Windows.Forms.ToolStripMenuItem очиститьВсеПоляToolStripMenuItem1;
        private System.Windows.Forms.Label l_el_s;
        private System.Windows.Forms.Label l_el_f;
    }
}

