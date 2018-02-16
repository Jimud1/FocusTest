using System.Linq;

namespace FirstCentral.Util
{
    public class Kata
    {
        public static int DescendingOrder(int num)
        {
            return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
        }

        public static string Likes(string[] name)
        {
            string result = string.Empty;
            int nameCount = name.Count();
            switch (nameCount)
            {
                case 0:
                    result += "no one likes this";
                    break;
                case 1:
                    result += $"{name[0]} likes this";
                    break; 
                case 2:
                    result += $"{name[0]} and {name[1]} like this";
                    break;
                case 3:
                    result += $"{name[0]}, {name[1]} and {name[2]} like this";
                    break;
                default:
                    result += $"{name[0]}, {name[1]} and {nameCount - 2} others like this";
                    break;
            }
            return result;
        }
    }
}