public static class Print {
    public static void PrintArray(string[] array){
        for (int i = 0; i < array.Length; i++){
            if (array[i].Length <= 3) Console.Write($"{array[i]}\t");
        }
    }
}