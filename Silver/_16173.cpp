#include <iostream>

using namespace std;

int n, ans = 0;
int map[3][3];

void dfs(int x, int y)
{
	if (x >= n || y >= n || map[x][y] == 0)
		return;

	if (x == n - 1 && y == n - 1)
	{
		ans = 1;
		return;
	}

	dfs(x + map[x][y], y);
	dfs(x, y + map[x][y]);
}

int main()
{
	cin >> n;
	for (int i = 0; i < n; i++)
		for (int j = 0; j < n; j++)
			cin >> map[i][j];

	dfs(0, 0);

	cout << (ans ? "HaruHaru" : "Hing");
	return 0;
}
