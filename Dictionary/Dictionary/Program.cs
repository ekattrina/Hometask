class Program
{
    static void Main()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>
        {
            {"облачно", "Cloudy"},   
            {"ветрено", "Windy"},
            {"солнечно", "Sunny"},
            {"дождливо", "Rainy"},
            {"пасмурно", "Foggy"},
            {"снежно", "Snowy"},
            {"влажно", "Humid"},
            {"морозно", "Freezing"},
            {"жарко", "Hot"},
            {"сухо", "Dry"}
        };

        Console.WriteLine("Введите слово:");
        string input = Console.ReadLine().ToLower(); 

        if (dictionary.ContainsKey(input))
        {
            Console.WriteLine(dictionary[input]);
        }
        else
        {
            Console.WriteLine("Словарь не содержит этого слова");
        }
    }
}
