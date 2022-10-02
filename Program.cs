Console.WriteLine("-----------------------------------------------");
Console.WriteLine("ЭТО КЛАВИАТУРА КОТОРУЮ Я НЕНАВИЖУ");
Console.WriteLine("Клавиши Диеза W,E,T,Y,U");
Console.WriteLine("Клавиши нот A,S,D,F,G,H,J");
Console.WriteLine("Клавиши переключение актав F1,F2,F3,F4,F5");
Console.WriteLine("По умолчанию ключена первая актава!");
Console.WriteLine("-----------------------------------------------");


int[] firstOctave = { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
while (true)
{
    ConsoleKeyInfo InfoNum;
    InfoNum = Console.ReadKey(true);
    switch (InfoNum.Key)
    {
        case ConsoleKey.F1:
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Первая актава");
            Console.WriteLine("-----------------------------------------------");
            firstOctave = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
            break;
        case ConsoleKey.F2:
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Вторая актава");
            Console.WriteLine("-----------------------------------------------");
            firstOctave = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
            break;
        case ConsoleKey.F3:
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Третья актава");
            Console.WriteLine("-----------------------------------------------");
            firstOctave = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            break;
        case ConsoleKey.F4:
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Четвёртая актава");
            Console.WriteLine("-----------------------------------------------");
            firstOctave = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
            break;
        case ConsoleKey.F5:
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Пятая актава");
            Console.WriteLine("-----------------------------------------------");
            firstOctave = new int[] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };
            break;
        case ConsoleKey.A:
            Console.Beep(firstOctave[0], 250);
            break;
        case ConsoleKey.W:
            Console.Beep(firstOctave[1], 250);
            break;
        case ConsoleKey.S:
            Console.Beep(firstOctave[2], 250);
            break;
        case ConsoleKey.E:
            Console.Beep(firstOctave[3], 250);
            break;
        case ConsoleKey.D:
            Console.Beep(firstOctave[4], 250);
            break;
        case ConsoleKey.F:
            Console.Beep(firstOctave[5], 250);
            break;
        case ConsoleKey.T:
            Console.Beep(firstOctave[6], 250);
            break;
        case ConsoleKey.G:
            Console.Beep(firstOctave[7], 250);
            break;
        case ConsoleKey.Y:
            Console.Beep(firstOctave[8], 250);
            break;
        case ConsoleKey.H:
            Console.Beep(firstOctave[9], 250);
            break;
        case ConsoleKey.U:
            Console.Beep(firstOctave[10], 250);
            break;
        case ConsoleKey.J:
            Console.Beep(firstOctave[11], 250);
            break;
    }
}