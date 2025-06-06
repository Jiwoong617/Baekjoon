#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
	int n; cin >> n;
	vector<vector<int>> v(n, vector<int>(5));
	vector<vector<bool>> check(n, vector<bool>(n, false));
	
	for (int i = 0; i < n; i++)
		for (int j = 0; j < 5; j++)
			cin >> v[i][j];

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < 5; j++)
		{
			for (int k = 0; k < n; k++)
			{
				if (i == k) continue;

				if (v[i][j] == v[k][j])
					check[i][k] = true;
			}
		}
	}

	int ans = 1, cnt = count(check[0].begin(), check[0].end(), true);
	for (int i = 1; i < n; i++)
	{
		int c = count(check[i].begin(), check[i].end(), true);
		if(cnt < c)
		{
			ans = i + 1;
			cnt = c;
		}
	}

	cout << ans;
	return 0;
}
