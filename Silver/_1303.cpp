#include <iostream>
#include <queue>
#include <string>
#include <vector>
using namespace std;


int n, m;
int b = 0, w = 0;
int dx[4] = { 0, 0, 1, -1 };
int dy[4] = { 1, -1, 0, 0 };
vector<string> war;
vector<vector<bool>> visited;

int bfs(char c, int x, int y)
{
	queue<pair<int, int>> q;
	q.push(make_pair(x, y));
	visited[x][y] = true;

	int count = 1;
	while (!q.empty())
	{
		auto t = q.front(); q.pop();

		for (int i = 0; i < 4; i++)
		{
			int tx = t.first + dx[i];
			int ty = t.second + dy[i];

			if (tx >= 0 && ty >= 0 && tx < n && ty < m)
			{
				if (!visited[tx][ty] && war[tx][ty] == c)
				{
					count++;
					q.push(make_pair(tx, ty));
					visited[tx][ty] = true;
				}
			}
		}
	}

	return (count == 1 ? count : count * count);
}

int main()
{
	cin >> m >> n;
	string s;
	for (int i = 0; i < n; i++)
	{
		cin >> s;
		war.push_back(s);
		visited.push_back(vector<bool>(m, false));
	}

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			if (visited[i][j]) continue;

			if (war[i][j] == 'W') w += bfs('W', i, j);
			else b += bfs('B', i, j);
		}
	}

	cout << w << ' ' << b;
	return 0;
}
