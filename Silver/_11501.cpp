#include <iostream>
#include <vector>

using namespace std;

int main()
{
	long long t, n; cin >> t;
	while (t--)
	{
		cin >> n;
		long long m = 0, ans = 0;
		vector<long long> v = vector<long long>(n, 3);
		for (int i = n - 1; i >= 0; i--)
			cin >> v[i];

		for (int i = 0; i < n; i++)
		{
			if (v[i] >= m)
				m = v[i];
			else
				ans += (m - v[i]);
		}

		cout << ans << '\n';
	}

	return 0;
}
