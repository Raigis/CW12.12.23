public static class Print {
    public static void PrintArray(string[] array){
        Console.Write($"[");
        for (int i = 0; i < array.Length-1; i++){
            if (array[i].Length <= 3) Console.Write($"{array}, ");
        }
        Console.WriteLine($"{array[array.Length-1]}]");
    }
}