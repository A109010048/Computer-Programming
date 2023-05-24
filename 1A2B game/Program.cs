class Program{
    static bool A(int ans, int guess){
        if(ans == guess){
            return true;
        }
        else{
            return false;
        }
    }
    static bool B(ref int[] ansArray, ref int guess){
        for(int i = 0; i < 4; i ++){
            if(ansArray[i] == guess){
                ansArray[i] = -1;
                return true;
            }
        }
        return false;
    }

    static void Main(string[] args){
        Console.WriteLine("遊戲規則：\n\n電腦會設定一組四碼的數字作為謎底，四個數字不會重複。每猜一個數，電腦會根據這個數字給出提示，以 XAYB 形式呈現，直到猜中為止。其中X表示數字及位置皆正確的個數，而Y表示數字正確而位置不正確的個數。");
        int[] ansArray = new int[4];
        for (int i = 0; i < 4; i++){
            Random rnd = new Random();
            int remain;
            
            do{
                remain = rnd.Next(10);
            }while(Array.IndexOf(ansArray, remain) != -1);
            
            ansArray[i] = remain;
            // Console.Write(ansArray[i]);
            // 如果想看解答，把上面這條打開
        }

        int c = 0;
        Console.WriteLine("\n請猜一個四位數字：");
        c ++;

        while(c > 0){
            string guess = Console.ReadLine();
            if(guess == "n"){
                Console.WriteLine("歡迎下次再來挑戰！");
                break;
            }

            int[] guessArray = new int[4];
        
            for(int i = 0; i < guess.Length; i++){
                guessArray[i] = guess[i] - 48;
            }

            int a = 0, b = 0;
            int[] remainArray = new int[4]{ansArray[0], ansArray[1], ansArray[2], ansArray[3]};

            for (int i = 0; i < 4; i++){
                if(A(ansArray[i], guessArray[i])){
                    a ++;
                    guessArray[i] = -1;
                    remainArray[i] = -1;
                }         
            }

            
            for (int i = 0; i < 4; i++){
                if(guessArray[i] == -1){
                    continue;
                }
                if(B(ref remainArray, ref guessArray[i])){
                    b ++;
                }    
            }

            if(a == 4){
                Console.WriteLine("\n恭喜答對了！");
                Console.WriteLine("\n你總共猜了" + c + "次");
                break;
            }

            Console.WriteLine("\n" + a + "A" + b + "B\n請再猜一次（如果想結束遊戲，請輸入n）：");
            c ++;
        }
    }
}