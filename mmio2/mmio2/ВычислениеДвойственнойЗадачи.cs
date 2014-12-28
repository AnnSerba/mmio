using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mmio2
{
   public class ДвойственнаяЗадача
    {
        public List<Дробь> ФункцияЦели = new List<Дробь>();
        public List<СтрокаОграничения> Ограничения = new List<СтрокаОграничения>();
        Opt opt;
        public ДвойственнаяЗадача(List<Дробь> ФЦ, List<СтрокаОграничения> Ог, Opt opt)
        {
            if (opt == Opt.Max)
            {
                this.opt = Opt.Min;
            }
            else
            {
                this.opt = Opt.Max;
            }
            for (int i = 0; i < Ог.Count; i++)
            {
                ФункцияЦели.Add(Ог[i].СвободныйЧлен);
            }
            for (int i = 0; i < ФЦ.Count; i++)
            {
                Ограничения.Add(new СтрокаОграничения());
                Ограничения[i].СвободныйЧлен = ФЦ[i];

                for (int j = 0; j < Ог.Count; j++)
                {
                    Ограничения[i].Строка.Add(Ог[j].Строка[i]);
                }
                Ограничения[i].Знак = "<=";
                Ограничения[i].СвободныйЧлен = ФЦ[i];
            }
        }
        public string ВыводФункцииЦели()
        {
            string st = "f(";
            for (int i = 0; i < ФункцияЦели.Count; i++)
            {
                if (i != ФункцияЦели.Count - 1)
                {
                    st += "Y" + (i + 1) + ",";
                }
                else
                {
                    st += "Y" + (i + 1) + ")=";
                }
            }
            for (int i = 0; i < ФункцияЦели.Count; i++)
            {
                if (i == 0 || ФункцияЦели[i] < 0)
                {
                    st += ФункцияЦели[i] + "Y" + (i + 1);
                }
                else
                {
                    st += "+" + ФункцияЦели[i] + "Y" + (i + 1);
                }
            }
            st += "      ------>"+opt;
            return st;
        }
        public string ВыводОграничений()
        {
            string st = "";
            for (int i = 0; i < Ограничения.Count; i++)
            {
                for (int j = 0; j < Ограничения[i].Строка.Count; j++)
                {
                    if (j == 0 || Ограничения[i].Строка[j] < 0)
                    {
                        st += Ограничения[i].Строка[j] + "Y" + (i + 1);
                    }
                    else
                    {
                        st += "+" + Ограничения[i].Строка[j] + "Y" + (i + 1);
                    }
                }
                st +=Ограничения[i].Знак+Ограничения[i].СвободныйЧлен+ "\n";
            }
            return st;
        }
    }
}
