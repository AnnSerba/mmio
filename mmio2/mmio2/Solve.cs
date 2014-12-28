using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mmio2
{
    public partial class Solve : Form
    {

        Вычисления вычисления;
        АнализНаЧувствительность анализначувствительность;
        public Solve(List<Дробь> FuncCeli, List<СтрокаОграничения> Ogranich, Opt opt)
        {
            вычисления = new Вычисления(FuncCeli, Ogranich, opt);

            InitializeComponent();
            this.Visible = true;
            //Вывод
            ДобавлениеВДеревоИтераций();
            ВыводУсловия();
            анализначувствительность = new АнализНаЧувствительность(FuncCeli, Ogranich, opt, вычисления.СимплексРазности[вычисления.СимплексРазности.Count-1]);
            //Вывод анализа на чувствительность
        }


        #region Вывод
        void ВыводУсловия()
        {
            this.tableLayoutPanelПеременная.ColumnStyles[0].Width = 100F;
            this.tableLayoutPanelПеременная.ColumnStyles[1].Width = 0F;
            this.tableLayoutPanelПеременная.ColumnStyles[2].Width = 0F;
            this.tableLayoutPanelПеременная.ColumnStyles[3].Width = 0F;
            richTextBoxФункцияЦели.Text = "";
            richTextBoxСообщения.Text = вычисления.it[вычисления.it.Count - 1];
            for (int i = 0; i < вычисления.ФункцияЦели.Count; i++)
            {
                if (i == 0 || вычисления.ФункцияЦели[i] < 0)
                {
                    richTextBoxФункцияЦели.Text += вычисления.ФункцияЦели[i].ToString() + "X" + (i + 1) + " ";
                }
                else
                {
                    richTextBoxФункцияЦели.Text += "+ " + вычисления.ФункцияЦели[i].ToString() + "X" + (i + 1) + " ";
                }
            }
            richTextBoxФункцияЦели.Text += "    ----->   " + вычисления.opt;

            richTextBoxОграничения.Text = "";
            for (int i = 0; i < вычисления.Ограничения.Count; i++)
            {
                for (int j = 0; j < вычисления.Ограничения[i].Строка.Count; j++)
                {
                    if (j == 0 || вычисления.Ограничения[i].Строка[j] < 0)
                    {
                        richTextBoxОграничения.Text += вычисления.Ограничения[i].Строка[j].ToString() + "X" + (i + 1) + " ";
                    }
                    else
                    {
                        richTextBoxОграничения.Text += "+ " + вычисления.Ограничения[i].Строка[j].ToString() + "X" + (i + 1) + " ";
                    }
                }
                richTextBoxОграничения.Text += " " + вычисления.Ограничения[i].Знак + " " + вычисления.Ограничения[i].СвободныйЧлен.ToString() + "\n";
            }

        }
        void ВыводКанонизации()
        {
            this.tableLayoutPanelПеременная.ColumnStyles[0].Width = 100F;
            this.tableLayoutPanelПеременная.ColumnStyles[1].Width = 0F;
            this.tableLayoutPanelПеременная.ColumnStyles[2].Width = 0F;
            this.tableLayoutPanelПеременная.ColumnStyles[3].Width = 0F;
            richTextBoxСообщения.Text = вычисления.it[вычисления.it.Count - 1];
            richTextBoxФункцияЦели.Text = "";
            for (int i = 0; i < вычисления.КанонизируемаяФункцияЦели.Count; i++)
            {
                if (i == 0 || вычисления.КанонизируемаяФункцияЦели[i].дробь < 0)
                {
                    richTextBoxФункцияЦели.Text += вычисления.КанонизируемаяФункцияЦели[i].Вывод() + "X" + (i + 1) + " ";
                }
                else
                {
                    richTextBoxФункцияЦели.Text += "+ " + вычисления.КанонизируемаяФункцияЦели[i].Вывод() + "X" + (i + 1) + " ";
                }
            }
            richTextBoxФункцияЦели.Text += "    ----->   " + вычисления.opt;

            richTextBoxОграничения.Text = "";
            for (int i = 0; i < вычисления.Aij.Count; i++)
            {
                for (int j = 1; j < вычисления.Aij[i].Строка.Count; j++)
                {

                    if (j == 1 || вычисления.Aij[i].Строка[j].d < 0)
                    {
                        richTextBoxОграничения.Text += вычисления.Aij[i].Строка[j].d.ToString() + "X" + (i + 1) + " ";
                    }
                    else
                    {
                        richTextBoxОграничения.Text += "+ " + вычисления.Aij[i].Строка[j].d.ToString() + "X" + (i + 1) + " ";
                    }
                }
                richTextBoxОграничения.Text += " = " + вычисления.Aij[i].Строка[0].d.ToString() + "\n";
            }

        }
        void ВыводГлавнойТаблицы()
        {
            this.tableLayoutPanelПеременная.ColumnStyles[0].Width = 0F;
            this.tableLayoutPanelПеременная.ColumnStyles[1].Width = 100F;
            this.tableLayoutPanelПеременная.ColumnStyles[2].Width = 0F;
            this.tableLayoutPanelПеременная.ColumnStyles[3].Width = 0F;
            dataGridViewГТФункцияЦели.Columns.Clear();
            dataGridViewГТОграничения.Columns.Clear();
            dataGridViewГТСимплексРазности.Columns.Clear();
            dataGridViewГТФункцияЦели.Columns.Add("Базис", "");
            dataGridViewГТОграничения.Columns.Add("Базис", "Базис");
            dataGridViewГТСимплексРазности.Columns.Add("Базис", "");
            dataGridViewГТФункцияЦели.Columns.Add("Cj", "");
            dataGridViewГТОграничения.Columns.Add("Ci", "Ci");
            dataGridViewГТСимплексРазности.Columns.Add("бj", "");
            dataGridViewГТФункцияЦели.Columns.Add("Cj", "");
            dataGridViewГТОграничения.Columns.Add("A0", "A0");
            dataGridViewГТСимплексРазности.Columns.Add("бi0", "бi0");
            for (int i = 0; i < вычисления.КанонизируемаяФункцияЦели.Count; i++)
            {
                dataGridViewГТФункцияЦели.Columns.Add("C" + (i + 1), "C" + (i + 1));
                dataGridViewГТОграничения.Columns.Add("A" + (i + 1), "A" + (i + 1));
                dataGridViewГТСимплексРазности.Columns.Add("бi" + (i + 1), "бi" + (i + 1));
            }
            string[] FCArray = new string[вычисления.КанонизируемаяФункцияЦели.Count + 3];
            FCArray.SetValue("", 0);
            FCArray.SetValue("", 1);
            FCArray.SetValue("Cj", 2);

            richTextBoxСообщения.Text = вычисления.it[вычисления.it.Count - 1];
            dataGridViewГТФункцияЦели.Rows.Clear();
            int j = 0;
            for (int i = 0; i < вычисления.КанонизируемаяФункцияЦели.Count; i++)
            {
                FCArray.SetValue(вычисления.КанонизируемаяФункцияЦели[i].Вывод(), j + 3);
                j++;
            }
            dataGridViewГТФункцияЦели.Rows.Add(FCArray);

            dataGridViewГТОграничения.Rows.Clear();
            for (int k = 0; k < вычисления.Aij.Count; k++)
            {
                string[] OgArray = new string[вычисления.Aij[k].Строка.Count + 3];

                OgArray.SetValue("A" + вычисления.Aij[k].Базис, 0);
                OgArray.SetValue(вычисления.Aij[k].cj.Вывод() + "", 1);
                j = 0;
                for (int i = 0; i < вычисления.Aij[k].Строка.Count; i++)
                {
                    OgArray.SetValue(вычисления.Aij[k].Строка[i].d + "", j + 2);
                    j++;
                }
                dataGridViewГТОграничения.Rows.Add(OgArray);
            }
            dataGridViewГТСимплексРазности.Rows.Clear();
            for (int i = 0; i < вычисления.СимплексРазности.Count; i++)
            {
                string[] SRArray = new string[вычисления.СимплексРазности[i].Count + 3];
                SRArray.SetValue("", 0);
                SRArray.SetValue("б" + (i+1) + "j", 1);
                for (int k = 0; k < вычисления.СимплексРазности[i].Count; k++)
                {
                    if (вычисления.СимплексРазности[i][k].Выведён == true)
                    {
                        SRArray.SetValue("-", k + 2);
                    }
                    else
                    {
                        SRArray.SetValue(вычисления.СимплексРазности[i][k].Вывод(), k + 2);
                    }
                }
                dataGridViewГТСимплексРазности.Rows.Add(SRArray);
            }
            for (int k = 0; k < вычисления.СимплексРазности.Count - 1; k++)
            {
                for (int i = 0; i < вычисления.СимплексРазности[k].Count; i++)
                {
                    if (вычисления.ekij[k].kВводимыйВБазисСтолбец == i)
                    {
                        dataGridViewГТСимплексРазности.Rows[k].Cells[i + 2].Style.BackColor = System.Drawing.Color.Red;
                    }
                }
            }
        }
        void ВыводИтераций(int s)
        {
            this.tableLayoutPanelПеременная.ColumnStyles[0].Width = 0F;
            this.tableLayoutPanelПеременная.ColumnStyles[1].Width = 0F;
            this.tableLayoutPanelПеременная.ColumnStyles[2].Width = 100F;
            this.tableLayoutPanelПеременная.ColumnStyles[3].Width = 0F;

            //очистка таблиц итераций
            dataGridViewИтЕij.Rows.Clear();
            dataGridViewИтЕij.Columns.Clear();
            dataGridViewИтРазрешающиеМножители.Rows.Clear();
            dataGridViewИтРазрешающиеМножители.Columns.Clear();
            //добавление заголовков таблиц
            dataGridViewИтЕij.Columns.Add("Базис", "Базис");
            dataGridViewИтРазрешающиеМножители.Columns.Add("Базис", "");
            dataGridViewИтЕij.Columns.Add("Ci", "Ci");
            dataGridViewИтРазрешающиеМножители.Columns.Add("Лj", "");
            for (int i = 0; i < вычисления.ekij[s].Tablica.Count + 1; i++)
            {
                dataGridViewИтЕij.Columns.Add("e" + (i), "e" + (i));
                dataGridViewИтРазрешающиеМножители.Columns.Add("Л" + (i), "Л" + (i));
            }
            dataGridViewИтЕij.Columns.Add("Ai*", "Ai*");
            dataGridViewИтРазрешающиеМножители.Columns.Add(" ", "");
            dataGridViewИтЕij.Columns.Add("Qi", "Qi");
            dataGridViewИтРазрешающиеМножители.Columns.Add("  ", "");

            //добавление еij в таблицу
            for (int i = 0; i < вычисления.ekij[s].Tablica.Count; i++)
            {
                string[] OgArray = new string[вычисления.ekij[s].Tablica[1].Строка.Count + 6];
                OgArray.SetValue("A" + вычисления.ekij[s].Tablica[i].Базис, 0);
                OgArray.SetValue(вычисления.ekij[s].Tablica[i].cj.Вывод() + "", 1);
                int k = 2;
                for (int j = 0; j < вычисления.ekij[s].Tablica[i].Строка.Count; j++)
                {
                    OgArray.SetValue(вычисления.ekij[s].Tablica[i].Строка[j].ToString(), j + 2);
                    k++;
                }
                if (s != вычисления.ekij.Count - 1)
                {
                    OgArray.SetValue(вычисления.ekij[s].Tablica[i].AСоЗвёздочкой.ToString(), k++);
                    OgArray.SetValue(вычисления.ekij[s].Tablica[i].Q.ToString(), k);
                }
                dataGridViewИтЕij.Rows.Add(OgArray);
            }
            //Добавление в таблицу разрешающех множителей
            string[] RMArray = new string[вычисления.РазрешающиеМножители[s].Count + 2];
            RMArray.SetValue("", 0);
            RMArray.SetValue("Лj", 1);
            for (int i = 0; i < вычисления.РазрешающиеМножители[s].Count; i++)
            {
                RMArray.SetValue(вычисления.РазрешающиеМножители[s][i].Вывод(), i + 2);
            }
            dataGridViewИтРазрешающиеМножители.Rows.Add(RMArray);
            if (s != вычисления.ekij.Count - 1)
            {
                //выделение выводимого базиса в таблице
                for (int i = 0; i < вычисления.ekij[s].Tablica.Count; i++)
                {
                    if (вычисления.ВозвращениеСтрокиВЕijСДаннымБазисом(s, вычисления.ekij[s].rВыводимаяИзБазисаСтрока) == i)
                    {
                        for (int j = 0; j < dataGridViewИтЕij.Rows[i].Cells.Count; j++)
                        {
                            dataGridViewИтЕij.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Red;
                        }
                    }
                }
            }

            richTextBoxСообщения.Text = вычисления.it[s];
        }
        void ДобавлениеВДеревоИтераций()
        {
            TreeNode[] tn = treeViewРешение.Nodes.Find("Итерации", true);
            int i = 1;
            while (i < вычисления.ekij.Count)
            {
                tn[0].Nodes.Add("Итерация " + (i + 1));
                i++;
            }
        }
        void ВыводОтвета()
        {
            this.tableLayoutPanelПеременная.ColumnStyles[0].Width = 100F;
            this.tableLayoutPanelПеременная.ColumnStyles[1].Width = 0F;
            this.tableLayoutPanelПеременная.ColumnStyles[2].Width = 0F;
            this.tableLayoutPanelПеременная.ColumnStyles[3].Width = 0F;

            richTextBoxФункцияЦели.Text = "F(";
            for (int i = 0; i < вычисления.ФункцияЦели.Count; i++)
            {
                if (i == 0 || вычисления.ФункцияЦели[i] < 0)
                {
                    richTextBoxФункцияЦели.Text += вычисления.ФункцияЦели[i].ToString() + "X" + (i + 1);
                }
                else
                {
                    richTextBoxФункцияЦели.Text += "+" + вычисления.ФункцияЦели[i].ToString() + "X" + (i + 1);
                }
            }
            richTextBoxФункцияЦели.Text += ")--->" + вычисления.opt + " = " + вычисления.СимплексРазности[вычисления.СимплексРазности.Count - 1][0].Вывод();

            richTextBoxОграничения.Text = "При значениях:\n";

            foreach (int i in вычисления.Ответ.Keys)
            {
                richTextBoxОграничения.Text += "X" + i + " = " + вычисления.Ответ[i].ToString() + "\n";
            }
        }
        private void treeViewРешение_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Решение")
            {
                ВыводУсловия();
            }
            else if (e.Node.Text == "Условие")
            {
                ВыводУсловия();
            }
            else if (e.Node.Text == "Канонизация")
            {
                ВыводКанонизации();
            }
            else if (e.Node.Text == "Главная таблица")
            {
                ВыводГлавнойТаблицы();
            }
            else if (e.Node.Text == "Итерации")
            {
                ВыводИтераций(0);
            }
            else if (e.Node.Text == "Ответ")
            {
                ВыводОтвета();
            }
            else if (e.Node.Text == "Анализ на чувствительность")
            {
                ВыводСтатусаРесурсов();
            }
            else if (e.Node.Text == "Статус ресурсов")
            {
                ВыводСтатусаРесурсов();
            }
            else if (e.Node.Text == "Значимость ресурсов")
            {
                ВыводЗначимостиРесурсов();
            }
            else if (e.Node.Text == "Пределы допустимых изменений запасов ресурсов")
            {
                ВыводПределыДопустимыхИзмененийЗапасовРесурсов();
            }
            else if (e.Node.Text == "Влияние на оптимальный план изменения запаса ресурсов")
            {
                ВыводВлияниеНаОптимальныйПланИзмененияЗапасаРесурсов();
            }
            else
            {
                int i = 0;
                while (i < вычисления.ekij.Count)
                {
                    if (e.Node.Text == "Итерация " + (i + 1))
                    {
                        ВыводИтераций(i);
                    }
                    i++;
                }
            }
        }
        #endregion

        #region ВыводАнализаНаЧувствительность
        void ВыводСтатусаРесурсов()
        {
            this.tableLayoutPanelПеременная.ColumnStyles[0].Width = 0F;
            this.tableLayoutPanelПеременная.ColumnStyles[1].Width = 0F;
            this.tableLayoutPanelПеременная.ColumnStyles[2].Width = 0F;
            this.tableLayoutPanelПеременная.ColumnStyles[3].Width = 100F;

            richTextBoxСообщения.Text = "Cтатус ресурсов(какие из них “дефицитные”, а какие “недефицитные”)";
            richTextBoxФункцияЦелиДвойственнаяЗадача.Text =анализначувствительность.двойственнаязадача.ВыводФункцииЦели();
            richTextBoxОграниченияДвойственнаяЗадача.Text = анализначувствительность.двойственнаязадача.ВыводОграничений();
            dataGridViewСРДЗ.Columns.Clear();
            dataGridViewСРДЗ.Columns.Add("бj", "");
            dataGridViewСРДЗ.Columns.Add("бi0", "бi0");
            for (int i = 0; i < вычисления.КанонизируемаяФункцияЦели.Count; i++)
            {
                dataGridViewСРДЗ.Columns.Add("бi" + (i + 1), "бi" + (i + 1));
            }
            dataGridViewСРДЗ.Rows.Clear();
            string[] SRArray = new string[анализначувствительность.СимплексРазность.Count + 4];
            SRArray.SetValue("б" + вычисления.СимплексРазности.Count + "j", 0);
            for (int k = 0; k < анализначувствительность.СимплексРазность.Count; k++)
            {
                if (анализначувствительность.СимплексРазность[k].Выведён == true)
                {
                    SRArray.SetValue("-", k + 1);
                }
                else
                {
                    SRArray.SetValue(анализначувствительность.СимплексРазность[k].Вывод(), k + 1);
                }
            }
            dataGridViewСРДЗ.Rows.Add(SRArray);
            for (int k = 0; k < анализначувствительность.СимплексРазность.Count; k++)
            {
                if (анализначувствительность.СимплексРазность[k].p == ТипПеременной.Дополнительная)
                {
                    dataGridViewСРДЗ.Rows[0].Cells[k + 1].Style.BackColor = Color.Green;
                }
            }
            richTextBoxСтатусРесурсов.Text = анализначувствительность.ВыводСтатусаРесурсов();
        }
        void ВыводЗначимостиРесурсов()
        {
            this.tableLayoutPanelПеременная.ColumnStyles[0].Width = 0F;
            this.tableLayoutPanelПеременная.ColumnStyles[1].Width = 0F;
            this.tableLayoutPanelПеременная.ColumnStyles[2].Width = 0F;
            this.tableLayoutPanelПеременная.ColumnStyles[3].Width = 100F;

            richTextBoxСообщения.Text = "ЗначимостьРесурсов(изменение объема какого из ресурсов является наиболее выгодным, с точки зрения обеспечения наибольшего дохода (или наименьших потерь) при выполнении операции)";
            richTextBoxФункцияЦелиДвойственнаяЗадача.Text = анализначувствительность.двойственнаязадача.ВыводФункцииЦели();
            richTextBoxОграниченияДвойственнаяЗадача.Text = анализначувствительность.двойственнаязадача.ВыводОграничений();
            dataGridViewСРДЗ.Columns.Clear();
            dataGridViewСРДЗ.Columns.Add("бj", "");
            dataGridViewСРДЗ.Columns.Add("бi0", "бi0");
            for (int i = 0; i < вычисления.КанонизируемаяФункцияЦели.Count; i++)
            {
                dataGridViewСРДЗ.Columns.Add("бi" + (i + 1), "бi" + (i + 1));
            }
            dataGridViewСРДЗ.Rows.Clear();
            string[] SRArray = new string[анализначувствительность.СимплексРазность.Count + 4];
            SRArray.SetValue("б" + вычисления.СимплексРазности.Count + "j", 0);
            for (int k = 0; k < анализначувствительность.СимплексРазность.Count; k++)
            {
                if (анализначувствительность.СимплексРазность[k].Выведён == true)
                {
                    SRArray.SetValue("-", k + 1);
                }
                else
                {
                    SRArray.SetValue(анализначувствительность.СимплексРазность[k].Вывод(), k + 1);
                }
            }
            dataGridViewСРДЗ.Rows.Add(SRArray);
            for (int k = 0; k < анализначувствительность.СимплексРазность.Count; k++)
            {
                if (анализначувствительность.СимплексРазность[k].p == ТипПеременной.Дополнительная)
                {
                    dataGridViewСРДЗ.Rows[0].Cells[k + 1].Style.BackColor = Color.Green;
                }
            }
            richTextBoxСтатусРесурсов.Text = анализначувствительность.ВыводЗначимостиРесурсов();
        }
        void ВыводПределыДопустимыхИзмененийЗапасовРесурсов()
        {
            this.tableLayoutPanelПеременная.ColumnStyles[0].Width = 0F;
            this.tableLayoutPanelПеременная.ColumnStyles[1].Width = 0F;
            this.tableLayoutPanelПеременная.ColumnStyles[2].Width = 0F;
            this.tableLayoutPanelПеременная.ColumnStyles[3].Width = 100F;

            richTextBoxСообщения.Text = "Пределы допустимого изменения запаса ресурсов, при которых их влияние на исходную модель задачи линейного программирования адекватно описывается двойственной задачей";
        }
        void ВыводВлияниеНаОптимальныйПланИзмененияЗапасаРесурсов()
        {
            this.tableLayoutPanelПеременная.ColumnStyles[0].Width = 0F;
            this.tableLayoutPanelПеременная.ColumnStyles[1].Width = 0F;
            this.tableLayoutPanelПеременная.ColumnStyles[2].Width = 0F;
            this.tableLayoutPanelПеременная.ColumnStyles[3].Width = 100F;

            richTextBoxСообщения.Text = "ВлияниеНаОптимальныйПланИзмененияЗапасаРесурсов(как отразится на оптимальном плане увеличение (уменьшение) запаса ресурсов?)";

        }
        #endregion
    }
}

    

