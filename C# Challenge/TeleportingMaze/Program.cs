using System;

namespace Algoritm.CChallenge;

public class Program
{
      static int[] dr = new int[] { -1, 1, 0, 0 };
    static int[] dc = new int[] { 0, 0, -1, 1 };

    public static int ShortestPathWithPortals(char[][] grid, int n, int m)
    {
        (int r, int c) start = (-1, -1);
        (int r, int c) target = (-1, -1);

        // Collect portal positions: map char -> list of positions
        var portals = new Dictionary<char, List<(int,int)>>();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                char ch = grid[i][j];
                if (ch == 'S') start = (i, j);
                else if (ch == 'T') target = (i, j);
                else if (ch != '.' && ch != '#')
                {
                    if (!portals.ContainsKey(ch)) portals[ch] = new List<(int,int)>();
                    portals[ch].Add((i, j));
                }
            }
        }

        var dist = new int[n][];
        for (int i = 0; i < n; i++)
        {
            dist[i] = new int[m];
            for (int j = 0; j < m; j++) dist[i][j] = -1;
        }

        var q = new Queue<(int,int)>();
        dist[start.r][start.c] = 0;
        q.Enqueue(start);

        // To avoid reusing portal transitions many times, keep track if portal letter was "used"
        var portalUsed = new HashSet<char>();

        while (q.Count > 0)
        {
            var cur = q.Dequeue();
            int r = cur.Item1, c = cur.Item2;
            int d = dist[r][c];

            if (r == target.r && c == target.c) return d;

            // 4-neighbor moves
            for (int k = 0; k < 4; k++)
            {
                int nr = r + dr[k], nc = c + dc[k];
                if (nr < 0 || nr >= n || nc < 0 || nc >= m) continue;
                if (grid[nr][nc] == '#') continue;
                if (dist[nr][nc] == -1)
                {
                    dist[nr][nc] = d + 1;
                    q.Enqueue((nr, nc));
                }
            }

            // portal teleport (if current cell is a portal)
            char curCh = grid[r][c];
            if (curCh != '.' && curCh != '#' && curCh != 'S' && curCh != 'T')
            {
                if (!portalUsed.Contains(curCh))
                {
                    portalUsed.Add(curCh);
                    foreach (var pos in portals[curCh])
                    {
                        int pr = pos.Item1, pc = pos.Item2;
                        if (pr == r && pc == c) continue; // skip same cell
                        if (dist[pr][pc] == -1)
                        {
                            dist[pr][pc] = d + 1; // teleport counts as 1 move
                            q.Enqueue((pr, pc));
                        }
                    }
                }
            }
        }

        return -1; // targetga yetish mumkin emas
    }

    static void Main()
    {
        var first = Console.ReadLine().Split();
        int n = int.Parse(first[0]);
        int m = int.Parse(first[1]);
        var grid = new char[n][];
        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            if (line.Length != m) throw new Exception("Line length mismatch");
            grid[i] = line.ToCharArray();
        }

        int ans = ShortestPathWithPortals(grid, n, m);
        if (ans >= 0) Console.WriteLine(ans);
        else Console.WriteLine("NO PATH");
    }
}
