namespace _8_Lab {
    class Program {
        static void Main(string[] args) {

            static void task_1() {
                int[] letcount = new int[33];
                int count = 0;

                string text = Console.ReadLine().ToLower();
                
                for (int i = 0; i < text.Length; i++) {
                    int let = text[i];
                    let -= 1072;
                    if (0 <= let && let < 33) {
                        letcount[let] += 1;
                        count += 1;
                    }
                }

                Console.WriteLine(count);
                Console.WriteLine(letcount[0]);

                for (int i = 0; i < letcount.Length; i++) {
                    Console.WriteLine($"{(char)(i + 1072)}. {Math.Round(((double)letcount[i] / count) * 100, 3)}%");
                }
            }
            
             
            static void task_2() {
                string text = Console.ReadLine();
                string reversed_text = "";
                for (int i = text.Length - 1; i >= 0; i--) {
                    reversed_text += text[i];
                }
                Console.WriteLine(reversed_text);
            }

            task_1();
        }
    }
}
