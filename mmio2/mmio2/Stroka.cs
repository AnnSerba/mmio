using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mmio2
{
    
    public class СтрокаОграничения
    {
        public List<Дробь> Строка;
        public string Знак;
        public Дробь СвободныйЧлен;
        public СтрокаОграничения()
        {
            Строка = new List<Дробь>();
        }
    }
    public enum ДостижениеОптимума
    {
        Достигнут,НеДостигнут,ЗадачаНеразрешима
    }
    public enum ТипПеременной
    {
        Базисная, Дополнительная, Искуственная, СвободныйЧлен
    }
    public class Элемент
    {
        public Дробь d;
        public ТипПеременной p;
        public Элемент(Дробь _d, ТипПеременной _p)
        {
            d = _d;
            p = _p;
        }
    }
    public class ЭлементКанонизированнойФункцииЦели
    {
        public Дробь дробь;
        public bool бесконечность;
        public ЭлементКанонизированнойФункцииЦели(Дробь _дробь, bool _бесконечность)
        {
            дробь = _дробь;
            бесконечность = _бесконечность;
        }
        public string Вывод()
        {
            if (бесконечность == true)
            {
                return дробь.ToString() + "M";
            }
            else
            {
                return дробь.ToString();
            }
        }
    }
        
    public class КанонизированнаяСтрокаОграничения
    {
        public List<Элемент> Строка;
        public int Базис;
        public ЭлементКанонизированнойФункцииЦели cj;
        public КанонизированнаяСтрокаОграничения()
        {
            Строка = new List<Элемент>();
        }
    }
    public enum Opt
    {
        Min, Max
    }
    public class СтрокаДляEij
    {
        public List<Дробь> Строка;
        public int Базис;
        public ЭлементКанонизированнойФункцииЦели cj;
        public Дробь AСоЗвёздочкой=new Дробь(0);
        public Дробь Q=new Дробь(0);
        public СтрокаДляEij()
        {
            Строка = new List<Дробь>();
        }
    }
    public class ТаблицаДляEij
    {
        public List<СтрокаДляEij> Tablica;
        public int kВводимыйВБазисСтолбец;
        public int rВыводимаяИзБазисаСтрока;
        public ТаблицаДляEij()
        {
            Tablica = new List<СтрокаДляEij>();
        }
    }

    public class ТаблицаДляСимплексРазностей
    {
        public Дробь КоэффициентПриБесконечности = new Дробь(0), Число = new Дробь(0);
        public ТипПеременной p;
        public bool Выведён;
        public bool Введён;
        public ТаблицаДляСимплексРазностей(Дробь _koef_pri_besk, Дробь _chislo)
        {
            КоэффициентПриБесконечности = _koef_pri_besk;
            Число = _chislo;
            Выведён = false;
            Введён = false;
        }
        public ТаблицаДляСимплексРазностей()
        {
            Выведён = false;
            Введён = false;
        }
        public string Вывод()
        {
            string st = "";
            if (КоэффициентПриБесконечности != 0)
            {
                st += КоэффициентПриБесконечности.ToString() + "M";
            }
            if (Число != 0)
            {
                if (Число < 0)
                {
                    st += Число.ToString();
                }
                else
                    if (Число > 0 && КоэффициентПриБесконечности != 0)
                    {
                        st += "+" + Число.ToString();
                    }
                    else
                    {
                        st += Число.ToString();
                    }
            }
            if (st == "")
            {
                st = "0";
            }
            return st;
        }
    }
}

