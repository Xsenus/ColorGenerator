namespace ColorGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем список шестнадцатеричных цветов
            var colorList = GenerateColorList();

            // Путь к файлу для сохранения списка цветов
            string filePath = "color_list.txt";

            // Сохраняем список в файл
            SaveColorListToFile(colorList, filePath);

            Console.WriteLine($"Список цветов сохранен в файл: {filePath}");
        }

        static string[] GenerateColorList()
        {
            var colorList = new string[16777216]; // 16^6 = 16777216

            for (int i = 0; i < colorList.Length; i++)
            {
                // Форматируем числа в шестнадцатеричную строку и добавляем к списку
                colorList[i] = "#" + i.ToString("X6");
            }

            return colorList;
        }

        static void SaveColorListToFile(string[] colorList, string filePath)
        {
            // Записываем каждый цвет в файл
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var color in colorList)
                {
                    writer.WriteLine(color);
                }
            }
        }
    }
}
