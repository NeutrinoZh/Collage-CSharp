using System.Text.RegularExpressions;
using Task2;
class Program {
    private static string[] stopwords = { 
        "fuck", "fucking", "bitch"
    };

    public static void Main() {
        string text = String.Empty;

        try {
            using (StreamReader sr = new StreamReader(".\\text.txt")) {
                text = sr.ReadToEnd();
            }
        } catch (Exception ex) {
            Console.WriteLine(ex.ToString());
            return;
        }

        text = text.ToLower();
        text = Regex.Replace(text, @"\d", String.Empty);
        text = Regex.Replace(text, @"[!”#$%&’()*+,-./:;<=>?@[\]^_`{|}~]", String.Empty);
        
        bool space = false;
        for (int i = 0; i < text.Length; ++i) {
            if (space) {
                if (text[i] == ' ') {
                    text = text.Remove(i, 1);
                    i -= 1;
                } else {
                    space = false;
                }
            } else {
                space = (text[i] == ' ');
            }
        }

        List<string> words = new List<string>(text.Split(' '));
        for (int i = 0; i < words.Count; ++i) {
            if (stopwords.Contains(words[i])) {
                words.RemoveAt(i);
                i -= 1;
            }
        }

        foreach (string word in words) {
            Console.WriteLine(word + " ");
        }

        Credits.PrintTimeStamp("Тертичний Евгений");
    }
}