# -1
1.  15) Приведите синтаксис оператора выбора в общем виде. Проиллюстрируйте его фрагментом программы на языке C#.
switch — это оператор выбора, который выбирает для выполнения один раздел switch из списка кандидатов, сравнивая их с выражением соответствия.

using System;

public class Example
{
   public static void Main()
   {
      int caseSwitch = 1;
      
      switch (caseSwitch)
      {
          case 1:
              Console.WriteLine("Case 1");
              break;
          case 2:
              Console.WriteLine("Case 2");
              break;
          default:
              Console.WriteLine("Default case");
              break;
      }
   }
}


2. 5) Является ли среда CLR многоязычной?
Среда CLR предоставляет необходимую основу для взаимодействия языков, определяя и обеспечивая реализацию системы общих типов, а также предоставляя метаданные. Поскольку все языки, предназначенные для среды выполнения, следуют правилам системы общих типов CTS по использованию и определению типов, использование типов является согласованным для всех языков.
3. 10) Перечислите пять простых типов языка C#.
o	Целочисленный со знаком: sbyte, short, int,long
o	Целочисленный без знака: byte, ushort, uint,ulong
o	Символы Юникода: char
o	Логическое значение: bool
o	IEEE-представление с плавающей запятой: float, double
4.  21) В чем состоит назначение директивы using? 
•	Для разрешения использования типов в пространстве имен, чтобы не нужно было квалифицировать использование типа в этом пространстве имен:

using System.Text;
•	Для разрешения доступа к статическим членам и вложенным типам без необходимости квалифицировать доступ с помощью имени типа.

using static System.Math;

  Чтобы создать псевдоним для пространства имен или типа. Это  называется директивой using static.
   using Project = PC.MyCompany.Project;

5.  8) Какая дисциплина (вариант контроля) типов принята в языке C#?
Система типов поддерживает две категории типов, каждая из которых разделена на подкатегории: 
•	типы значений (типы–значения),  
•	ссылочные типы (типы–ссылки).

Для типов-ссылок необходимо явно выделять место в памяти, используя метод New().
