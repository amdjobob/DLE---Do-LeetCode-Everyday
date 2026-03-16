public class Solution {
    public int[][] GenerateMatrix(int n) {
        // 二維陣列初始化
        int[][] result = new int[n][];
        for (int i = 0; i < n; i++) { result[i] = new int[n]; }

        // 解題思路：撞到邊邊就換方向。
        // path 是方向  1右2下3左4上
        int path = 1, edge = 0, x = 0, y = 0;
        for (int i = 1; i < n*n+1; i++)
        {
            if (path == 1)
            {
                result[x][y++] = i;
                if (y == n - edge) { path = 2; y -= 1; }
            }
            if (path == 2)
            {
                result[x++][y] = i;
                if (x == n - edge) { path = 3; x -= 1; }
            }
            if (path == 3)
            {
                result[x][y--] = i;
                if (y == -1 + edge) { path = 4; edge += 1; y += 1; } // 關鍵！要把邊邊給縮小
            }
            if (path == 4)
            {
                result[x--][y] = i;
                if (x == -1 + edge) { path = 1; x += 1; y += 1;}    // 關鍵！最外圈結束，往內縮
            }
        }
        return result;
    }
}