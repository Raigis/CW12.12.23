public static class Append{
    public static string[] ArrayAppend(string[] array, string word){
        string[] array_temp = new string[array.Length+1];
        for (int i = 0; i < array.Length; i++){
            array_temp[i] = array[i];
        }
        array_temp[array.Length] = word;
        return array_temp;
    }
}