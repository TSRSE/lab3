using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_stack_queue_deck
{
    public partial class Form1 : Form
    {
        List<Stack> StackList = new List<Stack>();
        List<Queue> QueueList = new List<Queue>();
        List<Deck>  DeckList  = new List<Deck>();

        public Form1()
        {
            InitializeComponent();
        }

        //Верхняя менюшка
        #region menustrip
        private void очиститьВсеПоляToolStripMenuItem1_Click(object sender, EventArgs e) 
        {
            StackList.Clear();
            updateList(1);

            QueueList.Clear();
            updateList(2);

            DeckList.Clear();
            updateList(3);
        } //Очистка всех полей, очевидно
        private void готовыйПример1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(4,15); i++)
            {
                StackList.Add(new Stack($"Новый Олег номер О-{i + 1}", i + 1));
            }
            for (int i = 0; i < rnd.Next(4, 15); i++)
            {
                QueueList.Add(new Queue($"Новый Александр номер А-{i + 1}", i + 1));
            }
            for (int i = 0; i < rnd.Next(4, 15); i++)
            {
                DeckList.Add(new Deck($"Новый Сергей номер С-{i + 1}", i+1));
            }
            updateList(1);
            updateList(2);
            updateList(3);
        }
        #endregion

        private void updateList(int state) //Обноввление листа
        {
            switch (state)
            {
                case 1:
                    list_stack.Items.Clear();
                    for (int i = 0; i < StackList.Count; i++)
                    {
                        StackList[i].Place = i + 1;
                        list_stack.Items.Add($"№ {StackList[i].Place}\t {StackList[i].ElementName}");
                    }

                    try {
                        tb_stack_edit.Text = StackList[0].ElementName;
                    } catch { tb_stack_edit.Text = ""; }

                    if (StackList.Count == 0)
                    {
                        l_stack_chosen.Text = "Нет элементов";
                        b_stack_edit.Enabled = false;
                        tb_stack_edit.Enabled = false;
                        
                        b_stack_delete.Enabled = false;
                    }
                    else
                    {
                        l_stack_chosen.Text = ($"Выбранный элемент\n: {StackList[0].ElementName}");
                        b_stack_edit.Enabled = true;
                        tb_stack_edit.Enabled = true;

                        b_stack_delete.Enabled = true;
                    }
                    
                    toolStripStatusLabel1.Text = ($"Элементов в стеке: {StackList.Count}");
                    break;

                case 2:
                    list_queue.Items.Clear();

                    for (int i = 0; i < QueueList.Count; i++)
                    {
                        QueueList[i].Place = i + 1;
                        list_queue.Items.Add($"№ {QueueList[i].Place}\t {QueueList[i].ElementName}");
                    }

                    try
                    {
                        tb_queue_edit.Text = QueueList[QueueList.Count-1].ElementName;
                    }
                    catch { tb_queue_edit.Text = ""; }

                    if (QueueList.Count == 0)
                    {
                        l_queue_chosen_el.Text = "Нет элементов";
                        b_queue_edit.Enabled = false;
                        tb_queue_edit.Enabled = false;

                        b_queue_remove.Enabled = false;
                    }
                    else
                    {
                        l_queue_chosen_el.Text = ($"Выбранный элемент\n: {QueueList[QueueList.Count-1].ElementName}");
                        b_queue_edit.Enabled = true;
                        tb_queue_edit.Enabled = true;

                        b_queue_remove.Enabled = true;
                    }

                    toolStripStatusLabel2.Text = ($"Элементов в очереди: {QueueList.Count}");
                    break;

                case 3:
                    list_deck.Items.Clear();

                    for (int i = 0; i < DeckList.Count; i++)
                    {
                        DeckList[i].Place = i + 1;
                        list_deck.Items.Add($"№ {DeckList[i].Place}\t {DeckList[i].ElementName}");
                    }

                    try
                    {
                        tb_deck_edit_frt.Text = DeckList[0].ElementName;
                        tb_deck_edit_sec.Text = DeckList[DeckList.Count - 1].ElementName;
                    }
                    catch { tb_deck_edit_frt.Text = ""; }

                    if (DeckList.Count == 0)
                    {
                        b_deck_edit_frt.Enabled = false;
                        tb_deck_edit_frt.Enabled = false;
                        b_deck_delet_frt.Enabled = false;

                        b_deck_edit_sec.Enabled = false;
                        tb_deck_edit_sec.Enabled = false;
                        b_deck_delet_sec.Enabled = false;
                    }
                    else
                    {
                        b_deck_edit_frt.Enabled = true;
                        tb_deck_edit_frt.Enabled = true;
                        b_deck_delet_frt.Enabled = true;

                        b_deck_edit_sec.Enabled = true;
                        tb_deck_edit_sec.Enabled = true;
                        b_deck_delet_sec.Enabled = true;
                    }
                    

                    toolStripStatusLabel3.Text = ($"Элементов в деке: {DeckList.Count}");
                    break;
                default:
                    break;
            }
        }

        //Обработка STACK запросов
        #region Stack
        private void b_stack_add_Click(object sender, EventArgs e)
        {
            if (tb_stack_add.Text.Length > 0) { 
                if(StackList.Count==0)
                    StackList.Add(new Stack(tb_stack_add.Text, StackList.Count + 1));
                else
                    StackList.Insert(0, new Stack(tb_stack_add.Text, StackList.Count+1));

                updateList(1);
            }
        }
        private void b_stack_edit_Click(object sender, EventArgs e)
        {
            try { 
                if(tb_queue_edit.Text.Length > 0) { 
                    StackList[0].ElementName = tb_stack_edit.Text;
                    updateList(1);
                }
            }
            catch { }
        }
        private void b_stack_delete_Click(object sender, EventArgs e)
        {
            if (StackList.Count != 0)
            {
                StackList.RemoveAt(0);
                updateList(1);
            }
        }
        #endregion 

        //Обработка QUEUE запросов
        #region Queue
        private void b_queue_add_Click(object sender, EventArgs e)
        {
            if (tb_queue_add.Text.Length > 0) 
            { 
                if(QueueList.Count==0)
                    QueueList.Add(new Queue(tb_queue_add.Text, QueueList.Count + 1));
                else
                    QueueList.Insert(0, new Queue(tb_queue_add.Text, QueueList.Count+1));

                updateList(2);
            }
        }
        private void b_queue_edit_Click(object sender, EventArgs e)
        {
            try {
                if (tb_queue_edit.Text.Length > 0) 
                { 
                    QueueList[QueueList.Count - 1].ElementName = tb_queue_edit.Text;
                    updateList(2);
                }
            }
            catch { }
        }
        private void b_queue_remove_Click(object sender, EventArgs e)
        {
            if (QueueList.Count != 0)
            {
                QueueList.RemoveAt(QueueList.Count - 1);
                updateList(2);
            }
        }


        #endregion 

        //Обработка DECK запросов
        #region Deck

        //======================FIRST======================//

        private void b_deck_add_frt_Click(object sender, EventArgs e)
        {
            if (tb_deck_add_frt.Text.Length > 0)
            {
                if (QueueList.Count == 0)
                    DeckList.Insert(0, new Deck(tb_deck_add_frt.Text, DeckList.Count + 1));
                else
                    DeckList.Add(new Deck(tb_deck_add_frt.Text, DeckList.Count + 1));

                updateList(3);
            }
        }
        private void b_deck_edit_frt_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_deck_edit_frt.Text.Length > 0)
                {
                    DeckList[0].ElementName = tb_deck_edit_frt.Text;
                    updateList(3);
                }
            }
            catch { }
        }
        private void b_deck_delet_frt_Click(object sender, EventArgs e)
        {
            if (DeckList.Count != 0)
            {
                DeckList.RemoveAt(0);
                updateList(3);
            }
        }

        //=================================================//

        //======================SECOND=====================//

        private void b_deck_add_sec_Click(object sender, EventArgs e)
        {
            if (tb_deck_add_sec.Text.Length > 0)
            {
                if (QueueList.Count == 0)
                    DeckList.Add(new Deck(tb_deck_add_sec.Text, DeckList.Count + 1));
                else
                    DeckList.Insert(0, new Deck(tb_deck_add_sec.Text, DeckList.Count + 1));

                updateList(3);
            }
            
        }
        private void b_deck_edit_sec_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_deck_edit_sec.Text.Length > 0)
                {
                    DeckList[DeckList.Count - 1].ElementName = tb_deck_edit_sec.Text;
                    updateList(3);
                }
            }
            catch { }
        }
        private void b_deck_delet_sec_Click(object sender, EventArgs e)
        {
            if (DeckList.Count != 0)
            {
                DeckList.RemoveAt(DeckList.Count - 1);
                updateList(3);
            }
        }

        //=================================================//

        #endregion
    }
}
