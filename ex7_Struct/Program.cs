class Program{
    struct Book
    {
        public string title;
        public string author;
        public int price;
        public string date;
    }

    static void Main(string[] args)
    {
        Book[] book_list = new Book[]{
            new Book(){title = "都問AI吧！ChatGPT上手的第一本書", author ="維圖歐索", price = 380, date = "2023/03/11"},
            new Book(){title = "「新」SEO 超入門！打敗 AI、征服搜尋引擎，洞悉使用者需求的必備指南", author = "嚴家成", price = 630, date = "2023/02/06"},
            new Book(){title = "Python最強入門邁向頂尖高手之路：王者歸來(第二版)全彩版", author ="洪錦魁", price = 1080, date = "2020/09/17"},
            new Book(){title = "會分析是基本功，看懂結果才最強：所有工作都離不開數據，一張Excel教你如何提預算、估風險、分析市場，讓數字力成為你的超能力", author ="柏木吉基", price = 350, date = "2017/08/30"},
            new Book(){title = "給工程師的第一本理財書：程式金融交易的118個入門關鍵技巧", author ="酆士昌", price = 500, date = "2018/05/30"}
        };

        for(int i = 0; i < 5; i++)
        {   
            Console.Write("書名:{0} \n作者：{1} \n價格：{2} \n出版日期：{3}",book_list[i].title, book_list[i].author, book_list[i].price, book_list[i].date);
            // Console.Write("書名：");
            // Console.WriteLine(book_list[i].title);
            // Console.Write("作者：");
            // Console.WriteLine(book_list[i].author);
            // Console.Write("價格：");
            // Console.WriteLine(book_list[i].price);
            // Console.Write("出版日期：");
            // Console.WriteLine(book_list[i].date);
            Console.WriteLine();
            Console.WriteLine();
        }

        Console.WriteLine("依照價格排序後：");
        Console.WriteLine();

        for(int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 4 - i; j ++)
            {
                if(book_list[j].price > book_list[j + 1].price)
                    {
                        Book temp = book_list[j];
                        book_list[j] = book_list[j + 1];
                        book_list[j + 1] = temp;
                    }
            }
        }

        for(int i = 0; i < 5; i++)
        {   
            Console.Write("書名:{0} \n作者：{1} \n價格：{2} \n出版日期：{3}",book_list[i].title, book_list[i].author, book_list[i].price, book_list[i].date);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

