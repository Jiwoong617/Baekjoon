#include <iostream>
#include <vector>
#include <cmath>
#include <algorithm>
#include <queue>

using namespace std;

int n, m, ans = 0;
vector<vector<int>> v;
int dx[] = { 0, 0, -1, 1, -1, -1, 1, 1 };
int dy[] = { -1, 1, 0, 0, 1, -1, 1, -1 };

int bfs(int x, int y)
{
	vector<vector<int>> vec = v;
	queue<pair<int, int>> q;
	q.push(make_pair(x, y));
	vec[x][y] = -1;

	while (!q.empty())
	{
		auto t = q.front(); q.pop();
		for (int i = 0; i < 8; i++)
		{
			int tx = t.first + dx[i];
			int ty = t.second + dy[i];
			if (tx >= 0 && ty >= 0 && tx < n && ty < m)
			{
				if (vec[tx][ty] == 1) return -vec[t.first][t.second];

				if (vec[tx][ty] == 0)
				{
					vec[tx][ty] = vec[t.first][t.second] - 1;
					q.push(make_pair(tx, ty));
				}
			}
		}
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
			if (v[i][j] == 0)
				ans = max(ans, bfs(i, j));
		}
	}

	cout << ans;

	return 0;
}
