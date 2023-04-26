Console.Write("請輸入您想查詢的年份：");
int year = int.Parse(Console.ReadLine());
if (year < 1 || year > 9999){
    Console.WriteLine("輸入錯誤");
}
Console.Write("請輸入一排幾個月：");
int month = int.Parse(Console.ReadLine());

bool leap = false;
if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
    leap = true;

int[] leepyear = new int[12]{31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
int[] normyear = new int[12]{31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
string[] month_name = new string[12]{"Jan", "Fed", "Mar", "Apr","May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};

int total_days = 0;
for (int i = 1; i < year; i++){
    if (i == 4)
        total_days += 365;
    else if (i > 4 && i <1582)
        if (i % 4 == 0)
            total_days +=366;
        else
            total_days += 365;
    else if (i == 1582)
        total_days += 355;
    else if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
        total_days += 366;
    else
        total_days += 365;
}

int start_week = total_days % 7;

Console.WriteLine("    " + year + " 年");
Console.WriteLine("==============");
Console.WriteLine();

int heigh = 12 / month;
if (12 % month > 0)
    heigh += 1;

int[] remain = new int[12]{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

for (int i = 0; i < heigh; i++){
    for (int j = 0; j < month; j++){
        int month_index = i * month + j + 1;
        if (month_index > 12)
            continue;
        Console.Write(month_name[month_index - 1]);
        Console.Write("                    ");
    }
    Console.WriteLine();
    
    for (int j = 0; j < month; j++){ 
        int month_index = i * month + j + 1;
        if (month_index > 12)
            continue;
        Console.Write(" S  M  T  W  T  F  S   ");
    }
    Console.WriteLine();

    for(int m = 0; m < 6; m++){
        for (int j = 0; j < month; j++){
            int month_index = i * month + j + 1;
            if (month_index > 12){
                Console.Write("                       ");
                if (j == month - 1)
                    Console.WriteLine();
                continue;
            }
            
            if (remain[month_index - 1] == 0){
                int cur_start_week = start_week;
                if (month_index == 1){
                    for (int k = 0; k < start_week; k++)
                        Console.Write("   ");
                } else {
                    int month_start = start_week;
                    for(int k = 0; k < month_index - 1; k++){
                        if (leap)
                            month_start += leepyear[k]; 
                        else
                            month_start += normyear[k];
                    }
                    month_start = month_start % 7;
                    cur_start_week = month_start;
                    for (int k = 0; k < month_start; k++)
                        Console.Write("   ");
                }

                for (int k = cur_start_week; k < 7; k++){
                    remain[month_index - 1] += 1;
                    if (remain[month_index - 1] < 10)
                        Console.Write(" ");
                    
                    Console.Write(remain[month_index - 1]);
                    Console.Write(" ");
                }

                Console.Write("  ");
                if (j == month - 1)
                    Console.WriteLine();
            }

            if (m == 0)
                continue;
            
            for (int k = 0; k < 7; k++){
                remain[month_index - 1] += 1;
                if (remain[month_index - 1] < 10){
                    Console.Write(" ");

                }else{
                    if (leap){
                        if (remain[month_index - 1] > leepyear[month_index -1]){
                            Console.Write("   ");
                            continue;
                        }
                    }else{
                        if (remain[month_index - 1] > normyear[month_index -1]){
                            Console.Write("   ");
                            continue;
                        }
                    }
                }
                Console.Write(remain[month_index - 1]);
                Console.Write(" ");
            }
            Console.Write("  ");
           
            if (j == month - 1)
                Console.WriteLine();
        }
    }
    Console.WriteLine();
}