#include <iostream>
#include <vector>
#include <queue>

using namespace std;

int n, r1, c1, r2, c2;
vector<vector<int>> chess;
queue<pair<int, int>> q;
int dx[] = { -2, -2, 0, 0, 2, 2 };
int dy[] = { -1, 1, -2, 2, -1, 1 };

int main()
{
	cin >> n >> r1 >> c1 >> r2 >> c2;
	chess = vector<vector<int>>(n, vector<int>(n, -1));

	q.push(make_pair(r1, c1));
	chess[r1][c1] = 0;
	while (!q.empty())
	{
		auto t = q.front(); q.pop();
		for (int i = 0; i < 6; i++)
		{
			int x = t.first + dx[i];
			int y = t.second + dy[i];

			if (x < n && x >= 0 && y < n && y >= 0 && chess[x][y] == -1)
			{
				chess[x][y] = chess[t.first][t.second] + 1;
				q.push(make_pair(x, y));
			}
		}
	}

	cout << chess[r2][c2];
	return 0;
}
