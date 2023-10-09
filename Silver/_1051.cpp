#include <iostream>
using namespace std;
int main()
{
	ios::sync_with_stdio(0);
	cin.tie(0);
	cout.tie(0);

	int n, m, ans = 1;
	char num[50][50] = { 0 };
	cin >> n >> m;
	for (int i = 0; i < n; i++)
		for (int j = 0; j < m; j++)
			cin >> num[i][j];

	for (int k = 0; k < n; k++)
	{
		for (int i = 0; i < m; i++)
		{
			for (int j = i + 1; j < m; j++)
			{
				if (j - i > n - k || num[k][i] != num[k][j]) continue;
				if (num[k][i] != num[k + j - i][i] || num[k][i] != num[k + j - i][j]) continue;
				ans = max(ans, (j - i + 1) * (j - i + 1));
			}
		}
	}
	cout << ans;
}
