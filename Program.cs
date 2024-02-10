using System;

class Shiritori
{
  static void Main(string[] args) {
    Console.WriteLine("しりとりスタート！");
    Console.WriteLine("最初の単語を入力してください");
    string lastWord = Console.ReadLine();
    char lastChar = lastWord[lastWord.Length - 1];

    while(true) {
      Console.WriteLine($"{lastChar}で始まる単語:");
      string nextWord = Console.ReadLine();
      if(nextWord == "終了") {
        Console.WriteLine("しりとりゲームを終了します。");
        break;
      }

      if(nextWord.EndsWith("ん")) {
        Console.WriteLine("ゲームオーバー: 単語が「ん」で終わっています。");
        break;
      }

      if(lastChar != nextWord[0]) {
        Console.WriteLine($"入力エラー: '{lastChar}'で始まる単語を入力してください。");
        continue;
      }

      lastChar = nextWord[nextWord.Length - 1]; // 次の単語の最後の文字を更新
    }
  }
}

