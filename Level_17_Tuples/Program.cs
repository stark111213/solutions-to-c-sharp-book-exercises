// -------------------- Simula's Soup --------------------

int type = Choice("Choose food type:\n0. Soup\n1. Stew\n2. Gumbo");
int main = Choice("\nChoose main ingredient:" +
    "\n0. Mushrooms\n1. Chicken\n2. Carrots\n3. Potatoes");

int seasoning = Choice("\nChoose food type:\n0. Spicy\n1. Salty\n2. Sweet");

var soup = (type:      (FoodType)type, 
            main:      (MainIngredient)main, 
            seasoning: (Seasoning)seasoning);

Console.WriteLine($"\n{soup.seasoning} {soup.main} {soup.type}.");

int Choice(string menu)
{
    Console.WriteLine(menu);
    Console.Write("\n> ");
    return int.Parse(Console.ReadLine()!);
}

enum FoodType { Soup, Stew, Gumbo }
enum MainIngredient { Mushrooms, Chicken, Carrots, Potatoes }
enum Seasoning { Spicy, Salty, Sweet }