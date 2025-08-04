namespace Algoritm
{
    public class HumanTimeFormat
    {
        public static string formatDuration(int seconds)
        {
            if (seconds == 0) return "now";
            int years = seconds/(365*24*60*60);
            seconds%=365*24*60*60;
            int days = seconds/(24*60*60);
            seconds%=24*60*60;
            int hours = seconds/(60*60);
            seconds%=60*60;
            int minutes = seconds/60;
            seconds%=60;
            var parts = new List<string>();
            if (years>0) parts.Add($"{years} year{(years>1 ? "s" : "")}");
            if (days>0) parts.Add($"{days} days{(days>1 ? "s" : "")}");
            if (hours>0) parts.Add($"{hours} hours{(hours>1 ? "s" : "")}");
            if (minutes>0) parts.Add($"{minutes} minutes{(minutes>1 ? "s" : "")}");
            if (seconds>0) parts.Add($"{seconds} seconds{(seconds>1 ? "s" : "")}");
            if (parts.Count == 1)
                return parts[0];
            else
                return string.Join(", ", parts.Take(parts.Count - 1)) + " and " + parts.Last();
        }
    }
}
