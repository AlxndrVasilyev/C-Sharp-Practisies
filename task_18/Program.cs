// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool X = false;
bool Y = false;

if (!X | !Y == !X && !Y)
    Console.WriteLine("Yes, it's true");
else
    Console.WriteLine("Nope, it's false");

// Выраженние истинно только при следующих вводных bool: