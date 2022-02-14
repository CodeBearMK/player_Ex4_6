namespace player_Ex4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string s = "";
                CD cd = new CD();
                DVD dvd = new DVD();
                Console.Write("請輸入放入的光碟 (CD 或 DVD):");
                s = Console.ReadLine();
                if (s.ToUpper() == "CD")
                {
                    cd.play();
                }
                else if (s.ToUpper() == "DVD")
                {
                    dvd.play();
                }
                else if (s.ToUpper() == "Q")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("要結束時，請按 q 或 Q 離開");
                }
            }
        }
    }
}