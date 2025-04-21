#include <iostream>
#include <queue>
#include <vector>
#include <algorithm>
#include <string>

using namespace std;

int main()
{
	int n, m; cin >> n >> m;
	vector<vector<int>> v = vector<vector<int>>(n, vector<int>(m, 0));
	queue<pair<int, int>> q;
	for (int i = 0; i < n; i++)
	{
		string s;
		cin >> s;
		for (int j = 0; j < m; j++)
		{
			v[i][j] = (int)s[j] - '0';
			if (i == 0 && v[i][j] == 0)
			{
				q.push(make_pair(0, j));
				v[i][j] = 2;
			}
		}
	}

	int dx[] = { 0, 0, -1, 1 };
	int dy[] = { -1, 1, 0, 0 };
	while (!q.empty())
	{
		auto t = q.front(); q.pop();
		for (int i = 0; i < 4; i++)
		{
			int x = t.first + dx[i];
			int y = t.second + dy[i];

			if (x < n && x >= 0 && y < m && y >= 0 && v[x][y] == 0)
			{
				v[x][y] = 2;
				q.push(make_pair(x, y));
			}
		}
	}

	cout << (find(v[n - 1].begin(), v[n - 1].end(), 2) == v[n-1].end() ? "NO" : "YES");

	return 0;
}
