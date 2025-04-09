#include <iostream>
#include <vector>
#include <algorithm>
#include <cmath>

using namespace std;

int n, l, ans = 0;
vector<vector<int>> v;

void check(int x, bool isRow)
{
	bool* visited = new bool[n]();

	for (int i = 0; i < n - 1; i++)
	{
		if (isRow)
		{
			if (abs(v[x][i] - v[x][i + 1]) > 1) return;

			//오른쪽 더 큼
			if (v[x][i + 1] - v[x][i] == 1)
			{
				for (int j = 0; j < l; j++)
				{
					if (i - j < 0
						|| v[x][i] != v[x][i - j]
						|| visited[i - j])
						return;

					if (!visited[i - j]) visited[i - j] = true;
				}
			}
			else if (v[x][i + 1] - v[x][i] == -1)
			{
				for (int j = 0; j < l; j++)
				{
					if (i + 1 + j >= n
						|| v[x][i + 1] != v[x][i + 1 + j]
						|| visited[i + 1 + j])
						return;

					if (!visited[i + j + 1]) visited[i + j + 1] = true;
				}
			}
		}
		else
		{
			if (abs(v[i][x] - v[i + 1][x]) > 1) return;

			//아래가 더 큼
			if (v[i + 1][x] - v[i][x] == 1)
			{
				for (int j = 0; j < l; j++)
				{
					if (i - j < 0
						|| v[i][x] != v[i - j][x]
						|| visited[i - j])
						return;

					if (!visited[i - j]) visited[i - j] = true;
				}
			}
			else if (v[i + 1][x] - v[i][x] == -1)
			{
				for (int j = 0; j < l; j++)
				{
					if (i + 1 + j >= n
						|| v[i + 1][x] != v[i + 1 + j][x]
						|| visited[i + 1 + j])
						return;

					if (!visited[i + j + 1]) visited[i + j + 1] = true;
				}
			}
		}
	}

	ans++;
}

int main()
{
	cin >> n >> l;
	v = vector<vector<int>>(n, vector<int>(n, 0));

	for (int i = 0; i < n; i++)
		for (int j = 0; j < n; j++)
			cin >> v[i][j];

	for (int i = 0; i < n; i++)
	{
		check(i, true);
		check(i, false);
	}

	cout << ans;
	return 0;
}
