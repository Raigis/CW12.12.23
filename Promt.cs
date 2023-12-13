using static Append;

public static class Promt{
    public static string[] Enter(){
        string[] array = [];
        string? word;
        bool isEmpty = true;
        while (isEmpty){
            Console.WriteLine($"Введите любую строку. Если желаете остановиться, введите пустую строку.\nВ случае, когда ни одна строка не была введена будет использоваться набор строк по умолчанию.");
            word = Console.ReadLine();
            if (word == "") {
                if (array.Length == 0) {
                    string[] array_temp = {"one","two","three","four"};
                    return array_temp;
                }
                isEmpty = false;
            }
            else array = ArrayAppend(array, word);
        }
        return array;
    }
}