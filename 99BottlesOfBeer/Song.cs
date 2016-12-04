using System.Text;

namespace _99BottlesOfBeer
{
    public class Song
    {
        public Song()
        {
        }

        public string Sing()
        {
            var song = new StringBuilder();
            for (var bottlesRemaining = 99; bottlesRemaining >= 0; bottlesRemaining--)
            {
                song.Append(VerseFor(bottlesRemaining));
            }
            return song.ToString();
        }

        public string VerseFor(int v)
        {
            switch (v)
            {
                case 2:
                    return $@"2 bottles of beer on the wall, 2 bottles of beer.
Take one down and pass it around, 1 bottle of beer on the wall.
";

                case 1:
                    return $@"1 bottle of beer on the wall, 1 bottle of beer.
Take one down and pass it around, no more bottles of beer on the wall.
";

                case 0:
                    return $@"No more bottles of beer on the wall, no more bottles of beer.
Go to the store and buy some more, 99 bottles of beer on the wall.
";

                default:
                    return $@"{v} bottles of beer on the wall, {v} bottles of beer.
Take one down and pass it around, {v - 1} bottles of beer on the wall.
";
            }
        }
    }
}