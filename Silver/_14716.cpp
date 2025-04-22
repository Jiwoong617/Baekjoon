#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int n, m, cnt = 0;
vector<vector<int>> v;
int dx[] = { 0, 0, -1, 1, 1, 1, -1, -1 };
int dy[] = { -1, 1, 0, 0, -1, 1, -1, 1 };

void dfs(int x, int y)
{
	v[x][y] = 0;

	for (int i = 0; i < 8; i++)
	{
		int tx = x + dx[i];
		int ty = y + dy[i];
		if (tx >= 0 && ty >= 0 && tx < n && ty < m && v[tx][ty])
			dfs(tx, ty);
	}
}

int main()
{
	cin >> n >> m;
	v = vector<vector<int>>(n, vector<int>(m, 0));
	for (int i = 0; i < n; i++)
		for (int j = 0; j < m; j++)
			cin >> v[i][j];

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			if (v[i][j] == 1)
			{
				dfs(i, j);
				cnt++;
			}
		}
	}

	cout << cnt;
	return 0;
}
