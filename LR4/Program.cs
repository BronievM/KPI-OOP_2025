using LR4.Classes;

namespace LR4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Outfits wardrobe = new Outfits();

            wardrobe.outfits.Add(new OutfitBuilder().SetAccessories("Годинник").SetTop("Футболка").SetBottom("Джинси").SetShoes("Кросiвки").Build());
            wardrobe.outfits.Add(new OutfitBuilder().SetHat("Шапка").SetTop("Светр").SetBottom("Спiдниця").SetShoes("Чоботи").Build());
            wardrobe.outfits.Add(new OutfitBuilder().SetAccessories("Браслет").SetTop("Блузка").SetBottom("Шорти").SetShoes("Сандалi").Build());

            bool running = true;
            while (running)
            {
                Console.WriteLine("\n--- МЕНЮ ---");
                Console.WriteLine("1. Показати усе вбрання");
                Console.WriteLine("2. Вiдсортувати по верхнiй частинi (A-Я)");
                Console.WriteLine("3. Вiдсортувати по нижнiй частинi (Я-A)");
                Console.WriteLine("4. Створити нове вбрання");
                Console.WriteLine("0. Вийти");
                Console.Write("Ваш вибiр: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShowOutfits(wardrobe.outfits);
                        break;
                    case "2":
                        ShowOutfits(wardrobe.sortOutfitsTopByAZ());
                        break;
                    case "3":
                        ShowOutfits(wardrobe.sortOutfitBottomByZA());
                        break;
                    case "4":
                        var newOutfit = CreateOutfit();
                        wardrobe.outfits.Add(newOutfit);
                        Console.WriteLine("Успiх!");
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Невiрний вибiр, спробуйте ще раз");
                        break;
                }
            }
        }

        static void ShowOutfits(List<Outfit> outfits)
        {
            Console.WriteLine("\nСписок усього вбрання:");
            foreach (var outfit in outfits)
            {
                Console.WriteLine($"Головний убiр: {GetDisplayValue(outfit.Hat)}; Верх: {GetDisplayValue(outfit.Top)}; Низ: {GetDisplayValue(outfit.Bottom)}; Взуття: {GetDisplayValue(outfit.Shoes)}; Аксесуари: {GetDisplayValue(outfit.Accessories)}");
            }
        }

        static Outfit CreateOutfit()
        {
            Console.WriteLine("\nСтворення нового вбрання:");
            Console.Write("Введіть аксесуари (залиште порожнiм, якщо не плануєте додавати): ");
            string accessories = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(accessories)) accessories = string.Empty; 
            Console.Write("Введіть головний убiр (залиште порожнiм, якщо не плануєте додавати): ");
            string hat = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(hat)) hat = string.Empty;
            Console.Write("Введіть верх (залиште порожнiм, якщо не плануєте додавати): ");
            string top = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(top)) top = string.Empty;
            Console.Write("Введіть низ (залиште порожнiм, якщо не плануєте додавати): ");
            string bottom = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(bottom)) bottom = string.Empty;
            Console.Write("Введіть взуття (залиште порожнiм, якщо не плануєте додавати): ");
            string shoes = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(shoes)) shoes = string.Empty;

            return new OutfitBuilder()
                .SetAccessories(accessories)
                .SetHat(hat)
                .SetTop(top)
                .SetBottom(bottom)
                .SetShoes(shoes)
                .Build();
        }

        static string GetDisplayValue(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return "Немає";
            else return value;
        }

    }
}
