#include <iostream>
#include <string>

using namespace std;

int main()
{
	int n, k, ans = 0;
	string s;
	cin >> n >> k >> s;

	for (int i = 0; i < n; i++)
	{
		if (s[i] == 'P')
		{
			for (int j = i - k; j <= i + k; j++)
			{
				if (j < 0 || j >= n) continue;

				if (s[j] == 'H')
				{
					s[j] = 'E';
					ans++;
					break;
				}
			}
		}
	}

	cout << ans;
	return 0;
}
