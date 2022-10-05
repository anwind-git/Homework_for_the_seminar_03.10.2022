// На вход подаётся поговорка “без труда не выловишь и рыбку из пруда”.
// Используя рекурсию, подсчитайте, сколько в поговорке гласных букв.

void Podshet(int i = 0, string text = "без труда не выловишь и рыбку из пруда")
{
    if(i > 0 && i < text.Length) return;
       text = text.ToLower();
       char[] glas = {'а', 'е', 'ё', 'у', 'ы', 'я', 'и', 'о', 'ю', 'э'};
       foreach (char d in text) 
            if (glas.Contains(d))
                i++;
    Console.WriteLine($"Гласных букв в строке: " + i);
    Podshet(i);
}
Podshet();