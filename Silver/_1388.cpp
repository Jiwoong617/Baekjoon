#include <iostream>
#include <vector>
#include <string>

using namespace std;

int n, m, ans = 0;
vector<string> v;
vector<vector<bool>> visited;

void dfs(int x, int y, bool isRow)
{
	visited[x][y] = true;
	if (isRow)
	{
		if (y + 1 < m && !visited[x][y + 1] && v[x][y + 1] == '-')
			dfs(x, y + 1, isRow);
	}
	else
	{
		if (x + 1 < n && !visited[x + 1][y] && v[x + 1][y] == '|')
			dfs(x + 1, y, isRow);
	}
}

int main()
{
	cin >> n >> m;
	visited = vector<vector<bool>>(n, vector<bool>(m, false));
	v = vector<string>(n, "");
	for (int i = 0; i < n; i++)
		cin >> v[i];

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			if (visited[i][j]) continue;

			ans++;
			if (v[i][j] == '-') dfs(i, j, true);
			else dfs(i, j, false);
		}
	}

	cout << ans;

	return 0;
}
