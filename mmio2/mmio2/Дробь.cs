using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mmio2
{
    public class Дробь
    {
        public int Числитель;              // Числитель
        public int Знаменатель;            // Знаменатель
        public int Знак;                   // Знак

        public double ВозвращениеЧисла()
        {
            return Знак * (double)Числитель / (double)Знаменатель;
        }

        public Дробь(int Числитель, int Знаменатель)
        {
            if (Знаменатель == 0)
            {
                throw new DivideByZeroException("В знаменателе не может быть нуля");
            }

            this.Числитель = Math.Abs(Числитель);
            this.Знаменатель = Math.Abs(Знаменатель);

            if (Числитель * Знаменатель < 0)
            {
                this.Знак = -1;
            }
            else
            {
                this.Знак = 1;
            }
          this.Reduce();
        }

        // Вызов первого конструктора со знаменателем равным единице
        public Дробь(int number) : this(number, 1) { }

        // Возвращает наибольший общий делитель (Алгоритм Евклида)
        private static int getGreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }


        // Возвращает наименьшее общее кратное
        private static int getLeastCommonMultiple(int a, int b)
        {
            // В формуле опушен модуль, так как в классе
            // числитель всегда неотрицательный, а знаменатель -- положительный
            // ...
            // Деление здесь -- челочисленное, что не искажает результат, так как
            // числитель и знаменатель делятся на свои делители,
            // т.е. при делении не будет остатка
            return a * b / getGreatestCommonDivisor(a, b);
        }

        // Метод создан для устранения повторяющегося кода в методах сложения и вычитания дробей.
        // Возвращает дробь, которая является результатом сложения или вычитания дробей a и b,
        // В зависимости от того, какая операция передана в параметр operation.
        // P.S. использовать только для сложения и вычитания
        private static Дробь performOperation(Дробь a, Дробь b, Func<int, int, int> operation)
        {
            // Наименьшее общее кратное знаменателей
            int leastCommonMultiple = getLeastCommonMultiple(a.Знаменатель, b.Знаменатель);

            // Дополнительный множитель к первой дроби
            int additionalMultiplierFirst = leastCommonMultiple / a.Знаменатель;

            // Дополнительный множитель ко второй дроби
            int additionalMultiplierSecond = leastCommonMultiple / b.Знаменатель;

            // Результат операции
            int operationResult = operation(a.Числитель * additionalMultiplierFirst * a.Знак,
                                            b.Числитель * additionalMultiplierSecond * b.Знак);

            return new Дробь(operationResult, a.Знаменатель * additionalMultiplierFirst);
        }


        // Перегрузка оператора "+" для случая сложения двух дробей
        public static Дробь operator +(Дробь a, Дробь b)
        {
            return performOperation(a, b, (int x, int y) => x + y);
        }

        // Перегрузка оператора "+" для случая сложения дроби с числом
        public static Дробь operator +(Дробь a, int b)
        {
            return a + new Дробь(b);
        }

        // Перегрузка оператора "+" для случая сложения числа с дробью
        public static Дробь operator +(int a, Дробь b)
        {
            return b + a;
        }

        // Перегрузка оператора "-" для случая вычитания двух дробей
        public static Дробь operator -(Дробь a, Дробь b)
        {
            return performOperation(a, b, (int x, int y) => x - y);
        }

        // Перегрузка оператора "-" для случая вычитания из дроби числа
        public static Дробь operator -(Дробь a, int b)
        {
            return a - new Дробь(b);
        }

        // Перегрузка оператора "-" для случая вычитания из числа дроби
        public static Дробь operator -(int a, Дробь b)
        {
            return b - a;
        }

        // Перегрузка оператора "*" для случая произведения двух дробей
        public static Дробь operator *(Дробь a, Дробь b)
        {
            return new Дробь(a.Числитель * a.Знак * b.Числитель * b.Знак, a.Знаменатель * b.Знаменатель);
        }

        // Перегрузка оператора "*" для случая произведения дроби и числа
        public static Дробь operator *(Дробь a, int b)
        {
            
            return new Дробь(a.Числитель * new Дробь(b).Числитель,a.Знаменатель * new Дробь(b).Знаменатель);
        }

        // Перегрузка оператора "*" для случая произведения числа и дроби
        public static Дробь operator *(int a, Дробь b)
        {
            return b * a;
        }

        // Перегрузка оператора "/" для случая деления двух дробей
        public static Дробь operator /(Дробь a, Дробь b)
        {
            return a * b.GetReverse();
        }

        // Перегрузка оператора "/" для случая деления дроби на число
        public static Дробь operator /(Дробь a, int b)
        {
            return a / new Дробь(b);
        }

        // Перегрузка оператора "/" для случая деления числа на дробь
        public static Дробь operator /(int a, Дробь b)
        {
            return new Дробь(a) / b;
        }

        // Перегрузка оператора "унарный минус"
        public static Дробь operator -(Дробь a)
        {
            return a.GetWithChangedЗнак();
        }

        // Перегрузка оператора "++"
        public static Дробь operator ++(Дробь a)
        {
            return a + 1;
        }

        // Перегрузка оператора "--"
        public static Дробь operator --(Дробь a)
        {
            return a - 1;
        }

        // Возвращает дробь, обратную данной
        private Дробь GetReverse()
        {
            return new Дробь(this.Знаменатель * this.Знак, this.Числитель);
        }

        // Возвращает дробь с противоположным знаком
        private Дробь GetWithChangedЗнак()
        {
            return new Дробь(-this.Числитель * this.Знак, this.Знаменатель);
        }

        // Мой метод Equals
        public bool Equals(Дробь that)
        {
            Дробь a = this.Reduce();
            Дробь b = that.Reduce();

            return a.Числитель == b.Числитель &&
                    a.Знаменатель == b.Знаменатель &&
                    a.Знак == b.Знак;
        }

        // Переопределение метода Equals
        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is Дробь)
            {
                result = this.Equals(obj as Дробь);
            }

            return result;
        }

        // Переопределение метода GetHashCode
        public override int GetHashCode()
        {
            return this.Знак * (this.Числитель * this.Числитель + this.Знаменатель * this.Знаменатель);
        }

        // Перегрузка оператора "Равенство" для двух дробей
        public static bool operator ==(Дробь a, Дробь b)
        {
            // Приведение к Object необходимо для того, чтобы
            // можно было сравнивать дроби с null.
            // Обычное сравнение a.Equals(b) в данном случае не подходит,
            // так как если a есть null, то у него нет метода Equals,
            // следовательно будет выдано исключение, а если
            // b окажется равным null, то исключение будет вызвано в
            // методе this.Equals
            Object aAsObj = a as Object;
            Object bAsObj = b as Object;
            if (aAsObj == null || bAsObj == null)
            {
                return aAsObj == bAsObj;
            }
            return a.Equals(b);
        }

        // Перегрузка оператора "Равенство" для дроби и числа
        public static bool operator ==(Дробь a, int b)
        {
            return a == new Дробь(b);
        }

        // Перегрузка оператора "Равенство" для числа и дроби
        public static bool operator ==(int a, Дробь b)
        {
            return new Дробь(a) == b;
        }

        // Перегрузка оператора "Неравенство" для двух дробей
        public static bool operator !=(Дробь a, Дробь b)
        {
            return !(a == b);
        }

        // Перегрузка оператора "Неравенство" для дроби и числа
        public static bool operator !=(Дробь a, int b)
        {
            return a != new Дробь(b);
        }

        // Перегрузка оператора "Неравенство" для числа и дроби
        public static bool operator !=(int a, Дробь b)
        {
            return new Дробь(a) != b;
        }

        // Метод сравнения двух дробей
        // Возвращает    0, если дроби равны
        //               1, если this больше that
        //              -1, если this меньше that
        private int CompareTo(Дробь that)
        {
            if (this.Equals(that))
            {
                return 0;
            }

            Дробь a = this.Reduce();
            Дробь b = that.Reduce();

            if (a.Числитель * a.Знак * b.Знаменатель > b.Числитель * b.Знак * a.Знаменатель)
            {
                return 1;
            }
            return -1;
        }

        // Перегрузка оператора ">" для двух дробей
        public static bool operator >(Дробь a, Дробь b)
        {
            return a.CompareTo(b) > 0;
        }

        // Перегрузка оператора ">" для дроби и числа
        public static bool operator >(Дробь a, int b)
        {
            return a > new Дробь(b);
        }

        // Перегрузка оператора ">" для числа и дроби
        public static bool operator >(int a, Дробь b)
        {
            return new Дробь(a) > b;
        }



        // Перегрузка оператора "<" для двух дробей
        public static bool operator <(Дробь a, Дробь b)
        {
            return a.CompareTo(b) < 0;
        }

        // Перегрузка оператора "<" для дроби и числа
        public static bool operator <(Дробь a, int b)
        {
            return a < new Дробь(b);
        }

        // Перегрузка оператора "<" для числа и дроби
        public static bool operator <(int a, Дробь b)
        {
            return new Дробь(a) < b;
        }



        // Перегрузка оператора ">=" для двух дробей
        public static bool operator >=(Дробь a, Дробь b)
        {
            return a.CompareTo(b) >= 0;
        }

        // Перегрузка оператора ">=" для дроби и числа
        public static bool operator >=(Дробь a, int b)
        {
            return a >= new Дробь(b);
        }

        // Перегрузка оператора ">=" для числа и дроби
        public static bool operator >=(int a, Дробь b)
        {
            return new Дробь(a) >= b;
        }



        // Перегрузка оператора "<=" для двух дробей
        public static bool operator <=(Дробь a, Дробь b)
        {
            return a.CompareTo(b) <= 0;
        }

        // Перегрузка оператора "<=" для дроби и числа
        public static bool operator <=(Дробь a, int b)
        {
            return a <= new Дробь(b);
        }

        // Перегрузка оператора "<=" для числа и дроби
        public static bool operator <=(int a, Дробь b)
        {
            return new Дробь(a) <= b;
        }

        public Дробь Reduce()
        {
            Дробь result = this;
            int greatestCommonDivisor = getGreatestCommonDivisor(this.Числитель, this.Знаменатель);
            result.Числитель /= greatestCommonDivisor;
            result.Знаменатель /= greatestCommonDivisor;
            return result;
        }
        // Переопределение метода ToString
        public override string ToString()
        {
            if (this.Числитель == 0)
            {
                return "0";
            }

            string result;

            if (this.Знак < 0)
            {
                result = "-";
            }
            else
            {
                result = "";
            }

            if (this.Числитель == this.Знаменатель)
            {
                return result + "1";
            }

            if (this.Знаменатель == 1)
            {
                return result + this.Числитель;
            }

            return result + this.Числитель + "/" + this.Знаменатель;
        }
    }
}
