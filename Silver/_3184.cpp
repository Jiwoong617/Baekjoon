#include <iostream>
#include <vector>
#include <string>
#include <queue>

using namespace std;

int n, m, sheep = 0, wolf = 0;
vector<string> v;
vector<vector<bool>> visited;

int dx[4] = { 0, 0, -1, 1 };
int dy[4] = { -1, 1, 0, 0 };

void BFS(int x, int y)
{
	int s = 0, w = 0;
	queue<pair<int, int>> q;
	q.push(make_pair(x, y));
	visited[x][y] = true;
	while (!q.empty())
	{
		pair<int, int> t = q.front();
		q.pop();

		if (v[t.first][t.second] == 'o') s++;
		if (v[t.first][t.second] == 'v') w++;

		for (int i = 0; i < 4; i++)
		{
			int tx = t.first + dx[i];
			int ty = t.second + dy[i];

			if (tx < n && tx >= 0 && ty < m && ty >= 0 && !visited[tx][ty])
			{
				q.push(make_pair(tx, ty));
				visited[tx][ty] = true;
			}
		}
	}

	if (s > w) wolf -= w;
	else sheep -= s;
}

int main()
{
	cin >> n >> m;
	string s;
	for (int i = 0; i < n; i++)
	{
		visited.push_back(vector<bool>(m, false));
		cin >> s;
		v.push_back(s);
		for (int j = 0; j < m; j++)
		{
			if (s[j] == '#')
				visited[i][j] = true;
			else if (s[j] == 'v')
				wolf++;
			else if (s[j] == 'o')
				sheep++;
		}
	}

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			if (!visited[i][j])
				BFS(i, j);
		}
	}

	cout << sheep << ' ' << wolf;
	return 0;
}
