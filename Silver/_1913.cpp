#include <iostream>

using namespace std;

int snail[1000][1000];
int dx[] = { -1, 0, 1, 0 };
int dy[] = { 0, 1, 0, -1 };

int main()
{
	int n, m, a, b; cin >> n >> m;

	int x = n / 2, y = n / 2;
	int move = 1, moveCount = 0, dir = 0, dirCount = 0;
	for (int i = 1; i <= n * n; i++)
	{
		snail[x][y] = i;
		if (i == m)
		{
			a = x + 1;
			b = y + 1;
		}

		x += dx[dir % 4];
		y += dy[dir % 4];
		moveCount++;

		if (moveCount == move)
		{
			dir++;
			moveCount = 0;
			dirCount++;
		}

		if (dirCount == 2)
		{
			move++;
			dirCount = 0;
		}
	}

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
			cout << snail[i][j] << ' ';
		cout << '\n';
	}

	cout << a << ' ' << b;
	return 0;
}
