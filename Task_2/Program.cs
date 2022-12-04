int interXY(string str)
{
    Console.Write(str);
    int numberX = Convert.ToInt32(Console.ReadLine());
    return numberX;
}

void findLength(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double length = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2- z1) * (z2- z1));
    Console.WriteLine(length);
}


int x1 = interXY("Введите координату Х первой точки: ");
int y1 = interXY("Введите координату Y первой точки: ");
int z1 = interXY("Введите координату Z первой точки: ");
int x2 = interXY("Введите координату Х второй точки: ");
int y2 = interXY("Введите координату Y второй точки: ");
int z2 = interXY("Введите координату Z первой точки: ");

findLength(x1, y1, x2, y2, z1, z2);

// Почему-то не работает функция Math.power, по этому пришлось вот так расписывать:(