# Итоговая контрольная работа по основному блоку. 


1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

## Задача
_Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами._

#### Алгоритм решения задачи
_будем решать с учетом того, что изначальный массив нам уже дан_
1. Создать метод, находящий количество элементов в изначальном массиве, которые соответствуют нашему условию(_длина элемента меньше, либо равна 3_);
2. Создать метод, в котором мы будем создавать новый массив(имея длину, которую получили ранее в первом методе) и записывать в него данные, которые удовлетворяют условию;
3. Создадим метод, который будет выводить массив на экран в формате красивого массиве: [].
