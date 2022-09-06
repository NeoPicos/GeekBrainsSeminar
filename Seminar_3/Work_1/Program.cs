int GetAreaRange(int areaNum) {
    if (areaNum == 1) {
        return "x>0 y>0";
    }

    if (areaNum == 2) {
        return "x<0 y>0";
    }

    if (areaNum == 3) {
        return "x<0 y<0";
    }

    if (areaNum == 4) {
        return "x>0 y<0";
    }

    if (areaNum == 0) {
        return "x=0 y=0";
    }

    return "Введенный номер четверти больше 4-х";
}

Console.Write("Input area: ");
int areaNum = Convert.ToInt32(Console.ReadLine());

string result = GetAreaRange(areaNum);
Console.WriteLine(result);


