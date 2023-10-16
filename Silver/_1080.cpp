#include <vector>
#include <iostream>
using namespace std;

void flip(int n, int m, vector<vector<int>>& a)
{
	for (int i = n; i < n + 3; i++)
	{
		for (int j = m; j < m + 3; j++)
			a[i][j] = a[i][j] == 1 ? 0 : 1;
	}
}

int main()
{
	int n, m;
	cin >> n >> m;
	vector<vector<int>> a(n, vector<int>(m, 0));
	vector<vector<int>> b(n, vector<int>(m, 0));

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
			scanf("%1d", &a[i][j]);
	}
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
			scanf("%1d", &b[i][j]);
	}

	int count = 0;
	for (int i = 0; i < n - 2; i++)
	{
		for (int j = 0; j < m- 2;j++)
		{
			if (a[i][j] == b[i][j])
				continue;

			flip(i, j, a);
			count++;
		}
	}

	for (int i = 0; i < n; i++)
		for (int j = 0; j < m; j++)
			if (a[i][j] != b[i][j]) { cout << -1; return 0; }
	cout << count;
}
