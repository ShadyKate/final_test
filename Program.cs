Console.Clear();
//Создаем метод на поиск количества элементов
int countOfNeededElements(string [] array){
int count = 0;
for(int i = 0; i < array.Length; i++){

if (array[i].Length < 3 || array[i].Length == 3){
count++;
}
}
return count;
}
//Метод в котором записываем значения в новый массив и возвращаем этот массив
string [] arrayModification(string [] array, int arrayLength){
    string [] newArray = new string [arrayLength];
    int j = 0;
    for(int i = 0; i < array.Length; i++){
    if (array[i].Length < 3 || array[i].Length == 3){
    newArray[j] = array[i];
    j++;
    }
    }
    return newArray;
}
// печатаем массив
void PrintArray(string [] inArray)
{   
    Console.WriteLine("[{0}]", string.Join(", ", inArray));   
}

string [] strngsForModification = {"Hello", "World", "12345", "qwerty", "12", "132"};
int count = countOfNeededElements(strngsForModification);
string [] array = arrayModification(strngsForModification, count);
PrintArray(array);


