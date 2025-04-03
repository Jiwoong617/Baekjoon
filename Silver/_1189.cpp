#include <iostream>
#include <vector>
#include <string>
#include <algorithm>

using namespace std;

int n, m, k, ans = 0;
vector<string> v;
bool visited[5][5] = { false, };
int dx[] = { -1, 1, 0, 0 };
int dy[] = { 0, 0, -1, 1 };

void backT(int x, int y, int count)
{
	if (count == k)
	{
		if (x == 0 && y == m - 1)
			ans++;
		return;
	}

	for (int i = 0; i < 4; i++)
	{
		int xx = x + dx[i];
		int yy = y + dy[i];

		if (xx >= 0 && xx < n && yy >= 0 && yy < m && !visited[xx][yy])
		{
			visited[xx][yy] = true;
			backT(xx, yy, count + 1);
			visited[xx][yy] = false;
		}
	}
}

int main()
{
	cin >> n >> m >> k;

	for (int i = 0; i < n; i++)
	{
		string s; cin >> s;
		for (int j = 0; j < m; j++)
			if (s[j] == 'T') visited[i][j] = true;
		v.push_back(s);
	}

	visited[n - 1][0] = true;
	backT(n - 1, 0, 1);
	cout << ans;
	return 0;
}
